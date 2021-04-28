using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Helpers
{
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants

        private const string SettingsKey = "settings_key";
        private static readonly string SettingsDefault = string.Empty;

        #endregion
        public static void logOut()
        {
            Helpers.Settings.IsAuthenticated = false;

        }
        public static void RemoveUserData()
        {
            Settings.AppSettings.Clear();
        }
        public static string AuthenticationToken
        {
            get
            {
                return AppSettings.GetValueOrDefault("AuthenticationToken", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("AuthenticationToken", value);
            }
        }
        public static bool IsAuthenticated
        {
            get
            {
                return AppSettings.GetValueOrDefault("IsAuthenticated", false);
            }
            set
            {
                AppSettings.AddOrUpdateValue("IsAuthenticated", value);
            }
        }

    }
}
