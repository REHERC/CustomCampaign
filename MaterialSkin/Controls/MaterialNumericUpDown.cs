using MaterialSkin.Animations;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#pragma warning disable IDE0059, RCS1159

namespace MaterialSkin.Controls
{
    [DefaultBindingProperty("Value")]
    public class MaterialNumericUpDown : Control, IMaterialControl
    {
        //Properties for managing the material design properties
        [Browsable(false)]
        public int Depth { get; set; }

        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;

        [Browsable(false)]
        public MouseState MouseState { get; set; }

        public TextBox InputField => _baseNumericUpDown.Input;

        private readonly BaseNumericUpDown _baseNumericUpDown;
        private readonly AnimationManager _animationManager;

        public override string Text { get { return _baseNumericUpDown.Text; } set { _baseNumericUpDown.Text = value; } }
        public new object Tag { get { return _baseNumericUpDown.Tag; } set { _baseNumericUpDown.Tag = value; } }
        public int MaxLength { get { return _baseNumericUpDown.Input.MaxLength; } set { _baseNumericUpDown.Input.MaxLength = value; } }

        public string SelectedText { get { return _baseNumericUpDown.Input.SelectedText; } set { _baseNumericUpDown.Input.SelectedText = value; } }
        public string Hint { get { return _baseNumericUpDown.Hint; } set { _baseNumericUpDown.Hint = value; } }

        public int SelectionStart { get { return _baseNumericUpDown.Input.SelectionStart; } set { _baseNumericUpDown.Input.SelectionStart = value; } }
        public int SelectionLength { get { return _baseNumericUpDown.Input.SelectionLength; } set { _baseNumericUpDown.Input.SelectionLength = value; } }
        public int TextLength => _baseNumericUpDown.Input.TextLength;
        public void SelectAll() { _baseNumericUpDown.SelectAll(); }

        public decimal Minimum { get { return _baseNumericUpDown.Minimum; } set { _baseNumericUpDown.Minimum = value; } }
        public decimal Maximum { get { return _baseNumericUpDown.Maximum; } set { _baseNumericUpDown.Maximum = value; } }
        public decimal Value { get { return _baseNumericUpDown.Value; } set { _baseNumericUpDown.Value = value; } }
        public int DecimalPlaces { get { return _baseNumericUpDown.DecimalPlaces; } set { _baseNumericUpDown.DecimalPlaces = value; } }
        public decimal Increment { get { return _baseNumericUpDown.Increment; } set { _baseNumericUpDown.Increment = value; } }
        public bool ReadOnly { get { return _baseNumericUpDown.ReadOnly; } set { _baseNumericUpDown.ReadOnly = value; } }
        public LeftRightAlignment UpDownAlign { get { return _baseNumericUpDown.UpDownAlign; } set { _baseNumericUpDown.UpDownAlign = value; } }
        public bool Hexadecimal { get { return _baseNumericUpDown.Hexadecimal; } set { _baseNumericUpDown.Hexadecimal = value; } }

        # region Forwarding events to _baseNumericUpDown
        public new event EventHandler AutoSizeChanged
        {
            add
            {
                _baseNumericUpDown.AutoSizeChanged += value;
            }
            remove
            {
                _baseNumericUpDown.AutoSizeChanged -= value;
            }
        }

        public new event EventHandler BackgroundImageChanged
        {
            add
            {
                _baseNumericUpDown.BackgroundImageChanged += value;
            }
            remove
            {
                _baseNumericUpDown.BackgroundImageChanged -= value;
            }
        }

        public new event EventHandler BackgroundImageLayoutChanged
        {
            add
            {
                _baseNumericUpDown.BackgroundImageLayoutChanged += value;
            }
            remove
            {
                _baseNumericUpDown.BackgroundImageLayoutChanged -= value;
            }
        }

        public new event EventHandler BindingContextChanged
        {
            add
            {
                _baseNumericUpDown.BindingContextChanged += value;
            }
            remove
            {
                _baseNumericUpDown.BindingContextChanged -= value;
            }
        }

        public event EventHandler BorderStyleChanged
        {
            add
            {
                _baseNumericUpDown.Input.BorderStyleChanged += value;
            }
            remove
            {
                _baseNumericUpDown.Input.BorderStyleChanged -= value;
            }
        }

        public new event EventHandler CausesValidationChanged
        {
            add
            {
                _baseNumericUpDown.CausesValidationChanged += value;
            }
            remove
            {
                _baseNumericUpDown.CausesValidationChanged -= value;
            }
        }

