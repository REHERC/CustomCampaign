// Dragging items in a ListBox control with visual insertion guides
// http://www.cyotek.com/blog/dragging-items-in-a-listbox-control-with-visual-insertion-guides

namespace CustomCampaign.Editor.Controls.Cyotek
{
    /// <summary>
    /// Provides data for the <see cref="ListBox.ItemDrag"/> event of the <see cref="ListBox"/> control.
    /// </summary>
    public class ListBoxItemDragEventArgs : CancelListBoxItemDragEventArgs
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBoxItemDragEventArgs"/> class.
        /// </summary>
        /// <param name="dragIndex">The index of the item that initiated the drag operation.</param>
        /// <param name="insertionIndex">The index of the the <see cref="LevelItem"/> that is the target of the drag operation.</param>
        /// <param name="insertionMode">The relation of the <see cref="InsertionIndex"/>.</param>
        /// <param name="x">The x-coordinate of a mouse click, in pixels.</param>
        /// <param name="y">The y-coordinate of a mouse click, in pixels.</param>
        public ListBoxItemDragEventArgs(int dragIndex, int insertionIndex, InsertionMode insertionMode, int x, int y)
          : this()
        {
            this.DragIndex = dragIndex;
            this.X = x;
            this.Y = y;
            this.InsertionIndex = insertionIndex;
            this.InsertionMode = insertionMode;
        }

        #endregion

        #region Protected Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBoxItemDragEventArgs"/> class.
        /// </summary>
        protected ListBoxItemDragEventArgs()
        { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the insertion index of the drag operation.
        /// </summary>
        /// <value>The index of the the item that is the target of the drag operation.</value>
        public int InsertionIndex { get; protected set; }

        /// <summary>
        /// Gets the relation of the <see cref="InsertionIndex"/>
        /// </summary>
        /// <value>The relation of the <see cref="InsertionIndex"/>.</value>
        public InsertionMode InsertionMode { get; protected set; }

        /// <summary>
        /// Gets the x-coordinate of the mouse during the generating event.
        /// </summary>
        /// <value>The x-coordinate of the mouse, in pixels.</value>
        public int X { get; protected set; }

        /// <summary>
        /// Gets the y-coordinate of the mouse during the generating event.
        /// </summary>
        /// <value>The y-coordinate of the mouse, in pixels.</value>
        public int Y { get; protected set; }

        #endregion
    }
}
