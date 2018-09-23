using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rhino.Licensing
{
	public class StringBuilderLogService : ILogService
	{
		private StringBuilder _sb = new StringBuilder();

		public void DebugFormat(string format, params object[] args)
		{
			_sb.AppendFormat("[Debug] " + format, args).AppendLine();
		}

		public void Error(string msg, Exception e)
		{
			_sb.AppendFormat("[Error] " + msg + ": {0}", e.ToString()).AppendLine();
		}

		public void InfoFormat(string format, params object[] args)
		{
			_sb.AppendFormat("[Info] " + format, args).AppendLine();
		}

		public void Warn(string msg)
		{
			_sb.Append("[Warn] " + msg).AppendLine();
		}

		public void Warn(string msg, Exception e)
		{
			_sb.AppendFormat("[Warn] " + msg + ": {0}", e.ToString()).AppendLine();
		}

		public void WarnFormat(string format, params object[] args)
		{
			_sb.AppendFormat("[Warn] " + format, args).AppendLine();
		}

		public override string ToString()
		{
			return _sb.ToString();
		}
	}
}
