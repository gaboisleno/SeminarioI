namespace Semi.Presentacion {
    partial class AminEquipos {
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
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEquipos
            // 
            this.grdEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEquipos.Location = new System.Drawing.Point(13, 94);
            this.grdEquipos.Name = "grdEquipos";
            this.grdEquipos.Size = new System.Drawing.Size(680, 283);
            this.grdEquipos.TabIndex = 0;
            this.grdEquipos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEquipos_CellContentClick);
            // 
            // AminEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 389);
            this.Controls.Add(this.grdEquipos);
            this.Name = "AminEquipos";
            this.Text = "AminEquipos";
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdEquipos;
    }
}