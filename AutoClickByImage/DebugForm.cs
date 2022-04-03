using BotAutoFindItem.model;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AutoClickByImage
{
    public partial class DebugForm : Form
    {
        private readonly Point postion;
        private readonly Point location;
        private readonly Size sizeForm;
        private readonly Size sizeImage;
        private readonly List<PositionMatch> positions;


        public DebugForm(Point postion, Point location, Size sizeForm, Size sizeImage)
        {
            InitializeComponent();
            this.postion = postion;
            this.location = location;
            this.sizeForm = sizeForm;
            this.sizeImage = sizeImage;

            this.setStyle();
        }

        public DebugForm( List<PositionMatch> positions , Point location, Size sizeForm, Size sizeImage )
        {
            InitializeComponent();
            this.positions = positions; 
            this.location  = location;
            this.sizeForm  = sizeForm;
            this.sizeImage = sizeImage;
            this.setStyle();
        }


        private void setStyle()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = this.location;
            this.ClientSize = this.sizeForm;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.TransparencyKey = Color.Transparent;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            SolidBrush b = new SolidBrush(Color.Red);
            Pen pen = new Pen(b);

            if (positions == null)
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(postion, sizeImage));
            }
            else
            {
                foreach (PositionMatch item in this.positions)
                {
                    e.Graphics.DrawRectangle(pen, new Rectangle(new Point(item.x,item.y), sizeImage));
                }
            }
        }

        public void closeForm()
        {
            this.Dispose(true);
            Close();
        }
    }
}
