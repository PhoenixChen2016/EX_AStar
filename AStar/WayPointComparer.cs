using System;
using System.Collections.Generic;
using System.Text;

namespace AStar
{
	public class WayPointComparer : IComparer<WayPoint>
	{
		public int Compare(WayPoint x, WayPoint y)
		{
			return x.TotalCost.CompareTo(y.TotalCost);
		}
	}
}
