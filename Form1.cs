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
        List<Triangle> triangles;
        Pen blackPen;
        Pen redPen;
        bool drawLines = false;

        Color objectColor;
        double kd;
        double ks;
        int m;
        Color lightColor;
        VertexCoordinates sun;
        

        SimulationParameters simulationParameters;

        public Form1()
        {
            InitializeComponent();
            triangles = new List<Triangle>();
            blackPen = new Pen(Color.Black);
            redPen = new Pen(Color.Red);
            objectColor = Color.Green;
            lightColor = Color.White;
            kd = 0.5;
            ks = 0.5;
            m = 1;

            sun = new VertexCoordinates(0, 0, 2);
            
            simulationParameters = new SimulationParameters(kd, ks, lightColor, objectColor, m);

            Redraw();
        }

        public void Redraw()
        {
            drawArea.Image = new Bitmap(drawArea.Size.Width, drawArea.Size.Height);
            using (Graphics g = Graphics.FromImage(drawArea.Image))
            {
                g.Clear(Color.White);
                if (triangles != null && triangles.Count > 0)
                {
                    int size = drawArea.Size.Width - 100;
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
                        triangle.PaintTriangle(size, g, simulationParameters);
                        drawArea.Refresh();
                        System.Threading.Thread.Sleep(20);
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

        //private void drawArea_SizeChanged(object sender, EventArgs e)
        //{
        //    Redraw();
        //}

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (drawArea.Width != drawArea.Height)
            {
                Height += drawArea.Width - drawArea.Height;
            }
            Redraw();
        }

        private void animationButton_Click(object sender, EventArgs e)
        {
            for (int i = -2; i <= 2; i++)
            {
                for (int j = -2; j <= 2; j++)
                {
                    sun = new VertexCoordinates(i, j, 2);
                    Redraw();
                }
            }
        }
    }
}