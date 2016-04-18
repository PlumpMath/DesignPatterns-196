using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.MementoPattern
{
	public class Originator
	{
		public string State { get; set; }

		public Memento saveStatetoMemento()
		{
			return new Memento(State);
		}

		public void getStateFromMemento(Memento memento)
		{
			State = memento.State;
		}
	}
}
