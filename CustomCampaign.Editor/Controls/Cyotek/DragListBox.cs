using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

// Dragging items in a ListBox control with visual insertion guides
// http://www.cyotek.com/blog/dragging-items-in-a-listbox-control-with-visual-insertion-guides

namespace CustomCampaign.Editor.Controls.Cyotek
{
    public class DragListBox : ListBox
    {
        #region Constants

        private const int WM_PAINT = 0xF;

        private const int InvalidIndex = -1;

        #endregion

        #region Public Constructors

        public DragListBox()
        {
            this.DoubleBuffered = true;
            this.InsertionIndex = InvalidIndex;
        }

        #endregion

        #region Events
        /// <summary>
        /// Occurs when the user begins dragging an item.
        /// </summary>
        [Category("Drag Drop")]
        public event EventHandler<ListBoxItemDragEventArgs> ItemDrag;

        /// <summary>
        /// Occurs when a drag-and-drop operation for an item is completed.
        /// </summary>
        [Category("Drag Drop")]
        public event EventHandler<CancelListBoxItemDragEventArgs> ItemDragging;

        #endregion

        #region Overridden Methods

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.DragDrop"/> event.
        /// </summary>
        /// <param name="drgevent">A <see cref="T:System.Windows.Forms.DragEventArgs"/> that contains the event data. </param>
        protected override void OnDragDrop(DragEventArgs drgevent)
        {
            
            if (this.IsDragging)
            {
                try
                {
                    InsertionIndex = CheckInsertionIndex(InsertionIndex);

                    if (this.InsertionIndex != InvalidIndex)
                    {
                        int dragIndex;
                        int dropIndex;

                        dragIndex = (int)drgevent.Data.GetData(typeof(int));
                        dropIndex = this.InsertionIndex;

                        if (dragIndex < dropIndex)
                        {
                            dropIndex--;
                        }
                        if (this.InsertionMode == InsertionMode.After && dragIndex < this.Items.Count - 1)
                        {
                            dropIndex++;
                        }

                        if (dropIndex != dragIndex)
                        {
                            ListBoxItemDragEventArgs args;
                            Point clientPoint;

                            clientPoint = this.PointToClient(new Point(drgevent.X, drgevent.Y));
                            args = new ListBoxItemDragEventArgs(dragIndex, dropIndex, this.InsertionMode, clientPoint.X, clientPoint.Y);

                            this.OnItemDrag(args);

                            if (!args.Cancel)
                            {
                                object dragItem;
                                try
                                {
                                    dragItem = this.Items[dragIndex];

                                    this.Items.Remove(dragItem);
                                    this.Items.Insert(dropIndex, dragItem);
                                    this.SelectedItem = dragItem;
                                }
                                catch (Exception) { }
                            }
                        }
                    }
                }
                finally
                {
                    //this.Invalidate(this.InsertionIndex);
                    Invalidate();
                    this.InsertionIndex = InvalidIndex;
                    this.InsertionMode = InsertionMode.None;
                    this.IsDragging = false;
                }
            }
            Invalidate();
            base.OnDragDrop(drgevent);
        }

        protected override void OnDragLeave(EventArgs e)
        {
            this.Invalidate(this.InsertionIndex);
            ResetDragAndDrop();

            base.OnDragLeave(e);
        }

        private int CheckInsertionIndex(int index)
        {
            if (index == InvalidIndex)
            {
                if (IsInEmptySpace())
                    return Items.Count - 1;
                else
                    return 0;
            }
            else return index;
        }

        private bool IsInEmptySpace()
        {
            if (Items.Count <= 0) return true;

            Rectangle cursor = new Rectangle(PointToClient(Cursor.Position), new Size(1, 1));
            Rectangle lastitem = GetItemRectangle(Items.Count - 1);

            return cursor.Y > lastitem.Y + lastitem.Height;
        }

        protected override void OnDragOver(DragEventArgs drgevent)
        {
            if (this.IsDragging)
            {
                int insertionIndex;
                InsertionMode insertionMode;
                Point clientPoint;

                clientPoint = this.PointToClient(new Point(drgevent.X, drgevent.Y));
                insertionIndex = this.IndexFromPoint(clientPoint);

                insertionIndex = CheckInsertionIndex(insertionIndex);

                if (insertionIndex != InvalidIndex)
                {
                    Rectangle bounds;

                    bounds = this.GetItemRectangle(insertionIndex);
                    insertionMode = clientPoint.Y < bounds.Top + (bounds.Height / 2) ? InsertionMode.Before : InsertionMode.After;

                    drgevent.Effect = DragDropEffects.Move;
                }
                else
                {
                    insertionIndex = InvalidIndex;
                    insertionMode = InsertionMode.None;

                    drgevent.Effect = DragDropEffects.None;
                }

                if (insertionIndex != this.InsertionIndex || insertionMode != this.InsertionMode)
                {
                    this.Invalidate(this.InsertionIndex); // clear the previous item
                    this.InsertionMode = insertionMode;
                    this.InsertionIndex = insertionIndex;
                    this.Invalidate(this.InsertionIndex); // draw the new item
                }
            }

            base.OnDragOver(drgevent);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseDown"/> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs"/> that contains the event data. </param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (IsInEmptySpace())
            {
                SelectedIndex = -1;
                ResetDragAndDrop();
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                this.DragOrigin = e.Location;
                this.DragIndex = this.IndexFromPoint(e.Location);
            }
            else
            {
                this.DragOrigin = Point.Empty;
                this.DragIndex = InvalidIndex;
            }
        }

