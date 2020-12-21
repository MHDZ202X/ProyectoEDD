namespace app1
{
    partial class Shell
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.btnShell = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ltbDesordenados = new System.Windows.Forms.ListBox();
            this.ltbOrdenados = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(240, 502);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(106, 41);
            this.btnLimpiar.TabIndex = 43;
            this.btnLimpiar.Text = "Limpiar Datos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(218, 215);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(42, 13);
            this.lblTiempo.TabIndex = 42;
            this.lblTiempo.Text = "Tiempo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnRandom);
            this.groupBox1.Controls.Add(this.btnLista);
            this.groupBox1.Controls.Add(this.txtLista);
            this.groupBox1.Location = new System.Drawing.Point(62, -2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(489, 181);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arreglo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Numeros para agregar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tamaño del Arreglo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Agregar Tamaño";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRandom.Location = new System.Drawing.Point(311, 122);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(2);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(110, 37);
            this.btnRandom.TabIndex = 9;
            this.btnRandom.Text = "Agregar Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLista.Location = new System.Drawing.Point(158, 122);
            this.btnLista.Margin = new System.Windows.Forms.Padding(2);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(103, 37);
            this.btnLista.TabIndex = 1;
            this.btnLista.Text = "Agregar Lista";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(19, 141);
            this.txtLista.Margin = new System.Windows.Forms.Padding(2);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(114, 20);
            this.txtLista.TabIndex = 0;
            // 
            // btnShell
            // 
            this.btnShell.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnShell.Location = new System.Drawing.Point(240, 395);
            this.btnShell.Margin = new System.Windows.Forms.Padding(2);
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(106, 59);
            this.btnShell.TabIndex = 40;
            this.btnShell.Text = "Algoritmo Shell";
            this.btnShell.UseVisualStyleBackColor = false;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Desordenados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ordenados";
            // 
            // ltbDesordenados
            // 
            this.ltbDesordenados.FormattingEnabled = true;
            this.ltbDesordenados.Location = new System.Drawing.Point(74, 282);
            this.ltbDesordenados.Margin = new System.Windows.Forms.Padding(2);
            this.ltbDesordenados.Name = "ltbDesordenados";
            this.ltbDesordenados.Size = new System.Drawing.Size(116, 225);
            this.ltbDesordenados.TabIndex = 37;
            // 
            // ltbOrdenados
            // 
            this.ltbOrdenados.FormattingEnabled = true;
            this.ltbOrdenados.Location = new System.Drawing.Point(395, 282);
            this.ltbOrdenados.Margin = new System.Windows.Forms.Padding(2);
            this.ltbOrdenados.Name = "ltbOrdenados";
            this.ltbOrdenados.Size = new System.Drawing.Size(122, 225);
            this.ltbOrdenados.TabIndex = 36;
            // 
            // Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 541);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltbDesordenados);
            this.Controls.Add(this.ltbOrdenados);
            this.Name = "Shell";
            this.Text = "Form5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Button btnShell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ltbDesordenados;
        private System.Windows.Forms.ListBox ltbOrdenados;
    }
}