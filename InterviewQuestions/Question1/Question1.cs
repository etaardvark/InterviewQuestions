/* Question 1: A manufacturing line produces different products. 
 * For the line to run, a job with that product must be started.
 * The line can be in many different states, depending on the state, a different Event will be recorded for the line.
 * For example when the line has an active job a Running event will be active.
 * The line has finished a job with product A, some time has passed with the system recording different types of events, then a new job has started with product B.
 * The Changeover duration between product A and B should be 120 minutes. This duration can vary depending on the product.
 * Modify the method below so that the list returned contains changeover events present between the running events for the correct time duration.
 * These are new Event Object with the correct event Defination
 * The changeover event can only be 120 minutes or less. The remaining duration should instead be set to a Changeover Overage event.
 * Changeover events can only occur when the line is not running or when the line is not in a SystemNotScheduled event.
 * 
 * Update the Test Case to prove the method is working as specified by validating the return list
 */

using System;
using System.Collections.Generic;

namespace InterviewQuestions
{
    public class Question1
    {
        public void Q1Main()
        {
            List<EventDefinition> eventDefinitions = Program.GetEventDefinitionList();
            List<Event> events = Program.GetEventList();
            int changeoverDuration = 120;

            EvaluateChangeover(eventDefinitions, events, changeoverDuration);
        }

        public List<Event> EvaluateChangeover(List<EventDefinition> eventDefinitions, List<Event> events, int changeoverDuration)
        {


            return null;
        }
    }
}