// Dragging items in a ListBox control with visual insertion guides
// http://www.cyotek.com/blog/dragging-items-in-a-listbox-control-with-visual-insertion-guides

namespace CustomCampaign.Editor.Controls.Cyotek
{
    /// <summary>
    /// Determines the insertion mode of a drag operation
    /// </summary>
    public enum InsertionMode
    {
        /// <summary>
        /// None
        /// </summary>
        None,

        /// <summary>
        /// The source item will be inserted before the destination item
        /// </summary>
        Before,

        /// <summary>
        /// The source item will be inserted after the destination item
        /// </summary>
        After
    }
}
