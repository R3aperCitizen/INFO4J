namespace Giorgini.Matteo._4J.GiocoDiCarte
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
            this.InserisciCarta1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero1 = new System.Windows.Forms.NumericUpDown();
            this.Seme1 = new System.Windows.Forms.ComboBox();
            this.Visualizza1 = new System.Windows.Forms.Button();
            this.Visualizza2 = new System.Windows.Forms.Button();
            this.Seme2 = new System.Windows.Forms.ComboBox();
            this.Numero2 = new System.Windows.Forms.NumericUpDown();
            this.InserisciCarta2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ConfrontoVince = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Numero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numero2)).BeginInit();
            this.SuspendLayout();
            // 
            // InserisciCarta1
            // 
            this.InserisciCarta1.BackColor = System.Drawing.SystemColors.Highlight;
            this.InserisciCarta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InserisciCarta1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InserisciCarta1.Location = new System.Drawing.Point(199, 195);
            this.InserisciCarta1.Name = "InserisciCarta1";
            this.InserisciCarta1.Size = new System.Drawing.Size(120, 43);
            this.InserisciCarta1.TabIndex = 0;
            this.InserisciCarta1.Text = "Inserisci Carta";
            this.InserisciCarta1.UseVisualStyleBackColor = false;
            this.InserisciCarta1.Click += new System.EventHandler(this.InserisciCarta1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(194, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carta 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(483, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carta 2";
            // 
            // Numero1
            // 
            this.Numero1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Numero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero1.ForeColor = System.Drawing.SystemColors.Info;
            this.Numero1.Location = new System.Drawing.Point(198, 96);
            this.Numero1.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.Numero1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Numero1.Name = "Numero1";
            this.Numero1.Size = new System.Drawing.Size(120, 22);
            this.Numero1.TabIndex = 4;
            this.Numero1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Seme1
            // 
            this.Seme1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Seme1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Seme1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seme1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Seme1.FormattingEnabled = true;
            this.Seme1.Items.AddRange(new object[] {
            "C",
            "Q",
            "F",
            "P"});
            this.Seme1.Location = new System.Drawing.Point(199, 150);
            this.Seme1.Name = "Seme1";
            this.Seme1.Size = new System.Drawing.Size(121, 24);
            this.Seme1.TabIndex = 5;
            // 
            // Visualizza1
            // 
            this.Visualizza1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Visualizza1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visualizza1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Visualizza1.Location = new System.Drawing.Point(198, 244);
            this.Visualizza1.Name = "Visualizza1";
            this.Visualizza1.Size = new System.Drawing.Size(121, 42);
            this.Visualizza1.TabIndex = 6;
            this.Visualizza1.Text = "Visualizza";
            this.Visualizza1.UseVisualStyleBackColor = false;
            this.Visualizza1.Click += new System.EventHandler(this.Visualizza1_Click);
            // 
            // Visualizza2
            // 
            this.Visualizza2.BackColor = System.Drawing.SystemColors.Highlight;
            this.Visualizza2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visualizza2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Visualizza2.Location = new System.Drawing.Point(487, 244);
            this.Visualizza2.Name = "Visualizza2";
            this.Visualizza2.Size = new System.Drawing.Size(121, 42);
            this.Visualizza2.TabIndex = 10;
            this.Visualizza2.Text = "Visualizza";
            this.Visualizza2.UseVisualStyleBackColor = false;
            this.Visualizza2.Click += new System.EventHandler(this.Visualizza2_Click);
            // 
            // Seme2
            // 
            this.Seme2.BackColor = System.Drawing.SystemColors.Highlight;
            this.Seme2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Seme2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seme2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Seme2.FormattingEnabled = true;
            this.Seme2.Items.AddRange(new object[] {
            "C",
            "Q",
            "F",
            "P"});
            this.Seme2.Location = new System.Drawing.Point(488, 150);
            this.Seme2.Name = "Seme2";
            this.Seme2.Size = new System.Drawing.Size(121, 24);
            this.Seme2.TabIndex = 9;
            // 
            // Numero2
            // 
            this.Numero2.BackColor = System.Drawing.SystemColors.Highlight;
            this.Numero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero2.ForeColor = System.Drawing.SystemColors.Info;
            this.Numero2.Location = new System.Drawing.Point(487, 96);
            this.Numero2.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.Numero2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Numero2.Name = "Numero2";
            this.Numero2.Size = new System.Drawing.Size(120, 22);
            this.Numero2.TabIndex = 8;
            this.Numero2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // InserisciCarta2
            // 
            this.InserisciCarta2.BackColor = System.Drawing.SystemColors.Highlight;
            this.InserisciCarta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InserisciCarta2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InserisciCarta2.Location = new System.Drawing.Point(488, 195);
            this.InserisciCarta2.Name = "InserisciCarta2";
            this.InserisciCarta2.Size = new System.Drawing.Size(120, 43);
            this.InserisciCarta2.TabIndex = 7;
            this.InserisciCarta2.Text = "Inserisci Carta";
            this.InserisciCarta2.UseVisualStyleBackColor = false;
            this.InserisciCarta2.Click += new System.EventHandler(this.InserisciCarta2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "seme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "numero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "seme";
            // 
            // ConfrontoVince
            // 
            this.ConfrontoVince.BackColor = System.Drawing.SystemColors.Highlight;
            this.ConfrontoVince.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfrontoVince.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ConfrontoVince.Location = new System.Drawing.Point(315, 316);
            this.ConfrontoVince.Name = "ConfrontoVince";
            this.ConfrontoVince.Size = new System.Drawing.Size(175, 48);
            this.ConfrontoVince.TabIndex = 15;
            this.ConfrontoVince.Text = "Vince";
            this.ConfrontoVince.UseVisualStyleBackColor = false;
            this.ConfrontoVince.Click += new System.EventHandler(this.ConfrontoVince_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfrontoVince);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Visualizza2);
            this.Controls.Add(this.Seme2);
            this.Controls.Add(this.Numero2);
            this.Controls.Add(this.InserisciCarta2);
            this.Controls.Add(this.Visualizza1);
            this.Controls.Add(this.Seme1);
            this.Controls.Add(this.Numero1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InserisciCarta1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carte";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Numero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numero2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InserisciCarta1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Numero1;
        private System.Windows.Forms.ComboBox Seme1;
        private System.Windows.Forms.Button Visualizza1;
        private System.Windows.Forms.Button Visualizza2;
        private System.Windows.Forms.ComboBox Seme2;
        private System.Windows.Forms.NumericUpDown Numero2;
        private System.Windows.Forms.Button InserisciCarta2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ConfrontoVince;
    }
}

