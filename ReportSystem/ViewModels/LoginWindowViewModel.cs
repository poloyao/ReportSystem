using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataAnnotations;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class LoginWindowViewModel
    {
        public event EventHandler LoginSucess;

        public virtual string Name { get; set; }
        public virtual string Pwd { get; set; }

        public void Login()
        {
            LoginSucess(this, EventArgs.Empty);
        }

    }
}
