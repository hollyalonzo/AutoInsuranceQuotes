using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoInsuranceQuotes.Models;
using Newtonsoft.Json;

namespace AutoInsuranceQuotes.Controllers
{
    public class FormerInsurersController : ApiController
    {
        // GET: api/FormerInsurer
        public IEnumerable<string> Get()
        {
            List<AutoQuote> autoQuotes = new List<AutoQuote>();

            using (StreamReader reader = new StreamReader(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory) + @"./app_data/auto.leads.json"))
            {
                string jsonResponse = reader.ReadToEnd();

                autoQuotes = JsonConvert.DeserializeObject<List<AutoQuote>>(jsonResponse);
            }

            return autoQuotes.Select(a => a.Coverage.former_insurer).Distinct().OrderBy(s => s);
        }
    }
}
