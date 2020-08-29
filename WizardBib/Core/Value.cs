using System;
using System.Collections.Generic;

namespace WizardBib
{
	//abgeschlossene Klasse, fertig
	public class Value
    {
		public static readonly Value Null = new Value(0, "0", "Narr");
		public static readonly Value Eins = new Value(1, "1", "Eins");
		public static readonly Value Zwei = new Value(2, "2", "Zwei");
		public static readonly Value Drei = new Value(3, "3", "Drei");
		public static readonly Value Vier = new Value(4, "4", "Vier");
		public static readonly Value Fünf = new Value(5, "5", "Fünf");
		public static readonly Value Sechs = new Value(6, "6", "Sechs");
		public static readonly Value Sieben = new Value(7, "7", "Sieben");
		public static readonly Value Acht = new Value(8, "8", "Acht");
		public static readonly Value Neun = new Value(9, "9", "Neun");
		public static readonly Value Zehn = new Value(10, "10", "Zehn");
		public static readonly Value Elf = new Value(11, "11", "Elf");
		public static readonly Value Zwölf = new Value(12, "12", "Zwölf");
		public static readonly Value Dreizehn = new Value(13, "13", "Dreizehn");
		public static readonly Value Wizard = new Value(14, "W", "Wizard");

		public static List<Value> allValues = new List<Value>() { Null, Eins, Zwei, Drei, Vier, Fünf, Sechs,
		Sieben, Acht, Neun, Zehn, Elf, Zwölf, Dreizehn, Wizard};

		public int Index { get; set; }
		public string ShortNm { get; set; }
		public string Description { get; set; }


		private Value(int index, String shortNm, String description)
		{
			Index = index;
			ShortNm = shortNm;
			Description = description;

			
		}

		public bool isGreater(Value v)
		{
			if (v == null)
			{
				return false;
			}
			return (Index > v.Index);

		}

		public static Value findValueByShortName(string shortName)
        {
			if (shortName.Equals(Value.Wizard.ShortNm, StringComparison.InvariantCultureIgnoreCase))
			return Value.Wizard;

			else if (shortName.Equals(Value.Eins.ShortNm, StringComparison.InvariantCultureIgnoreCase))
			{
				return Value.Eins;
			}
			else if (shortName.Equals(Value.Zwei.ShortNm, StringComparison.InvariantCultureIgnoreCase))
			{
				return Value.Zwei;
			}
			else if (shortName.Equals(Value.Drei.ShortNm, StringComparison.InvariantCultureIgnoreCase))
			{
				return Value.Drei;
			}
			else if (shortName.Equals(Value.Vier.ShortNm, StringComparison.InvariantCultureIgnoreCase))
			{
				return Value.Vier;
			}
			else if (shortName.Equals(Value.Fünf.ShortNm, StringComparison.InvariantCultureIgnoreCase))
			{
				return Value.Fünf;
			}
			else if (shortName.Equals(Value.Sechs.ShortNm, StringComparison.InvariantCultureIgnoreCase))
			{
				return Value.Sechs;
			}
			else if (shortName.Equals(Value.Sieben.ShortNm, StringComparison.InvariantCultureIgnoreCase))
			{
				return Value.Sieben;
			}
			else if (shortName.Equals(Value.Acht.ShortNm, StringComparison.InvariantCultureIgnoreCase))
			{
				return Value.Acht;
			}
			else if (shortName.Equals(Value.Neun.ShortNm, StringComparison.InvariantCultureIgnoreCase))
			{
				return Value.Neun;
			}
			else if (shortName.Equals(Value.Zehn.ShortNm, StringComparison.InvariantCultureIgnoreCase))
			{
				return Value.Zehn;
			}
			else if (shortName.Equals(Value.Elf.ShortNm, StringComparison.InvariantCultureIgnoreCase))
			{
				return Value.Elf;
			}
			else if (shortName.Equals(Value.Zwölf.ShortNm, StringComparison.InvariantCultureIgnoreCase))
			{
				return Value.Zwölf;
			}
			else if (shortName.Equals(Value.Dreizehn.ShortNm, StringComparison.InvariantCultureIgnoreCase))
			{
				return Value.Dreizehn;
			}
			else if (shortName.Equals(Value.Null.ShortNm, StringComparison.InvariantCultureIgnoreCase))
			{
				return Value.Null;
			}
			return null;

		}

		public static Value findValueByIndex(int index)
		{
			foreach (var item in allValues)
			{
				if (item.Index == index)
				{
					return item;
				}

			}
			throw new Exception("Value index " + index + " nicht gefunden.");
		}

	}
}