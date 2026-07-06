namespace P05KontrolkaDataGridView
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
            this.dgvDane = new System.Windows.Forms.DataGridView();
            this.btnWyslij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDane)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDane
            // 
            this.dgvDane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDane.Location = new System.Drawing.Point(12, 73);
            this.dgvDane.Name = "dgvDane";
            this.dgvDane.Size = new System.Drawing.Size(776, 369);
            this.dgvDane.TabIndex = 1;
            // 
            // btnWyslij
            // 
            this.btnWyslij.Location = new System.Drawing.Point(713, 44);
            this.btnWyslij.Name = "btnWyslij";
            this.btnWyslij.Size = new System.Drawing.Size(75, 23);
            this.btnWyslij.TabIndex = 2;
            this.btnWyslij.Text = "Wyślij";
            this.btnWyslij.UseVisualStyleBackColor = true;
            this.btnWyslij.Click += new System.EventHandler(this.btnWyslij_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 454);
            this.Controls.Add(this.btnWyslij);
            this.Controls.Add(this.dgvDane);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDane;
        private System.Windows.Forms.Button btnWyslij;
    }
}

