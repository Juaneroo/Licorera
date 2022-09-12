namespace Licorera
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelCodigo = new System.Windows.Forms.Label();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.LabelValor = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.LabelProducto = new System.Windows.Forms.Label();
            this.textBoxProd = new System.Windows.Forms.TextBox();
            this.LabelDescripcion = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelCodigo
            // 
            this.LabelCodigo.AutoSize = true;
            this.LabelCodigo.Location = new System.Drawing.Point(51, 256);
            this.LabelCodigo.Name = "LabelCodigo";
            this.LabelCodigo.Size = new System.Drawing.Size(65, 20);
            this.LabelCodigo.TabIndex = 0;
            this.LabelCodigo.Text = "Codigo: ";
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(51, 291);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(125, 27);
            this.textBoxCod.TabIndex = 1;
            // 
            // LabelValor
            // 
            this.LabelValor.AutoSize = true;
            this.LabelValor.Location = new System.Drawing.Point(218, 256);
            this.LabelValor.Name = "LabelValor";
            this.LabelValor.Size = new System.Drawing.Size(50, 20);
            this.LabelValor.TabIndex = 2;
            this.LabelValor.Text = "Valor: ";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(218, 291);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(125, 27);
            this.textBoxValor.TabIndex = 3;
            // 
            // LabelProducto
            // 
            this.LabelProducto.AutoSize = true;
            this.LabelProducto.Location = new System.Drawing.Point(411, 256);
            this.LabelProducto.Name = "LabelProducto";
            this.LabelProducto.Size = new System.Drawing.Size(76, 20);
            this.LabelProducto.TabIndex = 4;
            this.LabelProducto.Text = "Producto: ";
            // 
            // textBoxProd
            // 
            this.textBoxProd.Location = new System.Drawing.Point(411, 291);
            this.textBoxProd.Name = "textBoxProd";
            this.textBoxProd.Size = new System.Drawing.Size(215, 27);
            this.textBoxProd.TabIndex = 5;
            // 
            // LabelDescripcion
            // 
            this.LabelDescripcion.AutoSize = true;
            this.LabelDescripcion.Location = new System.Drawing.Point(648, 256);
            this.LabelDescripcion.Name = "LabelDescripcion";
            this.LabelDescripcion.Size = new System.Drawing.Size(94, 20);
            this.LabelDescripcion.TabIndex = 6;
            this.LabelDescripcion.Text = "Descripcion: ";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(648, 291);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(233, 27);
            this.textBoxDescripcion.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(372, 345);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 29);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Aceptar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(271, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(300, 188);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 422);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.LabelDescripcion);
            this.Controls.Add(this.textBoxProd);
            this.Controls.Add(this.LabelProducto);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.LabelValor);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.LabelCodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelCodigo;
        private TextBox textBoxCod;
        private Label LabelValor;
        private TextBox textBoxValor;
        private Label LabelProducto;
        private TextBox textBoxProd;
        private Label LabelDescripcion;
        private TextBox textBoxDescripcion;
        private Button btnGuardar;
        private DataGridView dataGridView1;
    }
}