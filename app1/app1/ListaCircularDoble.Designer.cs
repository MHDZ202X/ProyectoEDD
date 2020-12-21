namespace app1
{
    partial class ListaCircularDoble
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
            this.buscando = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSEP = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Lista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblContar = new System.Windows.Forms.Label();
            this.lblContarDes = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.txtdato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buscando
            // 
            this.buscando.AutoSize = true;
            this.buscando.Location = new System.Drawing.Point(625, 151);
            this.buscando.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buscando.Name = "buscando";
            this.buscando.Size = new System.Drawing.Size(88, 13);
            this.buscando.TabIndex = 33;
            this.buscando.Text = "Buscando dato...";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(632, 105);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 35);
            this.button3.TabIndex = 32;
            this.button3.Text = "Modificar tabla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSEP
            // 
            this.txtSEP.Location = new System.Drawing.Point(541, 149);
            this.txtSEP.Margin = new System.Windows.Forms.Padding(2);
            this.txtSEP.Name = "txtSEP";
            this.txtSEP.Size = new System.Drawing.Size(38, 20);
            this.txtSEP.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lista});
            this.dataGridView1.Location = new System.Drawing.Point(11, 126);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 67;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(477, 329);
            this.dataGridView1.TabIndex = 30;
            // 
            // Lista
            // 
            this.Lista.HeaderText = "Lista";
            this.Lista.MinimumWidth = 8;
            this.Lista.Name = "Lista";
            this.Lista.Width = 165;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 311);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 37);
            this.button2.TabIndex = 29;
            this.button2.Text = "Guardar ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 269);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 37);
            this.button1.TabIndex = 28;
            this.button1.Text = "Siguiente Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Contando nodos...";
            // 
            // lblContar
            // 
            this.lblContar.AutoSize = true;
            this.lblContar.Location = new System.Drawing.Point(33, 79);
            this.lblContar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContar.Name = "lblContar";
            this.lblContar.Size = new System.Drawing.Size(70, 13);
            this.lblContar.TabIndex = 26;
            this.lblContar.Text = ".....................";
            // 
            // lblContarDes
            // 
            this.lblContarDes.AutoSize = true;
            this.lblContarDes.Location = new System.Drawing.Point(33, 58);
            this.lblContarDes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContarDes.Name = "lblContarDes";
            this.lblContarDes.Size = new System.Drawing.Size(67, 13);
            this.lblContarDes.TabIndex = 25;
            this.lblContarDes.Text = "....................";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(688, 227);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(119, 37);
            this.btnBorrar.TabIndex = 24;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(541, 269);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 37);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(688, 185);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(119, 37);
            this.btnMostrar.TabIndex = 22;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(541, 185);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(119, 37);
            this.btnInsertar.TabIndex = 21;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(541, 227);
            this.btnContar.Margin = new System.Windows.Forms.Padding(2);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(119, 37);
            this.btnContar.TabIndex = 20;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // txtdato
            // 
            this.txtdato.Location = new System.Drawing.Point(469, 18);
            this.txtdato.Margin = new System.Windows.Forms.Padding(2);
            this.txtdato.Name = "txtdato";
            this.txtdato.Size = new System.Drawing.Size(43, 20);
            this.txtdato.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.94937F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "Inserte elemento de la lista:";
            // 
            // ListaCircularDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 419);
            this.Controls.Add(this.buscando);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtSEP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblContar);
            this.Controls.Add(this.lblContarDes);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.txtdato);
            this.Controls.Add(this.label1);
            this.Name = "ListaCircularDoble";
            this.Text = "ListaCircularDoble";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buscando;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtSEP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lista;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblContar;
        private System.Windows.Forms.Label lblContarDes;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnContar;
        public System.Windows.Forms.TextBox txtdato;
        private System.Windows.Forms.Label label1;
    }
}