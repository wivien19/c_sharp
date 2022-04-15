using System;

namespace OlympicHistory2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 2)
                {
                    throw new Exception("Ketto csv-t kell megadnod!");
                }

                string csv_path = "";
                string csv_path2 = "";

                if (args[0].EndsWith("athletes.csv"))
                {
                    csv_path = args[0];
                    csv_path2 = args[1];
                }
                else
                {
                    csv_path = args[1];
                    csv_path2 = args[0];
                }

                //reader
                Reader.reader(csv_path, csv_path2);
                //task3
                MergerByID.merge(Reader.allAthletes, Reader.allAthleteEvents);
                //task4
                GoldMedal.countGoldMedal(Reader.allAthleteEvents);
                //task5
                GoldMedal.NOCMedal(Reader.allAthletes, Reader.allAthleteEvents);
                //task6
                GoldMedal.MaximumOfNOCMedal(Reader.allAthletes, Reader.allAthleteEvents);
                //task7
                Participant.participantsByNOC(Reader.allAthletes, Reader.allAthleteEvents);
                //task8
                Participant.shortestOfJapan(Reader.allAthletes);
                //task9
                Participant.ageUnder18(Reader.allAthletes);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
