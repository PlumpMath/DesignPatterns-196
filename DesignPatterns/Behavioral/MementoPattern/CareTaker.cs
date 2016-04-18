using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.MementoPattern
{
	public class CareTaker
	{
		public List<Memento> MementoList { get; set; }

		public CareTaker()
		{
			MementoList = new List<Memento>();
		}

		public void add(Memento state)
		{
			MementoList.Add(state);
		}

		public Memento get(int index)
		{
			return MementoList.ElementAt(index);
		}
	}
}
