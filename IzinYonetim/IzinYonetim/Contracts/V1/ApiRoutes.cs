using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IzinYonetim.Contracts
{
    public static class ApiRoutes
    {
        public const string Root = "Api";
        public const string Version = "V1";
        public const string Base =Root+"/"+Version;
        public static  class IzinHareketleri
        {
            public const string GetAll = Base+ "/IzinHareketi";
            public const string Get = Base + "/IzinHareketi/{izinHareketiId}";

            public const string Create = Base + "/IzinHareketi";

            public const string Update = Base + "/IzinHareketi/{izinHareketiId}";
            public const string Delete = Base + "/IzinHareketi/{izinHareketiId}";


        }
    }
}
