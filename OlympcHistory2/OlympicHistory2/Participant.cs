using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace OlympicHistory2
{
    class Participant
    {
        public static void participantsByNOC(List<Athlete> athletes, List<Athlete_event> athlete_event)
        {
            var all = (from athlete in athletes
                       join athelete_ev in athlete_event on athlete.athleteID equals athelete_ev.athleteEventID

                       group athlete by athlete.athleteNOC into grp
                       orderby grp.Count() descending

                       select new { key = grp.Key, co = grp.Count() });

            using (var writer = new StreamWriter(@"task7.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(all);
            }
        }

        public static void shortestOfJapan(List<Athlete> athletes)
        {
            var rows =
             (from row in athletes
             where row.athleteNOC.Contains("JPN")
             let x = Int32.Parse(row.athleteHeight)
             orderby x             
                   select new { row.athleteName, row.athleteSex, row.athleteAge}).Take(1);

            using (var writer = new StreamWriter(@"task8.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(rows);
            }
        }

        public static void ageUnder18(List<Athlete> athletes)
        {
            var rows =
                from row in athletes
                where  ( Int32.Parse(row.athleteAge) < 18)
                orderby Int32.Parse(row.athleteAge) ascending
                select new { row.athleteID, row.athleteName, row.athleteSex, row.athleteAge, row.athleteHeight, row.athleteWeight, row.athleteTeam, row.athleteNOC };

            using (var writer = new StreamWriter(@"task9.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(rows);
            }
        }
    }
}
