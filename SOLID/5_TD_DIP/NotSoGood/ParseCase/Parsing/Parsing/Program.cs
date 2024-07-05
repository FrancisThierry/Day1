using Parsing.BusinessLogic;
using System.Xml;

ParserManager parserManager = new ParserManager(new XmlDocument());
parserManager.ParserReport(@"C:\temp\jri\companies_temperature.xml");