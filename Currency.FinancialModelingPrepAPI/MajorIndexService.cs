using Newtonsoft.Json;
using Services.Models;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Currency.FinancialModelingPrepAPI
{
    public class MajorIndexService : IMajorIndexService
    {
        public async Task<MajorIndex> GetMajorIndex(MajorIndexType CharCode)
        {
            using (HttpClient client = new HttpClient())
            {
                string uri = "https://www.cbr-xml-daily.ru/daily_json.js" + GetUriSuffix(CharCode);
                HttpResponseMessage response = await client.GetAsync(uri);
                string jsonResponse = await response.Content.ReadAsStringAsync();

                MajorIndex majorIndex = JsonConvert.DeserializeObject<MajorIndex>(jsonResponse);
                majorIndex.Type = CharCode;

                return majorIndex;
            }
        }

        private string GetUriSuffix(MajorIndexType charCode)
        {
            switch(charCode)
            {
                case MajorIndexType.AUD:
                    return "AUD";
                default:
                    return "AUD";
            }
        }

        
    }
}

