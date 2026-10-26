namespace c__windowsforms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            parzysta_gb = new GroupBox();
            dzielniki_gb = new GroupBox();
            silnia_gb = new GroupBox();
            czypierwsza_gb = new GroupBox();
            liczba = new NumericUpDown();
            oblicz = new Button();
            ((System.ComponentModel.ISupportInitialize)liczba).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-2, 1);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Podaj liczbę dodatnią:";
            label1.Click += label1_Click;
            // 
            // parzysta_gb
            // 
            parzysta_gb.Location = new Point(12, 47);
            parzysta_gb.Name = "parzysta_gb";
            parzysta_gb.Size = new Size(72, 324);
            parzysta_gb.TabIndex = 1;
            parzysta_gb.TabStop = false;
            parzysta_gb.Text = "Parzysta?";
            // 
            // dzielniki_gb
            // 
            dzielniki_gb.Location = new Point(118, 47);
            dzielniki_gb.Name = "dzielniki_gb";
            dzielniki_gb.Size = new Size(67, 324);
            dzielniki_gb.TabIndex = 2;
            dzielniki_gb.TabStop = false;
            dzielniki_gb.Text = "Dzielniki";
            // 
            // silnia_gb
            // 
            silnia_gb.Location = new Point(230, 47);
            silnia_gb.Name = "silnia_gb";
            silnia_gb.Size = new Size(75, 324);
            silnia_gb.TabIndex = 3;
            silnia_gb.TabStop = false;
            silnia_gb.Text = "Silnia";
            // 
            // czypierwsza_gb
            // 
            czypierwsza_gb.Location = new Point(330, 47);
            czypierwsza_gb.Name = "czypierwsza_gb";
            czypierwsza_gb.Size = new Size(75, 324);
            czypierwsza_gb.TabIndex = 4;
            czypierwsza_gb.TabStop = false;
            czypierwsza_gb.Text = "Czy pierwsza?";
            // 
            // liczba
            // 
            liczba.Location = new Point(135, 0);
            liczba.Name = "liczba";
            liczba.Size = new Size(120, 23);
            liczba.TabIndex = 5;
            // 
            // oblicz
            // 
            oblicz.Location = new Point(276, 1);
            oblicz.Name = "oblicz";
            oblicz.Size = new Size(75, 23);
            oblicz.TabIndex = 6;
            oblicz.Text = "Oblicz";
            oblicz.UseVisualStyleBackColor = true;
            oblicz.Click += oblicz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 383);
            Controls.Add(oblicz);
            Controls.Add(liczba);
            Controls.Add(czypierwsza_gb);
            Controls.Add(silnia_gb);
            Controls.Add(dzielniki_gb);
            Controls.Add(parzysta_gb);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)liczba).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox parzysta_gb;
        private GroupBox dzielniki_gb;
        private GroupBox silnia_gb;
        private GroupBox czypierwsza_gb;
        private NumericUpDown liczba;
        private Button oblicz;
    }
}
