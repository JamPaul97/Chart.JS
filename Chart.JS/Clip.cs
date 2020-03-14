//************************
//**	    Clip		**
//**	 Version 1.0	**
//************************
namespace ChartJS
{
	/// <summary>
	/// Clip class
	/// </summary>
	public class Clip
	{
		private int? number = null;
		private BoolInt bottom;
		private BoolInt top;
		private BoolInt left;
		private BoolInt right;
		public Clip(int? number = null, BoolInt bottom = null, BoolInt top = null, BoolInt left = null, BoolInt right = null)
		{
			this.number = number;
			this.bottom = bottom;
			this.top = top;
			this.left = left;
			this.right = right;
		}
		public static implicit operator string(Clip clip)
		{
			if (clip.number == null)
			{
				string result = "{";
				result += clip.bottom == null ? string.Empty : "bottom: " + clip.bottom;
				result += clip.top == null ? string.Empty : "top: " + clip.top;
				result += clip.left == null ? string.Empty : "left: " + clip.left;
				result += clip.right == null ? string.Empty : "right: " + clip.right;
				result += "}";
				return result;
			}
			else return clip.number.ToString();
		}
	}
}
