using System.ComponentModel;

// Dragging items in a ListBox control with visual insertion guides
// http://www.cyotek.com/blog/dragging-items-in-a-listbox-control-with-visual-insertion-guides

namespace CustomCampaign.Editor.Controls.Cyotek
{
    /// <summary>
    /// Provides data for the <see cref="ListBox.ItemDragging"/> event of the <see cref="ListBox"/> control.
    /// </summary>
    public class CancelListBoxItemDragEventArgs : CancelEventArgs
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelListBoxItemDragEventArgs"/> class.
        /// </summary>
        /// <param name="dragIndex">The index of the item the event data relates to.</param>
        public CancelListBoxItemDragEventArgs(int dragIndex)
        {
            this.DragIndex = dragIndex;
        }

        #endregion

        #region Protected Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelListBoxItemDragEventArgs"/> class.
        /// </summary>
        protected CancelListBoxItemDragEventArgs()
        { Cancel = false; }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the index of the item that is the source of the drag operation.
        /// </summary>
        /// <value>The index of the item that initiated the drag operation.</value>
        public int DragIndex { get; protected set; }

        #endregion
    }
}
