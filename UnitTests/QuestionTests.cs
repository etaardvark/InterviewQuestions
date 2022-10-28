using InterviewQuestions;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;

namespace UnitTests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Question1_Test()
		{
			Question1 questionUnderTest = new Question1();
			List<EventDefinition> eventDefinitions = Program.GetEventDefinitionList();
			List<Event> events = Program.GetEventList();
			int changeoverDuration = 120;

			var returnList = questionUnderTest.EvaluateChangeover(eventDefinitions, events, changeoverDuration);


			Assert.IsNotNull(returnList, "Should have returned a list");
			Assert.IsNotEmpty(returnList.Where(x => x.EventDefinitionID == 4), "Should have returned some Changeover events");
			Assert.IsNotEmpty(returnList.Where(x => x.EndDateTime.Value.Subtract(x.StartDateTime).TotalMinutes < changeoverDuration),
				"Should not have any Changeover events over the changeover duration");			
			Assert.Pass();
		}

		[Test]
		public void Question2_Test()
		{
			Question2 questionUnderTest = new Question2();
			List<EventDefinition> eventDefinitions = Program.GetEventDefinitionList();
			List<Event> events = Program.GetQuestionTwoEventList();
			int changeoverDuration = 120;

			var returnList = questionUnderTest.RetrieveAllChangeoverEvents(eventDefinitions, events, changeoverDuration);


			Assert.IsNotNull(returnList, "Should have returned a list");
			Assert.IsNotEmpty(returnList.Where(x => x.EventDefinitionID == 4 || x.EventDefinitionID == 5), "Should have returned some Changeover events or Changeover Overrun events");
			Assert.Pass();
		}

		[Test]
		public void Question3_Test()
		{
			Question3 questionUnderTest = new Question3();
			List<EventDefinition> eventDefinitions = Program.GetEventDefinitionList();
			List<Event> events = Program.GetQuestionThreeEventList();			

			var returnList = questionUnderTest.RetrieveAllActiveEvents(events);


			Assert.IsNotNull(returnList, "Should have returned a list");
			Assert.IsTrue(returnList.Count > 0, "Should have returned some Active Events");
			Assert.Pass();
		}

		[Test]
		public void Question4_Test()
		{
			Question4 questionUnderTest = new Question4();
			List<EventDefinition> eventDefinitions = Program.GetEventDefinitionList();
			List<Event> events = Program.GetQuestionFourEventList();

			var returnList = questionUnderTest.RetrieveLinkedEvents(100145);

			Assert.IsNotNull(returnList, "Should have returned a list");
			Assert.IsTrue(returnList.Where(x => x.ID == 1000144).ToList().Count > 0, "Should have returned a Linked Event");

			returnList = null;
			returnList = questionUnderTest.RetrieveLinkedEvents(100147);
			Assert.IsNull(returnList, "Should have no linked event for this event");

			returnList = null;
			returnList = questionUnderTest.RetrieveLinkedEvents(100156);
			Assert.IsNotNull(returnList, "Should have returned a list");
			Assert.IsTrue(returnList.Where(x => x.ID == 1000144).ToList().Count > 0, "Should have returned a Linked Event");


			Assert.Pass();
		}
	}
}