using System;
using System.Collections.Generic;

namespace InterviewQuestions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Question1 question1 = new Question1();
            question1.Q1Main();
            Console.ReadKey();
        }

        public static List<EventDefinition> GetEventDefinitionList()
        {
            return new List<EventDefinition>
            {
                new EventDefinition {ID = 1, Name = "Running", EventDefinitionType = EventDefinitionType.Running, Key = "RUNNING"},
                new EventDefinition {ID = 2, Name = "Not Running", EventDefinitionType = EventDefinitionType.NotRunning, Key = "NOT.RUNNING"},
                new EventDefinition {ID = 3, Name = "Idle", Key = "IDLE"},
                new EventDefinition {ID = 4, Name = "Changeover", EventDefinitionType = EventDefinitionType.Changeover, Key = "CHANGEOVER"},
                new EventDefinition {ID = 5, Name = "Changeover Overage", EventDefinitionType = EventDefinitionType.ChangeoverOverage, Key = "CHANGEOVER.OVERAGE"},
                new EventDefinition {ID = 6, Name = "System Not Scheduled", EventDefinitionType = EventDefinitionType.SystemNotScheduled, Key = "SNS"},
                new EventDefinition {ID = 7, Name = "Break", Key = "BREAK"},
                new EventDefinition {ID = 8, Name = "Line Labour Shortage", Key="SLOWRUNNING"},              
            };
        }

        public static List<Event> GetEventList()
        {
            return new List<Event>
            {
                new Event {ID = 100145, StartDateTime = new DateTime(2022, 10, 18, 11, 00, 00), EndDateTime = new DateTime(2022, 10, 18, 11, 13, 10), EventDefinitionID = 1},
                new Event {ID = 100146, StartDateTime = new DateTime(2022, 10, 18, 11, 13, 10), EndDateTime = new DateTime(2022, 10, 18, 11, 37, 41), EventDefinitionID = 3},
                new Event {ID = 100147, StartDateTime = new DateTime(2022, 10, 18, 11, 37, 41), EndDateTime = new DateTime(2022, 10, 18, 12, 00, 00), EventDefinitionID = 2},
                new Event {ID = 100148, StartDateTime = new DateTime(2022, 10, 18, 12, 00, 00), EndDateTime = new DateTime(2022, 10, 18, 12, 30, 00), EventDefinitionID = 2},
                new Event {ID = 100149, StartDateTime = new DateTime(2022, 10, 18, 12, 30, 00), EndDateTime = new DateTime(2022, 10, 18, 13, 30, 00), EventDefinitionID = 6},
                new Event {ID = 100150, StartDateTime = new DateTime(2022, 10, 18, 13, 30, 00), EndDateTime = new DateTime(2022, 10, 18, 14, 00, 00), EventDefinitionID = 2},
                new Event {ID = 100151, StartDateTime = new DateTime(2022, 10, 18, 14, 00, 00), EndDateTime = new DateTime(2022, 10, 18, 14, 30, 00), EventDefinitionID = 2},
                new Event {ID = 100152, StartDateTime = new DateTime(2022, 10, 18, 14, 30, 00), EndDateTime = new DateTime(2022, 10, 18, 14, 58, 12), EventDefinitionID = 2},
                new Event {ID = 100153, StartDateTime = new DateTime(2022, 10, 18, 14, 58, 12), EndDateTime = new DateTime(2022, 10, 18, 15, 49, 45), EventDefinitionID = 1},
            };
        }

        public static List<Event> GetQuestionTwoEventList()
        {
            return new List<Event>
            {
                new Event {ID = 100145, StartDateTime = new DateTime(2022, 10, 18, 11, 00, 00), EndDateTime = new DateTime(2022, 10, 18, 11, 13, 10), EventDefinitionID = 1},
                new Event {ID = 100146, StartDateTime = new DateTime(2022, 10, 18, 11, 13, 10), EndDateTime = new DateTime(2022, 10, 18, 12, 00, 00).AddMinutes(120), EventDefinitionID = 4 },                
				new Event {ID = 100147, StartDateTime = new DateTime(2022, 10, 18, 11, 13, 10), EndDateTime = new DateTime(2022, 10, 18, 11, 37, 41), EventDefinitionID = 3},
				new Event {ID = 100148, StartDateTime = new DateTime(2022, 10, 18, 11, 37, 41), EndDateTime = new DateTime(2022, 10, 18, 12, 00, 00), EventDefinitionID = 2},
				new Event {ID = 100149, StartDateTime = new DateTime(2022, 10, 18, 12, 00, 00), EndDateTime = new DateTime(2022, 10, 18, 12, 30, 00), EventDefinitionID = 2},
				new Event {ID = 100150, StartDateTime = new DateTime(2022, 10, 18, 12, 30, 00), EndDateTime = new DateTime(2022, 10, 18, 13, 30, 00), EventDefinitionID = 6},
				new Event {ID = 100151, StartDateTime = new DateTime(2022, 10, 18, 12, 30, 00), EndDateTime = new DateTime(2022, 10, 18, 12, 30, 00).AddMinutes(120), EventDefinitionID = 4 },
				new Event {ID = 100152, StartDateTime = new DateTime(2022, 10, 18, 14, 30, 10), EndDateTime = new DateTime(2022, 10, 18, 14, 58, 00), EventDefinitionID = 4 },
				new Event {ID = 100153, StartDateTime = new DateTime(2022, 10, 18, 13, 30, 00), EndDateTime = new DateTime(2022, 10, 18, 14, 00, 00), EventDefinitionID = 2},
				new Event {ID = 100154, StartDateTime = new DateTime(2022, 10, 18, 14, 00, 00), EndDateTime = new DateTime(2022, 10, 18, 14, 30, 00), EventDefinitionID = 2},
				new Event {ID = 100155, StartDateTime = new DateTime(2022, 10, 18, 14, 30, 00), EndDateTime = new DateTime(2022, 10, 18, 14, 58, 12), EventDefinitionID = 2},
				new Event {ID = 100156, StartDateTime = new DateTime(2022, 10, 18, 14, 58, 12), EndDateTime = new DateTime(2022, 10, 18, 15, 49, 45), EventDefinitionID = 1},
			};
		}

		public static List<Event> GetQuestionThreeEventList()
		{
			return new List<Event>
			{
                new Event {ID = 100144, StartDateTime = new DateTime(2022, 10,18,11,00,00), EndDateTime = null, EventDefinitionID = 8 },
				new Event {ID = 100145, StartDateTime = new DateTime(2022, 10, 18, 11, 00, 00), EndDateTime = new DateTime(2022, 10, 18, 11, 13, 10), EventDefinitionID = 1, LinkedEventID = 100144},
				new Event {ID = 100146, StartDateTime = new DateTime(2022, 10, 18, 11, 13, 10), EndDateTime = new DateTime(2022, 10, 18, 12, 00, 00).AddMinutes(120), EventDefinitionID = 4 },
				new Event {ID = 100147, StartDateTime = new DateTime(2022, 10, 18, 11, 13, 10), EndDateTime = new DateTime(2022, 10, 18, 11, 37, 41), EventDefinitionID = 3},
				new Event {ID = 100148, StartDateTime = new DateTime(2022, 10, 18, 11, 37, 41), EndDateTime = new DateTime(2022, 10, 18, 12, 00, 00), EventDefinitionID = 2},
				new Event {ID = 100149, StartDateTime = new DateTime(2022, 10, 18, 12, 00, 00), EndDateTime = new DateTime(2022, 10, 18, 12, 30, 00), EventDefinitionID = 2},
				new Event {ID = 100150, StartDateTime = new DateTime(2022, 10, 18, 12, 30, 00), EndDateTime = new DateTime(2022, 10, 18, 13, 30, 00), EventDefinitionID = 6},
				new Event {ID = 100151, StartDateTime = new DateTime(2022, 10, 18, 12, 30, 00), EndDateTime = new DateTime(2022, 10, 18, 12, 30, 00).AddMinutes(120), EventDefinitionID = 4 },
				new Event {ID = 100152, StartDateTime = new DateTime(2022, 10, 18, 14, 30, 10), EndDateTime = new DateTime(2022, 10, 18, 14, 58, 00), EventDefinitionID = 4 },
				new Event {ID = 100153, StartDateTime = new DateTime(2022, 10, 18, 13, 30, 00), EndDateTime = new DateTime(2022, 10, 18, 14, 00, 00), EventDefinitionID = 2},
				new Event {ID = 100154, StartDateTime = new DateTime(2022, 10, 18, 14, 00, 00), EndDateTime = new DateTime(2022, 10, 18, 14, 30, 00), EventDefinitionID = 2},
				new Event {ID = 100155, StartDateTime = new DateTime(2022, 10, 18, 14, 30, 00), EndDateTime = new DateTime(2022, 10, 18, 14, 58, 12), EventDefinitionID = 2},
				new Event {ID = 100156, StartDateTime = new DateTime(2022, 10, 18, 14, 58, 12), EndDateTime=null, EventDefinitionID = 1, LinkedEventID = 100144},
			};
		}

        public static List<Event> GetQuestionFourEventList()
        {
			return new List<Event>
			{
				//new Event {ID = 100144, StartDateTime = new DateTime(2022, 10,18,11,00,00), EndDateTime = null, EventDefinitionID = 8 },
				//new Event {ID = 100145, StartDateTime = new DateTime(2022, 10, 18, 11, 00, 00), EndDateTime = new DateTime(2022, 10, 18, 11, 13, 10), EventDefinitionID = 1},
				//new Event {ID = 100146, StartDateTime = new DateTime(2022, 10, 18, 11, 13, 10), EndDateTime = new DateTime(2022, 10, 18, 12, 00, 00).AddMinutes(120), EventDefinitionID = 4 },
				//new Event {ID = 100147, StartDateTime = new DateTime(2022, 10, 18, 11, 13, 10), EndDateTime = new DateTime(2022, 10, 18, 11, 37, 41), EventDefinitionID = 3},
				//new Event {ID = 100148, StartDateTime = new DateTime(2022, 10, 18, 11, 37, 41), EndDateTime = new DateTime(2022, 10, 18, 12, 00, 00), EventDefinitionID = 2},
				//new Event {ID = 100149, StartDateTime = new DateTime(2022, 10, 18, 12, 00, 00), EndDateTime = new DateTime(2022, 10, 18, 12, 30, 00), EventDefinitionID = 2},
				//new Event {ID = 100150, StartDateTime = new DateTime(2022, 10, 18, 12, 30, 00), EndDateTime = new DateTime(2022, 10, 18, 13, 30, 00), EventDefinitionID = 6},
				//new Event {ID = 100151, StartDateTime = new DateTime(2022, 10, 18, 12, 30, 00), EndDateTime = new DateTime(2022, 10, 18, 12, 30, 00).AddMinutes(120), EventDefinitionID = 4 },
				//new Event {ID = 100152, StartDateTime = new DateTime(2022, 10, 18, 14, 30, 10), EndDateTime = new DateTime(2022, 10, 18, 14, 58, 00), EventDefinitionID = 4 },
				//new Event {ID = 100153, StartDateTime = new DateTime(2022, 10, 18, 13, 30, 00), EndDateTime = new DateTime(2022, 10, 18, 14, 00, 00), EventDefinitionID = 2},
				//new Event {ID = 100154, StartDateTime = new DateTime(2022, 10, 18, 14, 00, 00), EndDateTime = new DateTime(2022, 10, 18, 14, 30, 00), EventDefinitionID = 2},
				//new Event {ID = 100155, StartDateTime = new DateTime(2022, 10, 18, 14, 30, 00), EndDateTime = new DateTime(2022, 10, 18, 14, 58, 12), EventDefinitionID = 2},
				//new Event {ID = 100156, StartDateTime = new DateTime(2022, 10, 18, 14, 58, 12), EndDateTime=null, EventDefinitionID = 1},

				//copy events from GetQuestionThreeEventList() because there are events contains LinkedEventID
				new Event {ID = 100144, StartDateTime = new DateTime(2022, 10,18,11,00,00), EndDateTime = null, EventDefinitionID = 8 },
				new Event {ID = 100145, StartDateTime = new DateTime(2022, 10, 18, 11, 00, 00), EndDateTime = new DateTime(2022, 10, 18, 11, 13, 10), EventDefinitionID = 1, LinkedEventID = 100144},
				new Event {ID = 100146, StartDateTime = new DateTime(2022, 10, 18, 11, 13, 10), EndDateTime = new DateTime(2022, 10, 18, 12, 00, 00).AddMinutes(120), EventDefinitionID = 4 },
				new Event {ID = 100147, StartDateTime = new DateTime(2022, 10, 18, 11, 13, 10), EndDateTime = new DateTime(2022, 10, 18, 11, 37, 41), EventDefinitionID = 3},
				new Event {ID = 100148, StartDateTime = new DateTime(2022, 10, 18, 11, 37, 41), EndDateTime = new DateTime(2022, 10, 18, 12, 00, 00), EventDefinitionID = 2},
				new Event {ID = 100149, StartDateTime = new DateTime(2022, 10, 18, 12, 00, 00), EndDateTime = new DateTime(2022, 10, 18, 12, 30, 00), EventDefinitionID = 2},
				new Event {ID = 100150, StartDateTime = new DateTime(2022, 10, 18, 12, 30, 00), EndDateTime = new DateTime(2022, 10, 18, 13, 30, 00), EventDefinitionID = 6},
				new Event {ID = 100151, StartDateTime = new DateTime(2022, 10, 18, 12, 30, 00), EndDateTime = new DateTime(2022, 10, 18, 12, 30, 00).AddMinutes(120), EventDefinitionID = 4 },
				new Event {ID = 100152, StartDateTime = new DateTime(2022, 10, 18, 14, 30, 10), EndDateTime = new DateTime(2022, 10, 18, 14, 58, 00), EventDefinitionID = 4 },
				new Event {ID = 100153, StartDateTime = new DateTime(2022, 10, 18, 13, 30, 00), EndDateTime = new DateTime(2022, 10, 18, 14, 00, 00), EventDefinitionID = 2},
				new Event {ID = 100154, StartDateTime = new DateTime(2022, 10, 18, 14, 00, 00), EndDateTime = new DateTime(2022, 10, 18, 14, 30, 00), EventDefinitionID = 2},
				new Event {ID = 100155, StartDateTime = new DateTime(2022, 10, 18, 14, 30, 00), EndDateTime = new DateTime(2022, 10, 18, 14, 58, 12), EventDefinitionID = 2},
				new Event {ID = 100156, StartDateTime = new DateTime(2022, 10, 18, 14, 58, 12), EndDateTime=null, EventDefinitionID = 1, LinkedEventID = 100144},
			};
		}
	}
}