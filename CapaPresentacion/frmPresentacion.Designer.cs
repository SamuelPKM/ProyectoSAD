namespace CapaPresentacion
{
    partial class frmPresentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresentacion));
            this.btAbout = new System.Windows.Forms.Button();
            this.btEntrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAbout
            // 
            this.btAbout.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAbout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAbout.Location = new System.Drawing.Point(24, 518);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(143, 148);
            this.btAbout.TabIndex = 0;
            this.btAbout.Text = "Acerca De: Nosotros";
            this.btAbout.UseVisualStyleBackColor = false;
            this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
            // 
            // btEntrar
            // 
            this.btEntrar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btEntrar.Location = new System.Drawing.Point(571, 518);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(206, 142);
            this.btEntrar.TabIndex = 1;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1134, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 148);
            this.button1.TabIndex = 2;
            this.button1.Text = "Acerca De: Programa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPresentacion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1334, 680);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.btAbout);
            this.Name = "frmPresentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProyectoSAD";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAbout;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.Button button1;
    }
}

