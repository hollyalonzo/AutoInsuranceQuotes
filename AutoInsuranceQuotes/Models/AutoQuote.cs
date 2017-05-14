using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoInsuranceQuotes.Models
{
    public class AutoQuote
    {
        public int ID { get; set; }
        public Consumer Consumer { get; set; }
        public List<Vehicle> Vehicle { get; set; }
        public Coverage Coverage { get; set; }
    }
    public class Consumer
    {

        public int age { get; set; }
        public string credit_rating { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public string state { get; set; }
        public string zip_code { get; set; }
        public string area_code { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public string primary_phone { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public int years_at_address { get; set; }
        public bool is_currently_at_address { get; set; }
        public string secondary_phone { get; set; }
        public string own_or_rent { get; set; }
        public string comments { get; set; }
        public string contact_method { get; set; }
        public DateTime? birthdate { get; set; }
        public string occupation { get; set; }
        public string highest_level { get; set; }
        public string gender { get; set; }
        public string property_type { get; set; }
    }
    public class Vehicle
    {
        public int year { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int days_used { get; set; }
        public string use { get; set; }
        public int distance { get; set; }
        public int annual_distance { get; set; }
    }
    public class Coverage
    {
        public string months_insured { get; set; }
        public string has_coverage { get; set; }
        public string type { get; set; }
        public int bodilyinjury_person { get; set; }
        public int bodilyinjury_accident { get; set; }
        public int deductible { get; set; }
        public int propertydamage { get; set; }
        public DateTime? expiration_date { get; set; }
        public int expiration_days_remaining { get; set; }
        public DateTime? dtgExpirationDate { get; set; }
        public string former_insurer { get; set; }
    }
}