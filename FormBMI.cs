using System.Diagnostics.Eventing.Reader;

namespace BMICalculator {
  public partial class FormBMI : Form {
    public FormBMI() {
      InitializeComponent();
    }

    private void btnIzracunaj_Click(object sender, EventArgs e) {
      try {
        BMI bmi = new BMI(tbTezina.Text, tbVisina.Text);
        
        lblBMI.Text = string.Format("{0:0.00}", bmi.Vrijednost);
        lblBMITekst.Text = bmi.Opis;
      } catch (Exception ex) {
        MessageBox.Show(ex.Message, "Greška unosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
