namespace app1
{
    partial class Form3
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
            this.btnBurbuja = new System.Windows.Forms.Button();
            this.btnCocktail = new System.Windows.Forms.Button();
            this.btnCounting = new System.Windows.Forms.Button();
            this.btnShell = new System.Windows.Forms.Button();
            this.btnRadix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBurbuja
            // 
            this.btnBurbuja.Location = new System.Drawing.Point(146, 38);
            this.btnBurbuja.Name = "btnBurbuja";
            this.btnBurbuja.Size = new System.Drawing.Size(91, 40);
            this.btnBurbuja.TabIndex = 0;
            this.btnBurbuja.Text = "Burbuja";
            this.btnBurbuja.UseVisualStyleBackColor = true;
            this.btnBurbuja.Click += new System.EventHandler(this.btnBurbuja_Click);
            // 
            // btnCocktail
            // 
            this.btnCocktail.Location = new System.Drawing.Point(146, 84);
            this.btnCocktail.Name = "btnCocktail";
            this.btnCocktail.Size = new System.Drawing.Size(91, 40);
            this.btnCocktail.TabIndex = 1;
            this.btnCocktail.Text = "Cocktail";
            this.btnCocktail.UseVisualStyleBackColor = true;
            this.btnCocktail.Click += new System.EventHandler(this.btnCocktail_Click);
            // 
            // btnCounting
            // 
            this.btnCounting.Location = new System.Drawing.Point(146, 130);
            this.btnCounting.Name = "btnCounting";
            this.btnCounting.Size = new System.Drawing.Size(91, 40);
            this.btnCounting.TabIndex = 2;
            this.btnCounting.Text = "Counting";
            this.btnCounting.UseVisualStyleBackColor = true;
            this.btnCounting.Click += new System.EventHandler(this.btnCounting_Click);
            // 
            // btnShell
            // 
            this.btnShell.Location = new System.Drawing.Point(146, 176);
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(91, 40);
            this.btnShell.TabIndex = 3;
            this.btnShell.Text = "Shell";
            this.btnShell.UseVisualStyleBackColor = true;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // btnRadix
            // 
            this.btnRadix.Location = new System.Drawing.Point(146, 222);
            this.btnRadix.Name = "btnRadix";
            this.btnRadix.Size = new System.Drawing.Size(91, 40);
            this.btnRadix.TabIndex = 4;
            this.btnRadix.Text = "Radix";
            this.btnRadix.UseVisualStyleBackColor = true;
            this.btnRadix.Click += new System.EventHandler(this.btnRadix_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(395, 290);
            this.Controls.Add(this.btnRadix);
            this.Controls.Add(this.btnShell);
            this.Controls.Add(this.btnCounting);
            this.Controls.Add(this.btnCocktail);
            this.Controls.Add(this.btnBurbuja);
            this.Name = "Form3";
            this.Text = "Metodos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBurbuja;
        private System.Windows.Forms.Button btnCocktail;
        private System.Windows.Forms.Button btnCounting;
        private System.Windows.Forms.Button btnShell;
        private System.Windows.Forms.Button btnRadix;
    }
}