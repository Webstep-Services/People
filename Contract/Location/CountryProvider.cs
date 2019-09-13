using System.Collections.Generic;
using System.IO;

namespace Wss.People
{
    public class CountryProvider
    {
        public IEnumerable<CountryInfo> GetAll()
        {
            string phoneCodeFile = "Wss.People.Data.CountryCodeToPhoneCode.json";
            IList<CountryInfo> countries = new List<CountryInfo>();
            string result;

            using (Stream stream = GetType().Assembly.GetManifestResourceStream(phoneCodeFile))
            using (StreamReader reader = new StreamReader(stream))
            {
                result = reader.ReadToEnd();
            }

            return countries;

        }
    }
}