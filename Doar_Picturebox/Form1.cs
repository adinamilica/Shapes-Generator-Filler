using System.Drawing.Imaging;

namespace Doar_Picturebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     void deseneaza()
        {

            int nr_figuri = Convert.ToInt32(number_of_figures.Text);

            for (int i = 1; i <= nr_figuri; i++)
            {
                Random figure = new Random();
                int figure_id = figure.Next(1, 5);

                if (figure_id == 1)
                {
                    // draw rectangle

                    Random r1 = new Random(); int r1_x = r1.Next(0, 500);
                    Random r2 = new Random(); int r2_y = r2.Next(0, 500);

                    Random r3 = new Random(); int r3_width = r3.Next(20, 500);
                    Random r4 = new Random(); int r4_height = r4.Next(20, 500);



                    Rectangle r = new Rectangle(r1_x, r2_y, r3_width, r4_height);

                    using (Graphics g = Graphics.FromImage(Tablou.Image))
                    {
                        g.DrawRectangle(new Pen(Color.Red, 4), r);
                    }
                }

                else if (figure_id == 2)
                {
                    //draw triangle
                    Random r1 = new Random(); int r1_x = r1.Next(0, 500);
                    Random r2 = new Random(); int r2_y = r2.Next(0, 500);

                    Random r3 = new Random(); int r3_x = r3.Next(0, 500);
                    Random r4 = new Random(); int r4_y = r4.Next(0, 500);

                    Random r5 = new Random(); int r5_x = r5.Next(0, 500);
                    Random r6 = new Random(); int r6_y = r6.Next(0, 500);



                    Point[] Triangle_points = new Point[] { new Point { X = r1_x, Y = r2_y }, new Point { X = r3_x, Y = r4_y }, new Point { X = r5_x, Y = r6_y } };

                    using (Graphics g = Graphics.FromImage(Tablou.Image))
                    {
                        g.DrawPolygon(new Pen(Color.Red, 4), Triangle_points);
                    }

                }

                else if (figure_id == 3)
                {
                    //draw line
                    Random r1 = new Random(); int r1_x = r1.Next(0, 500);
                    Random r2 = new Random(); int r2_y = r2.Next(0, 500);

                    Random r3 = new Random(); int r3_x = r3.Next(0, 500);
                    Random r4 = new Random(); int r4_y = r4.Next(0, 500);

                    Point p1 = new Point(r1_x, r2_y);
                    Point p2 = new Point(r3_x, r4_y);

                    using (Graphics g = Graphics.FromImage(Tablou.Image))
                    {
                        g.DrawLine(new Pen(Color.Red, 4), p1, p2);
                    }
                }

                else if (figure_id == 4)
                {
                    //draw Bezier curve
                    Random r1 = new Random(); int r1_x = r1.Next(0, 500);
                    Random r2 = new Random(); int r2_y = r2.Next(0, 500);

                    Random r3 = new Random(); int r3_x = r3.Next(0, 500);
                    Random r4 = new Random(); int r4_y = r4.Next(0, 500);

                    Random r5 = new Random(); int r5_x = r5.Next(0, 500);
                    Random r6 = new Random(); int r6_y = r6.Next(0, 500);

                    Random r7 = new Random(); int r7_x = r7.Next(0, 500);
                    Random r8 = new Random(); int r8_y = r8.Next(0, 500);



                    Point p1 = new Point(r1_x, r2_y);
                    Point p2 = new Point(r3_x, r4_y);
                    Point p3 = new Point(r5_x, r6_y);
                    Point p4 = new Point(r7_x, r8_y);

                    using (Graphics g = Graphics.FromImage(Tablou.Image))
                    {
                        g.DrawBezier(new Pen(Color.Red, 4), p1, p2, p3, p4);
                    }
                }

                else
                {
                    //draw elipse

                    Random r1 = new Random(); int r1_x = r1.Next(0, 500);
                    Random r2 = new Random(); int r2_y = r2.Next(0, 500);

                    Random r3 = new Random(); int r3_width = r3.Next(20, 500);
                    Random r4 = new Random(); int r4_height = r4.Next(20, 500);

                    // g.DrawEllipse(creion, r1_x, r2_y, r3_width, r4_height);
                }



                // }

                // Tablou.Refresh();



            }

            // Tablou.Refresh();




            //draw_random_figures(Tablou.CreateGraphics());

            // Tablou.Invalidate();

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(Tablou.Width, Tablou.Height);
            //Graphics g = Graphics.FromImage(bmp);

            // daca inlocuiesc  Tablou.CreateGraphics()  cu g ar trebui sa mearga sa pastreze imaginea dar nu merge nici macar sa mai afiseze
            // obiectivul e si sa se pastreze imaginea, dar mai ales sa producem un bitmap pe care sa lucram dupa.

           // Graphics g = Tablou.CreateGraphics();

            //void draw_random_figures(Graphics g)
            //{

            Tablou.Image = bmp;

            deseneaza();

            for (int i = 100; i < 120; i++)
            {
                for (int j = 100; j < 120; j++)
                {
                    Color pixel = bmp.GetPixel(i, j);
                    bitmap_text.Text += pixel.ToString() + " ";
                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(Tablou.Width, Tablou.Height);

            Graphics g = Graphics.FromImage(bmp);

            //if (Tablou.Image == null) button2.Text = "null";
            //else button2.Text = Tablou.Image.ToString();

            for (int i = 0; i < 500; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    Color pixel = bmp.GetPixel(i, j);
                    bitmap_text.Text  += pixel.ToString() + " ";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        byte[] BitmapData_Din_Bitmap(Bitmap bmp)
        {
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Bmp);
            return (ms.GetBuffer());
        }

        void set_color(byte[] sir_biti, int rezO, Color col, int l, int c)
        {
            sir_biti[54 + 4 * c + 4 * l * rezO] = col.R;
            sir_biti[54 + 4 * c + 4 * l * rezO + 1] = col.G;
            sir_biti[54 + 4 * c + 4 * l * rezO + 2] = col.B;
            sir_biti[54 + 4 * c + 4 * l * rezO + 3] = col.A;
        }

        Bitmap Bitmap_Din_BitmapData(byte[] bmpData)
        {
            MemoryStream ms = new MemoryStream(bmpData);
            return (new Bitmap(ms));
        }

        private void Tablou_Click(object sender, EventArgs e)
        {
            var mouseEventArgs = e as MouseEventArgs;

            int coordonta_x = mouseEventArgs.X;
            int coordonata_y = mouseEventArgs.Y;

            Bitmap bmp = new Bitmap(Tablou.Width, Tablou.Height );

            Graphics g = Tablou.CreateGraphics();
          //  Graphics g = Graphics.FromImage(bmp);

            //if (Tablou.Image == null) button2.Text = "null";
            //else button2.Text = Tablou.Image.ToString();

            byte[] bmpb = BitmapData_Din_Bitmap(bmp);

            for (int i = 0; i < 500; i++)
            {
                for (int j = 0; j < 500; j++)
                {

                    if (i == coordonta_x && j == coordonata_y)
                    {
                        //  Color pixel = bmp.GetPixel(i, j);
                        
                        set_color(bmpb, Tablou.Width,Color.Purple,coordonta_x + 54,coordonata_y + 54);
                    }

                    //bitmap_text.Text += pixel.ToString() + " ";
                }
            }

            dimensiune.Text = bmpb.Length.ToString();

            bmp = Bitmap_Din_BitmapData(bmpb);
            g.DrawImage(bmp, 0, 0);

        }
    }
}