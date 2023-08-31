// See https://aka.ms/new-console-template for more information
using Test.RideAnalyzer.Data.Data;
using Serilog;
//using Serilog.Sinks.SystemConsole;

try
{
    Console.WriteLine("Hello, Ride Analyzer");
    Console.WriteLine("Calculations are beginning!");
	DataLoader dataLoader = new();

	var _datas = dataLoader.GetRides(10000);

	foreach (var data in _datas)
	{
        //Console.WriteLine($"{data.Address},{data.FullName},{data.StartDate},{data.EndDate}");
        Console.WriteLine($"{data.Address},{data.FullName},{data.Created},{data.BirthDate}");

    }
    Console.WriteLine("Calculations are ended!");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
	throw;
}