using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSet
{
    class Code
    {
        int ChancesLife = 3;
        int Ameo = 0;
        int Ameonum = 1;
        int a = 2;
        int b = 1;
        int ql = 2;
        int qt = 2;
        int met = 2;
        public void ShootingAway()
        {

            if (qt == 0)
            


                if (ChancesLife == 0)
                {
                    MessageBox.Show("You Cross 2 Chances Away, So Game Over!!");
                    ql = 2;
                    qt = 2;
                }
                else
                {
                    SoundPlayer sound = new SoundPlayer(GameSet.Properties.Resources.MissShot);
                    sound.Play();
                    ChancesLife = ChancesLife - 1;
                    MessageBox.Show("Ameo Is Away");
                    Ameonum = Ameonum + 1;
                    // Ameo will count according to away chances
                    MessageBox.Show("You Have Point \n " + Ameo + "\n");
                    // For the Ameo Counter

                }

            
        }


        public void ShootingAmeo()
        {
            if (qt == 0)
            {
                
                    if (Ameo == 6 || Ameo == met)
                    {
                        MessageBox.Show("Got 6 Points Game Over !!");
                    // game will be over when all the Ameo will be used
                    ql = 2;
                    qt = 2;
                    }
                    else
                    {
                        SoundPlayer AmeoSound = new SoundPlayer(GameSet.Properties.Resources.Shot);
                        AmeoSound.Play();
                        MessageBox.Show("Shooting Targets");
                        Ameo = Ameo + 1;
                        MessageBox.Show("Point \n " + Ameo + (Ameo == 5 ? "\n \n Gain By You" : "\n"));
                    }
            }
        }

        public void ReloadAmeo()
        {                           
                {
                    Ameo = 0;                    
                    ql = 99;
                met = met + 1;
                }
            if (met>=6)
            {
                met = 3;
            }

                SoundPlayer ReloadAmeoSound = new SoundPlayer(GameSet.Properties.Resources.ReloadGun);
                ReloadAmeoSound.Play();
                MessageBox.Show("Ameo Relaod");
            
        }

        public void SpinAmeo()
        {
        if (ql == 99)
        {
            if (a > b)
            {
                Random Pick = new Random();
                // Create the instance of the Spin Gun
                Ameo = Pick.Next(0, 6);
                qt = 0;
                // ameo is pick from 0 to 6 Ameos
                MessageBox.Show("Gun is Spin Now!");
                // Gun Spin
            }
        }
        }
    }
}
