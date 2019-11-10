using System.Windows.Forms;
using ClickerClassLibrary;

namespace Clicker_by_Leyson.Conf
{
    public partial class ClickerStore : Form
    {
        private Game gameOnStore;
        public ClickerStore(Game game)
        {
            InitializeComponent();
            gameOnStore = game;

            upgrade1CostLabel.Text = "Price:\n" + gameOnStore.upgrade1Cost; 
        }

        private void Upgrade1Button_Click(object sender, System.EventArgs e)
        {
            if (gameOnStore.CheckingUsersMoneyForBuyingUpgrades(upgrade1Button.Name) == true)
            {
                gameOnStore.oneClick += gameOnStore.upgrade1;
                gameOnStore.money -= gameOnStore.upgrade1Cost;
                gameOnStore.upgrade1Cost *= 2;

                MessageBox.Show("Upgrade purchased!\nTo update data, click\non the button in the clicker!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Too big the price for you!");
            }
        }
    }
}
