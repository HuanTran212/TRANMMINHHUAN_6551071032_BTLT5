namespace Ve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pnlCanvas.BackColor = Color.White;

            hinhVe = new Bitmap(
                pnlCanvas.Width,
                pnlCanvas.Height);

            using (Graphics g = Graphics.FromImage(hinhVe))
            {
                g.Clear(Color.White);
            }

            pnlCanvas.Paint += pnlCanvas_Paint;
            pnlCanvas.MouseDown += pnlCanvas_MouseDown;
            pnlCanvas.MouseMove += pnlCanvas_MouseMove;
            pnlCanvas.MouseUp += pnlCanvas_MouseUp;
            pnlCanvas.MouseClick += pnlCanvas_MouseClick;
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(hinhVe, 0, 0);
        }

        private void pnlCanvas_MouseDown(
            object sender,
            MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dangVe = true;
                diemCuoi = e.Location;

                lblViTri.Text =
                    $"X: {e.X}, Y: {e.Y} - Đang vẽ...";
            }
        }

        private void pnlCanvas_MouseMove(
            object sender,
            MouseEventArgs e)
        {
            lblViTri.Text =
                $"X: {e.X}, Y: {e.Y} - " +
                (dangVe ? "Đang vẽ..." : "Sẵn sàng");

            if (dangVe)
            {
                using (Graphics g = Graphics.FromImage(hinhVe))
                {
                    using (Pen pen = new Pen(Color.Black, 2))
                    {
                        pen.StartCap =
                            System.Drawing.Drawing2D.LineCap.Round;

                        pen.EndCap =
                            System.Drawing.Drawing2D.LineCap.Round;

                        g.DrawLine(
                            pen,
                            diemCuoi,
                            e.Location);
                    }
                }

                diemCuoi = e.Location;

                pnlCanvas.Invalidate();
            }
        }

        private void pnlCanvas_MouseUp(
            object sender,
            MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dangVe = false;

                lblViTri.Text =
                    $"X: {e.X}, Y: {e.Y} - Sẵn sàng";
            }
        }

        private void pnlCanvas_MouseClick(
            object sender,
            MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                using (Graphics g = Graphics.FromImage(hinhVe))
                {
                    g.Clear(Color.White);
                }

                pnlCanvas.Invalidate();

                lblViTri.Text =
                    $"X: {e.X}, Y: {e.Y} - Sẵn sàng";
            }
        }
        private bool dangVe = false;
        private Point diemCuoi;
        private Bitmap hinhVe;
    }
}
