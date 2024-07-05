// See https://aka.ms/new-console-template for more information
using ConsoleTempWorkBench.Business;
using ConsoleTempWorkBench.Models;
using ConsoleTempWorkBench.Services;
using System.Net.NetworkInformation;


CsvReader csvReader = new CsvReader();
var listData = csvReader.ReadCsvData(@"chemin csv");

//Console.WriteLine(listData[0][0]);
JsonWriter jsonWriter = new JsonWriter(listData);

DatabaseMyTempContext context = new DatabaseMyTempContext();

DeviceDataManager deviceDataManager = new DeviceDataManager(context);
MeasureDataManagement measureDataManagement = new MeasureDataManagement(context, deviceDataManager);


using var transaction = context.Database.BeginTransaction();

try
{
    saveDevices(listData, deviceDataManager);

    saveMeasures(listData, measureDataManagement);

    jsonWriter.Write(@"C:\temp\file_"+Guid.NewGuid() + ".json");

    transaction.Commit();
}
catch (Exception ex)
{

    throw new Exception("L'opération a échoué, surveiller les logs"+ ex.Message);
}



static void saveDevices(List<string[]> listData, DeviceDataManager deviceDataManager)
{
    //to do filter distinct devicename
    for (int i = 0; i < listData.Count; i++)
    {
        //ajout des devices
        deviceDataManager.AddNonPresentDevices(listData[i][0]);
    }
    deviceDataManager.Save();
}

static void saveMeasures(List<string[]> listData, MeasureDataManagement measureDataManagement)
{
    for (int i = 0; i < listData.Count; i++)
    {
        measureDataManagement.AddNonExistingMeasure(listData[i][0], listData[i][1], listData[i][2]);
    }
    measureDataManagement.Save();
}