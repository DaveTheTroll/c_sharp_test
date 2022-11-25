using MathNet.Numerics;

namespace FitForPurpose
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        double[] x_;
        double[] y_;
        void buttonGenerateData_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            x_ = new double[100];
            y_ = new double[100];
            for (int i = 0; i < 100; i++)
            {
                x_[i] = rnd.NextDouble() * 10 - 5;
                y_[i] = f(2, -2, 2, x_[i]) + rnd.NextDouble();
            }
            panelGraph.Invalidate();
        }

        void panelGraph_Paint(object sender, PaintEventArgs e)
        {
            double ymin = double.MaxValue, ymax = double.MinValue;

            PointF[] p = null;
            if (a != 0 || b != 0 || c != 0)
            {
                p = new PointF[100];
                for (int i = 0; i < 100; i++)
                {
                    float x = i * 10.0f / 100 - 5;
                    p[i] = new PointF(x, (float)f(a, b, c, x));
                    ymin = ymin < p[i].Y ? ymin : p[i].Y;
                    ymax = ymax > p[i].Y ? ymax : p[i].Y;
                }
            }

            if (x_ != null)
            {
                for(int i=0; i<x_.Length; i++)
                {
                    ymin = ymin < y_[i] ? ymin : y_[i];
                    ymax = ymax > y_[i] ? ymax : y_[i];
                }
            }

            Graphics g = e.Graphics;
            float scaleX = 10.0f / panelGraph.Width;
            float scaleY = (float)(ymax - ymin) / panelGraph.Height;

            if (p!=null)
            {
                for(int i=0; i< p.Length; i++)
                {
                    p[i] = new PointF((5+p[i].X) / scaleX, (float)(ymax-p[i].Y) / scaleY);
                }
                g.DrawLines(new Pen(Color.Black, Math.Max(scaleX, scaleY)), p);
            }

            if(x_ != null)
            {
                for(int i=0; i<x_.Length; i++)
                {
                    g.FillEllipse(Brushes.Orange, (float)(5+x_[i])/scaleX-2, (float)(ymax - y_[i])/scaleY - 2, 5, 5);
                }
            }
        }


        double a, b, c;

        void panelGraph_SizeChanged(object sender, EventArgs e)
        {
            panelGraph.Invalidate();
        }

        void buttonFit_Click(object sender, EventArgs e)
        {
            (a,b,c) = Fit.Curve(x_, y_, f, 1, 1, 1);
            textBoxOut.Text += ($"{a:0.00},{b:0.00},{c:0.00}\r\n");
            panelGraph.Invalidate();
        }

        static double f(double a, double b, double c, double x)
        {
            return a * x * x + b * x + c;
        }
    }
}