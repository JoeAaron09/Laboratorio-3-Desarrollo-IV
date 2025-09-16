namespace JeremyR_JosephG_DanielC_Lab3
{
    partial class Problema2
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
            this.lbDefinirRango = new System.Windows.Forms.Label();
            this.tbRango = new System.Windows.Forms.TextBox();
            this.lbPalindromos = new System.Windows.Forms.ListBox();
            this.btProb3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDefinirRango
            // 
            this.lbDefinirRango.AutoSize = true;
            this.lbDefinirRango.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDefinirRango.ForeColor = System.Drawing.Color.SeaShell;
            this.lbDefinirRango.Location = new System.Drawing.Point(28, 36);
            this.lbDefinirRango.Name = "lbDefinirRango";
            this.lbDefinirRango.Size = new System.Drawing.Size(409, 25);
            this.lbDefinirRango.TabIndex = 0;
            this.lbDefinirRango.Text = "Defina un rango de números palíndromos:";
            // 
            // tbRango
            // 
            this.tbRango.BackColor = System.Drawing.Color.DarkRed;
            this.tbRango.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRango.ForeColor = System.Drawing.Color.MistyRose;
            this.tbRango.Location = new System.Drawing.Point(30, 88);
            this.tbRango.MaxLength = 25;
            this.tbRango.Name = "tbRango";
            this.tbRango.Size = new System.Drawing.Size(407, 27);
            this.tbRango.TabIndex = 1;
            this.tbRango.TextChanged += new System.EventHandler(this.tbRango_TextChanged);
            // 
            // lbPalindromos
            // 
            this.lbPalindromos.BackColor = System.Drawing.Color.Firebrick;
            this.lbPalindromos.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPalindromos.ForeColor = System.Drawing.Color.MistyRose;
            this.lbPalindromos.FormattingEnabled = true;
            this.lbPalindromos.ItemHeight = 25;
            this.lbPalindromos.Location = new System.Drawing.Point(41, 157);
            this.lbPalindromos.Name = "lbPalindromos";
            this.lbPalindromos.Size = new System.Drawing.Size(358, 179);
            this.lbPalindromos.TabIndex = 4;
            // 
            // btProb3
            // 
            this.btProb3.BackColor = System.Drawing.Color.Maroon;
            this.btProb3.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProb3.ForeColor = System.Drawing.Color.SeaShell;
            this.btProb3.Location = new System.Drawing.Point(345, 386);
            this.btProb3.Name = "btProb3";
            this.btProb3.Size = new System.Drawing.Size(141, 38);
            this.btProb3.TabIndex = 5;
            this.btProb3.Text = "Problema 3";
            this.btProb3.UseVisualStyleBackColor = false;
            this.btProb3.Click += new System.EventHandler(this.btProb3_Click);
            // 
            // Problema2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btProb3);
            this.Controls.Add(this.lbPalindromos);
            this.Controls.Add(this.tbRango);
            this.Controls.Add(this.lbDefinirRango);
            this.Name = "Problema2";
            this.Text = "Problema 2";
            this.Load += new System.EventHandler(this.Problema2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDefinirRango;
        private System.Windows.Forms.TextBox tbRango;
   
        private System.Windows.Forms.ListBox lbPalindromos;
        private System.Windows.Forms.Button btProb3;
    }
}