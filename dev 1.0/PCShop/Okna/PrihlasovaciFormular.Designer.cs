namespace PCShop
{
    partial class PrihlasovaciFormular
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btPrihlasit = new System.Windows.Forms.Button();
            this.lblUzivatelskeJmeno = new System.Windows.Forms.Label();
            this.lblHeslo = new System.Windows.Forms.Label();
            this.lblLoginNadpis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLogin.Location = new System.Drawing.Point(154, 41);
            this.tbLogin.MaxLength = 20;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 20);
            this.tbLogin.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPassword.Location = new System.Drawing.Point(154, 67);
            this.tbPassword.MaxLength = 20;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // btPrihlasit
            // 
            this.btPrihlasit.Location = new System.Drawing.Point(55, 93);
            this.btPrihlasit.Name = "btPrihlasit";
            this.btPrihlasit.Size = new System.Drawing.Size(199, 23);
            this.btPrihlasit.TabIndex = 5;
            this.btPrihlasit.Text = "Přihlásit";
            this.btPrihlasit.UseVisualStyleBackColor = true;
            this.btPrihlasit.Click += new System.EventHandler(this.btPrihlasit_Click);
            // 
            // lblUzivatelskeJmeno
            // 
            this.lblUzivatelskeJmeno.AutoSize = true;
            this.lblUzivatelskeJmeno.Location = new System.Drawing.Point(52, 44);
            this.lblUzivatelskeJmeno.Name = "lblUzivatelskeJmeno";
            this.lblUzivatelskeJmeno.Size = new System.Drawing.Size(96, 13);
            this.lblUzivatelskeJmeno.TabIndex = 1;
            this.lblUzivatelskeJmeno.Text = "Uživatelské jméno:";
            // 
            // lblHeslo
            // 
            this.lblHeslo.AutoSize = true;
            this.lblHeslo.Location = new System.Drawing.Point(111, 70);
            this.lblHeslo.Name = "lblHeslo";
            this.lblHeslo.Size = new System.Drawing.Size(37, 13);
            this.lblHeslo.TabIndex = 3;
            this.lblHeslo.Text = "Heslo:";
            // 
            // lblLoginNadpis
            // 
            this.lblLoginNadpis.AutoSize = true;
            this.lblLoginNadpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLoginNadpis.Location = new System.Drawing.Point(9, 9);
            this.lblLoginNadpis.Name = "lblLoginNadpis";
            this.lblLoginNadpis.Size = new System.Drawing.Size(289, 15);
            this.lblLoginNadpis.TabIndex = 0;
            this.lblLoginNadpis.Text = "Přihlášení do evidenčního systému PC-Shop";
            // 
            // PrihlasovaciFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 128);
            this.Controls.Add(this.lblLoginNadpis);
            this.Controls.Add(this.lblHeslo);
            this.Controls.Add(this.lblUzivatelskeJmeno);
            this.Controls.Add(this.btPrihlasit);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrihlasovaciFormular";
            this.ShowIcon = false;
            this.Text = "Přihlášení do systému";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrihlasovaciFormular_FormClosing);
            this.Load += new System.EventHandler(this.PrihlasovaciFormular_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btPrihlasit;
        private System.Windows.Forms.Label lblUzivatelskeJmeno;
        private System.Windows.Forms.Label lblHeslo;
        private System.Windows.Forms.Label lblLoginNadpis;
    }
}