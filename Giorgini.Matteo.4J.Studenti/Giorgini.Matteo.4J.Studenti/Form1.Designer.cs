namespace Giorgini.Matteo._4J.Studenti
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.names = new System.Windows.Forms.ListBox();
            this.surnames = new System.Windows.Forms.ListBox();
            this.listaassenze = new System.Windows.Forms.ListBox();
            this.listavoti = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listamedia = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(580, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Carica";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(580, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Aggiungi Assenza";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // names
            // 
            this.names.BackColor = System.Drawing.SystemColors.HotTrack;
            this.names.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.names.FormattingEnabled = true;
            this.names.Location = new System.Drawing.Point(0, 13);
            this.names.Name = "names";
            this.names.Size = new System.Drawing.Size(97, 433);
            this.names.TabIndex = 2;
            // 
            // surnames
            // 
            this.surnames.BackColor = System.Drawing.SystemColors.HotTrack;
            this.surnames.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.surnames.FormattingEnabled = true;
            this.surnames.Location = new System.Drawing.Point(103, 13);
            this.surnames.Name = "surnames";
            this.surnames.Size = new System.Drawing.Size(99, 433);
            this.surnames.TabIndex = 3;
            // 
            // listaassenze
            // 
            this.listaassenze.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listaassenze.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.listaassenze.FormattingEnabled = true;
            this.listaassenze.Location = new System.Drawing.Point(208, 13);
            this.listaassenze.Name = "listaassenze";
            this.listaassenze.Size = new System.Drawing.Size(101, 433);
            this.listaassenze.TabIndex = 4;
            // 
            // listavoti
            // 
            this.listavoti.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listavoti.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.listavoti.FormattingEnabled = true;
            this.listavoti.Location = new System.Drawing.Point(315, 13);
            this.listavoti.Name = "listavoti";
            this.listavoti.Size = new System.Drawing.Size(95, 433);
            this.listavoti.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(580, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 59);
            this.button3.TabIndex = 6;
            this.button3.Text = "Carica Voti";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listamedia
            // 
            this.listamedia.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listamedia.ForeColor = System.Drawing.SystemColors.Menu;
            this.listamedia.FormattingEnabled = true;
            this.listamedia.Location = new System.Drawing.Point(416, 13);
            this.listamedia.Name = "listamedia";
            this.listamedia.Size = new System.Drawing.Size(95, 433);
            this.listamedia.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "NOMI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(103, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "COGNOMI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(208, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "ASSENZE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(312, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "VOTI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(413, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "MEDIE VOTI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listamedia);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listavoti);
            this.Controls.Add(this.listaassenze);
            this.Controls.Add(this.surnames);
            this.Controls.Add(this.names);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Studente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox names;
        private System.Windows.Forms.ListBox surnames;
        private System.Windows.Forms.ListBox listaassenze;
        private System.Windows.Forms.ListBox listavoti;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listamedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

