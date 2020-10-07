using System;
using System.IO;
using System.Collections.Generic;

namespace CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"C:\Users\Donation\Desktop\Learn C#\CSV\Example_CSVs\us-500.csv"))
            {
                List<string> firstName = new List<string>();
                List<string> lastName = new List<string>();
                List<string> companyName = new List<string>();
                List<string> address = new List<string>();
                List<string> city = new List<string>();
                List<string> country = new List<string>();
                List<string> state = new List<string>();
                List<string> zip = new List<string>();
                List<string> phone1 = new List<string>();
                List<string> phone2 = new List<string>();
                List<string> email = new List<string>();
                List<string> web = new List<string>();
                
                
                try
                {
                    while (!reader.EndOfStream)
                    {
                        var data = reader.ReadLine();
                        var values = data.Split(",");
                    
                        firstName.Add(values[0]);
                        lastName.Add(values[1]);
                        companyName.Add(values[2]);
                        address.Add(values[3]);
                        city.Add(values[4]);
                        country.Add(values[5]);
                        state.Add(values[6]);
                        zip.Add(values[7]);
                        phone1.Add(values[8]);
                        phone2.Add(values[9]);
                        email.Add(values[10]);
                        web.Add(values[11]);
                        
                    }
                  
                }
                catch (IndexOutOfRangeException) 
                {
                }
            foreach (var value in firstName)
                {
                    Console.WriteLine(value);
                }
            }
        }
    }
}
