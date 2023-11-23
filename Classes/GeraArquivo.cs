using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SRP.Classes
{
    public class GeraArquivo
    {
        public void SalvaArquivoJson<T>(string nomeArq, List<T> objetos)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonArq = JsonSerializer.Serialize(objetos, options);
            File.WriteAllText(nomeArq + ".json", jsonArq);
        }
    }
}