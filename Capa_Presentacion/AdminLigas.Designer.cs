namespace Semi.Presentacion {
    partial class AdminLigas {
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
            this.grdLigas = new System.Windows.Forms.DataGridView();
            this.txbxNewName = new System.Windows.Forms.TextBox();
            this.cmbxEquipos = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnInsLiga = new System.Windows.Forms.Button();
            this.txbxUpId = new System.Windows.Forms.TextBox();
            this.cmbxCampeon = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txbxDelID = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdLigas)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLigas
            // 
            this.grdLigas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdLigas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdLigas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdLigas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLigas.Location = new System.Drawing.Point(227, 12);
            this.grdLigas.Name = "grdLigas";
            this.grdLigas.Size = new System.Drawing.Size(445, 388);
            this.grdLigas.TabIndex = 0;
            this.grdLigas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txbxNewName
            // 
            this.txbxNewName.Location = new System.Drawing.Point(48, 46);
            this.txbxNewName.Name = "txbxNewName";
            this.txbxNewName.Size = new System.Drawing.Size(121, 20);
            this.txbxNewName.TabIndex = 1;
            // 
            // cmbxEquipos
            // 
            this.cmbxEquipos.FormattingEnabled = true;
            this.cmbxEquipos.Location = new System.Drawing.Point(48, 101);
            this.cmbxEquipos.Name = "cmbxEquipos";
            this.cmbxEquipos.Size = new System.Drawing.Size(121, 21);
            this.cmbxEquipos.TabIndex = 2;
            this.cmbxEquipos.SelectedIndexChanged += new System.EventHandler(this.cmbxEquipos_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(175, 104);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnInsLiga
            // 
            this.btnInsLiga.Location = new System.Drawing.Point(71, 133);
            this.btnInsLiga.Name = "btnInsLiga";
            this.btnInsLiga.Size = new System.Drawing.Size(75, 23);
            this.btnInsLiga.TabIndex = 4;
            this.btnInsLiga.Text = "Nueva liga";
            this.btnInsLiga.UseVisualStyleBackColor = true;
            this.btnInsLiga.Click += new System.EventHandler(this.btnInsLiga_Click);
            // 
            // txbxUpId
            // 
            this.txbxUpId.Location = new System.Drawing.Point(51, 210);
            this.txbxUpId.Name = "txbxUpId";
            this.txbxUpId.Size = new System.Drawing.Size(121, 20);
            this.txbxUpId.TabIndex = 5;
            // 
            // cmbxCampeon
            // 
            this.cmbxCampeon.FormattingEnabled = true;
            this.cmbxCampeon.Location = new System.Drawing.Point(51, 265);
            this.cmbxCampeon.Name = "cmbxCampeon";
            this.cmbxCampeon.Size = new System.Drawing.Size(121, 21);
            this.cmbxCampeon.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Nuevo Campeon";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbxDelID
            // 
            this.txbxDelID.Location = new System.Drawing.Point(48, 381);
            this.txbxDelID.Name = "txbxDelID";
            this.txbxDelID.Size = new System.Drawing.Size(121, 20);
            this.txbxDelID.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(71, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Borrar Liga";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre de la Liga (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ultimo campeon (Opcional)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID Liga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Campeon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID Liga";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminLigas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txbxDelID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbxCampeon);
            this.Controls.Add(this.txbxUpId);
            this.Controls.Add(this.btnInsLiga);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmbxEquipos);
            this.Controls.Add(this.txbxNewName);
            this.Controls.Add(this.grdLigas);
            this.Name = "AdminLigas";
            this.Text = "AdminLigas";
            ((System.ComponentModel.ISupportInitialize)(this.grdLigas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdLigas;
        private System.Windows.Forms.TextBox txbxNewName;
        private System.Windows.Forms.ComboBox cmbxEquipos;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnInsLiga;
        private System.Windows.Forms.TextBox txbxUpId;
        private System.Windows.Forms.ComboBox cmbxCampeon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txbxDelID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}