//************************
//**	   Fill			**
//**	 Version 1.0	**
//************************

namespace ChartJS
{
	/// <summary>
	/// Fill class
	/// </summary>
	public class Fill
	{
		private int? absNumber = null;
		private int? relNumber = null;
		private Boundary? boundary = null;
		private bool? disabled = null;
		/// <summary>
		/// Creates a fill class with one of the chossen values. If more than one values is chosen then the first value of the list bellow will be returned when compliling.
		/// <br>1.Absolute Number</br>
		/// <br>2.Relative Number</br>
		/// <br>3.Boundary</br>
		/// <br>4.Disabled</br>
		/// <br>If no value is given the default value is : Disabled</br>
		/// </summary>
		/// <param name="Absolute"></param>
		/// <param name="Relative"></param>
		/// <param name="Boundary"></param>
		/// <param name="Disabled"></param>
		public Fill(int? Absolute = null, int? Relative = null, Boundary? Boundary = null,bool? Disabled = null)
		{
			this.absNumber = Absolute;
			this.relNumber = Relative;
			this.boundary = Boundary;
			this.disabled = Disabled;
		}
		public static implicit operator string(Fill fill)
		{
			if (fill.absNumber != null)
			{
				return fill.absNumber.ToString();
			}
			else if (fill.relNumber != null)
			{
				return "'" + fill.relNumber.ToString() + "'";
			}
			else if (fill.boundary != null)
			{
				if (fill.boundary == Boundary.end)
					return "'end'";
				else if (fill.boundary == Boundary.origin)
					return "'origin'";
				else return "'start'";
			}
			else return "false";
		}
		public enum Boundary
		{
			start,end,origin
		}
	}
}
