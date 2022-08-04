using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        // Variables
        string txtFileName = "CurrentCities.txt";
        List<string> cityList = new List<string>();
        
        // Instances
        TxtFile txtFile = new TxtFile();
        RequestTemp requestTemp = new RequestTemp();
        TxtListConvert  txtListConvert = new TxtListConvert();
        TempType tempType = new TempType();

        // ======================================================
        
        // Welcome
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Welcome to Audiaxel's WeatherApp!");

        // App features        
        bool txtFileExist = !txtFile.CreateTxtFile(txtFileName);
        if (txtFileExist){
            cityList = txtListConvert.ConvertTxtFileToList(txtFileName);
            PrintTemperatures(cityList);
        }



        // Wait before closing
        System.Console.ReadKey();
        

        // ======================================================
        
        // Neah, wie geht das alles ab hier besser?!?!?!?!
        // Print city Temperatures
        async Task PrintTemperatures(List<string> _cityList)
        {
            for (int i = 0; i < _cityList.Count; i++ ){
                tempType.Celsius = await GetTemperature(_cityList[i]); 
                System.Console.WriteLine
                    ($"In {_cityList[i]}: {tempType.Celsius} celsius || {tempType.Kelvin} kelvin || {tempType.Farenheit} fahrenheit" );
            }

        }
        
        // Get current temperatures 
        async Task<float> GetTemperature(string _cityName)
        {
            float _currentTemp = await Task.Run(()  => requestTemp.CurrentTemp(_cityName));
            return _currentTemp;
        }
    }
}



    