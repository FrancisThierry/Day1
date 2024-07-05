public class SendEmailFromCsv
{
    public static string? CheminFichier { get; set; }

    public SendEmailFromCsv(string _cheminFichier)
    {
        CheminFichier = _cheminFichier;
    }

    /// <summary>
    /// Send emails from a list in a file
    /// </summary>
    public static void Send()
    {
        Console.WriteLine("lecture du fichier csv");
        Console.WriteLine("Parse du csv");

        Console.WriteLine("Chemin du fichier" + CheminFichier);
        if (CheminFichier != null)
        {
            var lignes = File.ReadAllLines(CheminFichier);
            foreach (var ligne in lignes)
            {
                var valeurs = ligne.Split(',');
                if (valeurs.Length > 2 && valeurs[2] != null)
                    Console.WriteLine("Envoi des emails à " + valeurs[2]);
            }
        }
    }
}
