using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ClickerClassLibrary
{
    public class Game
    {
        public string gameVersion = "0.2.0 Alpha";

        public ulong money = 100;
        public ulong oneClick = 1;

        public ulong upgrade1 = 1;
        public ulong upgrade1Cost = 100;       

        public void OneClick()
        {
            money += oneClick;            
        }        

        public bool CheckingUsersMoneyForBuyingUpgrades(string nameButton)
        {
            bool checkingUsersMoneyForBuyingUpgrades = false;
            switch (nameButton)
            {
                case "upgrade1Button":
                    if (money >= upgrade1Cost)
                    {                        
                        checkingUsersMoneyForBuyingUpgrades = true;
                    }
                    else
                    {
                        checkingUsersMoneyForBuyingUpgrades = false;
                    }
                break;
            }
            return checkingUsersMoneyForBuyingUpgrades;
        }

        public void SaveData()
        {
            File.WriteAllText(@"save.txt", money + "\n" + oneClick + "\n" + upgrade1Cost);
        }

        public void LoadSaveData()
        {
            if (File.Exists(@"save.txt") == true)
            {
                money = Convert.ToUInt64(File.ReadLines(@"save.txt").First());
                oneClick = Convert.ToUInt64(File.ReadLines(@"save.txt").Skip(1).First());
                upgrade1Cost = Convert.ToUInt64(File.ReadLines(@"save.txt").Skip(2).First());
            }
            else
            {
                File.WriteAllText(@"save.txt", money + "\n" + oneClick + "\n" + upgrade1Cost);
            }
        }
    }   
}
