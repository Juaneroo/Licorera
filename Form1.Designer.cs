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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LabelCodigo = new System.Windows.Forms.Label();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.LabelValor = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.LabelProducto = new System.Windows.Forms.Label();
            this.textBoxProd = new System.Windows.Forms.TextBox();
            this.LabelDescripcion = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Listadedatos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Listadedatos)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelCodigo
            // 
            this.LabelCodigo.AutoSize = true;
            this.LabelCodigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelCodigo.Location = new System.Drawing.Point(12, 239);
            this.LabelCodigo.Name = "LabelCodigo";
            this.LabelCodigo.Size = new System.Drawing.Size(78, 20);
            this.LabelCodigo.TabIndex = 0;
            this.LabelCodigo.Text = "Codigo: ";
            // 
            // textBoxCod
            // 
            this.textBoxCod.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCod.Location = new System.Drawing.Point(12, 279);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(65, 27);
            this.textBoxCod.TabIndex = 1;
            // 
            // LabelValor
            // 
            this.LabelValor.AutoSize = true;
            this.LabelValor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelValor.Location = new System.Drawing.Point(110, 239);
            this.LabelValor.Name = "LabelValor";
            this.LabelValor.Size = new System.Drawing.Size(62, 20);
            this.LabelValor.TabIndex = 2;
            this.LabelValor.Text = "Valor: ";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxValor.Location = new System.Drawing.Point(110, 279);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(108, 27);
            this.textBoxValor.TabIndex = 3;
            // 
            // LabelProducto
            // 
            this.LabelProducto.AutoSize = true;
            this.LabelProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelProducto.Location = new System.Drawing.Point(244, 239);
            this.LabelProducto.Name = "LabelProducto";
            this.LabelProducto.Size = new System.Drawing.Size(93, 20);
            this.LabelProducto.TabIndex = 4;
            this.LabelProducto.Text = "Producto: ";
            // 
            // textBoxProd
            // 
            this.textBoxProd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxProd.Location = new System.Drawing.Point(244, 279);
            this.textBoxProd.Name = "textBoxProd";
            this.textBoxProd.Size = new System.Drawing.Size(147, 27);
            this.textBoxProd.TabIndex = 5;
            // 
            // LabelDescripcion
            // 
            this.LabelDescripcion.AutoSize = true;
            this.LabelDescripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDescripcion.Location = new System.Drawing.Point(409, 239);
            this.LabelDescripcion.Name = "LabelDescripcion";
            this.LabelDescripcion.Size = new System.Drawing.Size(118, 20);
            this.LabelDescripcion.TabIndex = 6;
            this.LabelDescripcion.Text = "Descripcion: ";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescripcion.Location = new System.Drawing.Point(409, 279);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(164, 27);
            this.textBoxDescripcion.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.Blue;
            this.btnGuardar.Location = new System.Drawing.Point(78, 349);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 43);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Listadedatos
            // 
            this.Listadedatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listadedatos.Location = new System.Drawing.Point(12, 12);
            this.Listadedatos.Name = "Listadedatos";
            this.Listadedatos.RowHeadersWidth = 51;
            this.Listadedatos.RowTemplate.Height = 29;
            this.Listadedatos.Size = new System.Drawing.Size(720, 188);
            this.Listadedatos.TabIndex = 9;
            this.Listadedatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Listadedatos_CellDoubleClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(230, 349);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 43);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.Location = new System.Drawing.Point(409, 349);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 43);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantidad.Location = new System.Drawing.Point(588, 279);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(87, 27);
            this.txtCantidad.TabIndex = 13;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.Location = new System.Drawing.Point(588, 239);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(94, 20);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cantidad: ";
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVender.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVender.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnVender.Location = new System.Drawing.Point(581, 349);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(94, 43);
            this.btnVender.TabIndex = 14;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(711, 422);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.Listadedatos);
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
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Listadedatos)).EndInit();
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
        private DataGridView Listadedatos;
        private Button btnEliminar;
        private Button btnUpdate;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private Button btnVender;
    }
}