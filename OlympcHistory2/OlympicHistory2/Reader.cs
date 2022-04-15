using System;
using System.Collections.Generic;
using CsvHelper;
using System.Globalization;
using System.IO;
using CsvHelper.Configuration;

namespace OlympicHistory2
{
    class Reader
    {
        public static List<Athlete_event> allAthleteEvents = new List<Athlete_event>();

        public static List<Athlete> allAthletes = new List<Athlete>();
        public static void reader(string csv_path, string csv_path2)
        {

            if (csv_path2.EndsWith("events.csv"))
            {
                using (var reader = new StreamReader(csv_path2))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Read();
                    csv.ReadHeader();

                    while (csv.Read())
                    {
                        var record = csv.GetRecord<Athlete_event>();
                        allAthleteEvents.Add(record);
                    }
                }
            }

            if (csv_path.EndsWith("athletes.csv"))
            {
                var badPeople = new List<string>();
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    BadDataFound = arg => badPeople.Add(arg.Context.Parser.RawRecord)
                };
                using (var reader = new StreamReader(csv_path))
                using (var csv = new CsvReader(reader, config))
                {
                    csv.Read();
                    csv.ReadHeader();
                    var asd = new List<Athlete>();

                    while (csv.Read())
                    {
                        var record = csv.GetRecord<Athlete>();
                        allAthletes.Add(record);
                    }
                }
            } 
        }
    }
}
