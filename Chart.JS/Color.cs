//************************
//**	Color Classes	**
//**	 Version 1.0	**
//************************
using System;

namespace ChartJS
{
	/// <summary>
	/// Color Basic class
	/// </summary>
	public class Color
	{
		private byte _red, _green, _blue;
		private float _alpha;
		public byte red
		{
			get { return this._red; }
			set { this._red = value;}
		}
		public byte green
		{
			get { return this._green; }
			set { this._green = value; }
		}
		public byte blue
		{
			get { return this._blue; }
			set { this._blue = value; }
		}

		public virtual float alpha
		{
			get { return this._alpha; }
			set { this._alpha = value; }
		}
	}
	/// <summary>
	/// RGB Color - rgb(255, 255, 255)
	/// </summary>
	public class RGB : Color
	{
		private const string Regex = @"rgb\((?:\s*)(?:(\d{1,3})\s*,+)(?:\s*)(?:(\d{1,3})\s*,+)(?:\s*)(?:(\d{1,3}))\)";
		public override float alpha
		{
			get
			{
				throw new NotSupportedException("RGB Color does not have an alpha value");
			}
			set
			{
				throw new NotSupportedException("RGB Color does not have an alpha value");
			}
		}
		public RGB(byte red, byte green, byte blue)
		{
			this.red = red;
			this.green = green;
			this.blue = blue;
		}
		public static implicit operator RGB(RGBA cl)
		{
			return new RGB(cl.red, cl.green, cl.blue);
		}
		public static implicit operator RGB(HTMLColor cl)
		{
			return new RGB(cl.red, cl.green, cl.blue);
		}
		public static implicit operator RGB(System.Drawing.Color cl)
		{
			return new RGB(cl.R, cl.G, cl.B);
		}
		public static implicit operator string(RGB cl)
		{
			return string.Format("rgb({0}, {1}, {2})", cl.red, cl.green, cl.blue);
		}
		public static implicit operator RGB(string str)
		{
			System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(Regex);
			var x = r.Match(str);
			if (x.Success)
			{
				return new RGB(
					(byte)int.Parse(x.Groups[1].Value),
					(byte)int.Parse(x.Groups[2].Value),
					(byte)int.Parse(x.Groups[3].Value));
			}
			else throw new Exception("The given string has not the correct format.");
		}
	}
	/// <summary>
	/// RGBA Color - rgba(255, 255, 255, 1)
	/// </summary>
	public class RGBA : Color
	{
		private const string Regex = @"rgba\((?:\s*)(?:(\d{1,3})\s*,+)(?:\s*)(?:(\d{1,3})\s*,+)(?:\s*)(?:(\d{1,3})\s*,+)(?:\s*)(?:((?:[0-9]+[.])?[0-9]+)(?:\s*))\)";
		public RGBA(byte red, byte green, byte blue, float alpha)
		{
			this.red = red;
			this.green = green;
			this.blue = blue;
			this.alpha = alpha;
		}
		public static implicit operator RGBA(RGB cl)
		{
			return new RGBA(cl.red, cl.green, cl.blue, 1);
		}
		public static implicit operator RGBA(HTMLColor cl)
		{
			return new RGBA(cl.red, cl.green, cl.blue,1);
		}
		public static implicit operator RGBA(System.Drawing.Color cl)
		{
			return new RGBA(cl.R, cl.G, cl.B,cl.A);
		}
		public static implicit operator string(RGBA cl)
		{
			return string.Format("rgba({0}, {1}, {2}, {3})", cl.red, cl.green, cl.blue,cl.alpha);
		}
		public static implicit operator RGBA(string str)
		{
			System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(Regex);
			var x = r.Match(str);
			if (x.Success)
			{
				return new RGBA(
					(byte)int.Parse(x.Groups[1].Value),
					(byte)int.Parse(x.Groups[2].Value),
					(byte)int.Parse(x.Groups[3].Value),
					float.Parse(x.Groups[4].Value));
			}
			else throw new Exception("The given string has not the correct format.");
		}
	}
	/// <summary>
	/// HTML Color - #FFFFFF
	/// </summary>
	public class HTMLColor : Color
	{
		private const string Regex = @"(?:#)([a-zA-Z0-9]{2})([a-zA-Z0-9]{2})([a-zA-Z0-9]{2})";
		public override float alpha
		{
			get
			{
				throw new NotSupportedException("HTML Color does not have an alpha value");
			}
			set
			{
				throw new NotSupportedException("HTML Color does not have an alpha value");
			}
		}
		public HTMLColor(byte red, byte green, byte blue)
		{
			this.red = red;
			this.green = green;
			this.blue = blue;
		}
		public static implicit operator HTMLColor(RGB cl)
		{
			return new HTMLColor(cl.red, cl.green, cl.blue);
		}
		public static implicit operator HTMLColor(RGBA cl)
		{
			return new HTMLColor(cl.red, cl.green, cl.blue);
		}
		public static implicit operator HTMLColor(System.Drawing.Color cl)
		{
			return new HTMLColor(cl.R, cl.G, cl.B);
		}
		public static implicit operator string(HTMLColor cl)
		{
			return string.Format("#{0}{1}{2}",
				ConvertHexToString(cl.red),
				ConvertHexToString(cl.green),
				ConvertHexToString(cl.blue));
		}
		public static implicit operator HTMLColor(string str)
		{
			System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(Regex);
			var x = r.Match(str);
			if (x.Success)
			{
				return new HTMLColor(
					StringToByteArray(x.Groups[1].Value),
					StringToByteArray(x.Groups[2].Value),
					StringToByteArray(x.Groups[3].Value));
			}
			else throw new Exception("The given string has not the correct format.");
		}
		private static string ConvertHexToString(byte value)
		{
			return BitConverter.ToString(new byte[] { (byte)value }).Replace("-", "");
		}
		private static byte StringToByteArray(string hex)
		{
			return System.Linq.Enumerable.Range(0, hex.Length)
							 .Where(x => x % 2 == 0)
							 .Select(x => Convert.ToByte(hex.Substring(x, 2), 16)).Single();
		}
	}
}
