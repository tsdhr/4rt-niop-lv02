using System.Diagnostics.Eventing.Reader;

namespace BMICalculator
{
    public partial class FormBMI : Form
    {
        public FormBMI()
        {
            InitializeComponent();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            double tezina, visina;

            try
            {
                tezina = double.Parse(tbTezina.Text);
                visina = double.Parse(tbVisina.Text) / 100;

                if (tezina < 0 || visina < 0)
                {
                    MessageBox.Show("Vrijednosti ne mogu biti negativne", "Gre�ka unosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (tezina > 200 || visina > 230)
                {
                    MessageBox.Show("Vrijednosti su prevelike!", "Gre�ka unosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var bmi = tezina / Math.Pow(visina, 2);
                lblBMI.Text = string.Format("BMI\n{0:0.00}", bmi);

                /*
                  Severe Thinness	< 16
                  Moderate Thinness	16 - 17
                  Mild Thinness	17 - 18.5
                  Normal	18.5 - 25
                  Overweight	25 - 30
                  Obese Class I	30 - 35
                  Obese Class II	35 - 40
                  Obese Class III	> 40
                */

                string opis;
                if (bmi < 16)
                {
                    opis = "Velika pothranjenost";
                }
                else if (bmi >= 16.0 && bmi < 17.0)
                {
                    opis = "Umjerena pothranjenost";
                }
                else if (bmi >= 17.0 && bmi < 18.5)
                {
                    opis = "Blaga pothranjenost";
                }
                else if (bmi >= 18.5 && bmi < 25.0)
                {
                    opis = "Normalna te�ina";
                }
                else if (bmi >= 25.0 && bmi < 30)
                {
                    opis = "Prekomjerna te�ina";
                }
                else
                {
                    opis = "Opasno prekomjerna te�ina";
                }
                lblBMITekst.Text = opis;
            }
            catch (Exception)
            {
                MessageBox.Show("Niste upisali ispravne vrijednosti!", "Gre�ka unosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
