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

			return null;
		}
	}
}