        public new event UICuesEventHandler ChangeUICues
        {
            add
            {
                _baseNumericUpDown.ChangeUICues += value;
            }
            remove
            {
                _baseNumericUpDown.ChangeUICues -= value;
            }
        }

        public new event EventHandler Click
        {
            add
            {
                _baseNumericUpDown.Click += value;
            }
            remove
            {
                _baseNumericUpDown.Click -= value;
            }
        }

        public new event EventHandler ClientSizeChanged
        {
            add
            {
                _baseNumericUpDown.ClientSizeChanged += value;
            }
            remove
            {
                _baseNumericUpDown.ClientSizeChanged -= value;
            }
        }

        public new event EventHandler ContextMenuChanged
        {
            add
            {
                _baseNumericUpDown.ContextMenuChanged += value;
            }
            remove
            {
                _baseNumericUpDown.ContextMenuChanged -= value;
            }
        }

        public new event EventHandler ContextMenuStripChanged
        {
            add
            {
                _baseNumericUpDown.ContextMenuStripChanged += value;
            }
            remove
            {
                _baseNumericUpDown.ContextMenuStripChanged -= value;
            }
        }

        public new event ControlEventHandler ControlAdded
        {
            add
            {
                _baseNumericUpDown.ControlAdded += value;
            }
            remove
            {
                _baseNumericUpDown.ControlAdded -= value;
            }
        }

        public new event ControlEventHandler ControlRemoved
        {
            add
            {
                _baseNumericUpDown.ControlRemoved += value;
            }
            remove
            {
                _baseNumericUpDown.ControlRemoved -= value;
            }
        }

        public new event EventHandler CursorChanged
        {
            add
            {
                _baseNumericUpDown.CursorChanged += value;
            }
            remove
            {
                _baseNumericUpDown.CursorChanged -= value;
            }
        }

        public new event EventHandler Disposed
        {
            add
            {
                _baseNumericUpDown.Disposed += value;
            }
            remove
            {
                _baseNumericUpDown.Disposed -= value;
            }
        }

        public new event EventHandler DockChanged
        {
            add
            {
                _baseNumericUpDown.DockChanged += value;
            }
            remove
            {
                _baseNumericUpDown.DockChanged -= value;
            }
        }

        public new event EventHandler DoubleClick
        {
            add
            {
                _baseNumericUpDown.DoubleClick += value;
            }
            remove
            {
                _baseNumericUpDown.DoubleClick -= value;
            }
        }

        public new event DragEventHandler DragDrop
        {
            add
            {
                _baseNumericUpDown.DragDrop += value;
            }
            remove
            {
                _baseNumericUpDown.DragDrop -= value;
            }
        }

        public new event DragEventHandler DragEnter
        {
            add
            {
                _baseNumericUpDown.DragEnter += value;
            }
            remove
            {
                _baseNumericUpDown.DragEnter -= value;
            }
        }

        public new event EventHandler DragLeave
        {
            add
            {
                _baseNumericUpDown.DragLeave += value;
            }
            remove
            {
                _baseNumericUpDown.DragLeave -= value;
            }
        }

        public new event DragEventHandler DragOver
        {
            add
            {
                _baseNumericUpDown.DragOver += value;
            }
            remove
            {
                _baseNumericUpDown.DragOver -= value;
            }
        }

        public new event EventHandler EnabledChanged
        {
            add
            {
                _baseNumericUpDown.EnabledChanged += value;
            }
            remove
            {
                _baseNumericUpDown.EnabledChanged -= value;
            }
        }

        public new event EventHandler Enter
        {
            add
            {
                _baseNumericUpDown.Enter += value;
            }
            remove
            {
                _baseNumericUpDown.Enter -= value;
            }
        }

        public new event EventHandler FontChanged
        {
            add
            {
                _baseNumericUpDown.FontChanged += value;
            }
            remove
            {
                _baseNumericUpDown.FontChanged -= value;
            }
        }

        public new event EventHandler ForeColorChanged
        {
            add
            {
                _baseNumericUpDown.ForeColorChanged += value;
            }
            remove
            {
                _baseNumericUpDown.ForeColorChanged -= value;
            }
        }

        public new event GiveFeedbackEventHandler GiveFeedback
        {
            add
            {
                _baseNumericUpDown.GiveFeedback += value;
            }
            remove
            {
                _baseNumericUpDown.GiveFeedback -= value;
            }
        }

