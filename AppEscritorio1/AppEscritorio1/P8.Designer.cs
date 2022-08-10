
namespace AppEscritorio1
{
    partial class P8
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
            this.clbElementos = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnMover = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbElementos
            // 
            this.clbElementos.CheckOnClick = true;
            this.clbElementos.FormattingEnabled = true;
            this.clbElementos.Items.AddRange(new object[] {
            "perro",
            "gato",
            "tortuga",
            "cerdo",
            "mono",
            "gallo",
            "avestruz",
            "pato",
            "gallina",
            "carpincho"});
            this.clbElementos.Location = new System.Drawing.Point(54, 54);
            this.clbElementos.Name = "clbElementos";
            this.clbElementos.Size = new System.Drawing.Size(255, 319);
            this.clbElementos.TabIndex = 0;
            this.clbElementos.SelectedIndexChanged += new System.EventHandler(this.clbElementos_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(468, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(275, 329);
            this.listBox1.TabIndex = 1;
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(353, 131);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(75, 23);
            this.btnMover.TabIndex = 2;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(353, 267);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // P8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.clbElementos);
            this.Name = "P8";
            this.Text = "P8";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbElementos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Button btnCancelar;
    }
}