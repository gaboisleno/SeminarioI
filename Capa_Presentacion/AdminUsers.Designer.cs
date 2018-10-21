namespace Semi.Presentacion {
    partial class AdminUsers {
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
            this.rbtnSetAdmin = new System.Windows.Forms.RadioButton();
            this.rbtnRmvAdmin = new System.Windows.Forms.RadioButton();
            this.rbtnDelUser = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txbxID = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnSetAdmin
            // 
            this.rbtnSetAdmin.AutoSize = true;
            this.rbtnSetAdmin.Location = new System.Drawing.Point(34, 27);
            this.rbtnSetAdmin.Name = "rbtnSetAdmin";
            this.rbtnSetAdmin.Size = new System.Drawing.Size(103, 17);
            this.rbtnSetAdmin.TabIndex = 0;
            this.rbtnSetAdmin.TabStop = true;
            this.rbtnSetAdmin.Text = "Conceder Admin";
            this.rbtnSetAdmin.UseVisualStyleBackColor = true;
            this.rbtnSetAdmin.CheckedChanged += new System.EventHandler(this.rbtnSetAdmin_CheckedChanged);
            // 
            // rbtnRmvAdmin
            // 
            this.rbtnRmvAdmin.AutoSize = true;
            this.rbtnRmvAdmin.Location = new System.Drawing.Point(34, 50);
            this.rbtnRmvAdmin.Name = "rbtnRmvAdmin";
            this.rbtnRmvAdmin.Size = new System.Drawing.Size(85, 17);
            this.rbtnRmvAdmin.TabIndex = 1;
            this.rbtnRmvAdmin.TabStop = true;
            this.rbtnRmvAdmin.Text = "Quitar Admin";
            this.rbtnRmvAdmin.UseVisualStyleBackColor = true;
            this.rbtnRmvAdmin.CheckedChanged += new System.EventHandler(this.rbtnRmvAdmin_CheckedChanged);
            // 
            // rbtnDelUser
            // 
            this.rbtnDelUser.AutoSize = true;
            this.rbtnDelUser.Location = new System.Drawing.Point(34, 73);
            this.rbtnDelUser.Name = "rbtnDelUser";
            this.rbtnDelUser.Size = new System.Drawing.Size(92, 17);
            this.rbtnDelUser.TabIndex = 2;
            this.rbtnDelUser.TabStop = true;
            this.rbtnDelUser.Text = "Borrar Usuario";
            this.rbtnDelUser.UseVisualStyleBackColor = true;
            this.rbtnDelUser.CheckedChanged += new System.EventHandler(this.rbtnDelUser_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(187, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 438);
            this.dataGridView1.TabIndex = 3;
            // 
            // txbxID
            // 
            this.txbxID.Location = new System.Drawing.Point(34, 127);
            this.txbxID.Name = "txbxID";
            this.txbxID.Size = new System.Drawing.Size(100, 20);
            this.txbxID.TabIndex = 4;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(47, 154);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Aplicar";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Usuario";
            // 
            // AdminUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txbxID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbtnDelUser);
            this.Controls.Add(this.rbtnRmvAdmin);
            this.Controls.Add(this.rbtnSetAdmin);
            this.Name = "AdminUsers";
            this.Text = "AdminUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnSetAdmin;
        private System.Windows.Forms.RadioButton rbtnRmvAdmin;
        private System.Windows.Forms.RadioButton rbtnDelUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txbxID;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label1;
    }
}