        public new event EventHandler GotFocus
        {
            add
            {
                _baseNumericUpDown.GotFocus += value;
            }
            remove
            {
                _baseNumericUpDown.GotFocus -= value;
            }
        }

        public new event EventHandler HandleCreated
        {
            add
            {
                _baseNumericUpDown.HandleCreated += value;
            }
            remove
            {
                _baseNumericUpDown.HandleCreated -= value;
            }
        }

        public new event EventHandler HandleDestroyed
        {
            add
            {
                _baseNumericUpDown.HandleDestroyed += value;
            }
            remove
            {
                _baseNumericUpDown.HandleDestroyed -= value;
            }
        }

        public new event HelpEventHandler HelpRequested
        {
            add
            {
                _baseNumericUpDown.HelpRequested += value;
            }
            remove
            {
                _baseNumericUpDown.HelpRequested -= value;
            }
        }

        public event EventHandler HideSelectionChanged
        {
            add
            {
                _baseNumericUpDown.Input.HideSelectionChanged += value;
            }
            remove
            {
                _baseNumericUpDown.Input.HideSelectionChanged -= value;
            }
        }

        public new event EventHandler ImeModeChanged
        {
            add
            {
                _baseNumericUpDown.ImeModeChanged += value;
            }
            remove
            {
                _baseNumericUpDown.ImeModeChanged -= value;
            }
        }

        public new event InvalidateEventHandler Invalidated
        {
            add
            {
                _baseNumericUpDown.Invalidated += value;
            }
            remove
            {
                _baseNumericUpDown.Invalidated -= value;
            }
        }

        public new event KeyEventHandler KeyDown
        {
            add
            {
                _baseNumericUpDown.KeyDown += value;
            }
            remove
            {
                _baseNumericUpDown.KeyDown -= value;
            }
        }

        public new event KeyPressEventHandler KeyPress
        {
            add
            {
                _baseNumericUpDown.KeyPress += value;
            }
            remove
            {
                _baseNumericUpDown.KeyPress -= value;
            }
        }

        public new event KeyEventHandler KeyUp
        {
            add
            {
                _baseNumericUpDown.KeyUp += value;
            }
            remove
            {
                _baseNumericUpDown.KeyUp -= value;
            }
        }

        public new event LayoutEventHandler Layout
        {
            add
            {
                _baseNumericUpDown.Layout += value;
            }
            remove
            {
                _baseNumericUpDown.Layout -= value;
            }
        }

        public new event EventHandler Leave
        {
            add
            {
                _baseNumericUpDown.Leave += value;
            }
            remove
            {
                _baseNumericUpDown.Leave -= value;
            }
        }

        public new event EventHandler LocationChanged
        {
            add
            {
                _baseNumericUpDown.LocationChanged += value;
            }
            remove
            {
                _baseNumericUpDown.LocationChanged -= value;
            }
        }

        public new event EventHandler LostFocus
        {
            add
            {
                _baseNumericUpDown.LostFocus += value;
            }
            remove
            {
                _baseNumericUpDown.LostFocus -= value;
            }
        }

        public new event EventHandler MarginChanged
        {
            add
            {
                _baseNumericUpDown.MarginChanged += value;
            }
            remove
            {
                _baseNumericUpDown.MarginChanged -= value;
            }
        }

        public event EventHandler ModifiedChanged
        {
            add
            {
                _baseNumericUpDown.Input.ModifiedChanged += value;
            }
            remove
            {
                _baseNumericUpDown.Input.ModifiedChanged -= value;
            }
        }

        public new event EventHandler MouseCaptureChanged
        {
            add
            {
                _baseNumericUpDown.MouseCaptureChanged += value;
            }
            remove
            {
                _baseNumericUpDown.MouseCaptureChanged -= value;
            }
        }

        public new event MouseEventHandler MouseClick
        {
            add
            {
                _baseNumericUpDown.MouseClick += value;
            }
            remove
            {
                _baseNumericUpDown.MouseClick -= value;
            }
        }

        public new event MouseEventHandler MouseDoubleClick
        {
            add
            {
                _baseNumericUpDown.MouseDoubleClick += value;
            }
            remove
            {
                _baseNumericUpDown.MouseDoubleClick -= value;
            }
        }

        public new event MouseEventHandler MouseDown
        {
            add
            {
                _baseNumericUpDown.MouseDown += value;
            }
            remove
            {
                _baseNumericUpDown.MouseDown -= value;
            }
        }

        public new event EventHandler MouseEnter
        {
            add
            {
                _baseNumericUpDown.MouseEnter += value;
            }
            remove
            {
                _baseNumericUpDown.MouseEnter -= value;
            }
        }

