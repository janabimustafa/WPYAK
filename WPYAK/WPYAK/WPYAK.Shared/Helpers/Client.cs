using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WPYAK.Helpers
{
    class Client
    {
        public const string BASE_URL = "https://us-central-api.yikyakapi.net/api/";
        public static async  Task<string> Get(Uri uri)
        {
            var client = new HttpClient();
            return await client.GetStringAsync(uri);
        }
    }
}
