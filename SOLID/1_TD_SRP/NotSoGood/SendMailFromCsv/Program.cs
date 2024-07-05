// Configurer le constructeur de configuration
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

var configuration = builder.Build();
var csvPath = configuration["AppSettings:csvPath"];



if(csvPath != null)
{

SendEmailFromCsv se = new SendEmailFromCsv(csvPath);

try
{
    SendEmailFromCsv.Send();
}
catch (System.Exception)
{
    throw;
}

}

