using System.Drawing.Drawing2D;

namespace Graphics1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = this.CreateGraphics();

            //SolidBrush s = new SolidBrush(Color.Orange);
            // Pen p = new Pen(s);
            //g.FillEllipse(s, new Rectangle(10,10,200,100));
            //g.FillRectangle(s,new Rectangle(10,10,200,200));
            //g.FillEllipse(s, new Rectangle(this.Width/2, this.Height-350, this.Width-800,100));


        }
        //int i = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //i += 10;
            //Graphics g = this.CreateGraphics();

            //SolidBrush s = new SolidBrush(Color.Orange);
            //Pen p = new Pen(Color.Black);
            //g.FillPie(s, new Rectangle(10, 10, 200, 200), 0, i);
            //g.DrawArc(p, new Rectangle(10, 10, 200, 200), 0, 360);
        }
        Bitmap bitmap;
        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Image);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Graphics g = this.CreateGraphics(); form
            Graphics g = Graphics.FromImage(bitmap);


            LinearGradientBrush ld = new LinearGradientBrush(new Point(0, 0), new Point(bitmap.Width, 0), Color.FromArgb(50, 211, 128, 172), Color.FromArgb(50, 52, 12, 178));
            g.FillRectangle(ld, new Rectangle(0, 0, bitmap.Width, bitmap.Height));

            pictureBox1.Image = bitmap;

            // OpenFileDialog openFileDialog = new OpenFileDialog();
            //if (DialogResult.OK == openFileDialog.ShowDialog())
            //{
            //    string filePath=openFileDialog.FileName;
            //    Bitmap bitmap = new Bitmap(filePath);
            //    pictureBox1.Image= bitmap;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Title = "Save imgage";
            if (DialogResult.OK == s.ShowDialog())
            {
                string path = s.FileName;
                bitmap.Save(path);

                MessageBox.Show("Image save", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
