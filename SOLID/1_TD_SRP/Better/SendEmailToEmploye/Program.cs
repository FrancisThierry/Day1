using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

var configuration = builder.Build();
var csvPath = configuration["AppSettings:csvPath"];

if (csvPath != null)
{
    var parser = new CsvParser();
    var employes = parser.ParseCsv(csvPath);

    var emailSender = new EmailSender();
    emailSender.SendEmail(employes);

}


