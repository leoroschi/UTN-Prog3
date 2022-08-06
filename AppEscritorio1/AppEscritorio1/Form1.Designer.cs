
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
            this.tBprueba = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.txtTextBox2 = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1.BackgroundImage")));
            this.btn1.Location = new System.Drawing.Point(102, 362);
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
            this.lblPrimerEtiqueta.Size = new System.Drawing.Size(244, 30);
            this.lblPrimerEtiqueta.TabIndex = 1;
            this.lblPrimerEtiqueta.Text = "Formulario de Prueba";
            this.lblPrimerEtiqueta.MouseLeave += new System.EventHandler(this.lblPrimerEtiqueta_MouseLeave);
            this.lblPrimerEtiqueta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblPrimerEtiqueta_MouseMove);
            // 
            // tBprueba
            // 
            this.tBprueba.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tBprueba.Location = new System.Drawing.Point(102, 179);
            this.tBprueba.Name = "tBprueba";
            this.tBprueba.Size = new System.Drawing.Size(184, 20);
            this.tBprueba.TabIndex = 2;
            this.tBprueba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBprueba_KeyPress);
            // 
            // btn2
            // 
            this.btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2.BackgroundImage")));
            this.btn2.Location = new System.Drawing.Point(274, 362);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(93, 29);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTextBox2
            // 
            this.txtTextBox2.Location = new System.Drawing.Point(102, 223);
            this.txtTextBox2.Multiline = true;
            this.txtTextBox2.Name = "txtTextBox2";
            this.txtTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTextBox2.Size = new System.Drawing.Size(184, 117);
            this.txtTextBox2.TabIndex = 4;
            this.txtTextBox2.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(98, 97);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(462, 66);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "En este formulario se probaron algunas funcionalidades\r\n y propiedades de los tex" +
    "tbox y botones y no tiene\r\nfuncionalidad alguna mas que probar propiedades";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Ventana1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTextBox2);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.tBprueba);
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
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblPrimerEtiqueta;
        private System.Windows.Forms.TextBox tBprueba;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox txtTextBox2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label1;
    }
}

