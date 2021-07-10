using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int btnOneClicked = 0;
        int btnTwoClicked = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int r = rnd.Next(255), g = rnd.Next(255), b = rnd.Next(255);
            this.button1.BackColor = Color.FromArgb(r, g, b);

            this.label1.Text = $"Btn 1: {++btnOneClicked}      Btn 2: {btnTwoClicked}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = rnd.Next(255), g = rnd.Next(255), b = rnd.Next(255);
            this.button2.BackColor = Color.FromArgb(r, g, b);
            this.label1.Text = $"Btn 1: {btnOneClicked}      Btn 2: {++btnTwoClicked}";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            bool moveHappened = false;

            while (!moveHappened)
            {
                var wdt = ClientSize.Width;
                var hght = ClientSize.Height;

                int x = rnd.Next(wdt);
                int y = rnd.Next(hght);

                if ((x - label1.Width <= 0 && x <= wdt - label1.Width) && (y > 0 && y < hght - 6))
                {
                    this.label1.Location = new Point(x, y);
                    moveHappened = true;
                }
            }

            int chooseBtn = rnd.Next(2);
            int opacity = rnd.Next(256);

            if (chooseBtn == 0)
            {
                this.button1.BackColor = Color.FromArgb(opacity, button1.BackColor);
            }
            else
            {
                this.button2.BackColor = Color.FromArgb(opacity, button2.BackColor);
            }
        }
    }
}

