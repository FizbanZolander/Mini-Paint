using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Mini_Paint
{
    public partial class frmMiniPaint : Form
    {
        private Graphics g;
        private Point p = Point.Empty;
        private Pen pioro;
        public frmMiniPaint()
        {
            InitializeComponent();
            imgObrazek.Image = new Bitmap(400, 400);
            g = Graphics.FromImage(imgObrazek.Image);
            pioro = new Pen(Color.Black);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                p = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(pioro, p, e.Location);
                p = e.Location;
                imgObrazek.Refresh();
            }
        }

        private void cmdZapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "bmp|*.bmp";
            dialog.ShowDialog();
            if (dialog.FileName != "")
                imgObrazek.Image.Save(dialog.FileName);
        }

        private void cmdKolor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = lblKolor.BackColor;
            dialog.ShowDialog();
            lblKolor.BackColor = dialog.Color;
            pioro.Color = dialog.Color;
        }

        private void cmdCzysc_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            imgObrazek.Refresh();
        }
    }
}