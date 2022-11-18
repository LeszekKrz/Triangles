using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Numerics;
using System.IO;

namespace Triangles
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer;
        List<Triangle> triangles;
        Pen blackPen;
        Pen redPen;
        bool drawLines = false;

        Color objectColor;
        Color lightColor;
        double kd;
        double ks;
        double z;
        int m;

        double r;
        double angle;
        double step;
        int increasing;


        VertexCoordinates sun;
        

        SimulationParameters simulationParameters;

        public Form1()
        {
            InitializeComponent();
            drawArea.Image = new Bitmap(drawArea.Size.Width, drawArea.Size.Height);

            triangles = new List<Triangle>();
            blackPen = new Pen(Color.Black);
            redPen = new Pen(Color.Red);
            //objectColor = Color.Green;
            objectColor = Color.Orange;
            lightColor = Color.White;
            kd = 0;
            ks = 0;
            m = 1;
            z = 2;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(TimerTick);

            drawArea.Image = new Bitmap(drawArea.Size.Width, drawArea.Size.Height);

            sun = new VertexCoordinates(0, 0, z);
            r = 0;
            step = Math.PI / 8;
            angle = 0;
            simulationParameters = new SimulationParameters(kd, ks, lightColor, objectColor, m);
            increasing = 1;

            RefreshObjectPicture();
            RefreshLightPicture();

            Redraw();
        }

        public void Redraw()
        {
            simulationParameters = new SimulationParameters(kd, ks, lightColor, objectColor, m);
            //drawArea.Image = new Bitmap(drawArea.Size.Width, drawArea.Size.Height);
            using (Graphics g = Graphics.FromImage(drawArea.Image))
            {
                g.Clear(Color.White);
                int size = drawArea.Size.Width - 100;
                if (triangles != null && triangles.Count > 0)
                {
                    simulationParameters.Sun = sun;
                    if (drawArea.Size.Height < size) size = drawArea.Size.Height;
                    if (drawLines) foreach (Triangle triangle in triangles)
                    {
                        g.DrawLine(blackPen, triangle.A.ToPoint(size), triangle.B.ToPoint(size));
                        g.DrawLine(blackPen, triangle.B.ToPoint(size), triangle.C.ToPoint(size));
                        g.DrawLine(blackPen, triangle.C.ToPoint(size), triangle.A.ToPoint(size));
                    }
                    //drawArea.Refresh();
                    foreach(Triangle triangle in triangles)
                    {
                        triangle.PaintTriangle(size, g, simulationParameters, interpolateColorRadio.Checked);
                        //drawArea.Refresh();
                        //System.Threading.Thread.Sleep(20);
                    }
                }
            }
            drawArea.Refresh();
        }

        void GetTrianglesFromFile()
        {
            Stream openStream;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Object files (*.obj)|*.obj";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((openStream = openFileDialog.OpenFile()) != null)
                {
                    StreamReader read = new StreamReader(openStream);
                    string? line;
                    List<VertexCoordinates> coordinates = new List<VertexCoordinates>();
                    List<NormalVector> normals = new List<NormalVector>();
                    triangles = new List<Triangle>();
                    while ((line = read.ReadLine()) != null)
                    {
                        string[] tempString = line.Split(' ');
                        if (tempString[0] == "v")
                        {
                            if (!double.TryParse(tempString[1], out double x) || !double.TryParse(tempString[2], out double y) || !double.TryParse(tempString[3], out double z))
                            {
                                Debug.WriteLine("Vertex parsing failed");
                                return;
                            }
                            coordinates.Add(new VertexCoordinates(x, y, z));
                        }
                        else if (tempString[0] == "vn")
                        {
                            if (!double.TryParse(tempString[1], out double xn) || !(double.TryParse(tempString[2], out double yn)) || !double.TryParse(tempString[3], out double zn))
                            {
                                Debug.WriteLine("Vectors parsing failed");
                                return;
                            }
                            normals.Add(new NormalVector(xn, yn, zn));
                        }
                        else if (tempString[0] == "f")
                        {
                            Vertex[] tempVertices = new Vertex[3];
                            VertexCoordinates tempCo;
                            NormalVector tempNormal;
                            string[] tempIndexes;
                            for (int i = 0; i < 3; i++)
                            {
                                tempIndexes = tempString[i + 1].Split('/');
                                tempCo = coordinates[int.Parse(tempIndexes[0]) - 1];
                                tempNormal = normals[int.Parse(tempIndexes[2]) - 1];
                                tempVertices[i] = new Vertex(tempCo, tempNormal);
                            }
                            triangles.Add(new Triangle(tempVertices));
                        }
                    }
                    Debug.WriteLine("End of file");
                    Redraw();
                }
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            GetTrianglesFromFile();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (drawArea.Width != drawArea.Height)
            {
                Height += drawArea.Width - drawArea.Height;
            }
            drawArea.Image = new Bitmap(drawArea.Size.Width, drawArea.Size.Height);
            Redraw();
        }

        private void animationButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == true)
            {
                timer.Enabled = false;
                animationButton.Text = "Start animation";
            }
            else
            {
                timer.Enabled = true;
                animationButton.Text = "Stop animation";
            }
        }

        private void TimerTick(object? sender, EventArgs e)
        {
            r += increasing * 0.1;
            if (r >= 3)
            {
                r = 3;
                increasing = -1;
            }
            if (r <= 0)
            {
                r = 0;
                increasing = 1;
                angle += step * 8;
            }
            angle += step;
            sun = new VertexCoordinates(Math.Cos(angle) * r, Math.Sin(angle) * r, z);
            Redraw();
        }

        private void ksBar_ValueChanged(object sender, EventArgs e)
        {
            ks = (double)ksBar.Value / (ksBar.Maximum + 1);
            Redraw();
        }

        private void kdBar_ValueChanged(object sender, EventArgs e)
        {
            kd = (double)kdBar.Value / (kdBar.Maximum + 1);
            Redraw();
        }

        private void mBar_ValueChanged(object sender, EventArgs e)
        {
            m = mBar.Value;
            Redraw();
        }

        private void zBar_ValueChanged(object sender, EventArgs e)
        {
            z = (double)zBar.Value / 10;
            sun = new VertexCoordinates(sun.X, sun.Y, z);
            Redraw();
        }

        private void objectColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                objectColor = colorDialog.Color;
                RefreshObjectPicture();
                Redraw();
            }
        }

        private void objectPicture_SizeChanged(object sender, EventArgs e)
        {
            RefreshObjectPicture();
        }

        private void RefreshObjectPicture()
        {
            objectPicture.Image = new Bitmap(objectPicture.Width, objectPicture.Height);
            using (Graphics g = Graphics.FromImage(objectPicture.Image))
            {
                g.Clear(objectColor);
            }
            objectPicture.Refresh();
        }

        private void lightPicture_SizeChanged(object sender, EventArgs e)
        {
            RefreshLightPicture();
        }

        private void lightColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lightColor = colorDialog.Color;
                RefreshLightPicture();
                Redraw();
            }
        }

        private void RefreshLightPicture()
        {
            lightPicture.Image = new Bitmap(lightPicture.Width, lightPicture.Height);
            using (Graphics g = Graphics.FromImage(lightPicture.Image))
            {
                g.Clear(lightColor);
            }
            lightPicture.Refresh();
        }

        private void interpolateColorRadio_CheckedChanged(object sender, EventArgs e)
        {
            Redraw();
        }
    }
}