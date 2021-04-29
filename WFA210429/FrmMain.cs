using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA210429
{
    public partial class FrmMain : Form
    {
        static Random rnd = new Random();
        string rndSzam;
        public FrmMain()
        {
            rndSzam = rnd.Next(1, 4).ToString();

            InitializeComponent();

            lblOpening.Text = $"nyomja meg a [{rndSzam}] gombot a folytatáshoz!";

            btnN1.Click += BtnNum_Click;
            btnN2.Click += BtnNum_Click;
            btnN3.Click += BtnNum_Click;
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == rndSzam)
            {
                this.Hide();
                new FrmKinalat().ShowDialog();
            }
            Application.Exit();
        }
    }
}
