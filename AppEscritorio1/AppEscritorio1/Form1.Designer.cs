﻿
namespace AppEscritorio1
{
    partial class Ventana1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana1));
            this.btn1 = new System.Windows.Forms.Button();
            this.lblPrimerEtiqueta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1.BackgroundImage")));
            this.btn1.Location = new System.Drawing.Point(344, 378);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(93, 29);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblPrimerEtiqueta
            // 
            this.lblPrimerEtiqueta.AutoSize = true;
            this.lblPrimerEtiqueta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrimerEtiqueta.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerEtiqueta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPrimerEtiqueta.Location = new System.Drawing.Point(102, 58);
            this.lblPrimerEtiqueta.Name = "lblPrimerEtiqueta";
            this.lblPrimerEtiqueta.Size = new System.Drawing.Size(115, 30);
            this.lblPrimerEtiqueta.TabIndex = 1;
            this.lblPrimerEtiqueta.Text = "Etiqueta1";
            this.lblPrimerEtiqueta.MouseLeave += new System.EventHandler(this.lblPrimerEtiqueta_MouseLeave);
            this.lblPrimerEtiqueta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblPrimerEtiqueta_MouseMove);
            // 
            // Ventana1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrimerEtiqueta);
            this.Controls.Add(this.btn1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ventana1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto 1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ventana1_FormClosed);
            this.Load += new System.EventHandler(this.Ventana1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblPrimerEtiqueta;
    }
}

