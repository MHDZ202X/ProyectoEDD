namespace app1
{
    partial class Radix
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.ltbDesordenado = new System.Windows.Forms.ListBox();
            this.ltbOrdenados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamaño";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dato";
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(110, 45);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(100, 20);
            this.txtTamaño.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(110, 71);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 3;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(234, 43);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(234, 73);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 5;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Location = new System.Drawing.Point(234, 102);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(75, 23);
            this.btnAleatorio.TabIndex = 6;
            this.btnAleatorio.Text = "Aleatorio";
            this.btnAleatorio.UseVisualStyleBackColor = true;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(315, 102);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 7;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // ltbDesordenado
            // 
            this.ltbDesordenado.FormattingEnabled = true;
            this.ltbDesordenado.Location = new System.Drawing.Point(63, 218);
            this.ltbDesordenado.Name = "ltbDesordenado";
            this.ltbDesordenado.Size = new System.Drawing.Size(120, 95);
            this.ltbDesordenado.TabIndex = 8;
            // 
            // ltbOrdenados
            // 
            this.ltbOrdenados.FormattingEnabled = true;
            this.ltbOrdenados.Location = new System.Drawing.Point(283, 218);
            this.ltbOrdenados.Name = "ltbOrdenados";
            this.ltbOrdenados.Size = new System.Drawing.Size(120, 95);
            this.ltbOrdenados.TabIndex = 9;
            // 
            // Radix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 391);
            this.Controls.Add(this.ltbOrdenados);
            this.Controls.Add(this.ltbDesordenado);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Radix";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnAleatorio;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.ListBox ltbDesordenado;
        private System.Windows.Forms.ListBox ltbOrdenados;
    }
}