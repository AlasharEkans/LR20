namespace lab23
{
    public partial class Form1 : Form
    {
        private TextBox txtA, txtB, txtX0, txtY0;
        private Button btnDraw;
        private PictureBox pictureBox;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            this.pictureBox.Invalidate(); // Triggers the Paint event
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            // Draw coordinate system
            Pen axisPen = new Pen(Color.Black);
            g.DrawLine(axisPen, 0, pictureBox.Height / 2, pictureBox.Width, pictureBox.Height / 2); // X-axis
            g.DrawLine(axisPen, pictureBox.Width / 2, 0, pictureBox.Width / 2, pictureBox.Height); // Y-axis

            // Draw parametric curve based on the equation
            try
            {
                float a = float.Parse(txtA.Text);
                float b = float.Parse(txtB.Text);
                float x0 = float.Parse(txtX0.Text);
                float y0 = float.Parse(txtY0.Text);

                DrawParametricCurve(g, a, b, x0, y0);
            }
            catch
            {
                MessageBox.Show("Please enter valid numeric values.");
            }
        }

        private void DrawParametricCurve(Graphics g, float a, float b, float x0, float y0)
        {
            Pen pen = new Pen(Color.Blue);
            float centerX = pictureBox.Width / 2;
            float centerY = pictureBox.Height / 2;

            for (float t = 0; t <= 2 * Math.PI; t += 0.01f)
            {
                float x = centerX + x0 + a * (float)Math.Cos(t);
                float y = centerY + y0 + b * (float)Math.Sin(t);
                g.DrawEllipse(pen, x, y, 1, 1);
            }
        }
    }
}
