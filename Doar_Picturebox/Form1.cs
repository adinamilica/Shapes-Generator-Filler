using System.Drawing.Imaging;

namespace Doar_Picturebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color background_color; // background of the tablou

        void deseneaza()
        {
            using (Graphics g = Graphics.FromImage(Tablou.Image))
            {
                g.Clear(Color.LightGray);
               // Tablou.Refresh();
            }

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

                    using (Graphics g = Graphics.FromImage(Tablou.Image))
                    {
                        g.DrawEllipse(new Pen(Color.Red, 4), r1_x, r2_y, r3_width, r4_height);
                    }
                }

            }

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(Tablou.Width, Tablou.Height);
            
           // Tablou.BackColor = Color.LightGray;
            background_color = Color.LightGray; 

            //Graphics g = Graphics.FromImage(bmp);

            // daca inlocuiesc  Tablou.CreateGraphics()  cu g ar trebui sa mearga sa pastreze imaginea dar nu merge nici macar sa mai afiseze
            // obiectivul e si sa se pastreze imaginea, dar mai ales sa producem un bitmap pe care sa lucram dupa.

            // Graphics g = Tablou.CreateGraphics();

            //void draw_random_figures(Graphics g)
            //{

            Tablou.Image = bmp;

            deseneaza();

            /*
             * ARGB LIST
              for (int i = 100; i < 120; i++)
            {
                for (int j = 100; j < 120; j++)
                {
                    Color pixel = bmp.GetPixel(i, j);
                    bitmap_R_text.Text += pixel.ToString() + " ";
                }
            }
             */

            


            //ALPHA MATRIX

            /*
            for (int i = 0; i < Tablou.Width; i++)
            {
                for (int j = 0; j < Tablou.Height; j++)
                {
                    Color pixel = bmp.GetPixel(i, j);
                    string culoare = pixel.A.ToString();

                    bitmap_R_text.Text += culoare + " ";
                }
            }
            */


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

            int x = mouseEventArgs.X;
            int y = mouseEventArgs.Y;

            Bitmap bmp;

            if (File.Exists(@"C:\Users\Adina Milica\Desktop\tot momentan\oop s2\Shapes-Generator-Filler\Doar_Picturebox\figuri\figura.bmp"))
            { 
                bmp = new Bitmap(@"C:\Users\Adina Milica\Desktop\tot momentan\oop s2\Shapes-Generator-Filler\Doar_Picturebox\figuri\figura.bmp");
                dimensiune.Text = "DA, EXISTA FILEUL";
            }
            else { 
                bmp = new Bitmap(Tablou.Width, Tablou.Height);

                dimensiune.Text = "NU, NU EXISTA FILEUL";
            }


            Point pt = new Point(x, y);
            FloodFill(bmp, pt, Color.Purple);

            //afisare
            Graphics g = Graphics.FromImage(bmp);
            Tablou.Image = bmp.Clone(new Rectangle(0, 0, 500, 500), System.Drawing.Imaging.PixelFormat.DontCare);
            g.DrawImage(bmp, 0, 0);


            // tre sa o salvam
            //problema e ca filestream-ul este ocupat in momentul asta
            // deci trebuie sa scoatem imaginea curenta din picturebox
            //si s-o inlocuim cu asta pe care o salvam
            Tablou.Image.Save(@"C:\Users\Adina Milica\Desktop\tot momentan\oop s2\Shapes-Generator-Filler\Doar_Picturebox\figuri\figura3.bmp");


        }

        public void DotOrLineMaker(Bitmap bmp, int x, int y)
        {
            //pune ori un punct ori o linie in interiorulunei portiuni conturate
            //incercare de fill esuata


           // toate sunt 211 pentru ca lightgray are toate coordonatele RGB 211
            int targetColorR = 211;
            int targetColorG = 211;
            int targetColorB = 211;

            Color goten = bmp.GetPixel(x, y);

            coordonate_punct_clickat.Text = x.ToString() + " " + y.ToString();

            verificare_event.Text = goten.A.ToString() + " " + goten.R.ToString() + " " + goten.G.ToString() + " " + goten.B.ToString();

            Graphics g = Graphics.FromImage(bmp);

            // in momentul de fata ne coloreaza o linie pana la intalnirea culorii rosii

            if (x <= Tablou.Width && x >= 0 && y <= Tablou.Height && y >= 0)
            {
                // while(bmp.GetPixel(x, y).R == targetColorR && bmp.GetPixel(x, y).G == targetColorG && bmp.GetPixel(x, y).B == targetColorB )
                while (bmp.GetPixel(x, y).R != 255)
                {

                    bmp.SetPixel(x, y, Color.Purple); // punctul curent

                    //punctele din jur

                    bmp.SetPixel(x - 1, y, Color.Purple);
                    bmp.SetPixel(x + 1, y, Color.Purple);

                    bmp.SetPixel(x, y - 1, Color.Purple);
                    bmp.SetPixel(x, y + 1, Color.Purple);

                    x = x + 2;

                }


                //coordonate_punct_clickat.Text = x.ToString() + " " + y.ToString();

                ultimul_point.Text = x.ToString();

                Color pixel = bmp.GetPixel(x, y);
                bitmap_after_click.Text = pixel.ToString(); //vedem daca culoarea pixelului e buna


            }


            // AFISAREA PUNCTULUI o singura data (tot ce urmeaza necomentat)

           // Tablou.Image = bmp.Clone(new Rectangle(0, 0, 500, 500), System.Drawing.Imaging.PixelFormat.DontCare);
           // g.DrawImage(bmp, 0, 0);
        }

        public void FloodFill(Bitmap bmp, Point pt, Color replacementColor)
        {
           Color targetColor = bmp.GetPixel(pt.X, pt.Y);

            if (targetColor.ToArgb().Equals(replacementColor.ToArgb()))
            {
                return;
                
            }

            Stack<Point> pixels = new Stack<Point>();

            pixels.Push(pt);
            while (pixels.Count != 0)
            {
                Point temp = pixels.Pop();
                int y1 = temp.Y;
                while (y1 >= 0 && bmp.GetPixel(temp.X, y1) == targetColor)
                {
                    y1--;
                }
                y1++;
                bool spanLeft = false;
                bool spanRight = false;
                while (y1 < bmp.Height && bmp.GetPixel(temp.X, y1) == targetColor)
                {
                    bmp.SetPixel(temp.X, y1, replacementColor);

                    if (!spanLeft && temp.X > 0 && bmp.GetPixel(temp.X - 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X - 1, y1));
                        spanLeft = true;
                    }
                    else if (spanLeft && temp.X - 1 == 0 && bmp.GetPixel(temp.X - 1, y1) != targetColor)
                    {
                        spanLeft = false;
                    }
                    if (!spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X + 1, y1));
                        spanRight = true;
                    }
                    else if (spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) != targetColor)
                    {
                        spanRight = false;
                    }
                    y1++;
                }

            }
            //Tablou.Refresh();

        }

        private void Salveaza_Click(object sender, EventArgs e)
        {
            sf.DefaultExt = "bmp";
            sf.FileName = "figura.bmp";
            sf.Filter = "Bitmap Image (.bmp)|*.bmp";
            sf.FilterIndex = 1;
            sf.RestoreDirectory = true;
            sf.ShowDialog();

            
            Tablou.Image.Save(sf.FileName, System.Drawing.Imaging.ImageFormat.Bmp);

            
        }
    }
}