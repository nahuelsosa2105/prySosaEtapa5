namespace prySosaEtapa5
{
    partial class frmMainEtapa5
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblBarco = new System.Windows.Forms.Label();
            this.lblAvion = new System.Windows.Forms.Label();
            this.lblAuto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(77, 558);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(656, 44);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblBarco
            // 
            this.lblBarco.AutoSize = true;
            this.lblBarco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarco.Location = new System.Drawing.Point(557, 35);
            this.lblBarco.Name = "lblBarco";
            this.lblBarco.Size = new System.Drawing.Size(0, 31);
            this.lblBarco.TabIndex = 12;
            // 
            // lblAvion
            // 
            this.lblAvion.AutoSize = true;
            this.lblAvion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvion.Location = new System.Drawing.Point(367, 35);
            this.lblAvion.Name = "lblAvion";
            this.lblAvion.Size = new System.Drawing.Size(0, 31);
            this.lblAvion.TabIndex = 11;
            // 
            // lblAuto
            // 
            this.lblAuto.AutoSize = true;
            this.lblAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuto.Location = new System.Drawing.Point(75, 35);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(0, 31);
            this.lblAuto.TabIndex = 10;
            // 
            // frmMainEtapa5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prySosaEtapa5.Properties.Resources.FondoEtapa_3;
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.lblBarco);
            this.Controls.Add(this.lblAvion);
            this.Controls.Add(this.lblAuto);
            this.Controls.Add(this.btnCrear);
            this.Name = "frmMainEtapa5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CREAR OBJETOS POR CÓDIGO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblBarco;
        private System.Windows.Forms.Label lblAvion;
        private System.Windows.Forms.Label lblAuto;
    }
}

