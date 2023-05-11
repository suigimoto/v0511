namespace v0511
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("‚±‚ñ‚É‚¿‚Í");
            button1.Text = "‰Ÿ‚³‚ê‚½";
            button1.Left = 0;
            button1.Visible = false;
            button2.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible=true;
        }
    }
}