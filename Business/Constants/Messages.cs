using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AddProduct="Product elave edildi";
        public static string ProductNameInvalid="Product uzunlugu min 3 olmali";
        public static string MaintenanceTime = "Sistem baxim vaxtindadi";
        public static string ProductListed = "Productlar listelendi";
        public static string GetById = "Product bulundu";

        public static string ProductCountOfCategoryError = "Bu categoryde olan product sayi max 10 olmali";

        public static string ProductNameAlreadyExists = "Bu adda basqa product var";

        public static string CategoryLimitExceded = "Category limiti asildigi icin yeni product elave edile bilmir";

        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "Qeydiyyat tamamlandi";
        public static string UserNotFound = "Bu adda istifadeci tapilmadi";
        public static string PasswordError = "Paraol duzgun deyil";
        public static string SuccessfulLogin = "Giris basarili";
        public static string UserAlreadyExists = "Bu adda istifadeci movcuddur";
        public static string AccessTokenCreated = "Token yaradildi";
    }
}
