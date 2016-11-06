using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCShop
{
    public partial class HlavniFormular : Form
    {
        private int IdUser;

        public HlavniFormular()
        {
            PrihlaseniDialog();
            InitializeComponent();
        }

        private void PrihlaseniDialog()
        {
            PrihlasovaciFormular pf = new PrihlasovaciFormular();
            pf.StartPosition = FormStartPosition.CenterScreen;
            DialogResult r = pf.ShowDialog();
            if (r == DialogResult.OK)
            {
                this.IdUser = pf.IdLogin;
                MessageBox.Show(this.IdUser.ToString());
            }
            else
                Environment.Exit(0);
            return;
        }

        private void ukončitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
