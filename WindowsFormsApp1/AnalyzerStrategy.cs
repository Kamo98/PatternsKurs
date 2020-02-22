// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
	public interface AnalyzerStrategy
	{
		void execute_analysis(List<Signal> signals);
		void accept_new_interval(int curIndex, FinancialInstrument instrument);
		void print(Series series);
	}
}
