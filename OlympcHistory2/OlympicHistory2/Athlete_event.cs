namespace OlympicHistory2
{
    public class Athlete_event
    {
        public Athlete_event(string ID, string Name, string Year, string Season, string City, string Sport, string Event, string Medal)
        {
            athleteEventID = ID;
            athleteEventName = Name;
            athleteEventYear = Year;
            athleteEventSeason = Season;
            athleteEventCity = City;
            athleteEventSport = Sport;
            athleteEventEvent = Event;
            athleteEventMedal = Medal;
        }

        public string athleteEventID { get; set; }
        public string athleteEventName { get; set; }

        public string athleteEventYear { get; set; }
        public string athleteEventSeason { get; set; }
        public string athleteEventCity { get; set; }
        public string athleteEventSport { get; set; }
        public string athleteEventEvent { get; set; }
        public string athleteEventMedal { get; set; }
        
    }
}
