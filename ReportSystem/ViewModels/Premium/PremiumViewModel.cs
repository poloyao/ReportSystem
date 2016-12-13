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
            var vm = AddPremiumViewModel.Create();
            IDocument doc = documentManagerService.FindDocument(vm);

            if (doc == null)
            {
                doc = documentManagerService.CreateDocument("AddPremiumView", null, vm);
                doc.Id = documentManagerService.Documents.Count();
                doc.Title = "新增保费信息";
            }
            doc.Show();
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