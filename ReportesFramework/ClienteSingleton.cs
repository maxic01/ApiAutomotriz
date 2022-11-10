using System.Net.Http;
using System.Threading.Tasks;

namespace ReportesFramework
{
    public class ClienteSingleton
    {
        private static ClienteSingleton instancia;
        private HttpClient client;
        private ClienteSingleton()
        {
            client = new HttpClient();
        }
        public static ClienteSingleton GetInstance()
        {
            if (instancia == null)
                instancia = new ClienteSingleton();
            return instancia;
        }
        public async Task<string> GetAsync(string url)
        {
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            return content;
        }
    }
}