using ClickerClassLibrary;
using System;
using System.Windows.Forms;

namespace Clicker_by_Leyson.Conf
{
    public partial class Clicker : Form
    {
        private Game game;
        public Clicker()
        {
            InitializeComponent();
            InitGame();
            game.LoadSaveData();
            GetMoneyAndOneClickInfo();

            gameVersionLabel.Text = "Game Version: " + game.gameVersion;

            antiEnterButton.FlatStyle = FlatStyle.Flat;
            antiEnterButton.FlatAppearance.BorderColor = BackColor;
            antiEnterButton.FlatAppearance.MouseOverBackColor = BackColor;
            antiEnterButton.FlatAppearance.MouseDownBackColor = BackColor;
            antiEnterButton.Focus();

            oneClickButton.FlatStyle = FlatStyle.Flat;
            oneClickButton.FlatAppearance.BorderColor = BackColor;
            oneClickButton.FlatAppearance.MouseOverBackColor = BackColor;
            oneClickButton.FlatAppearance.MouseDownBackColor = BackColor;
        }        

        public void OneClickButton_Click(object sender, EventArgs e)
        {
            antiEnterButton.Focus();
            game.OneClick();
            GetMoneyAndOneClickInfo();            
        }

        private void StoreButton_Click(object sender, EventArgs e)
        {
            ClickerStore clickerStore = new ClickerStore(game);
            clickerStore.Show();            
        }

        private void AntiEnterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Don't use Enter, Nigga!");
        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Proc = new System.Diagnostics.Process();
            Proc.StartInfo.FileName = "Clicker by Leyson.Conf.exe";
            Proc.Start();
            this.Close();
        }
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.SaveData();
            Close();
        }

        private void ResetDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitGame();
            GetMoneyAndOneClickInfo();
        }


        private void GetMoneyAndOneClickInfo()
        {
            moneyLabel.Text = "Money: " + Convert.ToString(game.money);
            oneClickLabel.Text = "OneClick: " + Convert.ToString(game.oneClick);
        }

        private void InitGame()
        {
            game = new Game();
        }

        
    }
}
