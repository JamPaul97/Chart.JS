//************************
//**	 Stepped Line	**
//**	 Version 1.0	**
//************************
namespace ChartJS
{
	public class SteppedLine
	{
		private bool? boolean = null;
		private SteppedLineEnum? Enum = null;
		/// <summary>
		/// Creates a Stepped Line class with one of the chossen values. If more than one values is chosen then the first value of the list bellow will be returned when compliling.
		/// <br>1.Enum</br>
		/// <br>2.Boolean</br>
		/// <br>If no value is given the default value is : Stepped Line - middle</br>
		/// </summary>
		/// <param name="boolean"></param>
		/// <param name="Enum"></param>
		public SteppedLine(bool? boolean = null, SteppedLineEnum? Enum = null)
		{
			this.boolean = boolean;
			this.Enum = Enum;
		}
		public static explicit operator string(SteppedLine sl)
		{
			if(sl.Enum != null)
			{
				if (sl.Enum == SteppedLineEnum.after)
					return "'after'";
				else if (sl.Enum == SteppedLineEnum.before)
					return "'before'";
				else return "'middle'";
			}
			return sl.boolean == null ? string.Empty : sl.boolean == true? "true" : "false";
		}


		public enum SteppedLineEnum
		{
			before,after,middle
		}
	}
}
