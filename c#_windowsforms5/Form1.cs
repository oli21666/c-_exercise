
using System;
using System.Drawing;
using System.Windows.Forms;

namespace c__windowsforms5
{
    public partial class Form1 : Form
    {
        private Panel panelKoloru;
        private TrackBar suwakR;
        private TrackBar suwakG;
        private TrackBar suwakB;
        private Label wartoscR;
        private Label wartoscG;
        private Label wartoscB;
        private Button przyciskPobierz;
        private Label pobranyKolor;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StworzInterfejs();
        }

        private void StworzInterfejs()
        {
            this.Text = "Wzornik kolorów RGB.;
            this.ClientSize = new Size(430, 290);
            this.BackColor = Color.Cornsilk;

            panelKoloru = new Panel();
            panelKoloru.Location = new Point(20, 20);
            panelKoloru.Size = new Size(380, 40);
            panelKoloru.BackColor = Color.White;
            Controls.Add(panelKoloru);

            Label opis = new Label();
            opis.Text = "Dobierz kolor suwakami i zapisz przyciskiem:";
            opis.Location = new Point(20, 75);
            opis.AutoSize = true;
            Controls.Add(opis);

            DodajEtykiete("R", 25, 110);
            DodajEtykiete("G", 25, 155);
            DodajEtykiete("B", 25, 200);

            suwakR = DodajSuwak(50, 100);
            suwakG = DodajSuwak(50, 145);
            suwakB = DodajSuwak(50, 190);

            wartoscR = DodajWartosc(390, 110);
            wartoscG = DodajWartosc(390, 155);
            wartoscB = DodajWartosc(390, 200);

            suwakR.ValueChanged += ZmienKolor;
            suwakG.ValueChanged += ZmienKolor;
            suwakB.ValueChanged += ZmienKolor;

            przyciskPobierz = new Button();
            przyciskPobierz.Text = "Pobierz";
            przyciskPobierz.Location = new Point(160, 230);
            przyciskPobierz.Size = new Size(110, 30);
            przyciskPobierz.BackColor = Color.Peru;
            przyciskPobierz.Click += PobierzKolor;
            Controls.Add(przyciskPobierz);

            pobranyKolor = new Label();
            pobranyKolor.Text = "255, 255, 255";
            pobranyKolor.Location = new Point(160, 265);
            pobranyKolor.Size = new Size(110, 20);
            pobranyKolor.BackColor = Color.White;
            Controls.Add(pobranyKolor);

            ZmienKolor(null, EventArgs.Empty);
        }

        private void DodajEtykiete(string tekst, int x, int y)
        {
            Label etykieta = new Label();
            etykieta.Text = tekst;
            etykieta.Location = new Point(x, y);
            etykieta.AutoSize = true;
            Controls.Add(etykieta);
        }

        private TrackBar DodajSuwak(int x, int y)
        {
            TrackBar suwak = new TrackBar();
            suwak.Location = new Point(x, y);
            suwak.Size = new Size(330, 35);
            suwak.Minimum = 0;
            suwak.Maximum = 255;
            suwak.Value = 255;
            suwak.TickStyle = TickStyle.None;
            Controls.Add(suwak);
            return suwak;
        }

        private Label DodajWartosc(int x, int y)
        {
            Label etykieta = new Label();
            etykieta.Location = new Point(x, y);
            etykieta.Size = new Size(35, 20);
            Controls.Add(etykieta);
            return etykieta;
        }

        private void ZmienKolor(object sender, EventArgs e)
        {
            int r = suwakR.Value;
            int g = suwakG.Value;
            int b = suwakB.Value;

            wartoscR.Text = r.ToString();
            wartoscG.Text = g.ToString();
            wartoscB.Text = b.ToString();

            panelKoloru.BackColor = Color.FromArgb(r, g, b);
        }

        private void PobierzKolor(object sender, EventArgs e)
        {
            int r = suwakR.Value;
            int g = suwakG.Value;
            int b = suwakB.Value;

            pobranyKolor.BackColor = Color.FromArgb(r, g, b);
            pobranyKolor.Text = r + ", " + g + ", " + b;
        }
    }
}
