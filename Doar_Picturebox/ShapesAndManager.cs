using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doar_Picturebox
{

    class Figura
    {
        public Figura() { }
        public virtual double daLungime(Figura figura)
        {
            return 0;
        }

        public virtual void deseneaza(Graphics g, Color brush, int size)
        {

        }

    }

    class Linie : Figura
    {
        public int x1, y1, x2, y2;
        public Linie(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;

            this.x2 = x2;
            this.y2 = y2;

        }

        
        public override double daLungime(Figura figura)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        public void RandomizeParameters()
        {
            Random r1 = new Random();
            x1 = r1.Next(0, 500);


            Random r2 = new Random();
            y1 = r2.Next(0, 500);

            Random r3 = new Random();
            x2 = r3.Next(0, 500);

            Random r4 = new Random();
            y2 = r4.Next(0, 500);
        }

        public override void deseneaza(Graphics g, Color brush, int size)
        {
            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            g.DrawLine(new Pen(brush, size), p1, p2);

        }
    }

    class Triunghi : Figura
    {
        public int x1, y1, x2, y2, x3, y3;

        public override double daLungime(Figura figura)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1))
                 + Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2))
                 + Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
        }

        public void RandomizeParameters()
        {
            Random r1 = new Random();
            x1 = r1.Next(0, 500);


            Random r2 = new Random();
            y1 = r2.Next(0, 500);

            Random r3 = new Random();
            x2 = r3.Next(0, 500);

            Random r4 = new Random();
            y2 = r4.Next(0, 500);

            Random r5 = new Random();
            x3 = r5.Next(0, 500);

            Random r6 = new Random();
            y3 = r6.Next(0, 500);
        }

        public Triunghi(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            this.x1 = x1;
            this.y1 = y1;

            this.x2 = x2;
            this.y2 = y2;

            this.x3 = x3;
            this.y3 = y3;
        }
        public override void deseneaza(Graphics g, Color brush, int size)
        {
            Point[] Triangle_points = new Point[] { new Point { X = x1, Y = y1 }, new Point { X = x2, Y = y2 }, new Point { X = x3, Y = y3 } };

            g.DrawPolygon(new Pen(brush, size), Triangle_points);
        }
    }

    class Dreptunghi : Figura
    {
        public int x, y, width, height;

        public override double daLungime(Figura figura)
        {
            return 2 * (width + height);
        }

        public void RandomizeParameters()
        {
            Random r3 = new Random();
            x = r3.Next(0, 500);

            Random r4 = new Random();
            y = r4.Next(0, 500);

            Random r5 = new Random();
            width = r5.Next(50, 500);

            Random r6 = new Random();
            height = r6.Next(20, 500);
        }

        public Dreptunghi(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;

            this.width = width;
            this.height = height;
        }


        public override void deseneaza(Graphics g, Color brush, int size)
        {
            Rectangle r = new Rectangle(x, y, width, height);
            g.DrawRectangle(new Pen(brush, size), r);
        }
    }

    class Elipsa : Figura
    {
        public int x, y, width, height;

        public override double daLungime(Figura figura)
        {
            return 3.141429 * (width / 2 + height / 2);
        }

        public void RandomizeParameters()
        {
            Random r3 = new Random();
            x = r3.Next(0, 500);

            Random r4 = new Random();
            y = r4.Next(0, 500);

            Random r5 = new Random();
            width = r5.Next(50, 500);

            Random r6 = new Random();
            height = r6.Next(20, 500);
        }
        public Elipsa(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;

            this.height = height;
            this.width = width;
        }
        public override void deseneaza(Graphics g, Color brush, int size)
        {
            Pen pen = new Pen(brush, size);
            g.DrawEllipse(pen, x, y, width, height);

        }
    }

    class CurbaBezier : Figura
    {
        public int x1, y1, x2, y2, x3, y3, x4, y4;

        public override double daLungime(Figura figura)
        {
            double chord = Math.Sqrt((x4 - x1) * (x4 - x1) + (y4 - y1) * (y4 - y1));

            double cont_net = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))
                + Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2))
                + Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));

            double app_arc_length = (cont_net + chord) / 2;
            return app_arc_length;
        }

        public void RandomizeParameters()
        {
            Random r1 = new Random();
            x1 = r1.Next(0, 500);


            Random r2 = new Random();
            y1 = r2.Next(0, 500);

            Random r3 = new Random();
            x2 = r3.Next(0, 500);

            Random r4 = new Random();
            y2 = r4.Next(0, 500);

            Random r5 = new Random();
            x3 = r5.Next(0, 500);

            Random r6 = new Random();
            y3 = r6.Next(0, 500);

            Random r7 = new Random();
            x4 = r7.Next(0, 500);

            Random r8 = new Random();
            y4 = r8.Next(0, 500);


        }
        public CurbaBezier(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            this.x1 = x1;
            this.y1 = y1;

            this.x2 = x2;
            this.y2 = y2;

            this.x3 = x3;
            this.y3 = y3;

            this.x4 = x4;
            this.y4 = y4;
        }
        public override void deseneaza(Graphics g, Color brush, int size)
        {
            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            Point p3 = new Point(x3, y3);
            Point p4 = new Point(x4, y4);

            g.DrawBezier(new Pen(brush, size), p1, p2, p3, p4);

        }
    }

    internal class Manager
    {

        public int id_of_shape(Figura figura)
        {
            if (figura is Linie) return 1;
            else if (figura is Dreptunghi) return 2;
            else if (figura is Triunghi) return 3;
            else if (figura is Elipsa) return 4;
            else if (figura is CurbaBezier) return 5;

            return 0;
        }

        public Figura generate_shape(int id)
        {
            if (id == 0)
            {
                Linie linie = new Linie(0, 0, 0, 0);
                linie.RandomizeParameters();
                return linie;
            }

            else if (id == 1)
            {
                Triunghi triunghi = new Triunghi(0, 0, 0, 0, 0, 0);
                triunghi.RandomizeParameters();
                return triunghi;
            }

            else if (id == 2)
            {
                Dreptunghi dreptunghi = new Dreptunghi(0, 0, 0, 0);
                dreptunghi.RandomizeParameters();
                return dreptunghi;
            }

            else if (id == 3)
            {
                Elipsa elipsa = new Elipsa(0, 0, 0, 0);
                elipsa.RandomizeParameters();
                return elipsa;
            }

            else
            {
                CurbaBezier curba_bezier = new CurbaBezier(0, 0, 0, 0, 0, 0, 0, 0);
                curba_bezier.RandomizeParameters();
                return curba_bezier;
            }

           // return null;
        }

    }
}
