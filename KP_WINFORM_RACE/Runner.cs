using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP_WINFORM_RACE
{

    internal class Runner
    {
        private float x;
        private float y;
        private float width;
        public float xw => x + width;
        public int height { get; }
        private float baseSpeed;
        public float adSpeed;
        public string name { get; }
        private Brush brush;
        PictureBox pictureRunner = new PictureBox();
        Image imageRunner;

        public Runner(int x, int y, float speed, string name, Game form)
        {
            this.x = x;
            this.y = y;
            this.baseSpeed = speed;
            this.adSpeed = 0;
            this.name = name;
            this.width = 112;
            this.height = 70;
            this.brush = new SolidBrush(Color.Red);

            //form.label1.Text = AppDomain.CurrentDomain.BaseDirectory;
            //string imagePath = "C:\\Users\\Василий Карягин\\source\\repos\\KP_WINFORM_RACE\\KP_WINFORM_RACE\\pic\\";
            string imagePath = "..\\..\\pic\\";

            imageRunner = Image.FromFile(imagePath + name + ".gif");
            pictureRunner.Size = new Size((int)width, (int)height);
            pictureRunner.SizeMode = PictureBoxSizeMode.Zoom;
            pictureRunner.BackColor = Color.Transparent;
            pictureRunner.Image = imageRunner;
            pictureRunner.Visible = true;
            form.Controls.Add(pictureRunner);
        }

        public void Draw(Graphics g)
        {
            //g.FillRectangle(brush, x, y, width, height);
            pictureRunner.Location = new Point((int)x, (int)y);

        }
        public void Move()
        {
            x += baseSpeed + adSpeed;
        }
    }
}
