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

            int coordonata_x = mouseEventArgs.X;
            int coordonata_y = mouseEventArgs.Y;

            

            Bitmap bmp;

            if (File.Exists(@"C:\Users\Adina Milica\Desktop\Figura2.jpeg"))
            { 
                bmp = new Bitmap(@"C:\Users\Adina Milica\Desktop\Figura2.jpeg");
                dimensiune.Text = "DA, EXISTA FILEUL";
            }
            else { 
                bmp = new Bitmap(Tablou.Width, Tablou.Height);

                dimensiune.Text = "NU, NU EXISTA FILEUL";
            }
            

            


            Graphics g = Graphics.FromImage(bmp);

            

            /*

            for (int i = 0; i < 500; i++)
            {
                for (int j = 0; j < 500; j++)
                {

                    if (i == coordonta_x && j == coordonata_y)
                    {
                       
                        bmp.SetPixel(i, j, Color.Purple);

                        coordonate_punct_clickat.Text=i.ToString() + " " + j.ToString();

                        Color pixel = bmp.GetPixel(i, j);
                        bitmap_after_click.Text=pixel.ToString(); //vedem daca culoarea pixelului e buna


                        break;
                    }

                    
                }
            }

           
            // cu chestia asta de jos imi pune punctu bine, o singura data
             Tablou.Image= bmp.Clone(new Rectangle(0, 0, 500, 500), System.Drawing.Imaging.PixelFormat.DontCare);
            g.DrawImage(bmp, 0, 0);

            */

            //fill(bmp, coordonata_x, coordonata_y, Color.Pink);
            Point p = new Point(coordonata_x, coordonata_y);
            FloodFill(bmp, p, background_color, Color.Pink);
            //g.DrawImage(bmp, 0, 0);



        }

        private void FloodFill(Bitmap bmp, Point pt, Color targetColor, Color replacementColor)
        {
            Stack<Point> pixels = new Stack<Point>();

            targetColor = bmp.GetPixel(pt.X, pt.Y);
            pixels.Push(pt);

            while (pixels.Count > 0)
            {
                Point a = pixels.Pop();

                if (a.X < bmp.Width && a.X > 0 &&
                        a.Y < bmp.Height && a.Y > 0)//make sure we stay within bounds
                {

                    if (bmp.GetPixel(a.X, a.Y) == targetColor)
                    {
                        bmp.SetPixel(a.X, a.Y, replacementColor);
                        pixels.Push(new Point(a.X - 1, a.Y));
                        pixels.Push(new Point(a.X + 1, a.Y));
                        pixels.Push(new Point(a.X, a.Y - 1));
                        pixels.Push(new Point(a.X, a.Y + 1));

                        dimensiune.Text = "e target color";
                    }

                    else { dimensiune.Text = "nu e target color"; }
                   
                }

                
            }
            //Tablou.Refresh(); //refresh our main picture box
            return;
        }

        public void fill(Bitmap picture, int x, int y, Color bcolor)
        {
            //Graphics g = Graphics.FromImage(picture);

            if (x > 0 && x < picture.Width && y > 0 && y < picture.Height)
            {

                Point p = new Point(x, y);

                Stack<Point> s = new Stack<Point>();
                s.Push(p);

                while (s.Count > 0)
                {
                    p = s.Pop();

                    

                    Color currentcolor = picture.GetPixel(p.X, p.Y);

                    //initial era egal
                    if (currentcolor == background_color)
                    {
                        //era comentat
                        this.Refresh();
                        picture.SetPixel(p.X, p.Y, currentcolor);

                        //g.DrawImage(picture, 0, 0);

                        s.Push(new Point(p.X - 1, p.Y));
                        s.Push(new Point(p.X + 1, p.Y));
                        s.Push(new Point(p.X, p.Y - 1));
                        s.Push(new Point(p.X, p.Y + 1));
                    }

                }
                dimensiune.Text = s.Count().ToString();

            }



        }

        private void Salveaza_Click(object sender, EventArgs e)
        {
            sf.DefaultExt = "jpeg";
            sf.FileName = "Figura2.jpeg";
            sf.Filter = "JPEG files (*.jpeg)|*.jpeg|All files (*.*)|*.*";
            sf.FilterIndex = 1;
            sf.RestoreDirectory = true;
            sf.ShowDialog();

            
            Tablou.Image.Save(sf.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);

            
        }
    }
}