using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Lab7_2
{
    public partial class Form1 : Form
    {
        static Bitmap bmp = new Bitmap(1600, 1600);

        Graphics g = Graphics.FromImage(bmp);

        Pen myPen = new Pen(Color.Black);
        List<Line> lines;
        Polyhedron poly = new Polyhedron();
        Polyhedron poly2 = new Polyhedron();
        bool second_poly = false;

        int size = 70;
        Edge generatrix = new Edge();
        Point3 moving_point = new Point3(0, 0, 0);
        Point3 moving_point_line = new Point3(0, 0, 0);
        Point3 centr;
        string Path = "points.txt";


        Point3 watcher; 

        public Form1()
        {
            InitializeComponent();
            
            //lines = Hex(size);
            centr = new Point3(800 / 2, 800 / 2, 0);
            poly = Tetr(size);
            var edges = poly.edges;
            myPen.Width = 3f;

            foreach (var ed in edges)
                g.DrawPolygon(myPen, Position2d(ed));
            pictureBox1.Image = bmp;
        }
        public class Point3
        {
            public double X;
            public double Y;
            public double Z;
            public int ID;

            public Point3() { X = 0; Y = 0; Z = 0; ID = 0; }

            public Point3(double x, double y, double z)
            {
                this.X = x;
                this.Y = y;
                this.Z = z;
            }
            public Point3(double x, double y, double z, int id)
            {
                this.X = x;
                this.Y = y;
                this.Z = z;
                this.ID = id;
            }
        }

        public class Line
        {
            public Point3 p1;
            public Point3 p2;
            public int ID;

            public Line()
            {
                p1 = new Point3();
                p2 = new Point3();
            }

            public Line(Point3 p1, Point3 p2)
            {
                this.p1 = p1;
                this.p2 = p2;
            }

        }

        public class Edge
        {
            public List<Point3> points;

            public Edge()
            {
                this.points = new List<Point3> { };
            }
            public Edge(List<Point3> p)
            {
                this.points = p;
            }
        }

        public class Polyhedron
        {
            public List<Edge> edges;
            public List<Edge> faces;

            public Polyhedron()
            {
                this.edges = new List<Edge> { };
            }
            public Polyhedron(List<Edge> e, List<Edge> f)
            {
                this.edges = e;
            }
        }

        public Polyhedron Hex(int size)
        {
            var hc = size / 2;
            Polyhedron p = new Polyhedron();
            Edge e = new Edge();
            // 1-2-3-4
            e.points = new List<Point3> {
                new Point3(-hc, hc, -hc), // 1
                new Point3(hc, hc, -hc), // 2
                new Point3(hc, -hc, -hc), // 3
                new Point3(-hc, -hc, -hc) // 4
            };
            p.edges.Add(e);
            e = new Edge();

            // 1-2-6-5
            e.points = new List<Point3> {
                //new Point3(-hc, hc, -hc), // 1
                //new Point3(hc, hc, -hc), // 2
                //new Point3(hc, hc, hc), // 6 
                //new Point3(-hc, hc, hc) // 5
                new Point3(-hc, hc, -hc), // 1
                new Point3(-hc, hc, hc), // 5
                new Point3(hc, hc, hc), // 6 
                new Point3(hc, hc, -hc) // 2
            };
            p.edges.Add(e);
            e = new Edge();

            // 5-6-7-8
            e.points = new List<Point3> {
                //new Point3(-hc, hc, hc), // 5
                //new Point3(hc, hc, hc), // 6 
                //new Point3(hc, -hc, hc), // 7
                //new Point3(-hc, -hc, hc) // 8
                new Point3(-hc, hc, hc), // 5
                new Point3(-hc, -hc, hc), // 8
                new Point3(hc, -hc, hc), // 7
                new Point3(hc, hc, hc) // 6 
            };
            p.edges.Add(e);
            e = new Edge();

            // 6-2-3-7
            e.points = new List<Point3> {
                new Point3(hc, hc, hc), // 6 
                new Point3(hc, -hc, hc), // 7
                new Point3(hc, -hc, -hc), // 3
                new Point3(hc, hc, -hc) // 2
            };
            p.edges.Add(e);
            e = new Edge();

            // 5-1-4-8
            e.points = new List<Point3> {
                new Point3(-hc, hc, hc), // 5
                new Point3(-hc, hc, -hc), // 1
                new Point3(-hc, -hc, -hc), // 4
                new Point3(-hc, -hc, hc) // 8
            };
            p.edges.Add(e);
            e = new Edge();

            // 4-3-7-8
            e.points = new List<Point3> {
                new Point3(-hc, -hc, -hc), // 4
                new Point3(hc, -hc, -hc), // 3
                new Point3(hc, -hc, hc), // 7
                new Point3(-hc, -hc, hc) // 8
            };
            p.edges.Add(e);
            e = new Edge();

            return p;

        }

        public Polyhedron Tetr(int size)
        {
            //var tetr_centr = size / 2;
            //return new List<Line>
            //{
            //    new Line(new Point3(-tetr_centr, tetr_centr, -tetr_centr), new Point3(-tetr_centr, -tetr_centr, tetr_centr)), //1->2
            //    new Line(new Point3(-tetr_centr, tetr_centr, -tetr_centr), new Point3(-tetr_centr, tetr_centr, tetr_centr)), //1->4
            //    new Line(new Point3(-tetr_centr, tetr_centr, -tetr_centr), new Point3(tetr_centr, tetr_centr, tetr_centr)), //1->3
            //    new Line(new Point3(-tetr_centr, -tetr_centr, tetr_centr), new Point3(-tetr_centr, tetr_centr, tetr_centr)), //2->4
            //    new Line(new Point3(-tetr_centr, -tetr_centr, tetr_centr), new Point3(tetr_centr, tetr_centr, tetr_centr)), //2->3
            //    new Line(new Point3(tetr_centr, tetr_centr, tetr_centr), new Point3(-tetr_centr, tetr_centr, tetr_centr)) //3->4
            //};

            var hc = size / 2;
            Polyhedron p = new Polyhedron();
            Edge e = new Edge();

            //1-2-3
            e.points = new List<Point3> {
                new Point3(-hc, hc, hc), // 1
                new Point3(-hc,-hc, -hc), // 2
                new Point3(hc, hc, -hc), // 3
            };
            p.edges.Add(e);
            e = new Edge();

            // 1-4-2
            e.points = new List<Point3> {
                new Point3(-hc, hc, hc), // 1
                new Point3(-hc, hc, -hc), // 4
                new Point3(-hc,-hc, -hc), // 2
            };
            p.edges.Add(e);
            e = new Edge();

            // 1-3-4
            e.points = new List<Point3> {
                new Point3(hc, hc, -hc), // 3
                new Point3(-hc, hc, -hc), // 4
                new Point3(-hc, hc, hc), // 1
            };
            p.edges.Add(e);
            e = new Edge();

            // 3-2-4
            e.points = new List<Point3> {
                new Point3(-hc,-hc, -hc), // 2
                new Point3(-hc, hc, -hc), // 4
                new Point3(hc, hc, -hc), // 3
            };
            p.edges.Add(e);

            return p;
        }

        public Polyhedron Oct(int size)
        {
            var hc = size / 2;
            Polyhedron p = new Polyhedron();
            Edge e = new Edge();

            // 1-5-4
            e.points = new List<Point3> {
                new Point3(0, 0, hc), // 1
                new Point3(0, -hc, 0), // 5
                new Point3(hc, 0, 0), // 4 
            };
            p.edges.Add(e);
            e = new Edge();

            // 2-5-1
            e.points = new List<Point3> {
                new Point3(-hc, 0, 0), // 2
                new Point3(0, -hc, 0), // 5
                new Point3(0, 0, hc), // 1
            };
            p.edges.Add(e);
            e = new Edge();

            // 2-5-3
            e.points = new List<Point3> {
                new Point3(0, 0, -hc), // 3
                new Point3(0, -hc, 0), // 5
                new Point3(-hc, 0, 0), // 2 
            };
            p.edges.Add(e);
            e = new Edge();

            // 3-5-4
            e.points = new List<Point3> {
                new Point3(hc, 0, 0), // 4 
                new Point3(0, -hc, 0), // 5
                new Point3(0, 0, -hc), // 3
            };
            p.edges.Add(e);
            e = new Edge();
            ////////
            // 1-6-4
            e.points = new List<Point3> {
                new Point3(hc, 0, 0), // 4 
                new Point3(0, hc, 0), // 6
                new Point3(0, 0, hc), // 1
            };
            p.edges.Add(e);
            e = new Edge();

            // 2-6-1
            e.points = new List<Point3> {
                new Point3(0, 0, hc), // 1
                new Point3(0, hc, 0), // 6
                new Point3(-hc, 0, 0), // 2
            };
            p.edges.Add(e);
            e = new Edge();

            // 2-6-3
            e.points = new List<Point3> {
                new Point3(-hc, 0, 0), // 2 
                new Point3(0, hc, 0), // 6
                new Point3(0, 0, -hc), // 3
            };
            p.edges.Add(e);
            e = new Edge();

            // 3-6-4
            e.points = new List<Point3> {
                new Point3(0, 0, -hc), // 3
                new Point3(0, hc, 0), // 6
                new Point3(hc, 0, 0), // 4 
            };
            p.edges.Add(e);
            e = new Edge();

            return p;
        }


        Point Position2d(Point3 p)
        {
            return new Point((int)p.X + (int)centr.X, (int)p.Y + (int)centr.Y);
        }

        Point[] Position2d(Edge e)
        {
            List<Point> p2D = new List<Point> { };
            foreach (var p3 in e.points)
            {
                p2D.Add(new Point((int)p3.X + (int)centr.X, (int)p3.Y + (int)centr.Y));
            }
            return p2D.ToArray();
        }

        Point[] Position2dnocent(Edge e)
        {
            List<Point> p2D = new List<Point> { };
            foreach (var p3 in e.points)
            {
                p2D.Add(new Point((int)p3.X, (int)p3.Y));
            }
            return p2D.ToArray();
        }

        public static double[,] MultiplyMatrix(double[,] m1, double[,] m2)
        {
            double[,] m = new double[1, 4];

            for (int i = 0; i < 4; i++)
            {
                var temp = 0.0;
                for (int j = 0; j < 4; j++)
                {
                    temp += m1[0, j] * m2[j, i];
                }
                m[0, i] = temp;
            }
            return m;
        }



        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                g.Clear(Color.White);
                poly = Tetr(size);
                var edges = poly.edges;
                foreach (var ed in edges)
                    g.DrawPolygon(myPen, Position2d(ed));
                pictureBox1.Image = bmp;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                g.Clear(Color.White);
                poly = Hex(size);
                var edges = poly.edges;
                foreach (var ed in edges)
                    g.DrawPolygon(myPen, Position2d(ed));
                pictureBox1.Image = bmp;
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                g.Clear(Color.White);
                poly = Oct(size);
                var edges = poly.edges;
                foreach (var ed in edges)
                    g.DrawPolygon(myPen, Position2d(ed));
                pictureBox1.Image = bmp;
            }
        }



        // clear
        private void button7_Click(object sender, EventArgs e)
        {
            //generatrix = new Edge();
            //poly = new Polyhedron();
            //moving_point = new Point3(0, 0, 0);
            //moving_point_line = new Point3(0, 0, 0);
            ////lines = Hex(size);
            //g.Clear(Color.White);
            //pictureBox1.Image = bmp;
            var l = new List<Point3>();
            l.Add(new Point3(1, 3, 0));
            l.Add(new Point3(5, 6, 4));
            l.Add(new Point3(-1, -4, 0));
            double x = 5;
            double y = 2;
            double z = find_z_three_points(l, x, y);
            //MessageBox.Show(""+find_z_three_points(l, 5, 2));

            MessageBox.Show("" + InTriangle(l[0], l[1], l[2], new Point3(1, 3, 0)));
        }

        // move
        private void button1_Click(object sender, EventArgs e)
        {
            var posx = double.Parse(textBox1.Text);
            var posy = double.Parse(textBox2.Text);
            var posz = double.Parse(textBox3.Text);


            g.Clear(Color.White);
            moving_point.X += posx;
            moving_point.Y -= posy;
            moving_point.Z += posz;
            List<Edge> newEdges = new List<Edge>();
            foreach (var edge in poly.edges)
            {
                Edge newPoints = new Edge();
                foreach (var point in edge.points)
                {
                    double[,] m = new double[1, 4];
                    m[0, 0] = point.X;
                    m[0, 1] = point.Y;
                    m[0, 2] = point.Z;
                    m[0, 3] = 1;

                    double[,] matr = new double[4, 4]
                {   { 1, 0, 0, 0},
                    { 0, 1, 0, 0 },
                    {0, 0, 1, 0 },
                    { posx, -posy, posz, 1 } };

                    var final_matrix = MultiplyMatrix(m, matr);

                    newPoints.points.Add(new Point3(final_matrix[0, 0], final_matrix[0, 1], final_matrix[0, 2]));
                }
                newEdges.Add(newPoints);

            }
            poly.edges = newEdges;
            //DrawPol();
            if (!checkBox2.Checked)
                DrawPolyhedrFaces();
            else
                Z_buffer();
            pictureBox1.Image = bmp;
        }

        // rotate
        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            List<Edge> newEdges = new List<Edge>();
            foreach (var edge in poly.edges)
            {
                Edge newPoints = new Edge();
                foreach (var point in edge.points)
                {
                    double[,] m = new double[1, 4];
                    m[0, 0] = point.X - moving_point.X;
                    m[0, 1] = point.Y - moving_point.Y;
                    m[0, 2] = point.Z - moving_point.Z;
                    m[0, 3] = 1;

                    var angle = double.Parse(textBox6.Text) * Math.PI / 180;
                    double[,] matrx = new double[4, 4]
                {   { Math.Cos(angle), 0, Math.Sin(angle), 0},
                    { 0, 1, 0, 0 },
                    {-Math.Sin(angle), 0, Math.Cos(angle), 0 },
                    { 0, 0, 0, 1 } };

                    angle = double.Parse(textBox5.Text) * Math.PI / 180;
                    double[,] matry = new double[4, 4]
                    {  { 1, 0, 0, 0 },
                    { 0, Math.Cos(angle), -Math.Sin(angle), 0},
                    {0, Math.Sin(angle), Math.Cos(angle), 0 },
                    { 0, 0, 0, 1 } };

                    angle = double.Parse(textBox4.Text) * Math.PI / 180;
                    double[,] matrz = new double[4, 4]
                    {  { Math.Cos(angle), -Math.Sin(angle), 0, 0},
                    { Math.Sin(angle), Math.Cos(angle), 0, 0 },
                    { 0, 0, 1, 0 },
                    { 0, 0, 0, 1 } };

                    var final_matrix = MultiplyMatrix(m, matrx);
                    final_matrix = MultiplyMatrix(final_matrix, matry);
                    final_matrix = MultiplyMatrix(final_matrix, matrz);

                    newPoints.points.Add(new Point3(final_matrix[0, 0] + moving_point.X, final_matrix[0, 1] + moving_point.Y, final_matrix[0, 2] + moving_point.Z));
                }
                newEdges.Add(newPoints);
            }
            poly.edges = newEdges;
            
            g.Clear(Color.White);

            if(!checkBox2.Checked)
                DrawPolyhedrFaces();
            else
                Z_buffer();
            //DrawPol();
            pictureBox1.Image = bmp;
        }

        // scale
        private void button3_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            List<Edge> newEdges = new List<Edge>();
            var posx = double.Parse(textBox9.Text);
            var posy = double.Parse(textBox8.Text);
            var posz = double.Parse(textBox7.Text);
            foreach (var edge in poly.edges)
            {
                Edge newPoints = new Edge();
                foreach (var point in edge.points)
                {
                    double[,] m = new double[1, 4];
                    m[0, 0] = point.X - moving_point.X;
                    m[0, 1] = point.Y - moving_point.Y;
                    m[0, 2] = point.Z - moving_point.Z;
                    m[0, 3] = 1;

                    double[,] matr = new double[4, 4]
                {   { posx, 0, 0, 0 },
                    { 0, posy, 0, 0 },
                    { 0, 0, posz, 0 },
                    { 0, 0, 0, 1 } };

                    var final_matrix = MultiplyMatrix(m, matr);

                    newPoints.points.Add(new Point3(final_matrix[0, 0] + moving_point.X, final_matrix[0, 1] + moving_point.Y, final_matrix[0, 2] + moving_point.Z));
                }
                newEdges.Add(newPoints);

            }
            poly.edges = newEdges;
            if (!checkBox2.Checked)
                DrawPolyhedrFaces();
            else
                Z_buffer();
            pictureBox1.Image = bmp;

        }

        public void DrawAll()
        {
            foreach (var line in lines)
            {
                g.DrawLine(myPen, Position2d(line.p1), Position2d(line.p2));
            }
            pictureBox1.Image = bmp;
        }
        public void DrawPol()
        {
            g.Clear(Color.White);
            foreach (var edge in poly.edges)
                g.DrawPolygon(myPen, Position2d(edge));
            pictureBox1.Image = bmp;
        }

        public void DrawPolNoCent()
        {
            g.Clear(Color.White);
            foreach (var edge in poly.edges)
                g.DrawPolygon(myPen, Position2dnocent(edge));
            pictureBox1.Image = bmp;
        }


        private void button8_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(Path))
            {
                foreach (var edge in poly.edges)
                {
                    foreach (var point in edge.points)
                    {
                        writer.Write("" + point.X + " " + point.Y + " " + point.Z + ";");
                    }
                    writer.Write("\n");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var readText = File.ReadAllLines(Path);
            List<Edge> Edges = new List<Edge>();
            foreach (var line in readText)
            {
                Edge points = new Edge();
                var pointsline = line.Split(';');
                foreach (var point in pointsline)
                {
                    var pointXYZ = point.Split();
                    if (pointXYZ.Length > 1)
                        points.points.Add(new Point3(double.Parse(pointXYZ[0]), double.Parse(pointXYZ[1]), double.Parse(pointXYZ[2])));
                }
                Edges.Add(points);
            }
            poly.edges = Edges;

            DrawPol();

        }

        public void RotationFigure(List<Point3> generatrix, char axis, int count_splitting)
        {
            double angle_rotate = 360 / count_splitting;

            while (count_splitting != 0)
            {
                List<Point3> newpoints = new List<Point3>();
                foreach (var p in generatrix)
                {
                    double[,] m = new double[1, 4];
                    m[0, 0] = p.X;
                    m[0, 1] = p.Y;
                    m[0, 2] = p.Z;
                    m[0, 3] = 1;
                    if (axis == 'x')
                    {
                        double[,] matrx = new double[4, 4]
                            {   { Math.Cos(angle_rotate), 0, Math.Sin(angle_rotate), 0},
                                { 0, 1, 0, 0 },
                                {-Math.Sin(angle_rotate), 0, Math.Cos(angle_rotate), 0 },
                                { 0, 0, 0, 1 } };
                        m = MultiplyMatrix(m, matrx);
                    }
                    if (axis == 'y')
                    {
                        double[,] matry = new double[4, 4]
                        {  { 1, 0, 0, 0 },
                        { 0, Math.Cos(angle_rotate), -Math.Sin(angle_rotate), 0},
                        {0, Math.Sin(angle_rotate), Math.Cos(angle_rotate), 0 },
                        { 0, 0, 0, 1 } };
                        m = MultiplyMatrix(m, matry);
                    }
                    if (axis == 'z')
                    {
                        double[,] matrz = new double[4, 4]
                        {  { Math.Cos(angle_rotate), -Math.Sin(angle_rotate), 0, 0},
                            { Math.Sin(angle_rotate), Math.Cos(angle_rotate), 0, 0 },
                            { 0, 0, 1, 0 },
                            { 0, 0, 0, 1 } };
                        m = MultiplyMatrix(m, matrz);
                    }
                    newpoints.Add(new Point3(m[0, 0], m[0, 1], m[0, 2]));

                }
                generatrix = newpoints;
                var gen = new List<Point>();
                foreach (var x in generatrix)
                    gen.Add(new Point((int)x.X, (int)x.Y));
                g.DrawPolygon(myPen, gen.ToArray());
                pictureBox1.Image = bmp;
                count_splitting--;
            }
        }

        bool mouse_Down = false;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_Down = true;
            if (checkBox1.Checked)
            {
                
                generatrix.points.Add(new Point3(e.X - pictureBox1.Width/2, e.Y - pictureBox1.Height / 2, 0));
                bmp.SetPixel(e.X, e.Y, Color.Black);
            }
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_Down = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //var gen = new List<Point>();
            poly.edges.Add(generatrix);
            //DrawPolNoCent();
            DrawPol();
            //foreach(var x in generatrix.points)
            //    gen.Add(new Point((int)x.X, (int)x.Y));
            //g.DrawPolygon(myPen, gen.ToArray());
            //pictureBox1.Image = bmp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //var axis = 'y';
            //RotationFigure(generatrix.points, axis, 5);
            rotate(40,comboBox1.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            poly = new Polyhedron();
        }

        void rotate(int count,string axiis)
        {
            var angle = 360 / count * Math.PI / 180;
            var edges = new List<Edge>();

            while (count != 0)
            {
                List<Edge> newEdges = new List<Edge>();
                //foreach (var edge in poly.edges)
                {
                    Edge newPoints = new Edge();
                    foreach (var point in poly.edges.Last().points)
                    {
                        double[,] m = new double[1, 4];
                        m[0, 0] = point.X - moving_point.X;
                        m[0, 1] = point.Y - moving_point.Y;
                        m[0, 2] = point.Z - moving_point.Z;
                        m[0, 3] = 1;
                        double[,] matrx = new double[4,4];
                        //var angle = double.Parse(textBox6.Text) * Math.PI / 180;
                        if (axiis == "x")
                        {
                            matrx = new double[4, 4]
                            {   { Math.Cos(angle), 0, Math.Sin(angle), 0},
                            { 0, 1, 0, 0 },
                            {-Math.Sin(angle), 0, Math.Cos(angle), 0 },
                            { 0, 0, 0, 1 } };
                        }
                        if (axiis == "y")
                        {
                            matrx = new double[4, 4]
                            {  { 1, 0, 0, 0 },
                            { 0, Math.Cos(angle), -Math.Sin(angle), 0},
                            {0, Math.Sin(angle), Math.Cos(angle), 0 },
                            { 0, 0, 0, 1 } };
                        }
                        if (axiis == "z")
                        {
                            matrx = new double[4, 4]
                            {  { Math.Cos(angle), -Math.Sin(angle), 0, 0},
                            { Math.Sin(angle), Math.Cos(angle), 0, 0 },
                            { 0, 0, 1, 0 },
                            { 0, 0, 0, 1 } };
                        }
                        var final_matrix = MultiplyMatrix(m, matrx);

                        newPoints.points.Add(new Point3(final_matrix[0, 0] + moving_point.X, final_matrix[0, 1] + moving_point.Y, final_matrix[0, 2] + moving_point.Z));
                        var edg = new Edge();

                        edg.points.Add(new Point3(final_matrix[0, 0] + moving_point.X, final_matrix[0, 1] + moving_point.Y, final_matrix[0, 2] + moving_point.Z));
                        edg.points.Add(new Point3(point.X, point.Y, point.Z));
                        edges.Add(edg);

                    }
                    newEdges.Add(newPoints);
                }
                foreach(var x in edges)
                poly.edges.Add(x);
                foreach (var x in newEdges)
                poly.edges.Add(x);
                //DrawPol();
                foreach (var edge in poly.edges)
                    g.DrawPolygon(myPen, Position2d(edge));
                count--;
            }
            pictureBox1.Image = bmp;
        }

        bool is_visible(Edge pol)
        {
            Point3 v1 = new Point3(pol.points[0].X - pol.points[1].X, pol.points[0].Y - pol.points[1].Y, pol.points[0].Z - pol.points[1].Z);
            Point3 v2 = new Point3(pol.points[2].X - pol.points[1].X, pol.points[2].Y - pol.points[1].Y, pol.points[2].Z - pol.points[1].Z);
            Point3 normal = new Point3(v1.Z * v2.Y - v1.Y * v2.Z, v1.X * v2.Z - v1.Z * v2.X, v1.Y * v2.X - v1.X * v2.Y, 2);

            Point3 pointcentr = new Point3(0, 0, 0);
            //for (int i = 0; i < pol.points.Count(); i++)
            //{
            //    pointcentr.X += pol.points[i].X;
            //    pointcentr.Y += pol.points[i].Y;
            //    pointcentr.Z += pol.points[i].Z;
            //}


            //pointcentr.X += 2 * pol.points[1].X - pol.points[0].X - pol.points[2].X;
            //pointcentr.Y += 2 * pol.points[1].Y - pol.points[0].Y - pol.points[2].Y;
            //pointcentr.Z += 2 * pol.points[1].Z - pol.points[0].Z - pol.points[2].Z;

            //pointcentr.X /= 3;
            //pointcentr.Y /= 3;
            //pointcentr.Z /= 3;

            //pointcentr.X += /*pol.points[0].X +*/ (pol.points[2].X + pol.points[0].X) / 2;
            //pointcentr.Y += /*pol.points[0].Y +*/ (pol.points[2].Y + pol.points[0].Y) / 2;
            //pointcentr.Z += /*pol.points[0].Z +*/ (pol.points[2].Z + pol.points[0].Z) / 2;


            double length_v1 = Math.Sqrt(Math.Pow(pol.points[0].X - pol.points[1].X, 2) + Math.Pow(pol.points[0].Y - pol.points[1].Y, 2) + Math.Pow(pol.points[0].Z - pol.points[1].Z, 2));
            double length_v2 = Math.Sqrt(Math.Pow(pol.points[2].X - pol.points[1].X, 2) + Math.Pow(pol.points[2].Y - pol.points[1].Y, 2) + Math.Pow(pol.points[2].Z - pol.points[1].Z, 2));
            double length_v3 = Math.Sqrt(Math.Pow(pol.points[2].X - pol.points[0].X, 2) + Math.Pow(pol.points[2].Y - pol.points[0].Y, 2) + Math.Pow(pol.points[2].Z - pol.points[0].Z, 2));

            //double cos_fi = (pol.points[0].X * pol.points[2].X + pol.points[0].Y * pol.points[2].Y + pol.points[0].Z * pol.points[2].Z) / (Math.Sqrt(pol.points[0].X * pol.points[0].X + pol.points[0].Y * pol.points[0].Y + pol.points[0].Z * pol.points[0].Z) * Math.Sqrt(pol.points[2].X * pol.points[2].X + pol.points[2].Y * pol.points[2].Y + pol.points[2].Z * pol.points[2].Z));
            //double angle = Math.Acos(cos_fi);

            //double normal_res = length_v1 * length_v1 * Math.Sin(angle);
            //normal = new Point3(normal_res + pointcentr.X, normal_res + pointcentr.Y, normal_res + pointcentr.Z, 2);

            //if ((int)(angle*180/Math.PI) == 90)
            length_v1 = (int)(length_v1 * 100);
            length_v2 = (int)(length_v2 * 100);
            length_v3 = (int)(length_v3 * 100);

            if (!(length_v1 == length_v2 && length_v2 == length_v3 && length_v1 == length_v3))
            {
                pointcentr.X += (pol.points[2].X + pol.points[0].X) / 2;
                pointcentr.Y += (pol.points[2].Y + pol.points[0].Y) / 2;
                pointcentr.Z += (pol.points[2].Z + pol.points[0].Z) / 2;
            }
            else
            {
                for (int i = 0; i < pol.points.Count(); i++)
                {
                    pointcentr.X += pol.points[i].X;
                    pointcentr.Y += pol.points[i].Y;
                    pointcentr.Z += pol.points[i].Z;
                }
                pointcentr.X /= pol.points.Count();
                pointcentr.Y /= pol.points.Count();
                pointcentr.Z /= pol.points.Count();
            }

            double inv_length = 1 / Math.Sqrt(normal.X * normal.X + normal.Y * normal.Y + normal.Z * normal.Z);
            normal.X *= inv_length;
            normal.Y *= inv_length;
            normal.Z *= inv_length;

            Point3 watcherfromstart = new Point3(watcher.X - pointcentr.X, watcher.Y - pointcentr.Y, watcher.Z - pointcentr.Z);
            Point3 normalfromstart = new Point3(normal.X - pointcentr.X, normal.Y - pointcentr.Y, normal.Z - pointcentr.Z);

            double scal = watcherfromstart.X * normalfromstart.X + watcherfromstart.Y * normalfromstart.Y + watcherfromstart.Z * normalfromstart.Z;

            //линии к наблюдающему
            //g.DrawLine(myPen, Position2d(new Point3(pol.points[1].X, pol.points[1].Y, pol.points[1].Z)), Position2d(new Point3(-watcher.X, -watcher.Y, -watcher.Z)));
            //линии нормалей
            g.DrawLine(myPen, Position2d(new Point3(pointcentr.X, pointcentr.Y, pointcentr.Z)), Position2d(new Point3(normal.X * 200, normal.Y * 200, normal.Z * 200)));
            pictureBox1.Image = bmp;
            return scal > 0;

        }
        public void DrawPolyhedrFaces()
        {
            watcher = new Point3(int.Parse(textBox10.Text), int.Parse(textBox11.Text), int.Parse(textBox12.Text));
            foreach (Edge edg in poly.edges)
            {
                
                if (is_visible(edg)) 
                    g.DrawPolygon(myPen, Position2d(edg));
            }
            //g.DrawPolygon(myPen, Position2d(poly.edges[0]));
            Pen pen = new Pen(Color.Black, 10f);
            g.DrawLine(pen, pictureBox1.Width - Position2d(watcher).X, pictureBox1.Height - Position2d(watcher).Y, pictureBox1.Width - Position2d(watcher).X + 1, pictureBox1.Height - Position2d(watcher).Y + 1);
            g.DrawLine(pen, pictureBox1.Width - Position2d(watcher).X, pictureBox1.Height - Position2d(watcher).Y + 1, pictureBox1.Width - Position2d(watcher).X + 1, pictureBox1.Height - Position2d(watcher).Y);

            pictureBox1.Image = bmp;
        }


        public Point3 FindNormal(Edge pol)
        {
            Point3 v1 = new Point3(pol.points[0].X - pol.points[1].X, pol.points[0].Y - pol.points[1].Y, pol.points[0].Z - pol.points[1].Z);
            Point3 v2 = new Point3(pol.points[2].X - pol.points[1].X, pol.points[2].Y - pol.points[1].Y, pol.points[2].Z - pol.points[1].Z);
            Point3 normal = new Point3(v1.Z * v2.Y - v1.Y * v2.Z, v1.X * v2.Z - v1.Z * v2.X, v1.Y * v2.X - v1.X * v2.Y, 2);

            Point3 pointcentr = new Point3(0, 0, 0);
            
            double length_v1 = Math.Sqrt(Math.Pow(pol.points[0].X - pol.points[1].X, 2) + Math.Pow(pol.points[0].Y - pol.points[1].Y, 2) + Math.Pow(pol.points[0].Z - pol.points[1].Z, 2));
            double length_v2 = Math.Sqrt(Math.Pow(pol.points[2].X - pol.points[1].X, 2) + Math.Pow(pol.points[2].Y - pol.points[1].Y, 2) + Math.Pow(pol.points[2].Z - pol.points[1].Z, 2));
            double length_v3 = Math.Sqrt(Math.Pow(pol.points[2].X - pol.points[0].X, 2) + Math.Pow(pol.points[2].Y - pol.points[0].Y, 2) + Math.Pow(pol.points[2].Z - pol.points[0].Z, 2));

            length_v1 = (int)(length_v1 * 100);
            length_v2 = (int)(length_v2 * 100);
            length_v3 = (int)(length_v3 * 100);

            if (!(length_v1 == length_v2 && length_v2 == length_v3 && length_v1 == length_v3))
            {
                pointcentr.X += (pol.points[2].X + pol.points[0].X) / 2;
                pointcentr.Y += (pol.points[2].Y + pol.points[0].Y) / 2;
                pointcentr.Z += (pol.points[2].Z + pol.points[0].Z) / 2;
            }
            else
            {
                for (int i = 0; i < pol.points.Count(); i++)
                {
                    pointcentr.X += pol.points[i].X;
                    pointcentr.Y += pol.points[i].Y;
                    pointcentr.Z += pol.points[i].Z;
                }
                pointcentr.X /= pol.points.Count();
                pointcentr.Y /= pol.points.Count();
                pointcentr.Z /= pol.points.Count();
            }

            double inv_length = 1 / Math.Sqrt(normal.X * normal.X + normal.Y * normal.Y + normal.Z * normal.Z);
            normal.X *= inv_length;
            normal.Y *= inv_length;
            normal.Z *= inv_length;
            normal.X *= 50;
            normal.Y *= 50;
            normal.Z *= 50;
            g.DrawLine(myPen, Position2d(new Point3(pointcentr.X, pointcentr.Y, pointcentr.Z)), Position2d(new Point3(normal.X , normal.Y , normal.Z )));

            //g.DrawLine(myPen, new Point((int)pointcentr.X, (int)pointcentr.Y), new Point((int)normal.X * 200, (int)normal.Y * 200));
            //g.DrawLine(myPen, Position2d(new Point3(pointcentr.X-30, pointcentr.Y-30, pointcentr.Z-30)), Position2d(new Point3(normal.X-30, normal.Y-30, normal.Z-30)));

            normal.X -= pointcentr.X;
            normal.Y -= pointcentr.Y;
            normal.Z -= pointcentr.Z;
            //g.DrawLine(myPen, Position2d(new Point3(0, 0, 0)), Position2d(new Point3(normal.X, normal.Y, normal.Z)));

            return normal;
        }

        public bool InTriangle(Point3 p1, Point3 p2, Point3 p3, Point3 trypoint)
        {
            double x1 = p1.X;
            double x2 = p2.X;
            double x3 = p3.X;

            double y1 = p1.Y;
            double y2 = p2.Y;
            double y3 = p3.Y;

            double x0 = trypoint.X;
            double y0 = trypoint.Y;

            double a = (x1 - x0) * (y2 - y1) - (x2 - x1) * (y1 - y0);
            double b = (x2 - x0) * (y3 - y2) - (x3 - x2) * (y2 - y0);
            double c = (x3 - x0) * (y1 - y3) - (x1 - x3) * (y3 - y0);

            //if ((Math.Sign(t1) == Math.Sign(t2)) && (Math.Sign(t2) == Math.Sign(t3)) && (Math.Sign(t3) == Math.Sign(t1)) || t1 == 0 || t2 == 0 || t3 == 0)
            if (((int)a >= 0 && (int)b >= 0 && (int)c >= 0) || ((int)a <= 0 && (int)b <= 0 && (int)c <= 0))
                return true;
            return false;
        }

        public double find_z_three_points(List<Point3> points, double x, double y)
        {
            double x1 = points[0].X;
            double y1 = points[0].Y;
            double z1 = points[0].Z;

            double x2 = points[1].X;
            double y2 = points[1].Y;
            double z2 = points[1].Z;

            double x3 = points[2].X;
            double y3 = points[2].Y;
            double z3 = points[2].Z;

            double a11 = x - x1;
            double a12 = x2 - x1;
            double a13 = x3 - x1;
            double a21 = y - y1;
            double a22 = y2 - y1;
            double a23 = y3 - y1;
            //double a31 =z1 - z1;
            double a32 = z2 - z1;
            double a33 = z3 - z1;

            double  z = (a11 * a22 * a33  + a13 * a21 * a32  - a11 * a23 * a32 - a12 * a21 * a33)/ (a13 * a22 - a12 * a23) + z1;
            return z;
        }

        public void Z_buffer()
        {
            double[,] buffer = new double[pictureBox1.Width, pictureBox1.Height];
            Color[,] color = new Color[pictureBox1.Width , pictureBox1.Height];
            for (int i = 0; i < pictureBox1.Width; i++)
                for (int j = 0; j < pictureBox1.Height; j++)
                {
                    buffer[i, j] = double.MinValue;
                    color[i, j] = Color.White;
                }

            var temp_edges = new List<Edge>();
            foreach (var edge in poly.edges)
            {
                Edge temp_edge = new Edge();
                List<Point3> oldList = edge.points;
                List<Point3> newList = new List<Point3>(oldList.Count);
                oldList.ForEach((item) =>
                {
                    newList.Add(new Point3(item.X, item.Y, item.Z));
                });

                temp_edge.points = newList;
                temp_edges.Add(temp_edge);
            }
            foreach (var edge in poly2.edges)
            {
                Edge temp_edge = new Edge();
                List<Point3> oldList = edge.points;
                List<Point3> newList = new List<Point3>(oldList.Count);
                oldList.ForEach((item) =>
                {
                    newList.Add(new Point3(item.X, item.Y, item.Z));
                });

                temp_edge.points = newList;
                temp_edges.Add(temp_edge);
            }

            foreach (var edge in temp_edges)
            {
                g.Clear(Color.White);
                g.DrawPolygon(myPen, Position2d(edge));
                //pictureBox1.Image = bmp;

                Edge temp_edge = new Edge();
                List<Point3> oldList = edge.points;
                List<Point3> newList = new List<Point3>(oldList.Count);
                oldList.ForEach((item) =>
                {
                    newList.Add(new Point3(item.X, item.Y, item.Z));
                });

                temp_edge.points = newList;
                Point3 p1 = temp_edge.points[0];
                p1.X += centr.X;
                p1.Y += centr.Y;
                p1.Z += centr.Z;
                Point3 p2 = temp_edge.points[1];
                p2.X += centr.X;
                p2.Y += centr.Y;
                p2.Z += centr.Z;
                Point3 p3 = temp_edge.points[2];
                p3.X += centr.X;
                p3.Y += centr.Y;
                p3.Z += centr.Z;

                Point3 p4 = temp_edge.points[2];
                if (edge.points.Count == 4)
                {
                    p4 = temp_edge.points[3];
                    p4.X += centr.X;
                    p4.Y += centr.Y;
                    p4.Z += centr.Z;
                }

                double x1 = p1.X, y1 = p1.Y, z1 = p1.Z;
                double x2 = p2.X, y2 = p2.Y, z2 = p2.Z;
                double x3 = p3.X, y3 = p3.Y, z3 = p3.Z;
                //Point3 normal = FindNormal(edge);

                //double a = normal.X;
                //double b = normal.Y;
                //double c = normal.Z;
                
                for (int x = 0; x < pictureBox1.Width; x++)
                    for (int y = 0; y < pictureBox1.Height; y++)
                    {
                        //double z = ((a * (x - x1) + b * (y - y1)) / (-c)) + z1;
                        //if (edge.points.Count == 3)
                        {
                            if (InTriangle(p1, p2, p3, new Point3(x, y,0)))
                            {
                                double z = find_z_three_points(temp_edge.points, x, y);
                                if (z > buffer[x, y])
                                {
                                    buffer[x, y] = z;
                                    color[x, y] = bmp.GetPixel(x, y);
                                }
                            }
                        }
                        if (edge.points.Count == 4)
                        {
                            if (InTriangle(p1, p3, p4, new Point3(x, y,0)))
                            {
                                double z = find_z_three_points(temp_edge.points, x, y);
                                if (z > buffer[x, y])
                                {
                                    buffer[x, y] = (int)z;
                                    color[x, y] = bmp.GetPixel(x, y);
                                } 
                            }
                        }
                      
                    }
            }
            g.Clear(Color.White);
            for (int x = 0; x < pictureBox1.Width; x++)
                for (int y = 0; y < pictureBox1.Height; y++)
                    bmp.SetPixel(x, y, color[x, y]);
            //pictureBox1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            radioButton6.Checked = false;
            radioButton8.Checked = false;
            radioButton10.Checked = false;
            second_poly = true;
            poly2 = poly;
            poly = new Polyhedron();
        }
    }

}
