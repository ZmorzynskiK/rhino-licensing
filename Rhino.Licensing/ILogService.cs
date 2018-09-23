using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rhino.Licensing
{
	public interface ILogService
	{
		void Warn(string msg);
		void Warn(string msg, Exception e);
		void WarnFormat(string format, params object[] args);
		void InfoFormat(string format, params object[] args);
		void Error(string msg, Exception e);
		void DebugFormat(string format, params object[] args);
	}
}
