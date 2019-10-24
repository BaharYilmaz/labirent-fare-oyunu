namespace odev
{
    partial class Oyun
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
            this.components = new System.ComponentModel.Container();
            this.dgv_labirent = new System.Windows.Forms.DataGridView();
            this.btn_basla = new System.Windows.Forms.Button();
            this.timer_labirent = new System.Windows.Forms.Timer(this.components);
            this.btn_tekKisiOyna = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_labirent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_labirent
            // 
            this.dgv_labirent.AllowUserToAddRows = false;
            this.dgv_labirent.AllowUserToDeleteRows = false;
            this.dgv_labirent.AllowUserToResizeColumns = false;
            this.dgv_labirent.AllowUserToResizeRows = false;
            this.dgv_labirent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_labirent.ColumnHeadersVisible = false;
            this.dgv_labirent.Location = new System.Drawing.Point(12, 11);
            this.dgv_labirent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_labirent.Name = "dgv_labirent";
            this.dgv_labirent.ReadOnly = true;
            this.dgv_labirent.RowHeadersVisible = false;
            this.dgv_labirent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_labirent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_labirent.Size = new System.Drawing.Size(620, 573);
            this.dgv_labirent.TabIndex = 0;
            this.dgv_labirent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TekKisiOyna);
            // 
            // btn_basla
            // 
            this.btn_basla.Location = new System.Drawing.Point(661, 115);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(183, 69);
            this.btn_basla.TabIndex = 6;
            this.btn_basla.Text = "BAŞLA";
            this.btn_basla.UseVisualStyleBackColor = true;
            this.btn_basla.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // timer_labirent
            // 
            this.timer_labirent.Tick += new System.EventHandler(this.timer_labirent_Tick);
            // 
            // btn_tekKisiOyna
            // 
            this.btn_tekKisiOyna.Location = new System.Drawing.Point(661, 220);
            this.btn_tekKisiOyna.Name = "btn_tekKisiOyna";
            this.btn_tekKisiOyna.Size = new System.Drawing.Size(183, 69);
            this.btn_tekKisiOyna.TabIndex = 1;
            this.btn_tekKisiOyna.Text = "Tek Kişi Oyna";
            this.btn_tekKisiOyna.UseVisualStyleBackColor = true;
            this.btn_tekKisiOyna.Click += new System.EventHandler(this.btn_tekKisiOyna_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(658, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // Oyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 597);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_tekKisiOyna);
            this.Controls.Add(this.btn_basla);
            this.Controls.Add(this.dgv_labirent);
            this.Name = "Oyun";
            this.Text = "Oyun";
            this.Load += new System.EventHandler(this.Oyun_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Oyna);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_labirent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_labirent;
        private System.Windows.Forms.Button btn_basla;
        private System.Windows.Forms.Timer timer_labirent;
        private System.Windows.Forms.Button btn_tekKisiOyna;
        private System.Windows.Forms.Label label2;
    }
}

