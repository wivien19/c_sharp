using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace OlympicHistory2
{
    class GoldMedal
    {

        public static void countGoldMedal(List<Athlete_event> athlete_event)
        {
                var all = from res in athlete_event
                         where res.athleteEventMedal.Equals("Gold")
                         group res by res.athleteEventID into grp
                         select new {cnt = grp.Count() };

            using (var writer = new StreamWriter(@"task4.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecord(all.Count());
            }
        }

        public static void NOCMedal(List<Athlete> athletes, List<Athlete_event> athlete_event)
        {
            var all = from athlete in athletes
                      join athlete_ev in athlete_event on athlete.athleteID equals athlete_ev.athleteEventID
                      where athlete_ev.athleteEventMedal.Equals("Gold") || athlete_ev.athleteEventMedal.Equals("Silver")
                      || athlete_ev.athleteEventMedal.Equals("Bronze")
                      orderby athlete.athleteNOC
                      group athlete by athlete.athleteNOC into grp
                      select new { key = grp.Key, cnt = grp.Count() };

            using (var writer = new StreamWriter(@"task5.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(all);
            }
        }

        public static void MaximumOfNOCMedal(List<Athlete> athletes, List<Athlete_event> athlete_event)
        {
            var all = (from athlete in athletes
                      join athlete_ev in athlete_event on athlete.athleteID equals athlete_ev.athleteEventID
                      
                      where athlete_ev.athleteEventMedal.Equals("Gold") || athlete_ev.athleteEventMedal.Equals("Silver")
                      || athlete_ev.athleteEventMedal.Equals("Bronze")
                      
                      group athlete by athlete.athleteNOC into grp
                      orderby  grp.Count() descending
                      
                      select new { grp.Key }).Take(1);

            using (var writer = new StreamWriter(@"task6.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(all);
            }
        }


    }
}
