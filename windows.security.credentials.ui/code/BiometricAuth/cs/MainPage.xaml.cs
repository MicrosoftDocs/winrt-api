using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BiometricAuth
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        private async void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            OutputTextBlock.Text = await CheckDeviceAvailability();
        }

        private async void AuthenticateButton_Click(object sender, RoutedEventArgs e)
        {
            var consentResult = await RequestConsent("Let's make sure it's really you.");
            OutputTextBlock.Text += "\n" + consentResult;
        }

        //<Snippet1>
        public async System.Threading.Tasks.Task<string> CheckDeviceAvailability()
        {
            string returnMessage;

            // Check the availability of device authentication.
            var ucvAvailability = await Windows.Security.Credentials.UI.UserConsentVerifier.CheckAvailabilityAsync();

            switch (ucvAvailability)
            {
                case Windows.Security.Credentials.UI.UserConsentVerifierAvailability.Available:
                    returnMessage = "Authentication device is available.";
                    break;
                case Windows.Security.Credentials.UI.UserConsentVerifierAvailability.DeviceBusy:
                    returnMessage = "Authentication device is busy.";
                    break;
                case Windows.Security.Credentials.UI.UserConsentVerifierAvailability.DeviceNotPresent:
                    returnMessage = "No authentication device found.";
                    break;
                case Windows.Security.Credentials.UI.UserConsentVerifierAvailability.DisabledByPolicy:
                    returnMessage = "Authentication device verification is disabled by policy.";
                    break;
                case Windows.Security.Credentials.UI.UserConsentVerifierAvailability.NotConfiguredForUser:
                    returnMessage = "Please go to Account Settings to set up a PIN or other advanced authentication.";
                    break;
                default:
                    returnMessage = "Authentication device is currently unavailable.";
                    break;
            }

            return returnMessage;
        }
        // </Snippet1>

        // <Snippet2>
        private async System.Threading.Tasks.Task<string> RequestConsent(string userMessage)
        {
            string returnMessage;

            // Request the logged on user's consent via authentication device.
            var consentResult = await Windows.Security.Credentials.UI.UserConsentVerifier.RequestVerificationAsync(userMessage);

            switch (consentResult)
            {
                case Windows.Security.Credentials.UI.UserConsentVerificationResult.Verified:
                    returnMessage = "User verified.";
                    break;
                case Windows.Security.Credentials.UI.UserConsentVerificationResult.DeviceBusy:
                    returnMessage = "Authentication device is busy.";
                    break;
                case Windows.Security.Credentials.UI.UserConsentVerificationResult.DeviceNotPresent:
                    returnMessage = "No authentication device found.";
                    break;
                case Windows.Security.Credentials.UI.UserConsentVerificationResult.DisabledByPolicy:
                    returnMessage = "Authentication device verification is disabled by policy.";
                    break;
                case Windows.Security.Credentials.UI.UserConsentVerificationResult.NotConfiguredForUser:
                    returnMessage = "Please go to Account Settings to set up PIN or other advanced authentication.";
                    break;
                case Windows.Security.Credentials.UI.UserConsentVerificationResult.RetriesExhausted:
                    returnMessage = "There have been too many failed attempts. Device authentication canceled.";
                    break;
                case Windows.Security.Credentials.UI.UserConsentVerificationResult.Canceled:
                    returnMessage = "Device authentication canceled.";
                    break;
                default:
                    returnMessage = "Authentication device is currently unavailable.";
                    break;
            }
            return returnMessage;
        }
        // </Snippet2>
 
    }
}