        public new event EventHandler MouseHover
        {
            add
            {
                _baseNumericUpDown.MouseHover += value;
            }
            remove
            {
                _baseNumericUpDown.MouseHover -= value;
            }
        }

        public new event EventHandler MouseLeave
        {
            add
            {
                _baseNumericUpDown.MouseLeave += value;
            }
            remove
            {
                _baseNumericUpDown.MouseLeave -= value;
            }
        }

        public new event MouseEventHandler MouseMove
        {
            add
            {
                _baseNumericUpDown.MouseMove += value;
            }
            remove
            {
                _baseNumericUpDown.MouseMove -= value;
            }
        }

        public new event MouseEventHandler MouseUp
        {
            add
            {
                _baseNumericUpDown.MouseUp += value;
            }
            remove
            {
                _baseNumericUpDown.MouseUp -= value;
            }
        }

        public new event MouseEventHandler MouseWheel
        {
            add
            {
                _baseNumericUpDown.MouseWheel += value;
            }
            remove
            {
                _baseNumericUpDown.MouseWheel -= value;
            }
        }

        public new event EventHandler Move
        {
            add
            {
                _baseNumericUpDown.Move += value;
            }
            remove
            {
                _baseNumericUpDown.Move -= value;
            }
        }

        public event EventHandler MultilineChanged
        {
            add
            {
                _baseNumericUpDown.Input.MultilineChanged += value;
            }
            remove
            {
                _baseNumericUpDown.Input.MultilineChanged -= value;
            }
        }

        public new event EventHandler PaddingChanged
        {
            add
            {
                _baseNumericUpDown.PaddingChanged += value;
            }
            remove
            {
                _baseNumericUpDown.PaddingChanged -= value;
            }
        }

        public new event PaintEventHandler Paint
        {
            add
            {
                _baseNumericUpDown.Paint += value;
            }
            remove
            {
                _baseNumericUpDown.Paint -= value;
            }
        }

        public new event EventHandler ParentChanged
        {
            add
            {
                _baseNumericUpDown.ParentChanged += value;
            }
            remove
            {
                _baseNumericUpDown.ParentChanged -= value;
            }
        }

        public new event PreviewKeyDownEventHandler PreviewKeyDown
        {
            add
            {
                _baseNumericUpDown.PreviewKeyDown += value;
            }
            remove
            {
                _baseNumericUpDown.PreviewKeyDown -= value;
            }
        }

        public new event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp
        {
            add
            {
                _baseNumericUpDown.QueryAccessibilityHelp += value;
            }
            remove
            {
                _baseNumericUpDown.QueryAccessibilityHelp -= value;
            }
        }

        public new event QueryContinueDragEventHandler QueryContinueDrag
        {
            add
            {
                _baseNumericUpDown.QueryContinueDrag += value;
            }
            remove
            {
                _baseNumericUpDown.QueryContinueDrag -= value;
            }
        }

        public event EventHandler ReadOnlyChanged
        {
            add
            {
                _baseNumericUpDown.Input.ReadOnlyChanged += value;
            }
            remove
            {
                _baseNumericUpDown.Input.ReadOnlyChanged -= value;
            }
        }

        public new event EventHandler RegionChanged
        {
            add
            {
                _baseNumericUpDown.RegionChanged += value;
            }
            remove
            {
                _baseNumericUpDown.RegionChanged -= value;
            }
        }

        public new event EventHandler Resize
        {
            add
            {
                _baseNumericUpDown.Resize += value;
            }
            remove
            {
                _baseNumericUpDown.Resize -= value;
            }
        }

        public new event EventHandler RightToLeftChanged
        {
            add
            {
                _baseNumericUpDown.RightToLeftChanged += value;
            }
            remove
            {
                _baseNumericUpDown.RightToLeftChanged -= value;
            }
        }

        public new event EventHandler SizeChanged
        {
            add
            {
                _baseNumericUpDown.SizeChanged += value;
            }
            remove
            {
                _baseNumericUpDown.SizeChanged -= value;
            }
        }

        public new event EventHandler StyleChanged
        {
            add
            {
                _baseNumericUpDown.StyleChanged += value;
            }
            remove
            {
                _baseNumericUpDown.StyleChanged -= value;
            }
        }

        public new event EventHandler SystemColorsChanged
        {
            add
            {
                _baseNumericUpDown.SystemColorsChanged += value;
            }
            remove
            {
                _baseNumericUpDown.SystemColorsChanged -= value;
            }
        }

