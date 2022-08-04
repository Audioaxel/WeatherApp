using Newtonsoft.Json;


public class RequestTemp
{
        static string _apiKey = "7d587d120134bf679455bfb75e3db40d";
        



    public async Task<float> CurrentTemp(string city)
    {
        string _requestUri = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric";
        
        HttpClient httpClient = new HttpClient();
        HttpResponseMessage httpResponse = await httpClient.GetAsync(_requestUri);
        string response = await httpResponse.Content.ReadAsStringAsync();
        WeatherMapResponse weatherMapResponse = JsonConvert.DeserializeObject<WeatherMapResponse>(response);
        
        return weatherMapResponse.main.temp;
    }



}