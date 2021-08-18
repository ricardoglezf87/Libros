namespace Libros
{
    partial class frmNuevo
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Editorial = new System.Windows.Forms.TextBox();
            this.Insertar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Leido = new System.Windows.Forms.CheckBox();
            this.esPDF = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pertenece = new System.Windows.Forms.TextBox();
            this.Genero = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fechaLeido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // Titulo
            // 
            this.Titulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Titulo.Location = new System.Drawing.Point(17, 25);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(232, 20);
            this.Titulo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Autor";
            // 
            // Autor
            // 
            this.Autor.Location = new System.Drawing.Point(17, 64);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(232, 20);
            this.Autor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Editorial";
            // 
            // Editorial
            // 
            this.Editorial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Editorial.Location = new System.Drawing.Point(17, 103);
            this.Editorial.Name = "Editorial";
            this.Editorial.Size = new System.Drawing.Size(232, 20);
            this.Editorial.TabIndex = 2;
            // 
            // Insertar
            // 
            this.Insertar.Location = new System.Drawing.Point(254, 25);
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(75, 23);
            this.Insertar.TabIndex = 3;
            this.Insertar.Text = "Insertar";
            this.Insertar.UseVisualStyleBackColor = true;
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(254, 54);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 4;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Esta Leido";
            // 
            // Leido
            // 
            this.Leido.AutoSize = true;
            this.Leido.Location = new System.Drawing.Point(71, 211);
            this.Leido.Name = "Leido";
            this.Leido.Size = new System.Drawing.Size(15, 14);
            this.Leido.TabIndex = 6;
            this.Leido.UseVisualStyleBackColor = true;
            // 
            // esPDF
            // 
            this.esPDF.AutoSize = true;
            this.esPDF.Location = new System.Drawing.Point(71, 231);
            this.esPDF.Name = "esPDF";
            this.esPDF.Size = new System.Drawing.Size(15, 14);
            this.esPDF.TabIndex = 6;
            this.esPDF.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Es PDF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pertenece";
            // 
            // pertenece
            // 
            this.pertenece.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.pertenece.Location = new System.Drawing.Point(17, 186);
            this.pertenece.Name = "pertenece";
            this.pertenece.Size = new System.Drawing.Size(232, 20);
            this.pertenece.TabIndex = 2;
            // 
            // Genero
            // 
            this.Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Genero.FormattingEnabled = true;
            this.Genero.Items.AddRange(new object[] {
            "",
            "Romanticas",
            "Vampiricas",
            "Suspense",
            "Terror",
            "Arlequin",
            "Cocina",
            "Oeste"});
            this.Genero.Location = new System.Drawing.Point(17, 143);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(232, 21);
            this.Genero.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Genero:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha Leido";
            // 
            // fechaLeido
            // 
            this.fechaLeido.Location = new System.Drawing.Point(164, 209);
            this.fechaLeido.Name = "fechaLeido";
            this.fechaLeido.Size = new System.Drawing.Size(85, 20);
            this.fechaLeido.TabIndex = 14;
            // 
            // frmNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(335, 271);
            this.Controls.Add(this.fechaLeido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.esPDF);
            this.Controls.Add(this.Leido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Insertar);
            this.Controls.Add(this.pertenece);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Editorial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Libro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Autor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Editorial;
        private System.Windows.Forms.Button Insertar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Leido;
        private System.Windows.Forms.CheckBox esPDF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pertenece;
        private System.Windows.Forms.ComboBox Genero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fechaLeido;
    }
}