using InterviewQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
	/* Question 3: Active Events
	* An Event is 'Active' when the EndDateTime is null which indicates that the event is still ongoing on the line
	* 
	* There can be multiple active events on the line at any point in time
	* Modify the method below to return only the Active events for the line
	* Changeover events can only occur when the line is not running or when the line is not in a SystemNotScheduled event.
	* 
	* Update the Test Case to prove the method is working as specified by validating the return list
	*/
	public class Question3
	{
		public void Q3Main()
		{
			List<EventDefinition> eventDefinitions = Program.GetEventDefinitionList();
			List<Event> events = Program.GetQuestionThreeEventList();			

			RetrieveAllActiveEvents(events);
		}

		public List<Event> RetrieveAllActiveEvents(IList<Event> events)
		{
			List<Event> activeEvents = new List<Event>();

			foreach(Event @event in events)
				if(@event.EndDateTime == null) activeEvents.Add(@event);

			return activeEvents;
		}
	}
}
