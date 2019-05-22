namespace OverrloadingCards
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
            this.deckBox1 = new System.Windows.Forms.ListBox();
            this.deckBox2 = new System.Windows.Forms.ListBox();
            this.moveToDeckBox2 = new System.Windows.Forms.Button();
            this.moveToDeckBox1 = new System.Windows.Forms.Button();
            this.resetBox1 = new System.Windows.Forms.Button();
            this.resetBox2 = new System.Windows.Forms.Button();
            this.mixDeck2 = new System.Windows.Forms.Button();
            this.mixDeck1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deckBox1
            // 
            this.deckBox1.FormattingEnabled = true;
            this.deckBox1.Location = new System.Drawing.Point(12, 12);
            this.deckBox1.Name = "deckBox1";
            this.deckBox1.Size = new System.Drawing.Size(123, 251);
            this.deckBox1.TabIndex = 0;
            this.deckBox1.SelectedIndexChanged += new System.EventHandler(this.DeckBox1_SelectedIndexChanged);
            // 
            // deckBox2
            // 
            this.deckBox2.FormattingEnabled = true;
            this.deckBox2.Location = new System.Drawing.Point(228, 12);
            this.deckBox2.Name = "deckBox2";
            this.deckBox2.Size = new System.Drawing.Size(123, 251);
            this.deckBox2.TabIndex = 1;
            // 
            // moveToDeckBox2
            // 
            this.moveToDeckBox2.Location = new System.Drawing.Point(147, 90);
            this.moveToDeckBox2.Name = "moveToDeckBox2";
            this.moveToDeckBox2.Size = new System.Drawing.Size(75, 23);
            this.moveToDeckBox2.TabIndex = 2;
            this.moveToDeckBox2.Text = ">>>>";
            this.moveToDeckBox2.UseVisualStyleBackColor = true;
            this.moveToDeckBox2.Click += new System.EventHandler(this.MoveToDeckBox2_Click);
            // 
            // moveToDeckBox1
            // 
            this.moveToDeckBox1.Location = new System.Drawing.Point(147, 132);
            this.moveToDeckBox1.Name = "moveToDeckBox1";
            this.moveToDeckBox1.Size = new System.Drawing.Size(75, 23);
            this.moveToDeckBox1.TabIndex = 3;
            this.moveToDeckBox1.Text = "<<<<";
            this.moveToDeckBox1.UseVisualStyleBackColor = true;
            this.moveToDeckBox1.Click += new System.EventHandler(this.MoveToDeckBox1_Click);
            // 
            // resetBox1
            // 
            this.resetBox1.Location = new System.Drawing.Point(12, 284);
            this.resetBox1.Name = "resetBox1";
            this.resetBox1.Size = new System.Drawing.Size(123, 23);
            this.resetBox1.TabIndex = 4;
            this.resetBox1.Text = "Przywroc zestaw 1";
            this.resetBox1.UseVisualStyleBackColor = true;
            this.resetBox1.Click += new System.EventHandler(this.ResetBox1_Click);
            // 
            // resetBox2
            // 
            this.resetBox2.Location = new System.Drawing.Point(228, 284);
            this.resetBox2.Name = "resetBox2";
            this.resetBox2.Size = new System.Drawing.Size(123, 23);
            this.resetBox2.TabIndex = 5;
            this.resetBox2.Text = "Przywroc zestaw 2";
            this.resetBox2.UseVisualStyleBackColor = true;
            this.resetBox2.Click += new System.EventHandler(this.ResetBox2_Click);
            // 
            // mixDeck2
            // 
            this.mixDeck2.Location = new System.Drawing.Point(228, 322);
            this.mixDeck2.Name = "mixDeck2";
            this.mixDeck2.Size = new System.Drawing.Size(123, 23);
            this.mixDeck2.TabIndex = 7;
            this.mixDeck2.Text = "Wymieszaj zestaw 2";
            this.mixDeck2.UseVisualStyleBackColor = true;
            this.mixDeck2.Click += new System.EventHandler(this.MixDeck2_Click);
            // 
            // mixDeck1
            // 
            this.mixDeck1.Location = new System.Drawing.Point(12, 322);
            this.mixDeck1.Name = "mixDeck1";
            this.mixDeck1.Size = new System.Drawing.Size(123, 23);
            this.mixDeck1.TabIndex = 6;
            this.mixDeck1.Text = "Wymieszaj zestaw 1";
            this.mixDeck1.UseVisualStyleBackColor = true;
            this.mixDeck1.Click += new System.EventHandler(this.MixDeck1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 406);
            this.Controls.Add(this.mixDeck2);
            this.Controls.Add(this.mixDeck1);
            this.Controls.Add(this.resetBox2);
            this.Controls.Add(this.resetBox1);
            this.Controls.Add(this.moveToDeckBox1);
            this.Controls.Add(this.moveToDeckBox2);
            this.Controls.Add(this.deckBox2);
            this.Controls.Add(this.deckBox1);
            this.Name = "Form1";
            this.Text = "Dwie Talie !";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox deckBox1;
        private System.Windows.Forms.ListBox deckBox2;
        private System.Windows.Forms.Button moveToDeckBox2;
        private System.Windows.Forms.Button moveToDeckBox1;
        private System.Windows.Forms.Button resetBox1;
        private System.Windows.Forms.Button resetBox2;
        private System.Windows.Forms.Button mixDeck2;
        private System.Windows.Forms.Button mixDeck1;
    }
}

