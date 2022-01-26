using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMLaDoctaCines
{
    public class ComboPersonalizado : ComboBox
    {
        private const int WM_PAINT = 0xF;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_SYNCPAINT = 0x0088;
        private int m_buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;
        private Color m_BorderColor = Color.Red;
        private Color m_FadedBorderColor = Color.Red;
        private ControlBorderDrawMode m_BorderDrawMode = ControlBorderDrawMode.Full;
        private Rectangle m_BorderDrawArea = Rectangle.Empty;

        public enum ControlBorderDrawMode : int
        {
            Full = 0,
            Internal,
            InternalFaded
        }

        public ComboPersonalizado() => InitializeComponent();

        private void InitializeComponent()
        {
            SetStyle(ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            this.DrawMode = DrawMode.Normal;
            this.BorderColor = Color.SteelBlue;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            this.SetBorderArea();
            base.OnHandleCreated(e);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT | m.Msg == WM_SYNCPAINT | m.Msg == WM_NCPAINT)
            {
                using (Graphics g = Graphics.FromHwnd(this.Handle))
                {
                    this.SetBorderArea();
                    using (Pen pen = new Pen((this.m_BorderDrawMode == ControlBorderDrawMode.InternalFaded)
                                   ? this.m_FadedBorderColor
                                   : this.m_BorderColor, 1))
                    {
                        if (this.BorderDrawMode == ControlBorderDrawMode.Full)
                            g.DrawLine(pen, this.ClientRectangle.Width - m_buttonWidth, 0,
                                            this.ClientRectangle.Width - m_buttonWidth, this.ClientRectangle.Height - 1);
                        g.DrawRectangle(pen, m_BorderDrawArea);
                    }
                }
                m.Result = IntPtr.Zero;
            }
        }

        private void SetBorderArea()
        {
            this.m_FadedBorderColor = Color.DimGray;
            this.m_BorderDrawArea =
                new Rectangle(
                    Point.Empty,
                    new Size(this.ClientRectangle.Width - m_buttonWidth - 1, this.ClientRectangle.Height - 1));
        }

        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always), Category("Appearance")]
        [Description("Determines how the colored border is drawn. " +
                     "Full: specifies the control's client area and the DropDown Button" +
                     "Internal: the intenal section of the control, excluding the DropDown Button.")]
        public ControlBorderDrawMode BorderDrawMode
        {
            get => this.m_BorderDrawMode;
            set { this.m_BorderDrawMode = value; Invalidate(); }
        }

        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always), Category("Appearance")]
        [Description("Get or Set the Color of the Control's border")]
        public Color BorderColor
        {
            get => this.m_BorderColor;
            set { this.m_BorderColor = value; Invalidate(); }
        }
    }
}
