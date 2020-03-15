//************************
//**	 Line Chart		**
//**	 Version 1.0	**
//************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJS
{
	public class LineChart
	{
		//Properties
		public Color backgroundColor = null;
		public CapStyle? borderCapStyle = null;
		public Color borderColor = null;
		public List<float> borderDash = null;
		public float? borderDashOffset = null;
		public JoinStyle? borderJoinStyle = null;
		public float? borderWidth = null;
		public string cubicInteroplationMode = null;
		public Clip clip = null;
		public Fill fill = null;
		public Color hoverBackgroundColor = null;
		public string hoverBorderCapStyle = null;
		public Color hoverBorderColor = null;
		public List<float> hoverBorderDash = null;
		public float? hoverBorderDashOffset = null;
		public JoinStyle? hoverBorderJoinStyle = null;
		public float? hoverBorderWidth = null;
		public string label = null;
		public float? lineTension = null;
		public float? order = null;
		public Color pointBackgroundColor = null;
		public Color pointBorderColor = null;
		public float? pointBorderWidth = null;
		public float? pointHitRadius = null;
		public Color pointHoverBackgroundColor = null;
		public Color pointHoverBorderColor = null;
		public float? pointHoverBorderWidth = null;
		public float? pointHoverRadius = null;
		public float? pointRadius = null;
		public float? pointRotation = null;
		public PointStyle? pointStyle = null;
		public bool? showLine = null;
		public bool? snapGaps = null;
		public SteppedLine steppedLine = null;
		public string yAxisID = null;
		public string xAxisID = null;
	}
	public enum PointStyle
	{
		circle,
		cross,
		crossRot,
		dash,
		line,
		rect,
		rectRounded,
		rectRot,
		star,
		triangle
	}
	public enum JoinStyle
	{
		bevel,
		round,
		miter
	}
	public enum CapStyle
	{
		butt,
		round,
		square
	}
}
