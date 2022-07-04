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
            CountClass.Counts = CountClass.Counts+1;
            MessageBox.Show("You click button "+ CountClass.Counts +" times");

        }
    }
}