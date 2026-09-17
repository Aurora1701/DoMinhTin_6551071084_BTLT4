using B18C3;

namespace MDIEx
{
    public partial class Form1 : Form
    {
        private int documentCount = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 child = new Form2();
            child.MdiParent = this;
            documentCount++;
            child.Text = "New Document " + documentCount;
            child.Show();
        }

        private void horizontalSMenu_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalSMenu_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void cascadeSMenu_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
    }
}
