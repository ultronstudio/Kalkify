namespace Uloha2
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tboxCisloPrvni = new System.Windows.Forms.TextBox();
            this.lblCisloPrvni = new System.Windows.Forms.Label();
            this.tboxCisloDruhe = new System.Windows.Forms.TextBox();
            this.cboxZnamenko = new System.Windows.Forms.ComboBox();
            this.lblZnamenko = new System.Windows.Forms.Label();
            this.lblCisloDruhe = new System.Windows.Forms.Label();
            this.lblRovnitko = new System.Windows.Forms.Label();
            this.lblVysledek = new System.Windows.Forms.Label();
            this.btnPocitej = new System.Windows.Forms.Button();
            this.chboxZlomky = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tboxCisloPrvni
            // 
            this.tboxCisloPrvni.Location = new System.Drawing.Point(12, 25);
            this.tboxCisloPrvni.Name = "tboxCisloPrvni";
            this.tboxCisloPrvni.Size = new System.Drawing.Size(100, 20);
            this.tboxCisloPrvni.TabIndex = 0;
            // 
            // lblCisloPrvni
            // 
            this.lblCisloPrvni.Location = new System.Drawing.Point(12, 9);
            this.lblCisloPrvni.Name = "lblCisloPrvni";
            this.lblCisloPrvni.Size = new System.Drawing.Size(97, 13);
            this.lblCisloPrvni.TabIndex = 1;
            this.lblCisloPrvni.Text = "První číslo:";
            // 
            // tboxCisloDruhe
            // 
            this.tboxCisloDruhe.Location = new System.Drawing.Point(176, 25);
            this.tboxCisloDruhe.Name = "tboxCisloDruhe";
            this.tboxCisloDruhe.Size = new System.Drawing.Size(100, 20);
            this.tboxCisloDruhe.TabIndex = 3;
            // 
            // cboxZnamenko
            // 
            this.cboxZnamenko.AutoCompleteCustomSource.AddRange(new string[] {
            "+",
            "-",
            "*",
            "/"});
            this.cboxZnamenko.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxZnamenko.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboxZnamenko.FormattingEnabled = true;
            this.cboxZnamenko.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cboxZnamenko.Location = new System.Drawing.Point(118, 24);
            this.cboxZnamenko.Name = "cboxZnamenko";
            this.cboxZnamenko.Size = new System.Drawing.Size(52, 21);
            this.cboxZnamenko.TabIndex = 2;
            // 
            // lblZnamenko
            // 
            this.lblZnamenko.Location = new System.Drawing.Point(115, 8);
            this.lblZnamenko.Name = "lblZnamenko";
            this.lblZnamenko.Size = new System.Drawing.Size(55, 13);
            this.lblZnamenko.TabIndex = 4;
            this.lblZnamenko.Text = "Operace:";
            // 
            // lblCisloDruhe
            // 
            this.lblCisloDruhe.Location = new System.Drawing.Point(176, 9);
            this.lblCisloDruhe.Name = "lblCisloDruhe";
            this.lblCisloDruhe.Size = new System.Drawing.Size(100, 13);
            this.lblCisloDruhe.TabIndex = 5;
            this.lblCisloDruhe.Text = "Druhé číslo:";
            // 
            // lblRovnitko
            // 
            this.lblRovnitko.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRovnitko.Location = new System.Drawing.Point(282, 24);
            this.lblRovnitko.Name = "lblRovnitko";
            this.lblRovnitko.Size = new System.Drawing.Size(20, 21);
            this.lblRovnitko.TabIndex = 6;
            this.lblRovnitko.Text = "=";
            this.lblRovnitko.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVysledek
            // 
            this.lblVysledek.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVysledek.Location = new System.Drawing.Point(308, 18);
            this.lblVysledek.Name = "lblVysledek";
            this.lblVysledek.Size = new System.Drawing.Size(294, 31);
            this.lblVysledek.TabIndex = 7;
            this.lblVysledek.Text = "0";
            this.lblVysledek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPocitej
            // 
            this.btnPocitej.Location = new System.Drawing.Point(608, 12);
            this.btnPocitej.Name = "btnPocitej";
            this.btnPocitej.Size = new System.Drawing.Size(75, 23);
            this.btnPocitej.TabIndex = 4;
            this.btnPocitej.Text = "Počítej!";
            this.btnPocitej.UseVisualStyleBackColor = true;
            this.btnPocitej.Click += new System.EventHandler(this.btnPocitej_Click);
            // 
            // chboxZlomky
            // 
            this.chboxZlomky.AutoSize = true;
            this.chboxZlomky.Location = new System.Drawing.Point(12, 51);
            this.chboxZlomky.Name = "chboxZlomky";
            this.chboxZlomky.Size = new System.Drawing.Size(133, 17);
            this.chboxZlomky.TabIndex = 8;
            this.chboxZlomky.Text = "Chci počítat se zlomky";
            this.chboxZlomky.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 284);
            this.Controls.Add(this.chboxZlomky);
            this.Controls.Add(this.btnPocitej);
            this.Controls.Add(this.lblVysledek);
            this.Controls.Add(this.lblRovnitko);
            this.Controls.Add(this.lblCisloDruhe);
            this.Controls.Add(this.lblZnamenko);
            this.Controls.Add(this.cboxZnamenko);
            this.Controls.Add(this.tboxCisloDruhe);
            this.Controls.Add(this.lblCisloPrvni);
            this.Controls.Add(this.tboxCisloPrvni);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxCisloPrvni;
        private System.Windows.Forms.Label lblCisloPrvni;
        private System.Windows.Forms.TextBox tboxCisloDruhe;
        private System.Windows.Forms.ComboBox cboxZnamenko;
        private System.Windows.Forms.Label lblZnamenko;
        private System.Windows.Forms.Label lblCisloDruhe;
        private System.Windows.Forms.Label lblRovnitko;
        private System.Windows.Forms.Label lblVysledek;
        private System.Windows.Forms.Button btnPocitej;
        private System.Windows.Forms.CheckBox chboxZlomky;
    }
}

