namespace app1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEstructura = new System.Windows.Forms.Button();
            this.btnOrdenamiento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstructura
            // 
            this.btnEstructura.Location = new System.Drawing.Point(82, 73);
            this.btnEstructura.Name = "btnEstructura";
            this.btnEstructura.Size = new System.Drawing.Size(133, 55);
            this.btnEstructura.TabIndex = 0;
            this.btnEstructura.Text = "Estructura de datos";
            this.btnEstructura.UseVisualStyleBackColor = true;
            this.btnEstructura.Click += new System.EventHandler(this.btnEstructura_Click);
            // 
            // btnOrdenamiento
            // 
            this.btnOrdenamiento.Location = new System.Drawing.Point(82, 149);
            this.btnOrdenamiento.Name = "btnOrdenamiento";
            this.btnOrdenamiento.Size = new System.Drawing.Size(133, 55);
            this.btnOrdenamiento.TabIndex = 1;
            this.btnOrdenamiento.Text = "Metodos de Ordenamiento";
            this.btnOrdenamiento.UseVisualStyleBackColor = true;
            this.btnOrdenamiento.Click += new System.EventHandler(this.btnOrdenamiento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(294, 260);
            this.Controls.Add(this.btnOrdenamiento);
            this.Controls.Add(this.btnEstructura);
            this.Name = "Form1";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstructura;
        private System.Windows.Forms.Button btnOrdenamiento;
    }
}

