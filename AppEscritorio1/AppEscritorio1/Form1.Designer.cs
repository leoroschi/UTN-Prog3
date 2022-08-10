
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
            this.btnCambioColor = new System.Windows.Forms.Button();
            this.lblPrimerEtiqueta = new System.Windows.Forms.Label();
            this.tBprueba = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.txtTextBox2 = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblForm1 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnIrFormulario2 = new System.Windows.Forms.Button();
            this.btnFormulario3 = new System.Windows.Forms.Button();
            this.btnFormulario4 = new System.Windows.Forms.Button();
            this.btnTryCatch = new System.Windows.Forms.Button();
            this.lblPractica2 = new System.Windows.Forms.Label();
            this.lblPactica3 = new System.Windows.Forms.Label();
            this.lblPractica4 = new System.Windows.Forms.Label();
            this.btnP8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCambioColor
            // 
            this.btnCambioColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCambioColor.BackgroundImage")));
            this.btnCambioColor.Location = new System.Drawing.Point(115, 382);
            this.btnCambioColor.Name = "btnCambioColor";
            this.btnCambioColor.Size = new System.Drawing.Size(93, 29);
            this.btnCambioColor.TabIndex = 0;
            this.btnCambioColor.Text = "Cambia Color";
            this.btnCambioColor.UseVisualStyleBackColor = true;
            this.btnCambioColor.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblPrimerEtiqueta
            // 
            this.lblPrimerEtiqueta.AutoSize = true;
            this.lblPrimerEtiqueta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrimerEtiqueta.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerEtiqueta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPrimerEtiqueta.Location = new System.Drawing.Point(91, 73);
            this.lblPrimerEtiqueta.Name = "lblPrimerEtiqueta";
            this.lblPrimerEtiqueta.Size = new System.Drawing.Size(90, 24);
            this.lblPrimerEtiqueta.TabIndex = 1;
            this.lblPrimerEtiqueta.Text = "Unidad 1:";
            this.lblPrimerEtiqueta.MouseLeave += new System.EventHandler(this.lblPrimerEtiqueta_MouseLeave);
            this.lblPrimerEtiqueta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblPrimerEtiqueta_MouseMove);
            // 
            // tBprueba
            // 
            this.tBprueba.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tBprueba.Location = new System.Drawing.Point(91, 176);
            this.tBprueba.Name = "tBprueba";
            this.tBprueba.Size = new System.Drawing.Size(526, 20);
            this.tBprueba.TabIndex = 2;
            this.tBprueba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBprueba_KeyPress);
            // 
            // btnValidar
            // 
            this.btnValidar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnValidar.BackgroundImage")));
            this.btnValidar.Location = new System.Drawing.Point(273, 382);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(93, 29);
            this.btnValidar.TabIndex = 3;
            this.btnValidar.Text = "Valida Texto";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTextBox2
            // 
            this.txtTextBox2.Location = new System.Drawing.Point(91, 222);
            this.txtTextBox2.Multiline = true;
            this.txtTextBox2.Name = "txtTextBox2";
            this.txtTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTextBox2.Size = new System.Drawing.Size(298, 133);
            this.txtTextBox2.TabIndex = 4;
            this.txtTextBox2.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblForm1
            // 
            this.lblForm1.AutoSize = true;
            this.lblForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm1.Location = new System.Drawing.Point(87, 36);
            this.lblForm1.Name = "lblForm1";
            this.lblForm1.Size = new System.Drawing.Size(173, 24);
            this.lblForm1.TabIndex = 5;
            this.lblForm1.Text = "Practica 1, FORM";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(87, 107);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(437, 44);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "En este formulario se realizaron todas las actividade \r\npracticas del apunteTeori" +
    "co y practico N1";
            // 
            // btnIrFormulario2
            // 
            this.btnIrFormulario2.Location = new System.Drawing.Point(421, 222);
            this.btnIrFormulario2.Name = "btnIrFormulario2";
            this.btnIrFormulario2.Size = new System.Drawing.Size(196, 29);
            this.btnIrFormulario2.TabIndex = 7;
            this.btnIrFormulario2.Text = "Practica 5 Aplicacion de Windos";
            this.btnIrFormulario2.UseVisualStyleBackColor = true;
            this.btnIrFormulario2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnFormulario3
            // 
            this.btnFormulario3.Location = new System.Drawing.Point(421, 274);
            this.btnFormulario3.Name = "btnFormulario3";
            this.btnFormulario3.Size = new System.Drawing.Size(196, 29);
            this.btnFormulario3.TabIndex = 8;
            this.btnFormulario3.Text = "Practica 6 Radiobutton y Checkbox";
            this.btnFormulario3.UseVisualStyleBackColor = true;
            this.btnFormulario3.Click += new System.EventHandler(this.btnFormulario3_Click);
            // 
            // btnFormulario4
            // 
            this.btnFormulario4.Location = new System.Drawing.Point(421, 326);
            this.btnFormulario4.Name = "btnFormulario4";
            this.btnFormulario4.Size = new System.Drawing.Size(196, 29);
            this.btnFormulario4.TabIndex = 9;
            this.btnFormulario4.Text = "Practica 7 RichTextBox";
            this.btnFormulario4.UseVisualStyleBackColor = true;
            this.btnFormulario4.Click += new System.EventHandler(this.btnFormulario4_Click);
            // 
            // btnTryCatch
            // 
            this.btnTryCatch.Location = new System.Drawing.Point(421, 382);
            this.btnTryCatch.Name = "btnTryCatch";
            this.btnTryCatch.Size = new System.Drawing.Size(196, 29);
            this.btnTryCatch.TabIndex = 10;
            this.btnTryCatch.Text = "Tratamiento de errores (TryCatch)";
            this.btnTryCatch.UseVisualStyleBackColor = true;
            this.btnTryCatch.Click += new System.EventHandler(this.btnTryCatch_Click);
            // 
            // lblPractica2
            // 
            this.lblPractica2.AutoSize = true;
            this.lblPractica2.Location = new System.Drawing.Point(100, 366);
            this.lblPractica2.Name = "lblPractica2";
            this.lblPractica2.Size = new System.Drawing.Size(123, 13);
            this.lblPractica2.TabIndex = 11;
            this.lblPractica2.Text = "Practica 2 control button";
            // 
            // lblPactica3
            // 
            this.lblPactica3.AutoSize = true;
            this.lblPactica3.Location = new System.Drawing.Point(489, 47);
            this.lblPactica3.Name = "lblPactica3";
            this.lblPactica3.Size = new System.Drawing.Size(115, 13);
            this.lblPactica3.TabIndex = 12;
            this.lblPactica3.Text = "Practica 3 control label";
            // 
            // lblPractica4
            // 
            this.lblPractica4.AutoSize = true;
            this.lblPractica4.Location = new System.Drawing.Point(88, 199);
            this.lblPractica4.Name = "lblPractica4";
            this.lblPractica4.Size = new System.Drawing.Size(127, 13);
            this.lblPractica4.TabIndex = 13;
            this.lblPractica4.Text = "Practica 4 control textbox";
            // 
            // btnP8
            // 
            this.btnP8.Location = new System.Drawing.Point(421, 438);
            this.btnP8.Name = "btnP8";
            this.btnP8.Size = new System.Drawing.Size(196, 29);
            this.btnP8.TabIndex = 14;
            this.btnP8.Text = "P8 Listbox Checkedlistbox";
            this.btnP8.UseVisualStyleBackColor = true;
            this.btnP8.Click += new System.EventHandler(this.btnP8_Click);
            // 
            // Ventana1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(714, 489);
            this.Controls.Add(this.btnP8);
            this.Controls.Add(this.lblPractica4);
            this.Controls.Add(this.lblPactica3);
            this.Controls.Add(this.lblPractica2);
            this.Controls.Add(this.btnTryCatch);
            this.Controls.Add(this.btnFormulario4);
            this.Controls.Add(this.btnFormulario3);
            this.Controls.Add(this.btnIrFormulario2);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblForm1);
            this.Controls.Add(this.txtTextBox2);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.tBprueba);
            this.Controls.Add(this.lblPrimerEtiqueta);
            this.Controls.Add(this.btnCambioColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ventana1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unidad 1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ventana1_FormClosed);
            this.Load += new System.EventHandler(this.Ventana1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCambioColor;
        private System.Windows.Forms.Label lblPrimerEtiqueta;
        private System.Windows.Forms.TextBox tBprueba;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.TextBox txtTextBox2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnIrFormulario2;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblForm1;
        private System.Windows.Forms.Button btnFormulario3;
        private System.Windows.Forms.Button btnFormulario4;
        private System.Windows.Forms.Button btnTryCatch;
        private System.Windows.Forms.Label lblPractica4;
        private System.Windows.Forms.Label lblPactica3;
        private System.Windows.Forms.Label lblPractica2;
        private System.Windows.Forms.Button btnP8;
    }
}

