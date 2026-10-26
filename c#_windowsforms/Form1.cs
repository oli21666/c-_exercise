using System;
using System.Numerics;
using System.Windows.Forms;

namespace c__windowsforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            oblicz.Click += Oblicz;
        }

        private void Oblicz(object sender, EventArgs e)
        {
            int liczbaDoSprawdzenia = (int)liczba.Value;

            if (liczbaDoSprawdzenia % 2 == 0)
            {
                parzysta_gb.Text = "Parzysta? Tak";
            }
            else
            {
                parzysta_gb.Text = "Parzysta? Nie";
            }

            string dzielniki = "";

            for (int i = 1; i <= liczbaDoSprawdzenia; i++)
            {
                if (liczbaDoSprawdzenia % i == 0)
                {
                    dzielniki = dzielniki + i + " ";
                }
            }

            dzielniki_gb.Text = "Dzielniki: " + dzielniki;

            int silnia = 1;

            for (int i = 1; i <= liczbaDoSprawdzenia; i++)
            {
                silnia = silnia * i;
            }

            silnia_gb.Text = "Silnia: " + silnia;

            bool czyJestPierwsza = true;

            if (liczbaDoSprawdzenia < 2)
            {
                czyJestPierwsza = false;
            }
            else
            {
                for (int i = 2; i < liczbaDoSprawdzenia; i++)
                {
                    if (liczbaDoSprawdzenia % i == 0)
                    {
                        czyJestPierwsza = false;
                    }
                }
            }

            if (czyJestPierwsza == true)
            {
                czypierwsza_gb.Text = "Czy pierwsza? Tak";
            }
            else
            {
                czypierwsza_gb.Text = "Czy pierwsza? Nie";
            }
        }
    }
}