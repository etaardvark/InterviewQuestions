using System;

namespace InterviewQuestions
{
    public class Event
    {
        public int ID { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public int EventDefinitionID { get; set; }
        public int LinkedEventID { get; set; } = -1;
    }
}