namespace Proiect
{
    partial class FilmeZi
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
            this.Filme = new System.Windows.Forms.DataGridView();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Filme)).BeginInit();
            this.SuspendLayout();
            // 
            // Filme
            // 
            this.Filme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Filme.Location = new System.Drawing.Point(12, 12);
            this.Filme.Name = "Filme";
            this.Filme.ReadOnly = true;
            this.Filme.Size = new System.Drawing.Size(764, 300);
            this.Filme.TabIndex = 0;
            this.Filme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Filme_CellContentClick);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(700, 321);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 1;
            this.close.Text = "Inchide";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // FilmeZi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 356);
            this.Controls.Add(this.close);
            this.Controls.Add(this.Filme);
            this.Name = "FilmeZi";
            this.Text = "FilmeZi";
            this.Load += new System.EventHandler(this.FilmeZi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Filme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Filme;
        private System.Windows.Forms.Button close;
    }
}