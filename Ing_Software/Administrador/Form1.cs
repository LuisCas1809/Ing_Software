using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ing_Software.Administrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.FromArgb(52, 235, 164),
                                                                       Color.FromArgb(52, 203, 237),
                                                                       0F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

    }
}
