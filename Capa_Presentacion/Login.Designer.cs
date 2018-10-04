namespace Semi.Presentacion
{
    partial class Login
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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.txbxPasswrd = new System.Windows.Forms.TextBox();
            this.txbxUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(277, 182);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbxPasswrd
            // 
            this.txbxPasswrd.Location = new System.Drawing.Point(240, 133);
            this.txbxPasswrd.Name = "txbxPasswrd";
            this.txbxPasswrd.Size = new System.Drawing.Size(148, 20);
            this.txbxPasswrd.TabIndex = 2;
            this.txbxPasswrd.UseSystemPasswordChar = true;
            // 
            // txbxUser
            // 
            this.txbxUser.Location = new System.Drawing.Point(240, 92);
            this.txbxUser.Name = "txbxUser";
            this.txbxUser.Size = new System.Drawing.Size(148, 20);
            this.txbxUser.TabIndex = 1;
            this.txbxUser.TextChanged += new System.EventHandler(this.txbxUser_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 276);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbxUser);
            this.Controls.Add(this.txbxPasswrd);
            this.Controls.Add(this.BtnLogin);
            this.Name = "Login";
            this.Text = "SemiFutbol - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox txbxPasswrd;
        private System.Windows.Forms.TextBox txbxUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}