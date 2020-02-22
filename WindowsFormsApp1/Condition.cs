// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	public enum Predicate
	{
		More,
		Less,
		Equal,
		MoreEqual,
		LessEqual
	}

	[Serializable]
	public class Condition : ICloneable
	{
		public int indexOfInterval1;
		public ParameterCondition parameter1;
		public Indicator indicator1;
		public Predicate predicate;
		public Indicator indicator2;
		public ParameterCondition parameter2;
		public int indexOfInterval2;
		public double const1;
		public double const2;

		public Condition() { }

		public Condition(int index1, int index2, ParameterCondition par1, ParameterCondition par2,
			Indicator ind1, Indicator ind2, double c1, double c2, Predicate pred)
		{
			indexOfInterval1 = index1;
			parameter1 = par1;
			indicator1 = ind1;
			predicate = pred;
			indicator2 = ind2;
			parameter2 = par2;
			indexOfInterval2 = index2;
			const1 = c1;
			const2 = c2;
		}

		public override string ToString()
		{
			string str = "";
			if (parameter1 == ParameterCondition.Indicator)
				str += Config.indicator2name[indicator1.GetType()] + "(" + indicator1.Period + ") ";
			else
				str += Config.paramPrice2str[parameter1];
			str += "  на интервале i - " + indexOfInterval1 + "        ";

			str += Config.predicate2str[predicate] + "        ";

			if (parameter2 == ParameterCondition.Indicator)
			{
				str += Config.indicator2name[indicator2.GetType()] + "(" + indicator2.Period + ") ";
				str += "  на интервале i - " + indexOfInterval2 + "   ";
			} else if (parameter2 == ParameterCondition.Const)
			{
				str += " константа = " + const2 + "  ";
			}
			else
			{
				str += Config.paramPrice2str[parameter2];
				str += "  на интервале i - " + indexOfInterval2 + "   ";
			}

			return str;
		}
		
		//Проверка срабатывания условия
		public bool check(int curIndex, FinancialInstrument instr)
		{
			//Обновить индикаторы
			if (indicator1 != null)
				indicator1.update_value(curIndex, instr);

			if (indicator2 != null)
				indicator2.update_value(curIndex, instr);

			double par1 = 0, par2 = 0;
			switch(parameter1)
			{
				case ParameterCondition.Const:
					par1 = const1;
					break;
				case ParameterCondition.PriceClose:
					par1 = instr.get_interval(curIndex, indexOfInterval1).ClosingPrice;
					break;
				case ParameterCondition.PriceOpen:
					par1 = instr.get_interval(curIndex, indexOfInterval1).OpeningPrice;
					break;
				case ParameterCondition.PriceMax:
					par1 = instr.get_interval(curIndex, indexOfInterval1).MaxPrice;
					break;
				case ParameterCondition.PriceMin:
					par1 = instr.get_interval(curIndex, indexOfInterval1).MinPrice;
					break;
				case ParameterCondition.Volume:
					par1 = instr.get_interval(curIndex, indexOfInterval1).Volume;
					break;
				default:        //Индикатор
					par1 = indicator1.get_value(curIndex, indexOfInterval1);
					break;
			}

			switch (parameter2)
			{
				case ParameterCondition.Const:
					par2 = const2;
					break;
				case ParameterCondition.PriceClose:
					par2 = instr.get_interval(curIndex, indexOfInterval2).ClosingPrice;
					break;
				case ParameterCondition.PriceOpen:
					par2 = instr.get_interval(curIndex, indexOfInterval2).OpeningPrice;
					break;
				case ParameterCondition.PriceMax:
					par2 = instr.get_interval(curIndex, indexOfInterval2).MaxPrice;
					break;
				case ParameterCondition.PriceMin:
					par2 = instr.get_interval(curIndex, indexOfInterval2).MinPrice;
					break;
				case ParameterCondition.Volume:
					par2 = instr.get_interval(curIndex, indexOfInterval2).Volume;
					break;
				default:        //Индикатор
					par2 = indicator2.get_value(curIndex, indexOfInterval2);
					break;
			}

			switch (predicate)
			{
				case Predicate.Equal:
					return par1 == par2;
				case Predicate.Less:
					return par1 < par2;
				case Predicate.LessEqual:
					return par1 <= par2;
				case Predicate.More:
					return par1 > par2;
				case Predicate.MoreEqual:
					return par1 >= par2;
			}
			return false;
		}

		public object Clone()
		{
			return new Condition(indexOfInterval1, indexOfInterval2, parameter1, parameter2, indicator1,
				indicator2, const1, const2, predicate);
		}

		public override bool Equals(object other)
		{
			Condition o = (Condition)other;
			return indexOfInterval1 == o.indexOfInterval1 &&
				indexOfInterval2 == o.indexOfInterval2 &&
				o.indicator1 == indicator1 &&
				o.indicator2 == indicator2 &&
				o.parameter1 == parameter1 &&
				o.parameter2 == parameter2 &&
				o.predicate == predicate &&
				o.const1 == const1 &&
				o.const2 == const2;
		}

		public override int GetHashCode()
		{
			return indexOfInterval1 ^ indexOfInterval2 ^ (int)parameter1 ^ (int)parameter2;
		}
	}
}
