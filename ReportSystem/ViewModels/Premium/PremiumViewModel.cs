using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using ReportSystem.Common.ViewModel;
using ReportSystem.Models;
using DevExpress.Mvvm.POCO;
using System.Linq;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class PremiumViewModel: SingleViewModel<PremiumDisplayItemModel>
    {
        public static PremiumViewModel Create()
        {
            return ViewModelSource.Create(() => new PremiumViewModel());
        }

        protected PremiumViewModel() { }

        public virtual PremiumDisplayItemModel Content { get; set; }
        private INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
        protected IDocumentManagerService documentManagerService { get { return this.GetService<IDocumentManagerService>(); } }

        public void AddItem()
        {
            IDocument doc = documentManagerService.CreateDocument("AddPremiumView", null, this);
            doc.Id = documentManagerService.Documents.Count();
            doc.Title = "新增被担保人信息";
            var docVM = (AddPremiumViewModel)doc.Content;
            doc.Show();
            if (docVM.IsChange)
            {
                Content.PremiumItems.Add(docVM.Content);
            }

        }



        protected override void OnParameterChanged(object parameter)
        {
            base.OnParameterChanged(parameter);
            this.Content = base.ContentBase;
        }
        public void GoBack()
        {
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();
        }

    }
}