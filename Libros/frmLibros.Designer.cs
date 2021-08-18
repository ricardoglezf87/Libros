namespace Libros
{
    partial class frmLibros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Genero = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pdfNo = new System.Windows.Forms.CheckBox();
            this.LeidoNo = new System.Windows.Forms.CheckBox();
            this.Pdfsi = new System.Windows.Forms.CheckBox();
            this.LeidoSi = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pertenece = new System.Windows.Forms.TextBox();
            this.Editorial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DatosLibros = new System.Windows.Forms.DataGridView();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ListadoLibros = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Genero);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pdfNo);
            this.groupBox1.Controls.Add(this.LeidoNo);
            this.groupBox1.Controls.Add(this.Pdfsi);
            this.groupBox1.Controls.Add(this.LeidoSi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pertenece);
            this.groupBox1.Controls.Add(this.Editorial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Autor);
            this.groupBox1.Controls.Add(this.Titulo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
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
            this.Genero.Location = new System.Drawing.Point(6, 149);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(121, 21);
            this.Genero.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Si";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Si";
            // 
            // pdfNo
            // 
            this.pdfNo.AutoSize = true;
            this.pdfNo.Location = new System.Drawing.Point(78, 269);
            this.pdfNo.Name = "pdfNo";
            this.pdfNo.Size = new System.Drawing.Size(15, 14);
            this.pdfNo.TabIndex = 6;
            this.pdfNo.UseVisualStyleBackColor = true;
            // 
            // LeidoNo
            // 
            this.LeidoNo.AutoSize = true;
            this.LeidoNo.Location = new System.Drawing.Point(77, 232);
            this.LeidoNo.Name = "LeidoNo";
            this.LeidoNo.Size = new System.Drawing.Size(15, 14);
            this.LeidoNo.TabIndex = 6;
            this.LeidoNo.UseVisualStyleBackColor = true;
            // 
            // Pdfsi
            // 
            this.Pdfsi.AutoSize = true;
            this.Pdfsi.Location = new System.Drawing.Point(30, 269);
            this.Pdfsi.Name = "Pdfsi";
            this.Pdfsi.Size = new System.Drawing.Size(15, 14);
            this.Pdfsi.TabIndex = 5;
            this.Pdfsi.UseVisualStyleBackColor = true;
            // 
            // LeidoSi
            // 
            this.LeidoSi.AutoSize = true;
            this.LeidoSi.Location = new System.Drawing.Point(29, 232);
            this.LeidoSi.Name = "LeidoSi";
            this.LeidoSi.Size = new System.Drawing.Size(15, 14);
            this.LeidoSi.TabIndex = 5;
            this.LeidoSi.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Es Pdf:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Leido:";
            // 
            // pertenece
            // 
            this.pertenece.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.pertenece.Location = new System.Drawing.Point(6, 189);
            this.pertenece.Name = "pertenece";
            this.pertenece.Size = new System.Drawing.Size(121, 20);
            this.pertenece.TabIndex = 2;
            // 
            // Editorial
            // 
            this.Editorial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Editorial.Location = new System.Drawing.Point(6, 110);
            this.Editorial.Name = "Editorial";
            this.Editorial.Size = new System.Drawing.Size(121, 20);
            this.Editorial.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titulo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Pertenece:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Genero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Editorial:";
            // 
            // Autor
            // 
            this.Autor.Location = new System.Drawing.Point(6, 71);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(121, 20);
            this.Autor.TabIndex = 1;
            // 
            // Titulo
            // 
            this.Titulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Titulo.Location = new System.Drawing.Point(6, 32);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(121, 20);
            this.Titulo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autor:";
            // 
            // DatosLibros
            // 
            this.DatosLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DatosLibros.BackgroundColor = System.Drawing.Color.White;
            this.DatosLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DatosLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosLibros.Location = new System.Drawing.Point(167, 19);
            this.DatosLibros.Name = "DatosLibros";
            this.DatosLibros.Size = new System.Drawing.Size(705, 571);
            this.DatosLibros.TabIndex = 1;
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(12, 382);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(133, 23);
            this.Nuevo.TabIndex = 2;
            this.Nuevo.Text = "Nuevo Libro";
            this.Nuevo.UseVisualStyleBackColor = true;
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(12, 411);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(133, 23);
            this.Borrar.TabIndex = 4;
            this.Borrar.Text = "Borrar Libro Selec.";
            this.Borrar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Libros.gfx.agenda;
            this.pictureBox1.Location = new System.Drawing.Point(12, 440);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ListadoLibros
            // 
            this.ListadoLibros.Location = new System.Drawing.Point(12, 353);
            this.ListadoLibros.Name = "ListadoLibros";
            this.ListadoLibros.Size = new System.Drawing.Size(133, 23);
            this.ListadoLibros.TabIndex = 2;
            this.ListadoLibros.Text = "Listado Libros";
            this.ListadoLibros.UseVisualStyleBackColor = true;
            this.ListadoLibros.Click += new System.EventHandler(this.ListadoLibros_Click);
            // 
            // frmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 602);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.ListadoLibros);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.DatosLibros);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Libros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DatosLibros;
        private System.Windows.Forms.TextBox Editorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Autor;
        private System.Windows.Forms.TextBox Titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox LeidoNo;
        private System.Windows.Forms.CheckBox LeidoSi;
        private System.Windows.Forms.ComboBox Genero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox pdfNo;
        private System.Windows.Forms.CheckBox Pdfsi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pertenece;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button ListadoLibros;
    }
}

