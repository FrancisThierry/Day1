public class CsvParser
{
    public List<Employe> ParseCsv(string cheminFichier)
    {
        var employes = new List<Employe>();
        var lignes = File.ReadAllLines(cheminFichier);
        foreach (var ligne in lignes)
        {
            var valeurs = ligne.Split(',');
            if (valeurs.Length > 2)
            {
                employes.Add(new Employe { Nom = valeurs[1], Email = valeurs[2] });
            }
        }
        return employes;
    }
}