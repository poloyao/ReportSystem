using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using ReportSystem.Models;
using ReportSystem.Common.ViewModel;
using System.Linq;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class AddHalfYearViewModel: SingleViewModel<ReportHalfYearModel>
    {
        public static AddHalfYearViewModel Create()
        {
            return ViewModelSource.Create(() => new AddHalfYearViewModel());
        }

        protected AddHalfYearViewModel()
        {

        }

        protected IDocumentManagerService documentManagerService { get { return this.GetService<IDocumentManagerService>(); } }

        public ReportHalfYearModel Content { get; set; } = new ReportHalfYearModel();
        public bool IsSaved { get; set; } = false;

        /// <summary>
        /// 上/下半年
        /// </summary>
        public string HalfYear { get; set; }


        public void AddDetail()
        {
            var vm = AddHalfYearDetailViewModel.Create();
            IDocument doc = documentManagerService.FindDocument(vm);

            if (doc == null)
            {
                doc = documentManagerService.CreateDocument("AddHalfYearDetailView", null, vm);
                doc.Id = documentManagerService.Documents.Count();
                doc.Title = "新增信息备案表";
            }
            doc.Show();
            var docVM = (AddHalfYearDetailViewModel)doc.Content;
            if (docVM.IsSaved)
            {
                Content.HalfYearDetail.Add(docVM.Content);
            }
        }

        public void Save()
        {
            Content.HalfYear = HalfYear;
            var query = base.AddItem(Content);
            if (query != null)
            {
                Content = query;
                IsSaved = true;
            }
        }

    }
}