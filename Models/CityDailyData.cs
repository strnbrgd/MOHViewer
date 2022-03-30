using System;
using MOHViewer.Models.Converters;
using Newtonsoft.Json;

namespace MOHViewer.Models;

internal class CityDailyData
{
    [JsonProperty("City_Name")]
    public string CityName { get; set; }

    [JsonProperty("Date")]
    public DateTime Date { get; set; }
    [JsonProperty("Cumulative_verified_cases")]
    [JsonConverter(typeof(StringToIntConverter))]
    public int TotalVerified { get; set; }
    [JsonProperty("Cumulated_deaths")]
    [JsonConverter(typeof(StringToIntConverter))]
    public int TotalDeaths { get; set; }
    [JsonProperty("Cumulated_number_of_tests")]
    [JsonConverter(typeof(StringToIntConverter))]
    public int TotalTests { get; set; }
}