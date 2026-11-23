using System.Threading.Tasks;
using Wpf.Ui.Controls;

namespace FileManager.Services
{
    /// <summary>
    /// Handles all kind of MessageBoxes
    /// </summary>
    internal static class MessageBoxService
    {
        #region MessageBox OK

        /// <summary>
        /// Non-modal MessageBox with only an OK button. Returns immediately.
        /// </summary>
        /// <param name="height">Is optional. height = '0' sets it to default</param>
        /// <param name="width">Is optional. width = '0' sets it to default</param>
        public static void MessageBoxOK(string title, string text, int height = 0, int width = 0)
        {
            MessageBox messageBox = Create(title, text, height, width);
            messageBox.CloseButtonText = "OK";

            _ = messageBox.ShowDialogAsync(showAsDialog: false);
        }

        #endregion

        #region MessageBox Yes/No

        /// <summary>
        /// Modal MessageBox with a yes or no prompt. Returns true when "Yes" was clicked.
        /// </summary>
        /// <param name="height">Is optional. height = '0' sets it to default</param>
        /// <param name="width">Is optional. width = '0' sets it to default</param>
        public static async Task<bool> MessageBoxYesNo(string title, string text, int height = 0, int width = 0)
        {
            MessageBox messageBox = Create(title, text, height, width);
            messageBox.PrimaryButtonText = "Yes";
            messageBox.PrimaryButtonAppearance = ControlAppearance.Primary;
            messageBox.CloseButtonText = "No";

            MessageBoxResult result = await messageBox.ShowDialogAsync();

            return result == MessageBoxResult.Primary;
        }

        #endregion

        private static MessageBox Create(string title, string text, int height, int width)
        {
            MessageBox messageBox = new()
            {
                Title = title,
                Content = text,
            };

            if (height > 0)
            {
                messageBox.Height = height;
            }

            if (width > 0)
            {
                messageBox.Width = width;
            }

            return messageBox;
        }
    }
}
