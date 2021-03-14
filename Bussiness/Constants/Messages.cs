using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Bussiness.Constants
{
    public class Messages
    {
        // Added
        public static string CarAdded = "Ürün eklendi";
        public static string UserAdded = "Müşteri Eklendi";
        public static string RentalAdded = "Kiralama Eklendi";
        public static string CustomerAdded = "Müşteri eklendi";




        public static string CarNameInValid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        //Updated
        public static string UserUpdated = "Müşteri Güncellendi";
        public static string RentalUpdated = "Kiralama Güncellendi";
        public static string CustomerUpdated = "Müşteri Güncellendi";


        //Deleted
        public static string UserDeleted = "Müşteri Silindi";
        public static string RentalDeleted = "Kiralama Silindi";
        public static string CustomerDeleted = "Müşteri Silindi";


        //Listed
        public static string CarsListed = "Ürünler listelendi";
        //null
        public static string ReturnDateNotNull = "Araba Zaten Teslim Edildi";
        public static string RentalNotAvailable = "Kiralama Mevcut Degil";

        public static string CarImageLimitExceeded = "Araba fotograf limiti aşıldı";

        public static string AuthorizationDenied = "Yetkiniz bulunmamaktadir";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandListed = "Marka Listelendi";
        public static string BrandUpdated = "Marka güncellendi";

        public static string ColorAdded = "Renk Eklendi";

        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk Güncelledi";
    }
}
