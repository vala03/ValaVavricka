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
    public partial class PrihlasovaciFormular : Form
    {
        private Databaze db = new Databaze();
        public int IdLogin { get; set; }

        public PrihlasovaciFormular()
        {
            InitializeComponent();
        }

        private void PrihlasovaciFormular_Load(object sender, EventArgs e)
        {

        }

        private void btPrihlasit_Click(object sender, EventArgs e)
        {
            if ((this.IdLogin = db.ZkontrolujPrihlaseni(tbLogin.Text, tbPassword.Text)) != -1)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Špatné uživatelské jméno nebo heslo.", "Přihlášení", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void PrihlasovaciFormular_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
