namespace Caso02
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
            this.DgPedidos = new System.Windows.Forms.DataGridView();
            this.DgDetalle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // DgPedidos
            // 
            this.DgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPedidos.Location = new System.Drawing.Point(13, 13);
            this.DgPedidos.Name = "DgPedidos";
            this.DgPedidos.Size = new System.Drawing.Size(775, 172);
            this.DgPedidos.TabIndex = 0;
            this.DgPedidos.DoubleClick += new System.EventHandler(this.DgPedidos_DoubleClick);
            // 
            // DgDetalle
            // 
            this.DgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDetalle.Location = new System.Drawing.Point(13, 266);
            this.DgDetalle.Name = "DgDetalle";
            this.DgDetalle.Size = new System.Drawing.Size(775, 172);
            this.DgDetalle.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgDetalle);
            this.Controls.Add(this.DgPedidos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgPedidos;
        private System.Windows.Forms.DataGridView DgDetalle;
    }
}

