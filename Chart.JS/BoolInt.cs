//************************
//**	  BoolInt		**
//**	 Version 1.0	**
//************************
namespace Chart.JS
{
	/// <summary>
	/// BoolInt class value. This is a class that beening used when a property is either bool or int.
	/// <br>Note that if you set the bool value the int value will get setted to null and vice versa.</br>
	/// </summary>
	public class BoolInt
	{
		private bool? boolean = null;
		private int? number = null;
		public bool Boolean
		{
			get
			{
				return (bool)this.boolean;
			}
			set
			{
				this.boolean = value;
				this.number = null;
			}
		}
		public int Pixel 
		{
			get
			{
				return (int)this.number;
			}
			set
			{
				this.number = value;
				this.boolean = null;
			}
		}
		public BoolInt(bool boolean)
		{
			this.boolean = boolean;
		}
		public BoolInt(int number)
		{
			this.number = number;
		}
		public static implicit operator string(BoolInt var)
		{
			if (var.boolean == null)
				return var.number.ToString();
			else return var.boolean == true ? "true" : "false";
		}
	}
}
