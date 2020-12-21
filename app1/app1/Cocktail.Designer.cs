namespace app1
{
    partial class Cocktail
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
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblComparaciones = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblO = new System.Windows.Forms.Label();
            this.lblI = new System.Windows.Forms.Label();
            this.lblTiempoOrdenar = new System.Windows.Forms.Label();
            this.lblIntercambios = new System.Windows.Forms.Label();
            this.lbOrdenar = new System.Windows.Forms.ListBox();
            this.lbNum = new System.Windows.Forms.ListBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(139, 145);
            this.txtMax.Margin = new System.Windows.Forms.Padding(2);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(76, 20);
            this.txtMax.TabIndex = 25;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(137, 102);
            this.txtMin.Margin = new System.Windows.Forms.Padding(2);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(76, 20);
            this.txtMin.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Limite Maximo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Limite Minimo:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblComparaciones);
            this.groupBox1.Controls.Add(this.lblC);
            this.groupBox1.Controls.Add(this.lblO);
            this.groupBox1.Controls.Add(this.lblI);
            this.groupBox1.Controls.Add(this.lblTiempoOrdenar);
            this.groupBox1.Controls.Add(this.lblIntercambios);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(65, 279);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(232, 112);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiempo de ejecucion";
            // 
            // lblComparaciones
            // 
            this.lblComparaciones.AutoSize = true;
            this.lblComparaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComparaciones.Location = new System.Drawing.Point(109, 51);
            this.lblComparaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComparaciones.Name = "lblComparaciones";
            this.lblComparaciones.Size = new System.Drawing.Size(14, 15);
            this.lblComparaciones.TabIndex = 13;
            this.lblComparaciones.Text = "0";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(15, 51);
            this.lblC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(97, 15);
            this.lblC.TabIndex = 12;
            this.lblC.Text = "Comparaciones:";
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblO.Location = new System.Drawing.Point(15, 73);
            this.lblO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(55, 15);
            this.lblO.TabIndex = 11;
            this.lblO.Text = "Ordenar:";
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblI.Location = new System.Drawing.Point(15, 28);
            this.lblI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(78, 15);
            this.lblI.TabIndex = 10;
            this.lblI.Text = "Intercambios";
            // 
            // lblTiempoOrdenar
            // 
            this.lblTiempoOrdenar.AutoSize = true;
            this.lblTiempoOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoOrdenar.Location = new System.Drawing.Point(77, 73);
            this.lblTiempoOrdenar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiempoOrdenar.Name = "lblTiempoOrdenar";
            this.lblTiempoOrdenar.Size = new System.Drawing.Size(24, 15);
            this.lblTiempoOrdenar.TabIndex = 1;
            this.lblTiempoOrdenar.Text = "0:0";
            // 
            // lblIntercambios
            // 
            this.lblIntercambios.AutoSize = true;
            this.lblIntercambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntercambios.Location = new System.Drawing.Point(110, 28);
            this.lblIntercambios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIntercambios.Name = "lblIntercambios";
            this.lblIntercambios.Size = new System.Drawing.Size(14, 15);
            this.lblIntercambios.TabIndex = 0;
            this.lblIntercambios.Text = "0";
            // 
            // lbOrdenar
            // 
            this.lbOrdenar.FormattingEnabled = true;
            this.lbOrdenar.Location = new System.Drawing.Point(353, 61);
            this.lbOrdenar.Margin = new System.Windows.Forms.Padding(2);
            this.lbOrdenar.Name = "lbOrdenar";
            this.lbOrdenar.Size = new System.Drawing.Size(101, 160);
            this.lbOrdenar.TabIndex = 20;
            // 
            // lbNum
            // 
            this.lbNum.FormattingEnabled = true;
            this.lbNum.Location = new System.Drawing.Point(230, 61);
            this.lbNum.Margin = new System.Windows.Forms.Padding(2);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(99, 160);
            this.lbNum.TabIndex = 19;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(294, 236);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(88, 29);
            this.btnOrdenar.TabIndex = 18;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(89, 191);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(88, 29);
            this.btnGenerar.TabIndex = 17;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(107, 25);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(348, 24);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Ordenamiento Burbuja Bidireccional";
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeros.Location = new System.Drawing.Point(47, 61);
            this.lblNumeros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(60, 13);
            this.lblNumeros.TabIndex = 15;
            this.lblNumeros.Text = "Numeros:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(111, 61);
            this.txtNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(76, 20);
            this.txtNum.TabIndex = 14;
            // 
            // Cocktail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 417);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbOrdenar);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNumeros);
            this.Controls.Add(this.txtNum);
            this.Name = "Cocktail";
            this.Text = "Cocktail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblComparaciones;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.Label lblTiempoOrdenar;
        private System.Windows.Forms.Label lblIntercambios;
        private System.Windows.Forms.ListBox lbOrdenar;
        private System.Windows.Forms.ListBox lbNum;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.TextBox txtNum;
    }
}