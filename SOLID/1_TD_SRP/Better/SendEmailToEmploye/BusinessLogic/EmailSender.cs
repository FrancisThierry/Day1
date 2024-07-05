public class EmailSender
{
    public void SendEmail(List<Employe> employes)
    {
        foreach (var employe in employes)
        {
            Console.WriteLine($"Envoi de l'email à {employe.Nom}");
            // Logique d'envoi d'email
        }
    }
}