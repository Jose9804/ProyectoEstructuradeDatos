using System;

namespace Proyecto_EstructurasDeDatos
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
            this.components = new System.ComponentModel.Container();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.rutaArchivotextBox = new System.Windows.Forms.TextBox();
            this.BtnAbrirarchivo = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnLineaCircular = new System.Windows.Forms.Button();
            this.btnDoblementeEnlazada = new System.Windows.Forms.Button();
            this.btnEnlaceSimple = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.GridView.Location = new System.Drawing.Point(5, 71);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(728, 225);
            this.GridView.TabIndex = 3;
            this.GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "RutaArchivo";
            this.Column3.Name = "Column3";
            this.Column3.Width = 10000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresar los Datos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descripcion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ruta del Archivo:";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDtextBox.Location = new System.Drawing.Point(218, 422);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(118, 22);
            this.IDtextBox.TabIndex = 9;
            this.IDtextBox.TextChanged += new System.EventHandler(this.IDtextBox_TextChanged);
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripciontextBox.Location = new System.Drawing.Point(218, 457);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(394, 22);
            this.DescripciontextBox.TabIndex = 10;
            // 
            // rutaArchivotextBox
            // 
            this.rutaArchivotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rutaArchivotextBox.Location = new System.Drawing.Point(218, 494);
            this.rutaArchivotextBox.Name = "rutaArchivotextBox";
            this.rutaArchivotextBox.Size = new System.Drawing.Size(394, 22);
            this.rutaArchivotextBox.TabIndex = 11;
            // 
            // BtnAbrirarchivo
            // 
            this.BtnAbrirarchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrirarchivo.Location = new System.Drawing.Point(636, 494);
            this.BtnAbrirarchivo.Name = "BtnAbrirarchivo";
            this.BtnAbrirarchivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAbrirarchivo.Size = new System.Drawing.Size(79, 23);
            this.BtnAbrirarchivo.TabIndex = 12;
            this.BtnAbrirarchivo.Text = "Abrir Archivo";
            this.BtnAbrirarchivo.UseVisualStyleBackColor = true;
            this.BtnAbrirarchivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(218, 536);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(118, 56);
            this.BtnAgregar.TabIndex = 13;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(393, 536);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 56);
            this.button4.TabIndex = 15;
            this.button4.Text = "ELIMINAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(370, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sistema de Album de Fotos";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnLineaCircular
            // 
            this.btnLineaCircular.Location = new System.Drawing.Point(414, 12);
            this.btnLineaCircular.Name = "btnLineaCircular";
            this.btnLineaCircular.Size = new System.Drawing.Size(75, 23);
            this.btnLineaCircular.TabIndex = 17;
            this.btnLineaCircular.Text = "Circular";
            this.btnLineaCircular.UseVisualStyleBackColor = true;
            this.btnLineaCircular.Click += new System.EventHandler(this.btnLineaCircular_Click_1);
            // 
            // btnDoblementeEnlazada
            // 
            this.btnDoblementeEnlazada.Location = new System.Drawing.Point(512, 12);
            this.btnDoblementeEnlazada.Name = "btnDoblementeEnlazada";
            this.btnDoblementeEnlazada.Size = new System.Drawing.Size(100, 23);
            this.btnDoblementeEnlazada.TabIndex = 18;
            this.btnDoblementeEnlazada.Text = "Doble Enlace";
            this.btnDoblementeEnlazada.UseVisualStyleBackColor = true;
            this.btnDoblementeEnlazada.Click += new System.EventHandler(this.btnDoblementeEnlazada_Click);
            // 
            // btnEnlaceSimple
            // 
            this.btnEnlaceSimple.Location = new System.Drawing.Point(633, 12);
            this.btnEnlaceSimple.Name = "btnEnlaceSimple";
            this.btnEnlaceSimple.Size = new System.Drawing.Size(100, 23);
            this.btnEnlaceSimple.TabIndex = 19;
            this.btnEnlaceSimple.Text = "EnlaceSimple";
            this.btnEnlaceSimple.UseVisualStyleBackColor = true;
            this.btnEnlaceSimple.Click += new System.EventHandler(this.btnEnlaceSimple_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 604);
            this.Controls.Add(this.btnEnlaceSimple);
            this.Controls.Add(this.btnDoblementeEnlazada);
            this.Controls.Add(this.btnLineaCircular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnAbrirarchivo);
            this.Controls.Add(this.rutaArchivotextBox);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }*/

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        protected internal System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.TextBox rutaArchivotextBox;
        private System.Windows.Forms.Button BtnAbrirarchivo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnLineaCircular;
        private System.Windows.Forms.Button btnDoblementeEnlazada;
        private System.Windows.Forms.Button btnEnlaceSimple;
    }
}

