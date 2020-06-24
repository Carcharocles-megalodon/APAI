using System.Net.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokeAPI;
using Newtonsoft.Json;
namespace Pokedex
{
    class Downloader
    {
        static string URL = "https://pokeapi.co/api/v2/pokemon/";

        static async void GetPokemonAsync()
        {
            string result="";
            if (result != null)
            {
                for (int i = 1; i < 807; i++)
                {
                    string page = URL + i.ToString();
                    HttpClient client = new HttpClient();
                    HttpResponseMessage response = await client.GetAsync(page) ;
                    HttpContent content = response.Content;
                    result = await content.ReadAsStringAsync();
                    Pokemon a = JsonConvert.DeserializeObject<Pokemon>(result);
                    sqlLiteConn.RunIDbType(a.Name, a.Types[0], a.Types[1]);
                }
            }
        }
    }
}