using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace OlympicHistory2
{
    class MergerByID
    {
        public static void merge(List<Athlete> athletes, List<Athlete_event> athlete_event)
        {
            var all = from athlete in athletes
                      join athlete_ev in athlete_event on athlete.athleteID equals athlete_ev.athleteEventID 
                      select new { athlete.athleteID, athlete.athleteName, athlete.athleteSex, athlete_ev.athleteEventSport };
           
            using (var writer = new StreamWriter(@"task3.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(all);
            }
        }
    }
}
