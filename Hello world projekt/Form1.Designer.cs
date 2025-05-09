namespace Hello_world_projekt
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.guzik = new System.Windows.Forms.Button();
            this.Hello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guzik
            // 
            this.guzik.Location = new System.Drawing.Point(265, 191);
            this.guzik.Name = "guzik";
            this.guzik.Size = new System.Drawing.Size(282, 67);
            this.guzik.TabIndex = 0;
            this.guzik.Text = "Kliknij";
            this.guzik.UseVisualStyleBackColor = true;
            this.guzik.Click += new System.EventHandler(this.guzik_Click);
            // 
            // Hello
            // 
            this.Hello.AutoSize = true;
            this.Hello.Location = new System.Drawing.Point(359, 279);
            this.Hello.Name = "Hello";
            this.Hello.Size = new System.Drawing.Size(0, 16);
            this.Hello.TabIndex = 1;
            this.Hello.Click += new System.EventHandler(this.Hello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hello);
            this.Controls.Add(this.guzik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guzik;
        private System.Windows.Forms.Label Hello;
    }
}

