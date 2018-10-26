namespace Semi.Presentacion {
    partial class AdminEquipos {
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
            this.grdEquipos = new System.Windows.Forms.DataGridView();
            this.txbxInsNombre = new System.Windows.Forms.TextBox();
            this.cmbxInsLiga = new System.Windows.Forms.ComboBox();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.txbxDelId = new System.Windows.Forms.TextBox();
            this.txbxUpdNombre = new System.Windows.Forms.TextBox();
            this.txbxUpdId = new System.Windows.Forms.TextBox();
            this.cmbxUpdLiga = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEquipos
            // 
            this.grdEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEquipos.Location = new System.Drawing.Point(167, 32);
            this.grdEquipos.Name = "grdEquipos";
            this.grdEquipos.Size = new System.Drawing.Size(505, 388);
            this.grdEquipos.TabIndex = 0;
            this.grdEquipos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEquipos_CellContentClick);
            // 
            // txbxInsNombre
            // 
            this.txbxInsNombre.Location = new System.Drawing.Point(20, 32);
            this.txbxInsNombre.Name = "txbxInsNombre";
            this.txbxInsNombre.Size = new System.Drawing.Size(121, 20);
            this.txbxInsNombre.TabIndex = 1;
            // 
            // cmbxInsLiga
            // 
            this.cmbxInsLiga.FormattingEnabled = true;
            this.cmbxInsLiga.Location = new System.Drawing.Point(20, 79);
            this.cmbxInsLiga.Name = "cmbxInsLiga";
            this.cmbxInsLiga.Size = new System.Drawing.Size(121, 21);
            this.cmbxInsLiga.TabIndex = 2;
            this.cmbxInsLiga.SelectedIndexChanged += new System.EventHandler(this.cmbxInsLiga_SelectedIndexChanged);
            // 
            // btnIns
            // 
            this.btnIns.Location = new System.Drawing.Point(30, 107);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(100, 23);
            this.btnIns.TabIndex = 3;
            this.btnIns.Text = "Nuevo Equipo";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(43, 222);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Borrar Equipo";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txbxDelId
            // 
            this.txbxDelId.Location = new System.Drawing.Point(20, 195);
            this.txbxDelId.Name = "txbxDelId";
            this.txbxDelId.Size = new System.Drawing.Size(121, 20);
            this.txbxDelId.TabIndex = 5;
            // 
            // txbxUpdNombre
            // 
            this.txbxUpdNombre.Location = new System.Drawing.Point(19, 352);
            this.txbxUpdNombre.Name = "txbxUpdNombre";
            this.txbxUpdNombre.Size = new System.Drawing.Size(123, 20);
            this.txbxUpdNombre.TabIndex = 6;
            // 
            // txbxUpdId
            // 
            this.txbxUpdId.Location = new System.Drawing.Point(19, 305);
            this.txbxUpdId.Name = "txbxUpdId";
            this.txbxUpdId.Size = new System.Drawing.Size(123, 20);
            this.txbxUpdId.TabIndex = 7;
            // 
            // cmbxUpdLiga
            // 
            this.cmbxUpdLiga.FormattingEnabled = true;
            this.cmbxUpdLiga.Location = new System.Drawing.Point(20, 399);
            this.cmbxUpdLiga.Name = "cmbxUpdLiga";
            this.cmbxUpdLiga.Size = new System.Drawing.Size(121, 21);
            this.cmbxUpdLiga.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 427);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Liga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID Equipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID Equipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Liga";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AdminEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmbxUpdLiga);
            this.Controls.Add(this.txbxUpdId);
            this.Controls.Add(this.txbxUpdNombre);
            this.Controls.Add(this.txbxDelId);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.cmbxInsLiga);
            this.Controls.Add(this.txbxInsNombre);
            this.Controls.Add(this.grdEquipos);
            this.Name = "AdminEquipos";
            this.Text = "AminEquipos";
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdEquipos;
        private System.Windows.Forms.TextBox txbxInsNombre;
        private System.Windows.Forms.ComboBox cmbxInsLiga;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txbxDelId;
        private System.Windows.Forms.TextBox txbxUpdNombre;
        private System.Windows.Forms.TextBox txbxUpdId;
        private System.Windows.Forms.ComboBox cmbxUpdLiga;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}