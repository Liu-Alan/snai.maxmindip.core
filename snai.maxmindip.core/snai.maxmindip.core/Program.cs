using MaxMind.GeoIP2;
using System;

namespace snai.maxmindip.core
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new DatabaseReader("ip/GeoLite2-City.mmdb"))
            {
                var record = reader.City("120.229.72.77");
                //var record = reader.City("103.170.4.145");
                //var record = reader.City("2a02:2f0e:dc0b:4400:c71:7513:f404:b4aa");

                Console.WriteLine(record.Continent.Names["zh-CN"]);
                Console.WriteLine(record.Continent.Names["en"]);
                Console.WriteLine(record.Country.IsoCode);
                Console.WriteLine(record.Country.Names["zh-CN"]);
                Console.WriteLine(record.Location.TimeZone);
                try
                {
                    Console.WriteLine(record.City.Names["zh-CN"]);
                }
                catch {
                    Console.WriteLine(record.City.Name);
                }
                Console.ReadKey();
            }
        }
    }
}
