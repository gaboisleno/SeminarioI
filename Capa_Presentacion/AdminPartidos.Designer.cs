namespace Semi.Presentacion {
    partial class AdminPartidos {
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
            this.rbtnIns = new System.Windows.Forms.RadioButton();
            this.rbtnUpd = new System.Windows.Forms.RadioButton();
            this.rbtnDel = new System.Windows.Forms.RadioButton();
            this.cmbxLiga = new System.Windows.Forms.ComboBox();
            this.cmbxLocal = new System.Windows.Forms.ComboBox();
            this.cmbxVisitante = new System.Windows.Forms.ComboBox();
            this.txbxDate = new System.Windows.Forms.TextBox();
            this.txbxHour = new System.Windows.Forms.TextBox();
            this.txbxGoalL = new System.Windows.Forms.TextBox();
            this.txbxGoalV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grdPartidos = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPartidos)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnIns
            // 
            this.rbtnIns.AutoSize = true;
            this.rbtnIns.Checked = true;
            this.rbtnIns.Location = new System.Drawing.Point(191, 14);
            this.rbtnIns.Name = "rbtnIns";
            this.rbtnIns.Size = new System.Drawing.Size(93, 17);
            this.rbtnIns.TabIndex = 0;
            this.rbtnIns.TabStop = true;
            this.rbtnIns.Text = "Nuevo Partido";
            this.rbtnIns.UseVisualStyleBackColor = true;
            this.rbtnIns.CheckedChanged += new System.EventHandler(this.rbtnIns_CheckedChanged);
            // 
            // rbtnUpd
            // 
            this.rbtnUpd.AutoSize = true;
            this.rbtnUpd.Location = new System.Drawing.Point(290, 14);
            this.rbtnUpd.Name = "rbtnUpd";
            this.rbtnUpd.Size = new System.Drawing.Size(104, 17);
            this.rbtnUpd.TabIndex = 1;
            this.rbtnUpd.Text = "Modificar Partido";
            this.rbtnUpd.UseVisualStyleBackColor = true;
            this.rbtnUpd.CheckedChanged += new System.EventHandler(this.rbtnUpd_CheckedChanged);
            // 
            // rbtnDel
            // 
            this.rbtnDel.AutoSize = true;
            this.rbtnDel.Location = new System.Drawing.Point(400, 14);
            this.rbtnDel.Name = "rbtnDel";
            this.rbtnDel.Size = new System.Drawing.Size(89, 17);
            this.rbtnDel.TabIndex = 2;
            this.rbtnDel.Text = "Borrar Partido";
            this.rbtnDel.UseVisualStyleBackColor = true;
            this.rbtnDel.CheckedChanged += new System.EventHandler(this.rbtnDel_CheckedChanged);
            // 
            // cmbxLiga
            // 
            this.cmbxLiga.FormattingEnabled = true;
            this.cmbxLiga.Location = new System.Drawing.Point(273, 62);
            this.cmbxLiga.Name = "cmbxLiga";
            this.cmbxLiga.Size = new System.Drawing.Size(121, 21);
            this.cmbxLiga.TabIndex = 3;
            // 
            // cmbxLocal
            // 
            this.cmbxLocal.FormattingEnabled = true;
            this.cmbxLocal.Location = new System.Drawing.Point(273, 89);
            this.cmbxLocal.Name = "cmbxLocal";
            this.cmbxLocal.Size = new System.Drawing.Size(121, 21);
            this.cmbxLocal.TabIndex = 4;
            // 
            // cmbxVisitante
            // 
            this.cmbxVisitante.FormattingEnabled = true;
            this.cmbxVisitante.Location = new System.Drawing.Point(273, 116);
            this.cmbxVisitante.Name = "cmbxVisitante";
            this.cmbxVisitante.Size = new System.Drawing.Size(121, 21);
            this.cmbxVisitante.TabIndex = 5;
            // 
            // txbxDate
            // 
            this.txbxDate.Location = new System.Drawing.Point(273, 143);
            this.txbxDate.Name = "txbxDate";
            this.txbxDate.Size = new System.Drawing.Size(121, 20);
            this.txbxDate.TabIndex = 6;
            // 
            // txbxHour
            // 
            this.txbxHour.Location = new System.Drawing.Point(273, 169);
            this.txbxHour.Name = "txbxHour";
            this.txbxHour.Size = new System.Drawing.Size(121, 20);
            this.txbxHour.TabIndex = 7;
            // 
            // txbxGoalL
            // 
            this.txbxGoalL.Location = new System.Drawing.Point(273, 195);
            this.txbxGoalL.Name = "txbxGoalL";
            this.txbxGoalL.Size = new System.Drawing.Size(121, 20);
            this.txbxGoalL.TabIndex = 8;
            // 
            // txbxGoalV
            // 
            this.txbxGoalV.Location = new System.Drawing.Point(273, 221);
            this.txbxGoalV.Name = "txbxGoalV";
            this.txbxGoalV.Size = new System.Drawing.Size(121, 20);
            this.txbxGoalV.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "A que Competicion pertenece el partido? ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Quien es el equipo Local? (*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quien es el equipo Visitante (*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Que Fecha es el partido? (*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "En que Horario se juega?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cantidad de Goles Local";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cantidad de Goles Visitante";
            // 
            // grdPartidos
            // 
            this.grdPartidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPartidos.Location = new System.Drawing.Point(12, 300);
            this.grdPartidos.Name = "grdPartidos";
            this.grdPartidos.Size = new System.Drawing.Size(660, 150);
            this.grdPartidos.TabIndex = 18;
            this.grdPartidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPartidos_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(597, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grdPartidos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbxGoalV);
            this.Controls.Add(this.txbxGoalL);
            this.Controls.Add(this.txbxHour);
            this.Controls.Add(this.txbxDate);
            this.Controls.Add(this.cmbxVisitante);
            this.Controls.Add(this.cmbxLocal);
            this.Controls.Add(this.cmbxLiga);
            this.Controls.Add(this.rbtnDel);
            this.Controls.Add(this.rbtnUpd);
            this.Controls.Add(this.rbtnIns);
            this.Name = "AdminPartidos";
            this.Text = "AdminPartidos";
            this.Load += new System.EventHandler(this.AdminPartidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPartidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnIns;
        private System.Windows.Forms.RadioButton rbtnUpd;
        private System.Windows.Forms.RadioButton rbtnDel;
        private System.Windows.Forms.ComboBox cmbxLiga;
        private System.Windows.Forms.ComboBox cmbxLocal;
        private System.Windows.Forms.ComboBox cmbxVisitante;
        private System.Windows.Forms.TextBox txbxDate;
        private System.Windows.Forms.TextBox txbxHour;
        private System.Windows.Forms.TextBox txbxGoalL;
        private System.Windows.Forms.TextBox txbxGoalV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grdPartidos;
        private System.Windows.Forms.Button button2;
    }
}