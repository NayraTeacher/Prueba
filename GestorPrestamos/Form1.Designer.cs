namespace GestorPrestamos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.errores = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.editorial = new System.Windows.Forms.TextBox();
            this.isbn = new System.Windows.Forms.TextBox();
            this.autor = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.titulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.listViewLibros = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listViewLibrosPrestados = new System.Windows.Forms.ListView();
            this.bPrestar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.numRenovaciones = new System.Windows.Forms.TextBox();
            this.fechaDevolucion = new System.Windows.Forms.TextBox();
            this.precioPrestado = new System.Windows.Forms.TextBox();
            this.tituloPrestado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.codigoPrestado = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1257, 559);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Controls.Add(this.listViewLibrosPrestados);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1249, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Prestamos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bPrestar);
            this.tabPage2.Controls.Add(this.errores);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Controls.Add(this.listViewLibros);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1249, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Libros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // errores
            // 
            this.errores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errores.ForeColor = System.Drawing.Color.Red;
            this.errores.Location = new System.Drawing.Point(625, 452);
            this.errores.Name = "errores";
            this.errores.Size = new System.Drawing.Size(556, 20);
            this.errores.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(795, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 70);
            this.button2.TabIndex = 3;
            this.button2.Text = "Nuevo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.07914F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.92086F));
            this.tableLayoutPanel1.Controls.Add(this.editorial, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.isbn, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.autor, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.precio, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.titulo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.codigo, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(625, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(556, 294);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // editorial
            // 
            this.editorial.Location = new System.Drawing.Point(148, 232);
            this.editorial.Name = "editorial";
            this.editorial.Size = new System.Drawing.Size(272, 20);
            this.editorial.TabIndex = 11;
            // 
            // isbn
            // 
            this.isbn.Location = new System.Drawing.Point(148, 183);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(272, 20);
            this.isbn.TabIndex = 10;
            // 
            // autor
            // 
            this.autor.Location = new System.Drawing.Point(148, 142);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(272, 20);
            this.autor.TabIndex = 9;
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(148, 99);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(272, 20);
            this.precio.TabIndex = 8;
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(148, 51);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(272, 20);
            this.titulo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ISBN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Editorial";
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(148, 3);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(275, 20);
            this.codigo.TabIndex = 6;
            // 
            // listViewLibros
            // 
            this.listViewLibros.Location = new System.Drawing.Point(89, 45);
            this.listViewLibros.Name = "listViewLibros";
            this.listViewLibros.Size = new System.Drawing.Size(121, 97);
            this.listViewLibros.TabIndex = 0;
            this.listViewLibros.UseCompatibleStateImageBehavior = false;
            this.listViewLibros.SelectedIndexChanged += new System.EventHandler(this.listViewLibros_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1249, 533);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pelis";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listViewLibrosPrestados
            // 
            this.listViewLibrosPrestados.Location = new System.Drawing.Point(45, 32);
            this.listViewLibrosPrestados.Name = "listViewLibrosPrestados";
            this.listViewLibrosPrestados.Size = new System.Drawing.Size(245, 97);
            this.listViewLibrosPrestados.TabIndex = 0;
            this.listViewLibrosPrestados.UseCompatibleStateImageBehavior = false;
            this.listViewLibrosPrestados.SelectedIndexChanged += new System.EventHandler(this.listViewLibrosPrestados_SelectedIndexChanged);
            // 
            // bPrestar
            // 
            this.bPrestar.Location = new System.Drawing.Point(962, 355);
            this.bPrestar.Name = "bPrestar";
            this.bPrestar.Size = new System.Drawing.Size(152, 70);
            this.bPrestar.TabIndex = 5;
            this.bPrestar.Text = "Prestar";
            this.bPrestar.UseVisualStyleBackColor = true;
            this.bPrestar.Click += new System.EventHandler(this.bPrestar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.07914F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.92086F));
            this.tableLayoutPanel2.Controls.Add(this.numRenovaciones, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.fechaDevolucion, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.precioPrestado, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tituloPrestado, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Fecha, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.codigoPrestado, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(616, 32);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(556, 294);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // numRenovaciones
            // 
            this.numRenovaciones.Location = new System.Drawing.Point(148, 183);
            this.numRenovaciones.Name = "numRenovaciones";
            this.numRenovaciones.Size = new System.Drawing.Size(272, 20);
            this.numRenovaciones.TabIndex = 10;
            // 
            // fechaDevolucion
            // 
            this.fechaDevolucion.Location = new System.Drawing.Point(148, 142);
            this.fechaDevolucion.Name = "fechaDevolucion";
            this.fechaDevolucion.Size = new System.Drawing.Size(272, 20);
            this.fechaDevolucion.TabIndex = 9;
            // 
            // precioPrestado
            // 
            this.precioPrestado.Location = new System.Drawing.Point(148, 99);
            this.precioPrestado.Name = "precioPrestado";
            this.precioPrestado.Size = new System.Drawing.Size(272, 20);
            this.precioPrestado.TabIndex = 8;
            // 
            // tituloPrestado
            // 
            this.tituloPrestado.Location = new System.Drawing.Point(148, 51);
            this.tituloPrestado.Name = "tituloPrestado";
            this.tituloPrestado.Size = new System.Drawing.Size(272, 20);
            this.tituloPrestado.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Codigo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Titulo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Precio";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(3, 139);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(109, 13);
            this.Fecha.TabIndex = 3;
            this.Fecha.Text = "Fecha de Devolucion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Renovado";
            // 
            // codigoPrestado
            // 
            this.codigoPrestado.Location = new System.Drawing.Point(148, 3);
            this.codigoPrestado.Name = "codigoPrestado";
            this.codigoPrestado.Size = new System.Drawing.Size(275, 20);
            this.codigoPrestado.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 583);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Gestor Prestamos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewLibros;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox editorial;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.TextBox autor;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.TextBox titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox errores;
        private System.Windows.Forms.ListView listViewLibrosPrestados;
        private System.Windows.Forms.Button bPrestar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox numRenovaciones;
        private System.Windows.Forms.TextBox fechaDevolucion;
        private System.Windows.Forms.TextBox precioPrestado;
        private System.Windows.Forms.TextBox tituloPrestado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox codigoPrestado;
        private System.Windows.Forms.Label label7;
    }
}

