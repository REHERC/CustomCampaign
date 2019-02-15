using System.Drawing;
using System.Windows.Forms;

#pragma warning disable RCS1110
public class ReorderableListView : ListView
{
    // from WinUser.h
    private const int WM_PAINT = 0x000F;

    public ReorderableListView()
    {
        // Reduce flicker
        SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
    }

    /// <summary>
    /// If set to a value >= 0, an insertion line is painted before the item with the given index.
    /// </summary>
    public int LineBefore { get; set; } = -1;

    /// <summary>
    /// If set to a value >= 0, an insertion line is painted after the item with the given index.
    /// </summary>
    public int LineAfter { get; set; } = -1;

    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);

        // We have to take this way (instead of overriding OnPaint()) because the ListView is just a wrapper
        // around the common control ListView and unfortunately does not call the OnPaint overrides.
        if (m.Msg == WM_PAINT)
        {
            if (LineBefore >= 0 && LineBefore < Items.Count)
            {
                Rectangle rc = Items[LineBefore].GetBounds(ItemBoundsPortion.Entire);
                DrawInsertionLine(rc.Left, rc.Right, rc.Top);
            }
            if (LineAfter >= 0 && LineBefore < Items.Count)
            {
                Rectangle rc = Items[LineAfter].GetBounds(ItemBoundsPortion.Entire);
                DrawInsertionLine(rc.Left, rc.Right, rc.Bottom);
            }
        }
    }

    /// <summary>
    /// Draw a line with insertion marks at each end
    /// </summary>
    /// <param name="X1">Starting position (X) of the line</param>
    /// <param name="X2">Ending position (X) of the line</param>
    /// <param name="Y">Position (Y) of the line</param>
    private void DrawInsertionLine(int X1, int X2, int Y)
    {
        using (Graphics g = this.CreateGraphics())
        {
            using (Pen p = new Pen(Color.Black, 2))
            {
                using (SolidBrush b = new SolidBrush(Color.Black))
                {
                    g.DrawLine(p, X1, Y, X2 - 1, Y);

                    Point[] leftTriangle = new Point[3] {
                            new Point(X1,      Y-4),
                            new Point(X1 + 7,  Y),
                            new Point(X1,      Y+4)
                        };
                    Point[] rightTriangle = new Point[3] {
                            new Point(X2,     Y-4),
                            new Point(X2 - 8, Y),
                            new Point(X2,     Y+4)
                        };
                    g.FillPolygon(b, leftTriangle);
                    g.FillPolygon(b, rightTriangle);
                }
            }
        }
    }
}
