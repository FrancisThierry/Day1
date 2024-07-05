using ParserManagement.BusinessLogic;

//IDataSource xmlDataSource = new XmlData(@"C:\temp\jri\companies_temperature.xml");
//ParserManager xmlParserManager = new ParserManager(xmlDataSource);
//xmlParserManager.ParserReport();


IDataSource csvDataSource = new CsvData(@"C:\temp\jri\companies_temperature.csv");
ParserManager csvParserManager = new ParserManager(csvDataSource);
csvParserManager.ParserReport();