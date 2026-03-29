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
            MenuItemLabel.Text = "";
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SoupButton_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = "~ Soup of the Day ~";
            MenuItemLabel.Text = "Circuit Breaker Bisque" +
                "\n A silky roasted tomato and red pepper bisque finished with " +
                "\n basil oil \"circuits\" and a swirl of crème fraîche, served with " +
                "\n crispy grilled cheese dippers cut into geometric shapes.";
        }
        private void SaladButton_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = "~ Daily Salad Special ~";
            MenuItemLabel.Text = "Hydroponic Harvest Salad" +
                "\n A fresh mix of butter lettuce, arugula, and microgreens with" +
                "\n cucumber ribbons, cherry tomatoes, candied pecans, and " +
                "\n goat cheese, tossed in a light lemon-honey vinaigrette";
        }
        private void FishButton_Click(object sender, EventArgs e)
        {

        }
    }
}
