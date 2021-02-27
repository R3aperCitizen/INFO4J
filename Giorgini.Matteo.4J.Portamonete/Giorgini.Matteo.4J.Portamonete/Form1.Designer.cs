namespace Giorgini.Matteo._4J.Portamonete
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Inserisci = new System.Windows.Forms.Button();
            this.Inserisci2 = new System.Windows.Forms.Button();
            this.Denaro = new System.Windows.Forms.Button();
            this.DenaroString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Inserisci
            // 
            this.Inserisci.BackColor = System.Drawing.SystemColors.Highlight;
            this.Inserisci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inserisci.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Inserisci.Location = new System.Drawing.Point(226, 119);
            this.Inserisci.Name = "Inserisci";
            this.Inserisci.Size = new System.Drawing.Size(127, 53);
            this.Inserisci.TabIndex = 0;
            this.Inserisci.Text = "Inserisci Valore moneta";
            this.Inserisci.UseVisualStyleBackColor = false;
            this.Inserisci.Click += new System.EventHandler(this.Inserisci_Click);
            // 
            // Inserisci2
            // 
            this.Inserisci2.BackColor = System.Drawing.SystemColors.Highlight;
            this.Inserisci2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inserisci2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Inserisci2.Location = new System.Drawing.Point(445, 119);
            this.Inserisci2.Name = "Inserisci2";
            this.Inserisci2.Size = new System.Drawing.Size(130, 53);
            this.Inserisci2.TabIndex = 1;
            this.Inserisci2.Text = "Inserisci Valore e numero";
            this.Inserisci2.UseVisualStyleBackColor = false;
            this.Inserisci2.Click += new System.EventHandler(this.Inserisci2_Click);
            // 
            // Denaro
            // 
            this.Denaro.BackColor = System.Drawing.SystemColors.Highlight;
            this.Denaro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Denaro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Denaro.Location = new System.Drawing.Point(226, 228);
            this.Denaro.Name = "Denaro";
            this.Denaro.Size = new System.Drawing.Size(127, 53);
            this.Denaro.TabIndex = 2;
            this.Denaro.Text = "Totale Denaro";
            this.Denaro.UseVisualStyleBackColor = false;
            this.Denaro.Click += new System.EventHandler(this.Denaro_Click);
            // 
            // DenaroString
            // 
            this.DenaroString.BackColor = System.Drawing.SystemColors.Highlight;
            this.DenaroString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DenaroString.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DenaroString.Location = new System.Drawing.Point(445, 228);
            this.DenaroString.Name = "DenaroString";
            this.DenaroString.Size = new System.Drawing.Size(130, 53);
            this.DenaroString.TabIndex = 3;
            this.DenaroString.Text = "Visualizza Denaro per Tipo";
            this.DenaroString.UseVisualStyleBackColor = false;
            this.DenaroString.Click += new System.EventHandler(this.DenaroString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DenaroString);
            this.Controls.Add(this.Denaro);
            this.Controls.Add(this.Inserisci2);
            this.Controls.Add(this.Inserisci);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portamonete";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Inserisci;
        private System.Windows.Forms.Button Inserisci2;
        private System.Windows.Forms.Button Denaro;
        private System.Windows.Forms.Button DenaroString;
    }
}

