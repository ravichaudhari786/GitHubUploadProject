namespace GitHubUploadProject
{
    public partial class Form1 : Form
    {
        CountClass cc = new CountClass();
        public Form1()
        {
            InitializeComponent();
            CountClass.Counts = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            txtlable.Text = "";
            CountClass.Counts = CountClass.Counts+1;
            txtlable.Text = "Ravi click button " + CountClass.Counts +" times";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtlable.Text = "";
            CountClass.Counts = 0;
        }
    }
}