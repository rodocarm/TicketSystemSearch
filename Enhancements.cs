namespace TicketSystemSearch
{
    public class Enhancement : Ticket
    {
        public string software { get; set; }
        public double cost { get; set; }
        public string reason { get; set; }
        public double estimate { get; set; }

        public override string Entry()
        {
            return $"{ticketID},{summary},{status},{priority},{submitter},{assigned},{string.Join("|", peopleWatching)},{software},{cost},{reason},{estimate:C2}";
        }
    }
}