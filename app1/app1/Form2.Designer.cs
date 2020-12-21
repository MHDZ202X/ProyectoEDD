namespace app1
{
    partial class Form2
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
            this.btnListasimple = new System.Windows.Forms.Button();
            this.btnCola = new System.Windows.Forms.Button();
            this.btnGrafos = new System.Windows.Forms.Button();
            this.btnCircular2ble = new System.Windows.Forms.Button();
            this.btnCircular = new System.Windows.Forms.Button();
            this.btnListDobleMenteEnlazada = new System.Windows.Forms.Button();
            this.btnArbol = new System.Windows.Forms.Button();
            this.btnPila = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListasimple
            // 
            this.btnListasimple.Location = new System.Drawing.Point(61, 50);
            this.btnListasimple.Name = "btnListasimple";
            this.btnListasimple.Size = new System.Drawing.Size(94, 36);
            this.btnListasimple.TabIndex = 0;
            this.btnListasimple.Text = "Lista Simple";
            this.btnListasimple.UseVisualStyleBackColor = true;
            this.btnListasimple.Click += new System.EventHandler(this.btnListasimple_Click);
            // 
            // btnCola
            // 
            this.btnCola.Location = new System.Drawing.Point(202, 92);
            this.btnCola.Name = "btnCola";
            this.btnCola.Size = new System.Drawing.Size(94, 36);
            this.btnCola.TabIndex = 1;
            this.btnCola.Text = "Colas";
            this.btnCola.UseVisualStyleBackColor = true;
            this.btnCola.Click += new System.EventHandler(this.btnCola_Click);
            // 
            // btnGrafos
            // 
            this.btnGrafos.Location = new System.Drawing.Point(202, 134);
            this.btnGrafos.Name = "btnGrafos";
            this.btnGrafos.Size = new System.Drawing.Size(94, 36);
            this.btnGrafos.TabIndex = 2;
            this.btnGrafos.Text = "Grafos";
            this.btnGrafos.UseVisualStyleBackColor = true;
            this.btnGrafos.Click += new System.EventHandler(this.btnGrafos_Click);
            // 
            // btnCircular2ble
            // 
            this.btnCircular2ble.Location = new System.Drawing.Point(61, 176);
            this.btnCircular2ble.Name = "btnCircular2ble";
            this.btnCircular2ble.Size = new System.Drawing.Size(94, 36);
            this.btnCircular2ble.TabIndex = 3;
            this.btnCircular2ble.Text = "Lista circular doble";
            this.btnCircular2ble.UseVisualStyleBackColor = true;
            this.btnCircular2ble.Click += new System.EventHandler(this.btnCircular2ble_Click);
            // 
            // btnCircular
            // 
            this.btnCircular.Location = new System.Drawing.Point(61, 134);
            this.btnCircular.Name = "btnCircular";
            this.btnCircular.Size = new System.Drawing.Size(94, 36);
            this.btnCircular.TabIndex = 4;
            this.btnCircular.Text = "Lista circular";
            this.btnCircular.UseVisualStyleBackColor = true;
            this.btnCircular.Click += new System.EventHandler(this.btnCircular_Click);
            // 
            // btnListDobleMenteEnlazada
            // 
            this.btnListDobleMenteEnlazada.Location = new System.Drawing.Point(61, 92);
            this.btnListDobleMenteEnlazada.Name = "btnListDobleMenteEnlazada";
            this.btnListDobleMenteEnlazada.Size = new System.Drawing.Size(94, 36);
            this.btnListDobleMenteEnlazada.TabIndex = 5;
            this.btnListDobleMenteEnlazada.Text = "Lista Doble Mente Enlazada";
            this.btnListDobleMenteEnlazada.UseVisualStyleBackColor = true;
            this.btnListDobleMenteEnlazada.Click += new System.EventHandler(this.btnListDobleMenteEnlazada_Click);
            // 
            // btnArbol
            // 
            this.btnArbol.Location = new System.Drawing.Point(202, 176);
            this.btnArbol.Name = "btnArbol";
            this.btnArbol.Size = new System.Drawing.Size(94, 36);
            this.btnArbol.TabIndex = 6;
            this.btnArbol.Text = "Arbol";
            this.btnArbol.UseVisualStyleBackColor = true;
            this.btnArbol.Click += new System.EventHandler(this.btnArbol_Click);
            // 
            // btnPila
            // 
            this.btnPila.Location = new System.Drawing.Point(202, 50);
            this.btnPila.Name = "btnPila";
            this.btnPila.Size = new System.Drawing.Size(94, 36);
            this.btnPila.TabIndex = 7;
            this.btnPila.Text = "Pila";
            this.btnPila.UseVisualStyleBackColor = true;
            this.btnPila.Click += new System.EventHandler(this.btnPila_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(368, 293);
            this.Controls.Add(this.btnPila);
            this.Controls.Add(this.btnArbol);
            this.Controls.Add(this.btnListDobleMenteEnlazada);
            this.Controls.Add(this.btnCircular);
            this.Controls.Add(this.btnCircular2ble);
            this.Controls.Add(this.btnGrafos);
            this.Controls.Add(this.btnCola);
            this.Controls.Add(this.btnListasimple);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListasimple;
        private System.Windows.Forms.Button btnCola;
        private System.Windows.Forms.Button btnGrafos;
        private System.Windows.Forms.Button btnCircular2ble;
        private System.Windows.Forms.Button btnCircular;
        private System.Windows.Forms.Button btnListDobleMenteEnlazada;
        private System.Windows.Forms.Button btnArbol;
        private System.Windows.Forms.Button btnPila;
    }
}