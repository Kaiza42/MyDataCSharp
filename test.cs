public class Voiture
{
    private string numeroDeSerie;  // Champ privé, inaccessible de l'extérieur

    public void SetNumeroDeSerie(string numero)
    {
        numeroDeSerie = numero;  // Accessible dans la classe
    }

    public void AfficherNumeroDeSerie()
    {
        Console.WriteLine($"Numéro de série : {numeroDeSerie}");
    }
}


class Program
{
    static void Main()
    {
        Voiture maVoiture = new Voiture();
        maVoiture.SetNumeroDeSerie("12345");  // Accessible via méthode publique
        maVoiture.AfficherNumeroDeSerie();    // Affiche le numéro
    }
}

