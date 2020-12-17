using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSet
{
    

    public partial class Form1 : Form
    {
       
        Code Code = new Code();
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureAway_Click_1(object sender, EventArgs e)
        {
            Code.ShootingAway();

            
        }

        private void pictureSpin_Click_1(object sender, EventArgs e)
        {
            Code.SpinAmeo();
        }

        private void pictureReload_Click_1(object sender, EventArgs e)
        {
            Code.ReloadAmeo();
            
        }

        private void pictureShoot_Click_1(object sender, EventArgs e)
        {
            Code.ShootingAmeo();
            
        }
    }
}
