using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Dialogs;

namespace Xamarin.Forms
{
    public class DialogService : IDialogService
    {

        public Task ShowAlertAsync(string message, string title, string buttonLabel)
        {
            return UserDialogs.Instance.AlertAsync(message, title, buttonLabel);
        }

        public async void ShowToast(string message, int duration = 5000, int StatusCode = 0)
        {
            var toastConfig = new ToastConfig(message);
            toastConfig.SetDuration(duration);

            // ICON

            //var img = "tab_about.png";
            //var icon = await BitmapLoader.Current.LoadFromResource(img, null, null);
            //toastConfig.SetIcon(img);

            toastConfig.SetMessageTextColor(System.Drawing.Color.White);
            if (StatusCode == 0)
            {
                Application.Current.Resources.TryGetValue("PrimaryColor", out var PrimaryColor);
                if (PrimaryColor != null)
                {
                    toastConfig.SetBackgroundColor(Color.FromHex(PrimaryColor.ToString()));
                }
                else
                {
                    toastConfig.SetBackgroundColor(System.Drawing.Color.White);
                }

            }
            else if (StatusCode == 1)
            {
                Application.Current.Resources.TryGetValue("PrimaryColor", out var PrimaryColor);
                if (PrimaryColor != null)
                {
                    toastConfig.SetBackgroundColor(Color.FromHex(PrimaryColor.ToString()));
                }
                else
                {
                    toastConfig.SetBackgroundColor(System.Drawing.Color.White);
                }
            }
            else
            {
                toastConfig.SetBackgroundColor(Color.Red);
            }



            UserDialogs.Instance.Toast(toastConfig);
        }

        public Task<bool> ShowConfirmAsync(string message, string title, string okLabel, string cancelLabel) => UserDialogs.Instance.ConfirmAsync(message, title, okLabel, cancelLabel);

        public Task<string> SelectActionAsync(string message, string title, IEnumerable<string> options) => SelectActionAsync(message, title, "Cancel", options);

        public async Task<string> SelectActionAsync(string message, string title, string cancelLabel, IEnumerable<string> options)
        {
            try
            {
                if (options == null)
                {
                    throw new ArgumentNullException(nameof(options));
                }

                if (!options.Any())
                {
                    throw new ArgumentException("No options provided", nameof(options));
                }

                var result =
                    await UserDialogs.Instance.ActionSheetAsync(message, cancelLabel, null, buttons: options.ToArray());

                return options.Contains(result)
                    ? result
                    : cancelLabel;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
