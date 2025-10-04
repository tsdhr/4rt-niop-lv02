namespace BMICalculator {
  public class BMI {
    public BMI(string tezina, string visina) {
      try {
        Tezina = double.Parse(tezina);
        Visina = double.Parse(visina) / 100.0;
      } catch (Exception) {
        throw new Exception("Neispravna vrijednost težine ili visine!");
      }

      if (Tezina < 20 || Tezina > 200) {
        throw new Exception("Neispravna vrijednost težine!");
      }
      if (Visina < 0.5 || Visina > 2.5) {
        throw new Exception("Neispravna vrijednost visine!");
      }

      Vrijednost = IzracunajVrijednost();
    }

    private double IzracunajVrijednost() {
      try {
        return Tezina / Math.Pow(Visina, 2);
      } catch (Exception) {
        throw new Exception("Nije moguće izračunati vrijednost!");
      }
    }

    private string VratiOpis() {
      if (Vrijednost < 16) {
        return "Velika pothranjenost";
      } else if (Vrijednost >= 16.0 && Vrijednost < 17.0) {
        return "Umjerena pothranjenost";
      } else if (Vrijednost >= 17.0 && Vrijednost < 18.5) {
        return "Blaga pothranjenost";
      } else if (Vrijednost >= 18.5 && Vrijednost < 25.0) {
        return "Normalna težina";
      } else if (Vrijednost >= 25.0 && Vrijednost < 30) {
        return "Prekomjerna težina";
      } else {
        return "Opasno prekomjerna težina";
      }
    }

    public double Tezina { get; }
    public double Visina { get; }
    public double Vrijednost { get; }
    public string Opis {
      get {
        return VratiOpis();
      }
    }
  }
}
