using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public enum MajorIndexType
    {
        AUD,
        AZN,
        GBP,
        AMD,
        BYN,
        BGN,
        BRL,
        HUF,
        HKD,
        DKK,
        USD,
        EUR,
        INR,
        KZT,
        CAD,
        KGS,
        CNY,
        MDL,
        NOK,
        PLN,
        RON,
        XDR,
        SGD,
        TJS,
        TRY,
        TMT,
        UZS,
        UAH,
        CZK,
        SEK,
        CHF,
        ZAR,
        KRW,
        JPY
    }

    public class MajorIndex
    {


        public int Nominal { get; set; }

        public string Name { get; set; }

        public float Value { get; set; }

        public MajorIndexType Type { get; set; }
    }
}
