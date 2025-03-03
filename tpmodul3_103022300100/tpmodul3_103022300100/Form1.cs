namespace tpmodul3_103022300100
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            String text = textBox.Text;
            output.Text = "Halo " + text;
        }
    }
}
