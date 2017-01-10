using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Helpers
{
    /// <summary>
    /// 报表引发的异常
    /// </summary>
    public class ReportException : ApplicationException
    {
        public ReportException() { }
        public ReportException(string message) : base(message) { }
        public ReportException(string message, Exception inner) : base(message, inner) { }
    }
}
