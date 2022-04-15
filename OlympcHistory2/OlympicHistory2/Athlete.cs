namespace OlympicHistory2
{
    class Athlete
    {
        public Athlete(string ID, string Name, string Sex, string Age, string Height, string Weight, string Team, string NOC)
        {
            this.athleteID = ID;
            this.athleteName = Name;
            this.athleteSex = Sex;
            this.athleteAge = Age;
            this.athleteHeight = Height;
            this.athleteWeight = Weight;
            this.athleteTeam = Team;
            this.athleteNOC = NOC;
        }

        public string athleteID { get; set; }
        public string athleteName { get; set; }
        public string athleteSex { get; set; }
        public string athleteAge { get; set; }
        public string athleteHeight { get; set; }
        public string athleteWeight { get; set; }
        public string athleteTeam { get; set; }
        public string athleteNOC { get; set; }

    }
}
