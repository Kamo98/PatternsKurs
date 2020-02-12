using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	class StandartReader : InstrumentReader
	{
		public void read(string path, FinancialInstrument instr)
		{
			StreamReader file = new StreamReader(path);
			string line;
			line = file.ReadLine();
			while ((line = file.ReadLine()) != null)
			{
				string[] splitLine = line.Split(',');

				//Преобразование даты и времени
				string date = splitLine[2], time = splitLine[3];
				DateTime dateTime = new DateTime(
					Int32.Parse(date.Substring(0, 4)),
					Int32.Parse(date.Substring(4, 2)),
					Int32.Parse(date.Substring(6, 2)),
					Int32.Parse(time.Substring(0, 2)),
					Int32.Parse(time.Substring(2, 2)),
					Int32.Parse(time.Substring(4, 2))
				);

				instr.add_interval(new TradingInterval(
					Double.Parse(splitLine[4].Replace('.', ',')),
					Double.Parse(splitLine[7].Replace('.', ',')),
					Double.Parse(splitLine[6].Replace('.', ',')),
					Double.Parse(splitLine[5].Replace('.', ',')),
					Double.Parse(splitLine[8].Replace('.', ',')),
					dateTime
					));
			}

			file.Close();
			instr.Loaded = true;
		}
	}
}
