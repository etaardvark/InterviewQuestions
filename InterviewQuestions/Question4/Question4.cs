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
		
			RetrieveLinkedEvents(100145);
			RetrieveLinkedEvents(100147);
			RetrieveLinkedEvents(100156);

		}

		public List<Event> RetrieveLinkedEvents(int originalLinkedEvent)
		{
			return null;
		}
	}
}
