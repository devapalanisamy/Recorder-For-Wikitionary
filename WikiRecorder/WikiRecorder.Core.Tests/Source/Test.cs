using NUnit.Framework;
using System;

namespace WikiRecorder.Core.Tests
{
	[TestFixture()]
	public class Test
	{
		//Add two numbers

		[Test()]
		public void TestAddingNumbers()
		{
			MyClass myClass = new MyClass ();
			Assert.AreEqual(15, myClass.AddTwoNumbers(10, -5));
		}


	}
}

