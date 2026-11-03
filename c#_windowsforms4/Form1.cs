
using System;
using System.Drawing;
using System.Windows.Forms;

namespace c__windowsforms4
{
    public partial class Form1 : Form
    {
        TextBox txtImie;
        TextBox txtNazwisko;
        ComboBox cmbWyksztalcenie;
        RadioButton rbKobieta;
        RadioButton rbMezczyzna;
        CheckedListBox clbJezyki;
        Button btnPotwierdz;
        Label lblWynik;

        public Form1()
        {
            InitializeComponent();

            UtworzFormularz();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void UtworzFormularz()
        {
            this.Text = "Formularz danych";
            this.Size = new Size(750, 550);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblImie = new Label();
            lblImie.Text = "Imię:";
            lblImie.Location = new Point(30, 30);
            lblImie.AutoSize = true;
            Controls.Add(lblImie);

            txtImie = new TextBox();
            txtImie.Location = new Point(120, 27);
            txtImie.Width = 180;
            Controls.Add(txtImie);

            Label lblNazwisko = new Label();
            lblNazwisko.Text = "Nazwisko:";
            lblNazwisko.Location = new Point(30, 70);
            lblNazwisko.AutoSize = true;
            Controls.Add(lblNazwisko);

            txtNazwisko = new TextBox();
            txtNazwisko.Location = new Point(120, 67);
            txtNazwisko.Width = 180;
            Controls.Add(txtNazwisko);

            Label lblWyksztalcenie = new Label();
            lblWyksztalcenie.Text = "Wykształcenie:";
            lblWyksztalcenie.Location = new Point(30, 115);
            lblWyksztalcenie.AutoSize = true;
            Controls.Add(lblWyksztalcenie);

            cmbWyksztalcenie = new ComboBox();
            cmbWyksztalcenie.Location = new Point(120, 112);
            cmbWyksztalcenie.Width = 180;
            cmbWyksztalcenie.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbWyksztalcenie.Items.AddRange(new string[]
            {
                "podstawowe",
                "średnie",
                "wyższe"
            });

            cmbWyksztalcenie.SelectedIndex = 1;
            Controls.Add(cmbWyksztalcenie);

            GroupBox gbPlec = new GroupBox();
            gbPlec.Text = "Płeć";
            gbPlec.Location = new Point(120, 155);
            gbPlec.Size = new Size(180, 85);
            Controls.Add(gbPlec);

            rbKobieta = new RadioButton();
            rbKobieta.Text = "kobieta";
            rbKobieta.Location = new Point(10, 25);
            rbKobieta.AutoSize = true;
            gbPlec.Controls.Add(rbKobieta);

            rbMezczyzna = new RadioButton();
            rbMezczyzna.Text = "mężczyzna";
            rbMezczyzna.Location = new Point(10, 50);
            rbMezczyzna.AutoSize = true;
            rbMezczyzna.Checked = true;
            gbPlec.Controls.Add(rbMezczyzna);

            Label lblJezyki = new Label();
            lblJezyki.Text = "Języki obce:";
            lblJezyki.Location = new Point(30, 265);
            lblJezyki.AutoSize = true;
            Controls.Add(lblJezyki);

            clbJezyki = new CheckedListBox();
            clbJezyki.Location = new Point(120, 260);
            clbJezyki.Size = new Size(180, 100);

            clbJezyki.Items.AddRange(new string[]
            {
                "angielski",
                "niemiecki",
                "hiszpański",
                "chiński"
            });

            Controls.Add(clbJezyki);

            btnPotwierdz = new Button();
            btnPotwierdz.Text = "Potwierdź";
            btnPotwierdz.Location = new Point(350, 30);
            btnPotwierdz.Size = new Size(100, 35);
            btnPotwierdz.Click += BtnPotwierdz_Click;
            Controls.Add(btnPotwierdz);

            lblWynik = new Label();
            lblWynik.Location = new Point(350, 100);
            lblWynik.Size = new Size(350, 250);
            lblWynik.AutoSize = false;
            Controls.Add(lblWynik);
        }

        private void BtnPotwierdz_Click(object sender, EventArgs e)
        {
            string imie = txtImie.Text;
            string nazwisko = txtNazwisko.Text;

            string wyksztalcenie =
                cmbWyksztalcenie.SelectedItem?.ToString() ?? "";

            string plec = rbKobieta.Checked
                ? "Kobieta"
                : "Mężczyzna";

            string jezyki = "";

            foreach (var jezyk in clbJezyki.CheckedItems)
            {
                jezyki += jezyk.ToString() + ", ";
            }

            if (jezyki == "")
            {
                jezyki = "Nie wybrano";
            }
            else
            {
                jezyki = jezyki.TrimEnd(',', ' ');
            }

            lblWynik.Text =
                "Podałeś następujące dane:\n\n" +
                "Imię: " + imie + "\n" +
                "Nazwisko: " + nazwisko + "\n" +
                "Wykształcenie: " + wyksztalcenie + "\n" +
                "Płeć: " + plec + "\n" +
                "Języki obce: " + jezyki;
        }
    }
}
