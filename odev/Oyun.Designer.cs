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
            this.btn_bilgisayarOyna = new System.Windows.Forms.Button();
            this.timer_labirent = new System.Windows.Forms.Timer(this.components);
            this.btn_tekKisiOyna = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHamle = new System.Windows.Forms.Label();
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
            // btn_bilgisayarOyna
            // 
            this.btn_bilgisayarOyna.Location = new System.Drawing.Point(661, 115);
            this.btn_bilgisayarOyna.Name = "btn_bilgisayarOyna";
            this.btn_bilgisayarOyna.Size = new System.Drawing.Size(183, 69);
            this.btn_bilgisayarOyna.TabIndex = 6;
            this.btn_bilgisayarOyna.Text = "Bilgisayar Oyna";
            this.btn_bilgisayarOyna.UseVisualStyleBackColor = true;
            this.btn_bilgisayarOyna.Click += new System.EventHandler(this.btn_bilgisayarOyna_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hamle Sayısı:";
            // 
            // lblHamle
            // 
            this.lblHamle.AutoSize = true;
            this.lblHamle.Location = new System.Drawing.Point(753, 72);
            this.lblHamle.Name = "lblHamle";
            this.lblHamle.Size = new System.Drawing.Size(16, 17);
            this.lblHamle.TabIndex = 9;
            this.lblHamle.Text = "0";
            // 
            // Oyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(869, 597);
            this.Controls.Add(this.lblHamle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_tekKisiOyna);
            this.Controls.Add(this.btn_bilgisayarOyna);
            this.Controls.Add(this.dgv_labirent);
            this.MaximizeBox = false;
            this.Name = "Oyun";
            this.Text = "Oyun";
            this.Load += new System.EventHandler(this.Oyun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_labirent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_labirent;
        private System.Windows.Forms.Button btn_bilgisayarOyna;
        private System.Windows.Forms.Timer timer_labirent;
        private System.Windows.Forms.Button btn_tekKisiOyna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHamle;
    }
}

