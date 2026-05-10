namespace GitYGitHub
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_venta = new System.Windows.Forms.Button();
            this.btn_Almacen = new System.Windows.Forms.Button();
            this.btn_Lista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 119);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // btn_venta
            // 
            this.btn_venta.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_venta.Location = new System.Drawing.Point(282, 142);
            this.btn_venta.Name = "btn_venta";
            this.btn_venta.Size = new System.Drawing.Size(246, 80);
            this.btn_venta.TabIndex = 1;
            this.btn_venta.Text = "Venta";
            this.btn_venta.UseVisualStyleBackColor = true;
            this.btn_venta.Click += new System.EventHandler(this.btn_venta_Click);
            // 
            // btn_Almacen
            // 
            this.btn_Almacen.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold);
            this.btn_Almacen.Location = new System.Drawing.Point(282, 240);
            this.btn_Almacen.Name = "btn_Almacen";
            this.btn_Almacen.Size = new System.Drawing.Size(246, 80);
            this.btn_Almacen.TabIndex = 2;
            this.btn_Almacen.Text = "Almacen";
            this.btn_Almacen.UseVisualStyleBackColor = true;
            this.btn_Almacen.Click += new System.EventHandler(this.btn_Almacen_Click);
            // 
            // btn_Lista
            // 
            this.btn_Lista.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold);
            this.btn_Lista.Location = new System.Drawing.Point(282, 336);
            this.btn_Lista.Name = "btn_Lista";
            this.btn_Lista.Size = new System.Drawing.Size(246, 102);
            this.btn_Lista.TabIndex = 3;
            this.btn_Lista.Text = "Lista de Ventas";
            this.btn_Lista.UseVisualStyleBackColor = true;
            this.btn_Lista.Click += new System.EventHandler(this.btn_Lista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Lista);
            this.Controls.Add(this.btn_Almacen);
            this.Controls.Add(this.btn_venta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_venta;
        private System.Windows.Forms.Button btn_Almacen;
        private System.Windows.Forms.Button btn_Lista;
    }
}