        private void ResetDragAndDrop()
        {
            IsDragging = false;
            DragOrigin = Point.Empty;
            DragIndex = -1;
            InsertionIndex = -1;
            InsertionMode = InsertionMode.None;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (IsDragging)
            {
                ResetDragAndDrop();
                Invalidate();
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseMove"/> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs"/> that contains the event data. </param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (!this.IsDragging && e.Button == MouseButtons.Left && this.IsOutsideDragZone(e.Location))
            {
                CancelListBoxItemDragEventArgs args;

                args = new CancelListBoxItemDragEventArgs(this.DragIndex);

                this.OnItemDragging(args);

                if (!args.Cancel)
                {
                    this.IsDragging = true;
                    this.DoDragDrop(this.DragIndex, DragDropEffects.Move);
                }
            }

            base.OnMouseMove(e);
        }

        /// <summary>
        /// Overrides <see cref="M:System.Windows.Forms.Control.WndProc(System.Windows.Forms.Message@)" />.
        /// </summary>
        /// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message" /> to process.</param>
        [DebuggerStepThrough]
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case WM_PAINT:
                    this.OnWmPaint(ref m);
                    break;
            }
        }
        #endregion

        #region Private Members

        private void DrawInsertionLine()
        {
            if (this.InsertionIndex != InvalidIndex)
            {
                int index;

                index = this.InsertionIndex;

                if (index >= 0 && index < this.Items.Count)
                {
                    Rectangle bounds;
                    int x;
                    int y;
                    int width;

                    bounds = this.GetItemRectangle(this.InsertionIndex);
                    x = 0; // aways fit the line to the client area, regardless of how the user is scrolling
                    y = this.InsertionMode == InsertionMode.Before ? bounds.Top : bounds.Bottom;
                    width = Math.Min(bounds.Width - bounds.Left, this.ClientSize.Width); // again, make sure the full width fits in the client area

                    this.DrawInsertionLine(x, y, width);
                }
            }
        }

        private void DrawInsertionLine(int x1, int y, int width)
        {
            using (Graphics g = this.CreateGraphics())
            {
                Point[] leftArrowHead;
                Point[] rightArrowHead;
                int arrowHeadSize;
                int x2;

                x2 = x1 + width;
                arrowHeadSize = 7;
                leftArrowHead = new[]
                                {
                          new Point(x1, y - (arrowHeadSize / 2)), new Point(x1 + arrowHeadSize, y), new Point(x1, y + (arrowHeadSize / 2))
                        };
                rightArrowHead = new[]
                                 {
                           new Point(x2, y - (arrowHeadSize / 2)), new Point(x2 - arrowHeadSize, y), new Point(x2, y + (arrowHeadSize / 2))
                         };

                using (Pen pen = new Pen(LineColor))
                {
                    g.DrawLine(pen, x1, y, x2 - 1, y);
                }

                using (Brush brush = new SolidBrush(LineColor))
                {
                    g.FillPolygon(brush, leftArrowHead);
                    g.FillPolygon(brush, rightArrowHead);
                }
            }
        }

        private bool IsOutsideDragZone(Point location)
        {
            Rectangle dragZone;
            int dragWidth;
            int dragHeight;
            dragWidth = SystemInformation.DragSize.Width;
            dragHeight = SystemInformation.DragSize.Height;
            dragZone = new Rectangle(this.DragOrigin.X - (dragWidth / 2), this.DragOrigin.Y - (dragHeight / 2), dragWidth, dragHeight);

            return !dragZone.Contains(location);
        }

        #endregion

        #region Protected Properties

        protected int DragIndex { get; set; }

        protected Point DragOrigin { get; set; }

        protected int InsertionIndex { get; set; }

        protected InsertionMode InsertionMode { get; set; }

        protected bool IsDragging { get; set; }

        #endregion

        #region Overwritten Properties
        public override bool AllowDrop => true;
        #endregion

        #region Protected Members

        /// <summary>
        /// Invalidates the specified item, including the adjacent item depending on the current <see cref="InsertionMode"/>.
        /// </summary>
        /// <param name="index">The index of the item to invalidate.</param>
        protected void Invalidate(int index)
        {
            if (index != InvalidIndex)
            {
                Rectangle bounds;

                bounds = this.GetItemRectangle(index);
                if (this.InsertionMode == InsertionMode.Before && index > 0)
                {
                    bounds = Rectangle.Union(bounds, this.GetItemRectangle(index - 1));
                }
                else if (this.InsertionMode == InsertionMode.After && index < this.Items.Count - 1)
                {
                    bounds = Rectangle.Union(bounds, this.GetItemRectangle(index + 1));
                }

                this.Invalidate(bounds);
            }
        }

        /// <summary>
        /// Raises the <see cref="ItemDrag" /> event.
        /// </summary>
        /// <param name="e">The <see cref="ListBoxItemDragEventArgs" /> instance containing the event data.</param>
        protected virtual void OnItemDrag(ListBoxItemDragEventArgs e)
        {
            EventHandler<ListBoxItemDragEventArgs> handler;

            handler = this.ItemDrag;

            if (handler != null)
            {
                handler(this, e);
            }
        }

        /// <summary>
        /// Raises the <see cref="ItemDragging" /> event.
        /// </summary>
        /// <param name="e">The <see cref="CancelListBoxItemDragEventArgs" /> instance containing the event data.</param>
        protected virtual void OnItemDragging(CancelListBoxItemDragEventArgs e)
        {
            EventHandler<CancelListBoxItemDragEventArgs> handler;

            handler = this.ItemDragging;

            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnWmPaint(ref Message m)
        {
            this.DrawInsertionLine();
        }

        #endregion

        #region Virtual Propertiex
        protected virtual Color LineColor => Color.Red;
        #endregion
    }
}
