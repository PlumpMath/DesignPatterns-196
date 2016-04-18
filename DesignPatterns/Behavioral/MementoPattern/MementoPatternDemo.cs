using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.MementoPattern
{
	public class MementoPatternDemo
	{
		public static void Run()
		{
			var originator = new Originator();
			var careTaker = new CareTaker();

			originator.State = "State 1";
			originator.State = "State 2";

			careTaker.add(originator.saveStatetoMemento());

			originator.State = "State 3";
			careTaker.add(originator.saveStatetoMemento());

			originator.State = "State 4";
			Console.WriteLine("Current State: " + originator.State);

			originator.getStateFromMemento(careTaker.get(0));
			Console.WriteLine("FirstSaved State: " + originator.State);

			originator.getStateFromMemento(careTaker.get(1));
			Console.WriteLine("Second saved State: " + originator.State);

		}
	}
}
