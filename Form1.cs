namespace NNGASU_TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            this.Visible = false;
            form2.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Visible = false;
            form3.ShowDialog();
            this.Visible = true;
        }
    }
}