        public new event EventHandler TabIndexChanged
        {
            add
            {
                _baseNumericUpDown.TabIndexChanged += value;
            }
            remove
            {
                _baseNumericUpDown.TabIndexChanged -= value;
            }
        }

        public new event EventHandler TabStopChanged
        {
            add
            {
                _baseNumericUpDown.TabStopChanged += value;
            }
            remove
            {
                _baseNumericUpDown.TabStopChanged -= value;
            }
        }

        public event EventHandler TextAlignChanged
        {
            add
            {
                _baseNumericUpDown.Input.TextAlignChanged += value;
            }
            remove
            {
                _baseNumericUpDown.Input.TextAlignChanged -= value;
            }
        }

        public new event EventHandler TextChanged
        {
            add
            {
                _baseNumericUpDown.TextChanged += value;
            }
            remove
            {
                _baseNumericUpDown.TextChanged -= value;
            }
        }

        public new event EventHandler Validated
        {
            add
            {
                _baseNumericUpDown.Validated += value;
            }
            remove
            {
                _baseNumericUpDown.Validated -= value;
            }
        }

        public new event CancelEventHandler Validating
        {
            add
            {
                _baseNumericUpDown.Validating += value;
            }
            remove
            {
                _baseNumericUpDown.Validating -= value;
            }
        }

        public new event EventHandler VisibleChanged
        {
            add
            {
                _baseNumericUpDown.VisibleChanged += value;
            }
            remove
            {
                _baseNumericUpDown.VisibleChanged -= value;
            }
        }
        #endregion

        public new void Focus() { _baseNumericUpDown.Focus(); }

