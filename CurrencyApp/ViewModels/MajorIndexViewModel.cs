using Services.Models;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyApp.ViewModels
{
    public class MajorIndexViewModel
    {
        private readonly IMajorIndexService _majorIndexService;
        public MajorIndex AUD { get; set; }
        public MajorIndex AZN { get; set; }
        public MajorIndex GBP { get; set; }
        public MajorIndex AMD { get; set; }
        public MajorIndex BYN { get; set; }
        public MajorIndex BGN { get; set; }
        public MajorIndex BRL { get; set; }
        public MajorIndex HUF { get; set; }
        public MajorIndex HKD { get; set; }
        public MajorIndex DKK { get; set; }
        public MajorIndex USD { get; set; }
        public MajorIndex EUR { get; set; }
        public MajorIndex INR { get; set; }
        public MajorIndex KZT { get; set; }
        public MajorIndex CAD { get; set; }
        public MajorIndex KGS { get; set; }
        public MajorIndex CNY { get; set; }
        public MajorIndex MDL { get; set; }
        public MajorIndex NOK { get; set; }
        public MajorIndex PLN { get; set; }
        public MajorIndex RON { get; set; }
        public MajorIndex XDR { get; set; }
        public MajorIndex SGD { get; set; }
        public MajorIndex TJS { get; set; }
        public MajorIndex TRY { get; set; }
        public MajorIndex TMT { get; set; }
        public MajorIndex UZS { get; set; }
        public MajorIndex UAH { get; set; }
        public MajorIndex CZK { get; set; }
        public MajorIndex SEK { get; set; }
        public MajorIndex CHF { get; set; }
        public MajorIndex ZAR { get; set; }
        public MajorIndex KRW { get; set; }
        public MajorIndex JPY { get; set; }

        public MajorIndexViewModel(IMajorIndexService majorIndexService)
        {
            _majorIndexService = majorIndexService;
        }

        public static MajorIndexViewModel LoadMajorIndexViewModel(IMajorIndexService majorIndexService)
        {
            MajorIndexViewModel majorIndexViewModel = new MajorIndexViewModel(majorIndexService);
            majorIndexViewModel.LoadMajorIndexes();
            return majorIndexViewModel;
        }

        private void LoadMajorIndexes()
        {
             _majorIndexService.GetMajorIndex(MajorIndexType.AUD).ContinueWith(task =>
             {
                 if(task.Exception != null)
                 {
                     AUD = task.Result;
                 }
             });
            _majorIndexService.GetMajorIndex(MajorIndexType.AZN).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    AZN = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.GBP).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    GBP = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.AMD).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    AMD = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.BYN).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    BYN = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.BGN).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    BGN = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.BRL).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    BRL = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.HUF).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    HUF = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.HKD).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    HKD = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.DKK).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    DKK = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.USD).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    USD = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.EUR).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    EUR = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.INR).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    INR = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.KZT).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    KZT = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.CNY).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    CNY = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.MDL).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    MDL = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.NOK).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    NOK = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.RON).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    RON = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.XDR).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    XDR = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.SGD).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    SGD = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.TJS).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    TJS = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.TRY).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    TRY = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.TMT).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    TMT = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.UZS).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    UZS = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.UAH).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    UAH = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.CZK).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    CZK = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.SEK).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    SEK = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.CHF).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    CHF = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.ZAR).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    ZAR = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.KRW).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    KRW = task.Result;
                }
            });
            _majorIndexService.GetMajorIndex(MajorIndexType.JPY).ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    JPY = task.Result;
                }
            });
            

        }
    }
}
