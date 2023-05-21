using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm2
{
    public partial class Caphca : Form
    {
        public Caphca()
        {
            InitializeComponent();
        }
        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            Bitmap result = new Bitmap(Width, Height);

            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);

            Brush[] colors = { Brushes.Black,
                      };

            Graphics g = Graphics.FromImage((Image)result);


            g.Clear(Color.Gray);


            Text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                Text += ALF[rnd.Next(ALF.Length)];


            g.DrawString(Text, new Font("Comic Sans MS", 18),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));


            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));

            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.Red);

            return result;
        }

        private void BoxCaphca_Click(object sender, EventArgs e)
        {

        }

        private void BtnEnt_Click(object sender, EventArgs e)
        {
            FormEnter Enter = new FormEnter();
            Enter.Show();
            this.Hide();

            if (Enter.Text == this.Text)
                MessageBox.Show("Верно!");
            else
                MessageBox.Show("Ошибка!");
        }

        private void Caphca_Load(object sender, EventArgs e)
        {
            BoxCaphca.Image = this.CreateImage(BoxCaphca.Width, BoxCaphca.Height);


        }

        private void BtnObnov_Click(object sender, EventArgs e)
        {
            BoxCaphca.Image = this.CreateImage(BoxCaphca.Width, BoxCaphca.Height);
        }
    }
}
