using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using ReportSystem.Common.ViewModel;
using ReportSystem.Models;
using System.Linq;
using System.Collections.ObjectModel;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class SupervisionViewModel:SingleViewModel<SupervisionDetailModel>
    {


        public virtual SupervisionDetailModel Content { get; set; }
        public virtual ObservableCollection<SupervisionRecoveryModel> RecoveryItems { get; set; } = new ObservableCollection<SupervisionRecoveryModel>();
        protected IDocumentManagerService documentManagerService { get { return this.GetService<IDocumentManagerService>(); } }




        protected override void OnParameterChanged(object parameter)
        {
            base.OnParameterChanged(parameter);
            if (parameter != null)
            {
                Content = ContentBase;
                if (Content.RecoveryItems != null)
                    this.RecoveryItems = new ObservableCollection<SupervisionRecoveryModel>(Content.RecoveryItems);
            }
        }


        public void AddRecovert()
        {
            var vm = SupervisionRecovertViewModel.Create();
            IDocument doc = documentManagerService.FindDocument(vm);

            if (doc == null)
            {
                doc = documentManagerService.CreateDocument("SupervisionRecovertView", null, vm);
                doc.Id = documentManagerService.Documents.Count();
                doc.Title = "新增追偿信息";
            }
            doc.Show();
            var docVM = (SupervisionRecovertViewModel)doc.Content;
            if (docVM.IsChange)
            {
                this.Content.RecoveryItems.Add(docVM.Content);
                this.RecoveryItems.Add(docVM.Content);
            }
        }
    }
}