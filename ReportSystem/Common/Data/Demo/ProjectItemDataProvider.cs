using ReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Common.Data.Demo
{


    public class ProjectItemDataProvider : DataProviderBase<ProjectItemModel>
    {
        protected override ProjectItemModel AddItem(ProjectItemModel item)
        {
            throw new NotImplementedException();
        }

        protected override IList<ProjectItemModel> FillItems(object filter)
        {
            return new List<ProjectItemModel>()
            {
                ProjectItemModel.Create(x => { x.ID = Guid.NewGuid();x.Amount = 100000m; })
            };
        }

        protected override IList<ProjectItemModel> FillItems(object id, object filter)
        {
            return new List<ProjectItemModel>()
            {
                ProjectItemModel.Create(x => { x.ID = Guid.NewGuid();x.Amount = 100000m; })
            };
        }

        protected override ProjectItemModel GetItem(object id)
        {
            return ProjectItemModel.Create(x => { x.ID = Guid.NewGuid(); x.Amount = 100000m; });
        }

        protected override ProjectItemModel UpdateItem(ProjectItemModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }

    public class ContractItemDataProvider : DataProviderBase<ContractItemModel>
    {
        protected override ContractItemModel AddItem(ContractItemModel item)
        {
            throw new NotImplementedException();
        }

        protected override IList<ContractItemModel> FillItems(object filter)
        {
            return new List<ContractItemModel>()
            {
                GetItem(null)
            };
        }

        protected override IList<ContractItemModel> FillItems(object id, object filter)
        {
            return new List<ContractItemModel>()
            {
                //ContractItemModel.Create(x=> { x.ID = Guid.NewGuid();x.Amount =100003m; })
                GetItem(null)
            };
        }

        protected override ContractItemModel GetItem(object id)
        {
            int number = 1;
            return ContractItemModel.Create(x =>
            {
                x.ID = Guid.NewGuid();
                x.ProjectNo = "XM" + number.ToString("000");
                x.ContractrNo = "HT" + number.ToString("000");
                x.BusinessType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.BusinessType)).ID);
                x.GuaranteeType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.GuaranteeType)).ID);
                x.Amount = new Random().Next(100) * 100000;
                x.StartDate = DemoHelper.GetRandomTime();
                x.EndDate = DemoHelper.GetRandomTime(x.StartDate);
                x.DepositRatio = 0.3m;
                x.ReRatio = 0;
                x.CounterGuarantee = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.CGType)).ID);
                x.Rates = 0.3m;
                x.YearRates = 0.3m;
                x.WarranteeItems = new List<WarranteeItemModel>()
                  {
                      WarranteeItemModel.Create(x1=> {
                          x1.ID = Guid.NewGuid();
                        x1.WarranteeType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.WarranteeType)).ID);
                        x1.Name = DemoHelper.GetRandomChineseWords(new Random().Next(2, 5)) + "有限公司";
                        x1.CardType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.CodeType)).ID);
                        x1.CardID = DemoHelper.GetRandomCardID(18, true);
                        x1.IsMain = true;
                      })
                  };
            });
        }

        protected override ContractItemModel UpdateItem(ContractItemModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }


    public class WarranteeItemDataProvider : DataProviderBase<WarranteeItemModel>
    {
        protected override WarranteeItemModel AddItem(WarranteeItemModel item)
        {
            item.ID = Guid.NewGuid();
            return item;
        }

        protected override IList<WarranteeItemModel> FillItems(object filter)
        {
            throw new NotImplementedException();
        }

        protected override IList<WarranteeItemModel> FillItems(object id, object filter)
        {
            throw new NotImplementedException();
        }

        protected override WarranteeItemModel GetItem(object id)
        {
            return WarranteeItemModel.Create(x =>
            {
                x.ID = (Guid)id;
                x.WarranteeType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.WarranteeType)).ID);
                x.Name = DemoHelper.GetRandomChineseWords(new Random().Next(2, 5)) + "有限公司";
                x.CardType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.CodeType)).ID);
                x.CardID = DemoHelper.GetRandomCardID(18, true);
                x.IsMain = true;
            });
        }

        protected override WarranteeItemModel UpdateItem(WarranteeItemModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }


    public class LoanItemDataProvider : DataProviderBase<LoanItemModel>
    {
        protected override LoanItemModel AddItem(LoanItemModel item)
        {
            throw new NotImplementedException();
        }

        protected override IList<LoanItemModel> FillItems(object filter)
        {
            return new List<LoanItemModel>()
            {
                GetItem(null)
            };
        }

        protected override IList<LoanItemModel> FillItems(object id, object filter)
        {
            throw new NotImplementedException();
        }

        protected override LoanItemModel GetItem(object id)
        {
            return LoanItemModel.Create(x =>
            {
                x.ID = Guid.NewGuid();
                x.ProjectNo = "XM001";
                x.MianWarrantee = DemoHelper.GetRandomChineseWords(new Random().Next(2, 5)) + "有限公司";
                x.Amount = 5500000M;
                x.LoanAmount = new Random(Guid.NewGuid().GetHashCode()).Next((int)x.Amount);
            });
        }

        protected override LoanItemModel UpdateItem(LoanItemModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }


    public class LoanSingleItemlDataProvider : DataProviderBase<LoanSingleItemlModel>
    {
        protected override LoanSingleItemlModel AddItem(LoanSingleItemlModel item)
        {
            throw new NotImplementedException();
        }

        protected override IList<LoanSingleItemlModel> FillItems(object filter)
        {
            throw new NotImplementedException();
        }

        protected override IList<LoanSingleItemlModel> FillItems(object id, object filter)
        {
            throw new NotImplementedException();
        }

        protected override LoanSingleItemlModel GetItem(object id)
        {
            return LoanSingleItemlModel.Create(x =>
            {
                x.ID = Guid.NewGuid();
                x.ProjectNo = "XM001";
                x.WarranteeType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.WarranteeType)).ID);
                x.Name = DemoHelper.GetRandomChineseWords(new Random().Next(2, 5)) + "有限公司";
                x.BusinessType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.BusinessType)).ID);
                x.GuaranteeType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.GuaranteeType)).ID);
                x.Amount = 1000000m;
                x.LoanSumAmount = 0m;
                x.LoanCreditorItems = new List<LoanCreditorItemModel>()
                {
                    LoanCreditorItemModel.Create(lc =>
                    {
                        //lc.ID = Guid.NewGuid();
                        //lc.CreditorName = DemoHelper.GetRandomChineseWords(new Random().Next(2, 5)) + "银行";
                        //lc.ContractID = "ContractID";
                        //lc.ContractNo = "ContractNo";
                        //lc.TotalCredit = 10000m;
                        //lc.TotalLoanAmount = 5000m;
                        //lc.DirectionID = Guid.NewGuid();
                        //lc.IsMain = true;

                        lc.ID = Guid.NewGuid();
                        lc.TotalCredit = 10000m;
                        lc.TotalLoanAmount = 5000m;

                        lc.Creditor = CreditorItemModel.Create(xc =>
                        {
                            xc.ID = Guid.NewGuid();
                            xc.CreditorType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.CreditorType)).ID);
                            xc.CreditorName = DemoHelper.GetRandomChineseWords(new Random().Next(2, 5)) + "银行";
                            xc.CardType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.CodeType)).ID);
                            xc.CardID = DemoHelper.GetRandomCardID(18, true);
                        });
                        lc.Contract = CreditorContractItemModel.Create(xc =>
                        {
                            xc.ID = Guid.NewGuid();
                            xc.ContractID = "ContractID";
                            xc.ContractNo = "ContractNo";
                            //x.DirectionID
                            xc.IsMain = true;
                        });

                        lc.LoanEntryList = new System.Collections.ObjectModel.ObservableCollection<LoanEntryItemModel>()
                        {
                            LoanEntryItemModel.Create(le =>
                            {
                                le.ID = Guid.NewGuid();
                                le.Amount = new Random(Guid.NewGuid().GetHashCode()).Next(50) * 100000;
                                le.StartDate = DemoHelper.GetRandomTime();
                                le.EndDate = DemoHelper.GetRandomTime(le.StartDate);
                                le.RelieveAmount = new Random(Guid.NewGuid().GetHashCode()).Next((int)le.Amount);

                            })
                        };
                    })
                };
            });
        }

        protected override LoanSingleItemlModel UpdateItem(LoanSingleItemlModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }

    public class LoanCreditorItemDataProvider : DataProviderBase<LoanCreditorItemModel>
    {
        protected override LoanCreditorItemModel AddItem(LoanCreditorItemModel item)
        {
            if (item.Creditor.ID == Guid.Empty)
                item.Creditor.ID = Guid.NewGuid();
            if (item.Contract.ID == Guid.Empty)
                item.Contract.ID = Guid.NewGuid();
            item.ID = Guid.NewGuid();
            return item;
        }

        protected override IList<LoanCreditorItemModel> FillItems(object filter)
        {
            throw new NotImplementedException();
        }

        protected override IList<LoanCreditorItemModel> FillItems(object id, object filter)
        {
            throw new NotImplementedException();
        }

        protected override LoanCreditorItemModel GetItem(object id)
        {
            return LoanCreditorItemModel.Create(lc =>
            {
                lc.ID = Guid.NewGuid();
                lc.TotalCredit = 10000m;
                lc.TotalLoanAmount = 5000m;

                lc.Creditor = CreditorItemModel.Create(x =>
                {
                    x.ID = Guid.NewGuid();
                    x.CreditorType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.CreditorType)).ID);
                    x.CreditorName = DemoHelper.GetRandomChineseWords(new Random().Next(2, 5)) + "银行";
                    x.CardType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.CodeType)).ID);
                    x.CardID = DemoHelper.GetRandomCardID(18, true);
                });
                lc.Contract = CreditorContractItemModel.Create(x =>
                {
                    x.ID = Guid.NewGuid();
                    x.ContractID = "ContractID";
                    x.ContractNo = "ContractNo";
                    //x.DirectionID
                    x.IsMain = true;
                });

                lc.LoanEntryList = new System.Collections.ObjectModel.ObservableCollection<LoanEntryItemModel>()
                        {
                            LoanEntryItemModel.Create(le =>
                            {
                                le.ID = Guid.NewGuid();
                                le.Amount = new Random(Guid.NewGuid().GetHashCode()).Next(50) * 100000;
                                le.StartDate = DemoHelper.GetRandomTime();
                                le.EndDate = DemoHelper.GetRandomTime(le.StartDate);
                                le.RelieveAmount = new Random(Guid.NewGuid().GetHashCode()).Next((int)le.Amount);
                                le.LoanRelieveItems = new System.Collections.ObjectModel.ObservableCollection<LoanRelieveItemModel>()
                                {
                                    LoanRelieveItemModel.Create(lr =>
                                    {
                                        lr.ID = Guid.NewGuid();
                                        var stc = DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList("15"));

                                        lr.RelieveType = Guid.Parse(stc.ID);
                                        lr.RelieveAmount = stc.Value != "1" ? le.Amount:10000M;
                                        lr.RelieveDate = DateTime.Now;
                                        if(lr.RelieveAmount == le.Amount)
                                            le.LoanStatus = 1;
                                    })
                                };
                            })
                        };
            });
        }

        protected override LoanCreditorItemModel UpdateItem(LoanCreditorItemModel item, bool IsDelete)
        {
            return item;
        }
    }

    public class PremiumCollectionItemDataProvider : DataProviderBase<PremiumCollectionItemModel>
    {
        protected override PremiumCollectionItemModel AddItem(PremiumCollectionItemModel item)
        {
            throw new NotImplementedException();
        }

        protected override IList<PremiumCollectionItemModel> FillItems(object filter)
        {
            return new List<PremiumCollectionItemModel>()
            {
                GetItem(null)
            };
        }

        protected override IList<PremiumCollectionItemModel> FillItems(object id, object filter)
        {
            throw new NotImplementedException();
        }

        protected override PremiumCollectionItemModel GetItem(object id)
        {
            return PremiumCollectionItemModel.Create(x =>
            {
                x.ID = Guid.NewGuid();
                x.ProjectNo = "asda001";
                x.PreviousBookedDate = DateTime.Now;
                x.PremiumStatus = Guid.Parse("8FBB33BB-0F57-4BFC-97B1-18228C801307");
                x.TotalAmount = 0;
            });
        }

        protected override PremiumCollectionItemModel UpdateItem(PremiumCollectionItemModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }

    //public class PremiumItemDataProvider : DataProviderBase<PremiumItemModel>
    //{
    //    protected override PremiumItemModel AddItem(PremiumItemModel item)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    protected override IList<PremiumItemModel> FillItems(object filter)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    protected override IList<PremiumItemModel> FillItems(object id, object filter)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    protected override PremiumItemModel GetItem(object id)
    //    {
    //        return PremiumItemModel.Create(x =>
    //        {

    //        });
    //    }

    //    protected override PremiumItemModel UpdateItem(PremiumItemModel item, bool IsDelete)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}


    public class PremiumDisplayItemDataProvider : DataProviderBase<PremiumDisplayItemModel>
    {
        protected override PremiumDisplayItemModel AddItem(PremiumDisplayItemModel item)
        {
            throw new NotImplementedException();
        }

        protected override IList<PremiumDisplayItemModel> FillItems(object filter)
        {
            throw new NotImplementedException();
        }

        protected override IList<PremiumDisplayItemModel> FillItems(object id, object filter)
        {
            throw new NotImplementedException();
        }

        protected override PremiumDisplayItemModel GetItem(object id)
        {
            return PremiumDisplayItemModel.Create(p =>
            {
                p.ID = Guid.NewGuid();
                p.DisplayLoanBriefContent = DisplayLoanBriefContentModel.Create(d =>
                {
                    d.ProjectNo = "asda001";
                    d.WarranteeType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.WarranteeType)).ID);
                    d.Name = DemoHelper.GetRandomChineseWords(new Random().Next(2, 5)) + "有限公司";
                    d.BusinessType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.BusinessType)).ID);
                    d.GuaranteeType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.GuaranteeType)).ID);
                    d.Amount = 1000000m;
                    d.LoanSumAmount = 0m;
                });
                p.PremiumItems = new System.Collections.ObjectModel.ObservableCollection<PremiumItemModel>()
                {
                    PremiumItemModel.Create(x=> 
                    {
                        x.ID = Guid.NewGuid();
                        x.PayCategory = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.PayType)).ID);
                        x.AccountingDate = DateTime.Now;
                        x.PayAmount = 0;
                        x.PayMethod = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.PayOption)).ID);
                        x.PayFre = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.PayFre)).ID);
                        x.StartDate = DateTime.Now;
                        x.EndDate = DateTime.Now;
                        x.Balance = 0;
                        x.TotalArrears = 0;
                        x.PayStatus = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.PayStatus)).ID);
                        x.PremiumRecordItems = new System.Collections.ObjectModel.ObservableCollection<PremiumRecordItemModel>()
                        {
                            PremiumRecordItemModel.Create(pr =>
                            {
                                    pr.ID = Guid.NewGuid();
                                    pr.PayableAmount = 1000m;
                                    pr.PayableDate = DateTime.Now;
                                    pr.PaidDate = DateTime.Now;
                                    pr.ArrearsAmount = 0;
                                    pr.CurrentStatus = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.BQStatus)).ID);
                            })
                        };
                    })
                };
            });
        }

        protected override PremiumDisplayItemModel UpdateItem(PremiumDisplayItemModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }


    public class CompanyDisplayDataProvider : DataProviderBase<CompanyDisplayModel>
    {
        protected override CompanyDisplayModel AddItem(CompanyDisplayModel item)
        {
            throw new NotImplementedException();
        }

        protected override IList<CompanyDisplayModel> FillItems(object filter)
        {
            throw new NotImplementedException();
        }

        protected override IList<CompanyDisplayModel> FillItems(object id, object filter)
        {
            throw new NotImplementedException();
        }

        protected override CompanyDisplayModel GetItem(object id)
        {
            //不需要使用此id，获取的是机构信息

            return CompanyDisplayModel.Create(cd =>
            {
                cd.Info = CompanyInfoModel.Create(x => { x.Info1 = "123123123"; });
                cd.CM = new ObservableCollection<CompanyManagersModel>()
                {
                    CompanyManagersModel.Create(x=> { x.Info1 = "22222222"; })
                };
                cd.CS = new ObservableCollection<CompanyStockholderModel>()
                {
                    CompanyStockholderModel.Create(x=> { x.Info1 = "555555"; })
                };
                cd.CB = new ObservableCollection<CompanyBranchModel>()
                {
                    CompanyBranchModel.Create(x=> { x.Info1 = "555555"; })
                };
                cd.CA = new ObservableCollection<CompanyAccountModel>()
                {
                    CompanyAccountModel.Create(x=> { x.Info1 = "555555"; })
                };
            });
        }

        protected override CompanyDisplayModel UpdateItem(CompanyDisplayModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }


    public class CompanyManagersDataprovider : DataProviderBase<CompanyManagersModel>
    {
        protected override CompanyManagersModel AddItem(CompanyManagersModel item)
        {
            item.ID = Guid.NewGuid();
            return item;
        }

        protected override IList<CompanyManagersModel> FillItems(object filter)
        {
            throw new NotImplementedException();
        }

        protected override IList<CompanyManagersModel> FillItems(object id, object filter)
        {
            throw new NotImplementedException();
        }

        protected override CompanyManagersModel GetItem(object id)
        {
            throw new NotImplementedException();
        }

        protected override CompanyManagersModel UpdateItem(CompanyManagersModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }
    public class CompanyStockholderDataprovider : DataProviderBase<CompanyStockholderModel>
    {
        protected override CompanyStockholderModel AddItem(CompanyStockholderModel item)
        {
            item.ID = Guid.NewGuid();
            return item;
        }

        protected override IList<CompanyStockholderModel> FillItems(object filter)
        {
            throw new NotImplementedException();
        }

        protected override IList<CompanyStockholderModel> FillItems(object id, object filter)
        {
            throw new NotImplementedException();
        }

        protected override CompanyStockholderModel GetItem(object id)
        {
            throw new NotImplementedException();
        }

        protected override CompanyStockholderModel UpdateItem(CompanyStockholderModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }
    public class CompanyBranchDataprovider : DataProviderBase<CompanyBranchModel>
    {
        protected override CompanyBranchModel AddItem(CompanyBranchModel item)
        {
            item.ID = Guid.NewGuid();
            return item;
        }

        protected override IList<CompanyBranchModel> FillItems(object filter)
        {
            throw new NotImplementedException();
        }

        protected override IList<CompanyBranchModel> FillItems(object id, object filter)
        {
            throw new NotImplementedException();
        }

        protected override CompanyBranchModel GetItem(object id)
        {
            throw new NotImplementedException();
        }

        protected override CompanyBranchModel UpdateItem(CompanyBranchModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }
    public class CompanyAccountDataprovider : DataProviderBase<CompanyAccountModel>
    {
        protected override CompanyAccountModel AddItem(CompanyAccountModel item)
        {
            item.ID = Guid.NewGuid();
            return item;
        }

        protected override IList<CompanyAccountModel> FillItems(object filter)
        {
            throw new NotImplementedException();
        }

        protected override IList<CompanyAccountModel> FillItems(object id, object filter)
        {
            throw new NotImplementedException();
        }

        protected override CompanyAccountModel GetItem(object id)
        {
            throw new NotImplementedException();
        }

        protected override CompanyAccountModel UpdateItem(CompanyAccountModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }


    public class ReportMonthDataProvider : DataProviderBase<ReportMonthModel>
    {
        protected override ReportMonthModel AddItem(ReportMonthModel item)
        {
            return item;
            //throw new NotImplementedException();
        }

        protected override IList<ReportMonthModel> FillItems(object filter)
        {
            return new List<ReportMonthModel>();
        }

        protected override IList<ReportMonthModel> FillItems(object id, object filter)
        {
            throw new NotImplementedException();
        }

        protected override ReportMonthModel GetItem(object id)
        {
            throw new NotImplementedException();
        }

        protected override ReportMonthModel UpdateItem(ReportMonthModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }

    public class ReportQuarterDataProvider : DataProviderBase<ReportQuarterModel>
    {
        protected override ReportQuarterModel AddItem(ReportQuarterModel item)
        {
            return item;
        }

        protected override IList<ReportQuarterModel> FillItems(object filter)
        {
            return new List<ReportQuarterModel>();
        }

        protected override IList<ReportQuarterModel> FillItems(object id, object filter)
        {
            throw new NotImplementedException();
        }

        protected override ReportQuarterModel GetItem(object id)
        {
            throw new NotImplementedException();
        }

        protected override ReportQuarterModel UpdateItem(ReportQuarterModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }

    public class ReportHalfYearDataProvider : DataProviderBase<ReportHalfYearModel>
    {
        protected override ReportHalfYearModel AddItem(ReportHalfYearModel item)
        {
            return item;
        }

        protected override IList<ReportHalfYearModel> FillItems(object filter)
        {
            return new List<ReportHalfYearModel>();
        }

        protected override IList<ReportHalfYearModel> FillItems(object id, object filter)
        {
            throw new NotImplementedException();
        }

        protected override ReportHalfYearModel GetItem(object id)
        {
            throw new NotImplementedException();
        }

        protected override ReportHalfYearModel UpdateItem(ReportHalfYearModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }

    public class ReportYearDataProvider : DataProviderBase<ReportYearModel>
    {
        protected override ReportYearModel AddItem(ReportYearModel item)
        {
            return item;
        }

        protected override IList<ReportYearModel> FillItems(object filter)
        {
            return new List<ReportYearModel>();
        }

        protected override IList<ReportYearModel> FillItems(object id, object filter)
        {
            throw new NotImplementedException();
        }

        protected override ReportYearModel GetItem(object id)
        {
            throw new NotImplementedException();
        }

        protected override ReportYearModel UpdateItem(ReportYearModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }


    public class SupervisionDataProvider : DataProviderBase<SupervisionModel>
    {
        protected override SupervisionModel AddItem(SupervisionModel item)
        {
            throw new NotImplementedException();
        }

        protected override IList<SupervisionModel> FillItems(object filter)
        {
            return new List<SupervisionModel>()
            {
                SupervisionModel.Create()
            };
        }

        protected override IList<SupervisionModel> FillItems(object id, object filter)
        {
            throw new NotImplementedException();
        }

        protected override SupervisionModel GetItem(object id)
        {
            throw new NotImplementedException();
        }

        protected override SupervisionModel UpdateItem(SupervisionModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }


    public class SupervisionDetailDataProvider : DataProviderBase<SupervisionDetailModel>
    {
        protected override SupervisionDetailModel AddItem(SupervisionDetailModel item)
        {
            throw new NotImplementedException();
        }

        protected override IList<SupervisionDetailModel> FillItems(object filter)
        {
            throw new NotImplementedException();
        }

        protected override IList<SupervisionDetailModel> FillItems(object id, object filter)
        {
            throw new NotImplementedException();
        }

        protected override SupervisionDetailModel GetItem(object id)
        {
            return SupervisionDetailModel.Create();
        }

        protected override SupervisionDetailModel UpdateItem(SupervisionDetailModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }

    public static class DemoHelper
    {
        #region 帮助类


        public static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }



        /// <summary>
        /// List数组获取随机值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static T GetRandomItem<T>(IList<T> list)
        {
            if (list == null) throw new ArgumentNullException("list");
            int count = list.Count;
            if (count == 0) return default(T);
            System.Threading.Thread.Sleep(100);
            int index = new Random(GetRandomSeed()).Next(count);
            return list[index];
        }

        /// <summary>
        /// 得到随机日期
        /// </summary>
        /// <param name="date1">起始日期 默认值 new DateTime(2013, 1, 1)</param>
        /// <param name="date2">结束日期 默认值 DateTime.Now 或 起始有值延后3年</param>
        /// <returns>间隔日期之间的 随机日期</returns>
        public static DateTime GetRandomTime(DateTime? date1 = null, DateTime? date2 = null)
        {
            DateTime time1 = date1 ?? new DateTime(2013, 1, 1);
            DateTime time2 = date2 ?? (date1 == null ? DateTime.Now : time1.AddYears(3));

            Random random = new Random(Guid.NewGuid().GetHashCode());
            DateTime minTime = new DateTime();
            DateTime maxTime = new DateTime();

            System.TimeSpan ts = new System.TimeSpan(time1.Ticks - time2.Ticks);

            double dTotalSecontds = ts.TotalSeconds;
            int iTotalSecontds = 0;

            if (dTotalSecontds > System.Int32.MaxValue)
            {
                iTotalSecontds = System.Int32.MaxValue;
            }
            else if (dTotalSecontds < System.Int32.MinValue)
            {
                iTotalSecontds = System.Int32.MinValue;
            }
            else
            {
                iTotalSecontds = (int)dTotalSecontds;
            }


            if (iTotalSecontds > 0)
            {
                minTime = time2;
                maxTime = time1;
            }
            else if (iTotalSecontds < 0)
            {
                minTime = time1;
                maxTime = time2;
            }
            else
            {
                return time1;
            }

            int maxValue = iTotalSecontds;

            if (iTotalSecontds <= System.Int32.MinValue)
                maxValue = System.Int32.MinValue + 1;

            int i = random.Next(System.Math.Abs(maxValue));

            return minTime.AddSeconds(i);
        }



        /// <summary>  
        /// 随机产生常用汉字  
        /// </summary>  
        /// <param name="count">要产生汉字的个数</param>  
        /// <returns>常用汉字</returns>  
        public static string GetRandomChineseWords(int count)
        {
            string chineseWords = "";
            Random rm = new Random();
            Encoding gb = Encoding.GetEncoding("gb2312");

            for (int i = 0; i < count; i++)
            {
                // 获取区码(常用汉字的区码范围为16-55)  
                int regionCode = rm.Next(16, 56);
                // 获取位码(位码范围为1-94 由于55区的90,91,92,93,94为空,故将其排除)  
                int positionCode;
                if (regionCode == 55)
                {
                    // 55区排除90,91,92,93,94  
                    positionCode = rm.Next(1, 90);
                }
                else
                {
                    positionCode = rm.Next(1, 95);
                }

                // 转换区位码为机内码  
                int regionCode_Machine = regionCode + 160;// 160即为十六进制的20H+80H=A0H  
                int positionCode_Machine = positionCode + 160;// 160即为十六进制的20H+80H=A0H  

                // 转换为汉字  
                byte[] bytes = new byte[] { (byte)regionCode_Machine, (byte)positionCode_Machine };

                chineseWords += gb.GetString(bytes);
            }

            return chineseWords;
        }



        /// <summary>
        /// 随机生成证件号
        /// </summary>
        /// <param name="length">总长度</param>
        /// <param name="isLetter">是否在尾部后缀英文</param>
        /// <returns></returns>
        public static string GetRandomCardID(int length, bool isLetter)
        {
            length = isLetter ? length - 1 : length;
            string tmpstr = "";
            string idChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int randNum;
            Random ran = new Random();
            for (int i = 0; i < length; i++)
            {
                randNum = ran.Next(0, 9);
                tmpstr += randNum;
            }
            if (isLetter)
            {
                randNum = ran.Next(idChars.Length);
                tmpstr += idChars[randNum];
            }
            return tmpstr;
        }

        public static IList<T> GetRandomObjectList<T>(Action<T> Create, int count = 1)
        {

            return null;
        }

        #endregion
    }
}
