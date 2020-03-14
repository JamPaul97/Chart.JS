using System;
using ChartJS;
using System.Windows.Forms;
using System.Linq;

namespace Tests
{
	public partial class Form1 : Form
	{
		private const string Regex = @"(?:#)([a-zA-Z0-9]{2})([a-zA-Z0-9]{2})([a-zA-Z0-9]{2})";
		public Form1()
		{
			InitializeComponent();
		}
		//private const string Regex = @"rgb\((?:\s*)(?:(\d{1,3})\s*,+)(?:\s*)(?:(\d{1,3})\s*,+)(?:\s*)(?:(\d{1,3}))\)";
		private void Form1_Load(object sender, EventArgs e)
		{
			System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(Regex);
			var x = r.Match("#BD4646");
			if (x.Success)
			{
				var b = StringToByteArray("BD");
				var a = new HTMLColor(
					StringToByteArray(x.Groups[1].Value),
					StringToByteArray(x.Groups[2].Value),
					StringToByteArray(x.Groups[3].Value));
			}
		}
		public static byte StringToByteArray(string hex)
		{
			return Enumerable.Range(0, hex.Length)
							 .Where(x => x % 2 == 0)
							 .Select(x => Convert.ToByte(hex.Substring(x, 2), 16)).Single();
		}
	}
}
