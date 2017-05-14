using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using AutoInsuranceQuotes.Models;

namespace AutoInsuranceQuotes.Controllers
{
    public class DetailsController : ApiController
    {
        public async Task<AutoQuote> Get(int quoteId)
        {
            AutoQuote autoQuote = new AutoQuote();

            using (StreamReader reader = new StreamReader(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory) + @"./app_data/auto.leads.json"))
            {
                string jsonResponse = await reader.ReadToEndAsync();

                autoQuote = JsonConvert.DeserializeObject<List<AutoQuote>>(jsonResponse).First(q => q.ID == quoteId);
            }

            return autoQuote;
        }
    }
}
