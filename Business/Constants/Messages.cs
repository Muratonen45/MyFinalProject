using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "ürün eklendi";
        public static string ProductNameInvalid = "ürün ismi geçersiz";
        public static string MaintenanceTime="sistem bakımda";
        public static string ProductListed="ürünler listelendi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 tane ürün olabilir";
        public static string ProductNameAlreadyExists ="Bu isimde zaten başka bir ürün var" ;
        public static string CategoryLimitExceded= "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied="yetkiniz yok";
    }
}
