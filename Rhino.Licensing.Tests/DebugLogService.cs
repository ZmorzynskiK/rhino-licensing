using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rhino.Licensing.Tests
{
	public class DebugLogService : ILogService
	{
		public void DebugFormat(string format, params object[] args)
		{
			System.Diagnostics.Debug.WriteLine(string.Format("[Debug] " + format, args));
		}

		public void Error(string msg, Exception e)
		{
			System.Diagnostics.Debug.WriteLine(string.Format("[Error] " + msg + ": {0}", e.ToString()));
		}

		public void InfoFormat(string format, params object[] args)
		{
			System.Diagnostics.Debug.WriteLine(string.Format("[Info] " + format, args));
		}

		public void Warn(string msg)
		{
			System.Diagnostics.Debug.WriteLine("[Warn] " + msg);
		}

		public void Warn(string msg, Exception e)
		{
			System.Diagnostics.Debug.WriteLine(string.Format("[Warn] " + msg + ": {0}", e.ToString()));
		}

		public void WarnFormat(string format, params object[] args)
		{
			System.Diagnostics.Debug.WriteLine(string.Format("[Warn] " + format, args));
		}
	}
}
