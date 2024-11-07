using System.Text.Json.Serialization;

namespace Pokedex.Models
{
    public class Pokemon
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("growth_time")]
        public int GrowthTime { get; set; }

        [JsonPropertyName("max_harvest")]
        public int MaxHarvest { get; set; }

        [JsonPropertyName("natural_gift_power")]
        public int NaturalGiftPower { get; set; }

        [JsonPropertyName("size")]
        public int Size { get; set; }

        [JsonPropertyName("smoothness")]
        public int Smoothness { get; set; }

        [JsonPropertyName("soil_dryness")]
        public int SoilDryness { get; set; }


        /*
        [JsonPropertyName("firmness")]
        public Firmness Firmness { get; set; }
        */
    }
}
