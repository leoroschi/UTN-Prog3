
namespace AppEscritorio1
{
    partial class MasControles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbox = new System.Windows.Forms.GroupBox();
            this.rbtnMujer = new System.Windows.Forms.RadioButton();
            this.rbtnHombre = new System.Windows.Forms.RadioButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboxProgramador = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox
            // 
            this.gbox.Controls.Add(this.rbtnMujer);
            this.gbox.Controls.Add(this.rbtnHombre);
            this.gbox.ForeColor = System.Drawing.Color.Red;
            this.gbox.Location = new System.Drawing.Point(32, 172);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(535, 62);
            this.gbox.TabIndex = 0;
            this.gbox.TabStop = false;
            this.gbox.Text = "Sexo";
            // 
            // rbtnMujer
            // 
            this.rbtnMujer.AutoSize = true;
            this.rbtnMujer.ForeColor = System.Drawing.Color.Black;
            this.rbtnMujer.Location = new System.Drawing.Point(308, 31);
            this.rbtnMujer.Name = "rbtnMujer";
            this.rbtnMujer.Size = new System.Drawing.Size(51, 17);
            this.rbtnMujer.TabIndex = 1;
            this.rbtnMujer.Text = "Mujer";
            this.rbtnMujer.UseVisualStyleBackColor = true;
            // 
            // rbtnHombre
            // 
            this.rbtnHombre.AutoSize = true;
            this.rbtnHombre.Checked = true;
            this.rbtnHombre.ForeColor = System.Drawing.Color.Black;
            this.rbtnHombre.Location = new System.Drawing.Point(101, 31);
            this.rbtnHombre.Name = "rbtnHombre";
            this.rbtnHombre.Size = new System.Drawing.Size(62, 17);
            this.rbtnHombre.TabIndex = 0;
            this.rbtnHombre.TabStop = true;
            this.rbtnHombre.Text = "Hombre";
            this.rbtnHombre.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(29, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 20);
            this.textBox1.TabIndex = 2;
            // 
            // cboxProgramador
            // 
            this.cboxProgramador.AutoSize = true;
            this.cboxProgramador.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboxProgramador.Checked = true;
            this.cboxProgramador.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxProgramador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxProgramador.Location = new System.Drawing.Point(32, 111);
            this.cboxProgramador.Name = "cboxProgramador";
            this.cboxProgramador.Size = new System.Drawing.Size(107, 20);
            this.cboxProgramador.TabIndex = 3;
            this.cboxProgramador.Text = "Programador";
            this.cboxProgramador.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(588, 50);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(111, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 274);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(535, 179);
            this.textBox2.TabIndex = 5;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.Location = new System.Drawing.Point(29, 249);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(47, 16);
            this.lblSalida.TabIndex = 6;
            this.lblSalida.Text = "Salida";
            // 
            // MasControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(720, 484);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cboxProgramador);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.gbox);
            this.Name = "MasControles";
            this.Text = "RadioButton y CheckBox";
            this.gbox.ResumeLayout(false);
            this.gbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox;
        private System.Windows.Forms.RadioButton rbtnMujer;
        private System.Windows.Forms.RadioButton rbtnHombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cboxProgramador;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSalida;
    }
}