
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Label lblTekst;
        Panel panelTekstu;
        GroupBox groupKolor;
        Button btnRed, btnGreen, btnBlue;
        NumericUpDown numericFont;
        TrackBar trackFont;
        Button btnMniejszy, btnWiekszy;
        ComboBox comboTlo;

        public Form1()
        {
            InitializeComponent();
            UtworzInterfejs();
        }

        private void UtworzInterfejs()
        {
            this.Text = "Zmiana wyglądu tekstu";
            this.Size = new Size(850, 550);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Napis Tekst
            lblTekst = new Label();
            lblTekst.Text = "Tekst";
            lblTekst.Location = new Point(20, 20);
            lblTekst.AutoSize = true;
            this.Controls.Add(lblTekst);

            // Panel z tekstem
            panelTekstu = new Panel();
            panelTekstu.Location = new Point(20, 45);
            panelTekstu.Size = new Size(400, 105);
            panelTekstu.BackColor = Color.Moccasin;
            this.Controls.Add(panelTekstu);

            Label przykladowyTekst = new Label();
            przykladowyTekst.Text = "Przykładowy tekst";
            przykladowyTekst.Location = new Point(20, 30);
            przykladowyTekst.AutoSize = true;
            przykladowyTekst.Font = new Font("Arial", 15);
            przykladowyTekst.ForeColor = Color.Blue;
            panelTekstu.Controls.Add(przykladowyTekst);

            // Grupa wyboru koloru tekstu
            groupKolor = new GroupBox();
            groupKolor.Text = "Kolor tekstu";
            groupKolor.Location = new Point(430, 10);
            groupKolor.Size = new Size(130, 175);
            this.Controls.Add(groupKolor);

            btnRed = new Button();
            btnRed.Text = "red";
            btnRed.Location = new Point(25, 30);
            btnRed.Size = new Size(75, 30);
            btnRed.Click += (s, e) => ZmienKolor(Color.Red);
            groupKolor.Controls.Add(btnRed);

            btnGreen = new Button();
            btnGreen.Text = "green";
            btnGreen.Location = new Point(25, 75);
            btnGreen.Size = new Size(75, 30);
            btnGreen.Click += (s, e) => ZmienKolor(Color.Green);
            groupKolor.Controls.Add(btnGreen);

            btnBlue = new Button();
            btnBlue.Text = "blue";
            btnBlue.Location = new Point(25, 120);
            btnBlue.Size = new Size(75, 30);
            btnBlue.Click += (s, e) => ZmienKolor(Color.Blue);
            groupKolor.Controls.Add(btnBlue);

            // Wielkość tekstu
            Label lblWielkosc = new Label();
            lblWielkosc.Text = "Wielkość tekstu ";
            lblWielkosc.Location = new Point(20, 175);
            lblWielkosc.AutoSize = true;
            this.Controls.Add(lblWielkosc);

            numericFont = new NumericUpDown();
            numericFont.Location = new Point(130, 175);
            numericFont.Minimum = 10;
            numericFont.Maximum = 20;
            numericFont.Value = 15;
            numericFont.Size = new Size(80, 25);
            numericFont.ValueChanged += (s, e) =>
            {
                trackFont.Value = (int)numericFont.Value;
                ZmienRozmiar();
            };
            this.Controls.Add(numericFont);

            // Suwak
            trackFont = new TrackBar();
            trackFont.Location = new Point(80, 220);
            trackFont.Size = new Size(190, 45);
            trackFont.Minimum = 10;
            trackFont.Maximum = 20;
            trackFont.Value = 15;
            trackFont.TickFrequency = 1;
            trackFont.Scroll += (s, e) =>
            {
                numericFont.Value = trackFont.Value;
                ZmienRozmiar();
            };
            this.Controls.Add(trackFont);

            // Przycisk zmniejszania
            btnMniejszy = new Button();
            btnMniejszy.Text = "<<";
            btnMniejszy.Location = new Point(110, 290);
            btnMniejszy.Size = new Size(60, 25);
            btnMniejszy.Click += (s, e) =>
            {
                if (numericFont.Value > numericFont.Minimum)
                    numericFont.Value--;
            };
            this.Controls.Add(btnMniejszy);

            // Przycisk powiększania
            btnWiekszy = new Button();
            btnWiekszy.Text = ">>";
            btnWiekszy.Location = new Point(210, 290);
            btnWiekszy.Size = new Size(60, 25);
            btnWiekszy.Click += (s, e) =>
            {
                if (numericFont.Value < numericFont.Maximum)
                    numericFont.Value++;
            };
            this.Controls.Add(btnWiekszy);

            // Kolor tła
            Label lblTlo = new Label();
            lblTlo.Text = "Kolor tła";
            lblTlo.Location = new Point(460, 220);
            lblTlo.AutoSize = true;
            this.Controls.Add(lblTlo);

            comboTlo = new ComboBox();
            comboTlo.Location = new Point(445, 250);
            comboTlo.Size = new Size(120, 25);
            comboTlo.DropDownStyle = ComboBoxStyle.DropDownList;

            comboTlo.Items.AddRange(new string[]
            {
                "Moccasin",
                "White",
                "Yellow",
                "Green",
                "Red",
                "Blue",
                "Pink",
                "LightBlue",
                "Gray"
            });

            comboTlo.SelectedIndex = 0;

            comboTlo.SelectedIndexChanged += (s, e) =>
            {
                panelTekstu.BackColor =
                    Color.FromName(comboTlo.SelectedItem.ToString());
            };

            this.Controls.Add(comboTlo);
        }

        // Zmiana koloru tekstu
        private void ZmienKolor(Color kolor)
        {
            panelTekstu.Controls[0].ForeColor = kolor;
        }

        // Zmiana wielkości tekstu
        private void ZmienRozmiar()
        {
            Label tekst = (Label)panelTekstu.Controls[0];

            tekst.Font = new Font(
                tekst.Font.FontFamily,
                (float)numericFont.Value
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
