namespace DinerMenu
{
    public partial class DinerMenu : Form
    {
        public DinerMenu()
        {
            InitializeComponent();
            SetDefaults();
        }
        private void SetDefaults()
        {
            DisplayLabel.Text = "";
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
