using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Security;

namespace Esercizio02_SRV
{
    class pictureBoxRotonde : PictureBox
    {
        private int pBordo = 2;
        private Color pColoreBordo = Color.HotPink;
        private Color pColoreBordo2 = Color.RoyalBlue;
        private DashStyle pStileBordo = DashStyle.Solid;
        private DashCap pStileCapBordo = DashCap.Flat;
        private float pGradienteColore = 50F;

        public pictureBoxRotonde()
        {
            this.Size = new Size(100, 100);
            this.SizeMode = PictureBoxSizeMode.Zoom; // Strech
        }

        public int Bordo
        {
            get
            {
                return pBordo;
            }
            set
            {
                pBordo = value;
                this.Invalidate();
            }
        }
        public Color ColoreBordo
        {
            get
            {
                return pColoreBordo;
            }
            set
            {
                pColoreBordo = value;
                this.Invalidate();
            }
        }

        public Color ColoreBordo2
        {
            get
            {
                return pColoreBordo2;
            }
            set
            {
                pColoreBordo2 = value;
                this.Invalidate();
            }
        }

        public DashStyle StileBordo
        {
            get
            {
                return pStileBordo;
            }
            set
            {
                pStileBordo = value;
                this.Invalidate();
            }
        }

        public DashCap StileCapBordo
        {
            get
            {
                return pStileCapBordo;
            }
            set
            {
                pStileCapBordo = value;
                this.Invalidate();
            }
        }
        public float GradienteColore
        {
            get
            {
                return pGradienteColore;
            }
            set
            {
                pGradienteColore = value;
                this.Invalidate();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(this.Width, this.Width);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            var grafo = pe.Graphics;
            var rectContorno = Rectangle.Inflate(this.ClientRectangle, -1,1);
            var rectBordo = Rectangle.Inflate(rectContorno,-Bordo, -Bordo);
            var smoothSize = Bordo > 0 ? Bordo * 3 : 1;
            using (var borderGColor = new LinearGradientBrush(rectBordo, ColoreBordo, ColoreBordo2, GradienteColore)) 
            using (var pathRegion = new GraphicsPath()) 
            using (var penSmooth = new Pen(this.Parent.BackColor, smoothSize))
            using (var penBorder = new Pen(borderGColor, Bordo))
            {
                penBorder.DashStyle = StileBordo;
                penBorder.DashCap = StileCapBordo;
                pathRegion.AddEllipse(rectContorno);
                this.Region = new Region(pathRegion);
                grafo.SmoothingMode = SmoothingMode.AntiAlias;

                grafo.DrawEllipse(penSmooth,rectContorno);
                if (Bordo > 0)
                    grafo.DrawEllipse(penBorder,rectContorno);
            }

        }
    }
}
