using System;
using System.Collections.Generic;
using System.Text;

namespace TextClassificationGUI
{
	using System.Diagnostics;

	public static class TimeUtils
	{
		public static long GetNanoseconds()
		{
			double timestamp = Stopwatch.GetTimestamp();
			double nanoseconds = 1_000_000_000.0 * timestamp / Stopwatch.Frequency;

			return (long)nanoseconds;
		}
	}
}
