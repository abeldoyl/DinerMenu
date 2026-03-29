/*
Abel Doyle
RCET 2265
Spring Semester 2026
DinerMenu
https://github.com/abeldoyl/DinerMenu.git
*/

namespace DinerMenu
{
    public partial class DinerMenu : Form
    {
        public DinerMenu()
        {
            InitializeComponent();
            SetDefaults();
        }
        //Custom Methods below here -----------------------------------------------------

        private void SetDefaults()
        {
            DisplayLabel.Text = "";
            MenuItemLabel.Text = "";
        }

        //Event handlers below here -----------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SoupButton_Click(object sender, EventArgs e)
        {
            DisplayLabel.Text = "~ Soup of the Day ~";
            MenuItemLabel.Text = "Circuit Breaker Bisque" +
                "\n A silky roasted tomato and red pepper bisque finished with " +
                "\n basil oil \"circuits\" and a swirl of cream cheese, served with " +
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
            DisplayLabel.Text = "~ Daily Fish Entree ~";
            MenuItemLabel.Text = "Neptune’s Neural Catch" +
                "\n A Pan seared Atlantic salmon with a crisp skin, glazed in " +
                "\n a miso-honey reduction, served over garlic jasmine rice with " +
                "\n sauteed onion and a drizzle of soy-ginger \"data stream\" sauce.";
        }
    }
}
