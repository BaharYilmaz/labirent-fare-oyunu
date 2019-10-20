namespace odev
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer_labirent = new System.Windows.Forms.Timer(this.components);
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
            this.dgv_labirent.Location = new System.Drawing.Point(31, 32);
            this.dgv_labirent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_labirent.Name = "dgv_labirent";
            this.dgv_labirent.ReadOnly = true;
            this.dgv_labirent.RowHeadersVisible = false;
            this.dgv_labirent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_labirent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_labirent.Size = new System.Drawing.Size(620, 573);
            this.dgv_labirent.TabIndex = 1;
            // 
            // btn_basla
            // 
            this.btn_basla.Location = new System.Drawing.Point(861, 148);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(183, 69);
            this.btn_basla.TabIndex = 2;
            this.btn_basla.Text = "BAŞLA";
            this.btn_basla.UseVisualStyleBackColor = true;
            this.btn_basla.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(858, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // timer_labirent
            // 
            this.timer_labirent.Tick += new System.EventHandler(this.timer_labirent_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 718);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_basla);
            this.Controls.Add(this.dgv_labirent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_labirent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_labirent;
        private System.Windows.Forms.Button btn_basla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_labirent;
    }
}

