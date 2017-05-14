using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using AutoInsuranceQuotes.Models;
using Newtonsoft.Json;

namespace AutoInsuranceQuotes.Controllers
{
    public class QuotesController : ApiController
    {
        // GET: api/Quotes
        public async Task<List<AutoQuote>> Get(int pageNumber, string state, string make, string former)
        {
            List<AutoQuote> autoQuotes = new List<AutoQuote>();

            using (StreamReader reader = new StreamReader(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory) + @"./app_data/auto.leads.json"))
            {
                string jsonResponse = await reader.ReadToEndAsync();

                int startIndex = (pageNumber - 1) * 5;

                autoQuotes = JsonConvert.DeserializeObject<List<AutoQuote>>(jsonResponse);

                if (!string.IsNullOrEmpty(state))
                {
                    autoQuotes = autoQuotes.Where(a => a.Consumer.state == state).ToList();
                }

                if (!string.IsNullOrEmpty(make))
                {
                    autoQuotes = autoQuotes.Where(a => a.Vehicle.Any(v => v.make == make)).ToList();
                }

                if (!string.IsNullOrEmpty(former))
                {
                    autoQuotes = autoQuotes.Where(a => a.Coverage.former_insurer == former).ToList();
                }

                autoQuotes = autoQuotes.Skip(startIndex).Take(5).ToList();
            }

            return autoQuotes;
        }

    }
}
