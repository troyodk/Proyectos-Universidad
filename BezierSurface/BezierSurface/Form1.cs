using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;

namespace BezierSurface
{
    public partial class Form1 : Form
    {

        double xmax = 500.0, ymax = 500.0, zmax = 500.0;//TAMAÑO DEL MUNDO
        double alpha = -30.0, betha = 30.0, gamma = 0.0; //ANGULOS DE ROTACIÓN POR EJE
        //int Fila, Colum;
        
        public struct Punto
        {
            public double x, y, z;
            public Punto(double x, double y, double z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
        }

        Punto[,] pBezier = new Punto[2, 5];

        public Form1()
        {
            InitializeComponent();

            pBezier[0, 0] = new Punto(-500, 0, 0);
            pBezier[0, 1] = new Punto(-450, 200, 0);
            pBezier[0, 2] = new Punto(0, 200, 0);
            pBezier[0, 3] = new Punto(300, -400, 0);
            pBezier[0, 4] = new Punto(500, 0, 0);

            pBezier[1, 0] = new Punto(-500, 0, 100);
            pBezier[1, 1] = new Punto(-450, 200, 100);
            pBezier[1, 2] = new Punto(0, 200, 100);
            pBezier[1, 3] = new Punto(300, -400, 100);
            pBezier[1, 4] = new Punto(500, 0, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GL.Viewport(0, 0, glControl1.Width, glControl1.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-xmax, xmax, -ymax, ymax, -zmax, zmax);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

            GL.ClearColor(Color.Black);
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            double t;
            Punto PA0, PA1, PB0, PB1, Normal;
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit | ClearBufferMask.StencilBufferBit);

            GL.PushMatrix();
            GL.LoadIdentity();
            GL.Enable(EnableCap.DepthTest); //Habilitar el buffer de profundidad
            GL.Rotate(alpha, 1, 0, 0); //Alpha rota X
            GL.Rotate(betha, 0, 1, 0); //Betha rota Y
            GL.Rotate(gamma, 0, 0, 1); //Gamma rota Z

            #region EJES
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(1.0f, 0.0f, 0.0f); //ROJO
            GL.Vertex3(0.0, 0.0, 0.0);
            GL.Vertex3(xmax, 0.0, 0.0); //EJE X
            GL.Color3(0.0f, 1.0f, 0.0f); //VERDE
            GL.Vertex3(0.0, 0.0, 0.0);
            GL.Vertex3(0.0, ymax, 0.0); //EJE y
            GL.Color3(0.0f, 0.0f, 1.0f); //AZUL
            GL.Vertex3(0.0, 0.0, 0.0);
            GL.Vertex3(0.0, 0.0, zmax); //EJE Z
            GL.End();
            #endregion

            GL.Color3(Color.DarkRed);
            //Bezier(pBezier[0, 0], pBezier[0, 1], pBezier[0, 2], pBezier[0, 3], pBezier[0, 4]);
            PA0 = pBezier[0, 0];
            PB0 = pBezier[1, 0];
            for (t = 0.0; t <= 1.0; t += 0.01)
            {
                PA1 = Bezier(t, pBezier[0, 0], pBezier[0, 1], pBezier[0, 2], pBezier[0, 3], pBezier[0, 4]);
                PB1 = Bezier(t, pBezier[1, 0], pBezier[1, 1], pBezier[1, 2], pBezier[1, 3], pBezier[1, 4]);

                GL.Begin(PrimitiveType.Quads);
                    Normal = normal(PB1, PA1, PB0);
                    GL.Normal3(Normal.x, Normal.y, Normal.z);
                    GL.Vertex3(PA0.x, PA0.y, PA0.z);
                    GL.Vertex3(PA1.x, PA1.y, PA1.z);
                    GL.Vertex3(PB1.x, PB1.y, PB1.z);
                    GL.Vertex3(PB0.x, PB0.y, PB0.z);
                GL.End();
                PA0 = PA1;
                PB0 = PB1;
            }

            GL.PopMatrix();

            glControl1.SwapBuffers();
        }

        Punto Bezier(double t, Punto P0, Punto P1, Punto P2, Punto P3, Punto P4)
        {
            Punto Pf = new Punto(0, 0, 0);

            Pf.x = (P0.x * Math.Pow(1 - t, 4)) + (P1.x * 4 * t * Math.Pow(1 - t, 3)) + (P2.x * 6 * Math.Pow(t, 2) * Math.Pow(1 - t, 2)) + (P3.x * 4 * Math.Pow(t, 3) * (1 - t)) + (P4.x * Math.Pow(t, 4));
            Pf.y = (P0.y * Math.Pow(1 - t, 4)) + (P1.y * 4 * t * Math.Pow(1 - t, 3)) + (P2.y * 6 * Math.Pow(t, 2) * Math.Pow(1 - t, 2)) + (P3.y * 4 * Math.Pow(t, 3) * (1 - t)) + (P4.y * Math.Pow(t, 4));
            Pf.z = (P0.z * Math.Pow(1 - t, 4)) + (P1.z * 4 * t * Math.Pow(1 - t, 3)) + (P2.z * 6 * Math.Pow(t, 2) * Math.Pow(1 - t, 2)) + (P3.z * 4 * Math.Pow(t, 3) * (1 - t)) + (P4.z * Math.Pow(t, 4));

            return Pf;
        }

        private void glControl1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Z:
                    ++alpha;
                    break;
                case Keys.A:
                    --alpha;
                    break;
                case Keys.X:
                    ++betha;
                    break;
                case Keys.S:
                    --betha;
                    break;
                case Keys.C:
                    ++gamma;
                    break;
                case Keys.D:
                    --gamma;
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
            glControl1.Invalidate();
        }

        Punto normal(Punto p0, Punto p1, Punto p2)
        {
            Punto n, v1, v2, aux;

            v1.x = (p1.x - p0.x); v1.y = (p1.y - p0.y); v1.z = (p1.z - p0.z);
            v2.x = (p2.x - p0.x); v2.y = (p2.y - p0.y); v2.z = (p2.z - p0.z);

            aux.x = (v1.y * v2.z) - (v2.y * v1.z);
            aux.y = (v1.x * v2.z) - (v2.x * v1.z);
            aux.z = (v1.x * v2.y) - (v2.x * v1.y);

            n.x = aux.x;
            n.y = -aux.y;
            n.z = aux.z;

            return (n);
        }
    }
}
