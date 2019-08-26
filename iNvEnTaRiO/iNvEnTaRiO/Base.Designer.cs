namespace iNvEnTaRiO
{
    partial class Base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximo = new System.Windows.Forms.PictureBox();
            this.Regreso = new System.Windows.Forms.PictureBox();
            this.PanelVisual = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.Label();
            this.Consultar = new System.Windows.Forms.Button();
            this.Buscador = new System.Windows.Forms.TextBox();
            this.Texto = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Regreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelVisual)).BeginInit();
            this.SuspendLayout();
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(960, 3);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(40, 40);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar.TabIndex = 0;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(874, 3);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(40, 40);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 1;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximo
            // 
            this.Maximo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximo.Image = ((System.Drawing.Image)(resources.GetObject("Maximo.Image")));
            this.Maximo.Location = new System.Drawing.Point(917, 3);
            this.Maximo.Name = "Maximo";
            this.Maximo.Size = new System.Drawing.Size(40, 40);
            this.Maximo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximo.TabIndex = 3;
            this.Maximo.TabStop = false;
            this.Maximo.Click += new System.EventHandler(this.Maximo_Click);
            // 
            // Regreso
            // 
            this.Regreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Regreso.Image = ((System.Drawing.Image)(resources.GetObject("Regreso.Image")));
            this.Regreso.Location = new System.Drawing.Point(917, 3);
            this.Regreso.Margin = new System.Windows.Forms.Padding(0);
            this.Regreso.Name = "Regreso";
            this.Regreso.Size = new System.Drawing.Size(40, 40);
            this.Regreso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Regreso.TabIndex = 2;
            this.Regreso.TabStop = false;
            this.Regreso.Visible = false;
            this.Regreso.Click += new System.EventHandler(this.Regreso_Click);
            // 
            // PanelVisual
            // 
            this.PanelVisual.AllowUserToAddRows = false;
            this.PanelVisual.AllowUserToDeleteRows = false;
            this.PanelVisual.AllowUserToResizeColumns = false;
            this.PanelVisual.AllowUserToResizeRows = false;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.White;
            this.PanelVisual.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle36;
            this.PanelVisual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelVisual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.PanelVisual.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PanelVisual.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.PanelVisual.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.PanelVisual.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PanelVisual.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.PanelVisual.ColumnHeadersHeight = 30;
            this.PanelVisual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PanelVisual.DefaultCellStyle = dataGridViewCellStyle38;
            this.PanelVisual.EnableHeadersVisualStyles = false;
            this.PanelVisual.GridColor = System.Drawing.Color.Black;
            this.PanelVisual.Location = new System.Drawing.Point(12, 87);
            this.PanelVisual.MultiSelect = false;
            this.PanelVisual.Name = "PanelVisual";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PanelVisual.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.PanelVisual.RowHeadersVisible = false;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.Black;
            this.PanelVisual.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.PanelVisual.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.PanelVisual.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.PanelVisual.RowTemplate.Height = 20;
            this.PanelVisual.RowTemplate.ReadOnly = true;
            this.PanelVisual.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PanelVisual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.PanelVisual.Size = new System.Drawing.Size(800, 400);
            this.PanelVisual.TabIndex = 5;
            this.PanelVisual.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PanelVisual_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Mongolian Baiti", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(0, 3);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(302, 69);
            this.Nombre.TabIndex = 6;
            this.Nombre.Text = "Inventario";
            // 
            // Consultar
            // 
            this.Consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Consultar.Location = new System.Drawing.Point(818, 162);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(161, 23);
            this.Consultar.TabIndex = 7;
            this.Consultar.Text = "Consulta Total";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Buscador
            // 
            this.Buscador.Location = new System.Drawing.Point(818, 112);
            this.Buscador.Name = "Buscador";
            this.Buscador.Size = new System.Drawing.Size(161, 20);
            this.Buscador.TabIndex = 8;
            // 
            // Texto
            // 
            this.Texto.AutoSize = true;
            this.Texto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto.Location = new System.Drawing.Point(857, 87);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(69, 18);
            this.Texto.TabIndex = 9;
            this.Texto.Text = "Consulta";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(818, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // Base
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.Buscador);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.PanelVisual);
            this.Controls.Add(this.Minimizar);
            this.Controls.Add(this.Maximo);
            this.Controls.Add(this.Regreso);
            this.Controls.Add(this.Cerrar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base";
            this.Load += new System.EventHandler(this.Base_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Base_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Regreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelVisual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximo;
        private System.Windows.Forms.PictureBox Regreso;
        private System.Windows.Forms.DataGridView PanelVisual;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.TextBox Buscador;
        private System.Windows.Forms.Label Texto;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

