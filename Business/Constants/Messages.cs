using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Eklendi.";
        public static string Invalid = "Kriterlere uygun giriş yapınız!!";
        public static string Listed= "Listelendi";
        public static string MaintenanceTime="Sistem bakımda";
        public static string Deleted="Silindi";
        public static string Updated="Güncellendi";
        public static string InvalidCar="Araba kiralanmaya uygun değil.";
        public static string SuccessRental="Kiralama işlemi başarılı";
        public static string FailAddedImageLimit="Maksimum fotoğraf sayısına ulaşıldı.";
        public static string AuthorizationDenied="Yetkiniz yok!!!";
        internal static string UserRegistered;
        internal static User UserNotFound;
        internal static User PasswordError;
        internal static string SuccessfulLogin;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
    }
}
