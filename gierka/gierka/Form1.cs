namespace gierka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void playbutton_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
            
        }
    }
}