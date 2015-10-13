using System;

namespace HappyParty
{
	public class Drink
	{
		public Drink (string name, nint amount)
		{
			this.name = name;
			this.amount = amount;
		}

		string name {
			get;
			set;
		}

		nint amount {
			get;
			set;
		}
	}
}
