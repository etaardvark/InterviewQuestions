using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
	public class Question4
	{
		/* Question 3: Linked Events
		* An Event can be linked to another event as a related event
		* 
		* Update the method RetrieveLinkedEvent to either return a linked event or null if no event is linked
		* 
		* use event id's to test:
		* 100145
		* 
		* 
		*/
		public void Q4Main()
		{
			List<EventDefinition> eventDefinitions = Program.GetEventDefinitionList();
			List<Event> events = Program.GetQuestionFourEventList();
		
			RetrieveLinkedEvents(events, 100145);
			RetrieveLinkedEvents(events, 100147);
			RetrieveLinkedEvents(events, 100156);

		}

		public List<Event> RetrieveLinkedEvents(IList<Event> events, int originalLinkedEvent)  //Djordje: added events list becuase don't know where to look for 'linked events'
		{
			Dictionary<int, Event> keyEventPairs = new Dictionary<int, Event>();
			foreach (Event @event in events)
				if(!keyEventPairs.ContainsKey(@event.ID))
					keyEventPairs.Add(@event.ID, @event);


			List<Event> linkedEvents = new List<Event>();

			if (keyEventPairs.ContainsKey(originalLinkedEvent))
				if (keyEventPairs.ContainsKey(keyEventPairs[originalLinkedEvent].LinkedEventID))
					linkedEvents.Add(keyEventPairs[keyEventPairs[originalLinkedEvent].LinkedEventID]);

			if (linkedEvents.Count > 0) return linkedEvents;
			else return null;
		}
	}
}
