using InterviewQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
	/* Question 2: A manufacturing line produces different products. 
	* For the line to run, a job with that product must be started.
	* The line can be in many different states, depending on the state, a different Event will be recorded for the line.
	* For example when the line has an active job a Running event will be active.
	* The line has finished a job with product A, some time has passed with the system recording different types of events, then a new job has started with product B.
	* The Changeover duration between product A and B should be 120 minutes. This duration can vary depending on the product.
	*
	* Modify the method below RetrieveAllChangeoverEvents to return all Changeover or Changeover Overrun events, based on their event definition
	* Changeover events can only occur when the line is not running or when the line is not in a SystemNotScheduled event.
	* 
	* Update the Test Case to prove the method is working as specified by validating the return list
	*/

	public class Question2
	{
		public void Q2Main()
		{
			List<EventDefinition> eventDefinitions = Program.GetEventDefinitionList();
			List<Event> events = Program.GetQuestionTwoEventList();
			int changeoverDuration = 120;

			RetrieveAllChangeoverEvents(eventDefinitions, events, changeoverDuration);
		}

		public List<Event> RetrieveAllChangeoverEvents(List<EventDefinition> eventDefinitions, List<Event> events, int changeoverDuration)
		{
			List<Event> resEvents = new List<Event>();
			if (events.Count == 0) return resEvents;

			int currentEventID = events[0].ID;

			foreach (Event @event in events)
			{
				//Scenario 1:
				//if (@event.EventDefinitionID == 4 || @event.EventDefinitionID == 5) resEvents.Add(@event);


				//Scenario 2: if Changeover is longer than changeoverDuration, then split Changeover to Changeover + ChangeoverOverage and update EventID in all events accordingly
				if (@event.EventDefinitionID == 4)
				{
					if (@event.EndDateTime != null)
					{
						int duration = (int)(@event.EndDateTime - @event.StartDateTime).Value.TotalMinutes;
						if (duration > changeoverDuration)
						{
							DateTime? tmpEndTime = @event.EndDateTime;

							@event.ID = currentEventID++;
							@event.EndDateTime = @event.StartDateTime.AddMinutes(changeoverDuration);
							resEvents.Add(@event);

							Event changeoverOverageEvent = new Event() { ID = currentEventID, StartDateTime = @event.StartDateTime.AddMinutes(changeoverDuration), EndDateTime = tmpEndTime, EventDefinitionID = 5 };
							resEvents.Add(changeoverOverageEvent);
						}
						else
						{
							@event.ID = currentEventID;
							resEvents.Add(@event);
						}
					}
                    else
                    {
						@event.ID = currentEventID;
						resEvents.Add(@event);
					}
				}
				else if (@event.EventDefinitionID == 5) 
				{ 
					@event.ID = currentEventID; resEvents.Add(@event); 
				}
				else
				{
					@event.ID = currentEventID;
				}


				currentEventID++;
			}

			return resEvents;
			
		}
	}
}
