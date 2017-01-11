using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Models
{
    public class LoginModel
    {
        public string PWD { get; set; }

    }

    public class LoginResultModel
    {
        public LoginStatus Status { get; set; }

        public string Message { get; set; }
    }

    /// <summary>
    /// 结果反馈
    /// </summary>
    public enum LoginStatus
    {
        /// <summary>
        /// 通过
        /// </summary>
        PASS = 0,
        /// <summary>
        /// 拒绝
        /// </summary>
        REJECT = 1,

    }
}
