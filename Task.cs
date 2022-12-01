using System;

namespace TicketSystemSearch
{
    public class Task : Ticket
    {
        public string projectName { get; set; }
        public DateTime dueDate { get; set; }

        public override string Entry()
        {
            return $"{ticketID},{summary},{status},{priority},{submitter},{assigned},{string.Join("|", peopleWatching)},{projectName},{dueDate: dd}";
        }
    }
}