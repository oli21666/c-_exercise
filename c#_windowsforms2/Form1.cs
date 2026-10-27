
using System;
using System.Drawing;
using System.Windows.Forms;

namespace c__windowsforms2
{
    public partial class Form1 : Form
    {
        private Random losuj = new Random();

        private int[] a = new int[4];
        private int[] b = new int[4];

        private string[] znaki = { "+", "-", "*", "/" };

        private Label[] dzialania = new Label[4];
        private NumericUpDown[] odpowiedzi = new NumericUpDown[4];
        private Label[] komunikaty = new Label[4];

        public Form1()
        {
            InitializeComponent();

            Text = "Działania";
            ClientSize = new Size(600, 400);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            Controls.Clear();

            Label naglowek = new Label();
            naglowek.Text = "Wpisz wyniki działań:";
            naglowek.Location = new Point(30, 20);
            naglowek.Size = new Size(300, 30);
            naglowek.Font = new Font("Arial", 12);
            Controls.Add(naglowek);

            for (int i = 0; i < 4; i++)
            {
                dzialania[i] = new Label();
                dzialania[i].Location = new Point(50, 70 + i * 50);
                dzialania[i].Size = new Size(130, 30);
                dzialania[i].Font = new Font("Arial", 12);
                Controls.Add(dzialania[i]);

                odpowiedzi[i] = new NumericUpDown();
                odpowiedzi[i].Location = new Point(200, 68 + i * 50);
                odpowiedzi[i].Size = new Size(100, 30);
                odpowiedzi[i].Minimum = 0;
                odpowiedzi[i].Maximum = 100000;
                odpowiedzi[i].DecimalPlaces = 2;
                Controls.Add(odpowiedzi[i]);

                komunikaty[i] = new Label();
                komunikaty[i].Location = new Point(330, 70 + i * 50);
                komunikaty[i].Size = new Size(100, 30);
                komunikaty[i].Font = new Font("Arial", 11);
                Controls.Add(komunikaty[i]);
            }

            Button sprawdz = new Button();
            sprawdz.Text = "Sprawdź";
            sprawdz.Location = new Point(150, 290);
            sprawdz.Size = new Size(110, 35);
            sprawdz.Click += Sprawdz_Click;
            Controls.Add(sprawdz);

            Button uruchom = new Button();
            uruchom.Text = "Uruchom";
            uruchom.Location = new Point(280, 290);
            uruchom.Size = new Size(110, 35);
            uruchom.Click += Uruchom_Click;
            Controls.Add(uruchom);

            LosujDzialania();
        }

        private void LosujDzialania()
        {
            for (int i = 0; i < 4; i++)
            {
                switch (znaki[i])
                {
                    case "+":
                        a[i] = losuj.Next(1, 51);
                        b[i] = losuj.Next(1, 51);
                        break;

                    case "-":
                        a[i] = losuj.Next(1, 51);
                        b[i] = losuj.Next(1, 51);

                        if (a[i] < b[i])
                        {
                            int temp = a[i];
                            a[i] = b[i];
                            b[i] = temp;
                        }
                        break;

                    case "*":
                        a[i] = losuj.Next(1, 11);
                        b[i] = losuj.Next(1, 11);
                        break;

                    case "/":
                        b[i] = losuj.Next(1, 11);
                        a[i] = b[i] * losuj.Next(1, 11);
                        break;
                }

                dzialania[i].Text =
                    $"{a[i]}  {znaki[i]}  {b[i]}";

                odpowiedzi[i].Value = 0;
                komunikaty[i].Text = "";
            }
        }

        private void Sprawdz_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                decimal wynik = 0;

                switch (znaki[i])
                {
                    case "+":
                        wynik = a[i] + b[i];
                        break;

                    case "-":
                        wynik = a[i] - b[i];
                        break;

                    case "*":
                        wynik = a[i] * b[i];
                        break;

                    case "/":
                        wynik = a[i] / b[i];
                        break;
                }

                if (odpowiedzi[i].Value == wynik)
                {
                    komunikaty[i].Text = "Dobrze!";
                    komunikaty[i].ForeColor = Color.Green;
                }
                else
                {
                    komunikaty[i].Text = "Źle!";
                    komunikaty[i].ForeColor = Color.Red;
                }
            }
        }

        private void Uruchom_Click(object sender, EventArgs e)
        {
            LosujDzialania();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
