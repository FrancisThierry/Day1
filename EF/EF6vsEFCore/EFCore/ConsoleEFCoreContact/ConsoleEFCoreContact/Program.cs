using ConsoleEFCoreContact.Modele;
using System.Diagnostics;
var stopwatch = new Stopwatch();


using (var context = new ContactContext())
{
    stopwatch.Start();

    // Create
    for (int i = 0; i < 1000; i++)
    {
        context.Contacts.Add(new Contact { LastName = "Contact " + i });
    }
    context.SaveChanges();

    stopwatch.Stop();
    Console.WriteLine($"EF Core - Time to create 1000 records: {stopwatch.ElapsedMilliseconds} ms");
    stopwatch.Reset();

    // Read
    stopwatch.Start();
    var Contacts = context.Contacts.ToList();
    stopwatch.Stop();
    Console.WriteLine($"EF Core - Time to read 1000 records: {stopwatch.ElapsedMilliseconds} ms");
    stopwatch.Reset();

    // Update
    stopwatch.Start();
    foreach (var Contact in Contacts)
    {
        Contact.LastName += " Updated";
    }
    context.SaveChanges();
    stopwatch.Stop();
    Console.WriteLine($"EF Core - Time to update 1000 records: {stopwatch.ElapsedMilliseconds} ms");
    stopwatch.Reset();

    // Delete
    stopwatch.Start();
    context.Contacts.RemoveRange(Contacts);
    context.SaveChanges();
    stopwatch.Stop();
    Console.WriteLine($"EF Core - Time to delete 1000 records: {stopwatch.ElapsedMilliseconds} ms");
}