        public override Color BackColor
        {
            get => SkinManager.GetApplicationBackgroundColor();
            set
            {
                value = SkinManager.GetApplicationBackgroundColor();
                _baseNumericUpDown.BackColor = value;
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            var g = pevent.Graphics;
            g.Clear(SkinManager.GetApplicationBackgroundColor());

            var lineY = _baseNumericUpDown.Bottom + 3;

            if (!_animationManager.IsAnimating())
            {
                //No animation
                g.FillRectangle(_baseNumericUpDown.Focused ? SkinManager.ColorScheme.PrimaryBrush : SkinManager.GetDividersBrush(), _baseNumericUpDown.Location.X, lineY, _baseNumericUpDown.Width, _baseNumericUpDown.Focused ? 2 : 1);
            }
            else
            {
                //Animate
                int animationWidth = (int)(_baseNumericUpDown.Width * _animationManager.GetProgress());
                int halfAnimationWidth = animationWidth / 2;
                int animationStart = _baseNumericUpDown.Location.X + (_baseNumericUpDown.Width / 2);

                //Unfocused background
                g.FillRectangle(SkinManager.GetDividersBrush(), _baseNumericUpDown.Location.X, lineY, _baseNumericUpDown.Width, 1);

                //Animated focus transition
                g.FillRectangle(SkinManager.ColorScheme.PrimaryBrush, animationStart - halfAnimationWidth, lineY, animationWidth, 2);
            }

            //PaintSpinBox();
        }

        protected void PaintSpinBox()
        {
            Control spinbox = _baseNumericUpDown.Controls[0];
            var g = spinbox.CreateGraphics();
            g.Clear(Color.Red);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            _baseNumericUpDown.Location = new Point(0, 0);
            _baseNumericUpDown.Width = Width;

            Height = _baseNumericUpDown.Height + 5;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            _baseNumericUpDown.BackColor = SkinManager.GetApplicationBackgroundColor();
            _baseNumericUpDown.ForeColor = SkinManager.Theme == MaterialSkinManager.Themes.LIGHT ? SkinManager.GetPrimaryTextColor() : Color.White;
        }

        public MaterialNumericUpDown()
        {
            _animationManager = new AnimationManager
            {
                Increment = 0.06,
                AnimationType = AnimationType.EaseInOut,
                InterruptAnimation = false
            };
            _animationManager.OnAnimationProgress += _ => Invalidate();

            _baseNumericUpDown = new BaseNumericUpDown
            {
                BorderStyle = BorderStyle.None,
                Font = SkinManager.ROBOTO_REGULAR_11,
                BackColor = BackColor,
                ForeColor = SkinManager.Theme == MaterialSkinManager.Themes.LIGHT ? SkinManager.GetPrimaryTextColor() : Color.White,
                Location = new Point(0, 0),
                Width = Width,
                Height = Height - 5
            };

            if (!Controls.Contains(_baseNumericUpDown) && !DesignMode)
            {
                Controls.Add(_baseNumericUpDown);
            }

            _baseNumericUpDown.GotFocus += (sender, args) => _animationManager.StartNewAnimation(AnimationDirection.In);
            _baseNumericUpDown.LostFocus += (sender, args) => _animationManager.StartNewAnimation(AnimationDirection.Out);

            BackColorChanged += (sender, args) =>
            {
                _baseNumericUpDown.BackColor = SkinManager.GetApplicationBackgroundColor();
                _baseNumericUpDown.ForeColor = SkinManager.Theme == MaterialSkinManager.Themes.LIGHT ? SkinManager.GetPrimaryTextColor() : Color.White;
            };

            //Fix for tabstop
            _baseNumericUpDown.TabStop = true;
            this.TabStop = false;
        }

        private class BaseNumericUpDown : NumericUpDown
        {
            [DllImport("user32.dll", CharSet = CharSet.Unicode)]
            private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

            private const int EM_SETCUEBANNER = 0x1501;

            private string hint = string.Empty;

            public TextBox Input => Controls[1] as TextBox;

            public string Hint
            {
                get { return hint; }
                set
                {
                    hint = value;
                    SendMessage(Handle, EM_SETCUEBANNER, (int)IntPtr.Zero, Hint);
                }
            }

            public void SelectAll()
            {
                BeginInvoke((MethodInvoker)(() =>
                {
                    base.Focus();
                    base.Select(0, base.Value.ToString().Length);
                }));
            }

            public new void Focus()
            {
                BeginInvoke((MethodInvoker)(() => base.Focus()));
            }

            public BaseNumericUpDown()
            {
                MaterialContextMenuStrip cms = new NumericUpDownContextMenuStrip();
                cms.Opening += ContextMenuStripOnOpening;
                cms.OnItemClickStart += ContextMenuStripOnItemClickStart;

                ContextMenuStrip = cms;
            }

            private void ContextMenuStripOnItemClickStart(object sender, ToolStripItemClickedEventArgs toolStripItemClickedEventArgs)
            {
                switch (toolStripItemClickedEventArgs.ClickedItem.Text)
                {
                    case "Undo":
                        Input.Undo();
                        break;
                    case "Cut":
                        Input.Cut();
                        break;
                    case "Copy":
                        Input.Copy();
                        break;
                    case "Paste":
                        Input.Paste();
                        break;
                    case "Delete":
                        Input.SelectedText = string.Empty;
                        break;
                    case "Select All":
                        SelectAll();
                        break;
                }
            }

            private void ContextMenuStripOnOpening(object sender, CancelEventArgs cancelEventArgs)
            {
                if (sender is NumericUpDownContextMenuStrip strip)
                {
                    strip.Undo.Enabled = Input.CanUndo;
                    strip.Cut.Enabled = !string.IsNullOrEmpty(Input.SelectedText);
                    strip.Copy.Enabled = !string.IsNullOrEmpty(Input.SelectedText);
                    strip.Paste.Enabled = Clipboard.ContainsText();
                    strip.Delete.Enabled = !string.IsNullOrEmpty(Input.SelectedText);
                    strip.SelectAll.Enabled = !string.IsNullOrEmpty(Text);
                }
            }
        }

        private class NumericUpDownContextMenuStrip : MaterialContextMenuStrip
        {
            public readonly ToolStripItem Undo = new MaterialToolStripMenuItem { Text = "Undo" };
            public readonly ToolStripItem Seperator1 = new ToolStripSeparator();
            public readonly ToolStripItem Cut = new MaterialToolStripMenuItem { Text = "Cut" };
            public readonly ToolStripItem Copy = new MaterialToolStripMenuItem { Text = "Copy" };
            public readonly ToolStripItem Paste = new MaterialToolStripMenuItem { Text = "Paste" };
            public readonly ToolStripItem Delete = new MaterialToolStripMenuItem { Text = "Delete" };
            public readonly ToolStripItem Seperator2 = new ToolStripSeparator();
            public readonly ToolStripItem SelectAll = new MaterialToolStripMenuItem { Text = "Select All" };

            public NumericUpDownContextMenuStrip()
            {
                Items.AddRange(new[]
                {
                    Undo,
                    Seperator1,
                    Cut,
                    Copy,
                    Paste,
                    Delete,
                    Seperator2,
                    SelectAll
                });
            }
        }
    }
}
