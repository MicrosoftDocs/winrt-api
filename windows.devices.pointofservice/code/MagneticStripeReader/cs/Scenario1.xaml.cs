//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
//
//*********************************************************

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using SDKTemplate;
using System;
using System.Threading.Tasks;
using Windows.Devices.PointOfService;
using Windows.UI.Core;

namespace MagneticStripeReaderSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Scenario1 : SDKTemplate.Common.LayoutAwarePage
    {
        // A pointer back to the main page.  This is needed if you want to call methods in MainPage such
        // as NotifyUser()
        MainPage rootPage = MainPage.Current;

        MagneticStripeReader _reader = null;
        ClaimedMagneticStripeReader _claimedReader = null;

        public Scenario1()
        {
            this.InitializeComponent();
        }

        //<SnippetCreateMagStripeReader>
        //Creates a magnetic stripe reader.

        private async Task<bool> CreateDefaultMagneticStripeReaderObject()
        {
            if (_reader == null)
            {
                
                _reader = await MagneticStripeReader.GetDefaultAsync();

                if (_reader != null)
                {
                    // UpdateReaderStatusTextBlock("Magnetic stripe reader created.");
                    // UpdateReaderStatusTextBlock("Device Id is:" + _reader.DeviceId);
                }
                else
                {
                    // UpdateReaderStatusTextBlock("Magnetic stripe reader not found. Connect a magnetic stripe reader.");
                    return false;
                }
            }
            return true;
        }
        //</SnippetCreateMagStripeReader>
       
        /// <summary>
        /// Update the status in the UI with the string passed.
        /// </summary>
        /// <param name="message"></param>
        private void UpdateReaderStatusTextBlock(string message)
        {
            ReaderStatusText.Text += Environment.NewLine;
            ReaderStatusText.Text += message;
        }

        //<SnippetClaimMagStripeReader>
        // Claims the magnetic stripe reader for exclusive use.

        private async Task<bool> ClaimReader()
        {
            if (_claimedReader == null)
            {
                _claimedReader = await _reader.ClaimReaderAsync();

                if (_claimedReader != null)
                {
                    // UpdateReaderStatusTextBlock("Magnetic stripe reader claimed successfully.");
                }
                else
                {
                    // UpdateReaderStatusTextBlock("Failed to claim a magnetic stripe reader.");
                    return false;
                }
            }
            return true;
        }
        //</SnippetClaimMagStripeReader>

        //<SnippetEnableMagStripeReader>
        // Enables the magnetic stripe reader to receive data
        private async Task<bool> EnableReader()
        {
    
            await _claimedReader.EnableAsync();
            return true;
        }
        //</SnippetEnableMagStripeReader>

        //<SnippetSetupMagStripeReader>
        private async void ScenarioStartReadButton_Click(object sender, RoutedEventArgs e)
        {
            if (await CreateDefaultMagneticStripeReaderObject())
            {
                if (_reader != null)
                {
                    // Claim the reader for exclusive use by your application.
                    if (await ClaimReader())
                    {
                        if (_claimedReader != null)
                        {
                            /// Add a release device requested event handler. If this event is not handled,  
                            // another app can claim the magnetic stripe reader.
                            _claimedReader.ReleaseDeviceRequested += OnReleaseDeviceRequested;

                            // Add a data receive event handler.
                            _claimedReader.BankCardDataReceived += OnBankCardDataReceived;
                            UpdateReaderStatusTextBlock("Attached the BankCardDataReceived Event handler..");

                            // Set the app to decode the raw data from the magnetic stripe reader.
                            _claimedReader.IsDecodeDataEnabled = true;

                            // Enable the magnetic stripe reader.
                            if (await EnableReader())
                            {
                                UpdateReaderStatusTextBlock("Ready to Swipe..");

                                // Reset the button state
                                ScenarioEndReadButton.IsEnabled = true;
                                ScenarioStartReadButton.IsEnabled = false;
                            }
                        }
                    }
                }
            }
        }
        //</SnippetSetupMagStripeReader>

        /// <summary>
        /// Event handler for End button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ScenarioEndReadButton_Click(object sender, RoutedEventArgs e)
        {
            ResetTheScenarioState();
        }

        /// <summary>
        /// Event handler for the Release Device Requested event fired when magnetic stripe reader receives Claim request from another application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"> Contains the ClaimedMagneticStripeReader that is sending this request</param>
        //<SnippetMagStripeReaderReleaseDeviceRequested>
        void OnReleaseDeviceRequested(object sender, ClaimedMagneticStripeReader args)
        {
            // Always retain the device. If it is not retained, this exclusive claim will be lost.
            args.RetainDevice(); 
        }
        //</SnippetMagStripeReaderReleaseDeviceRequested>
        
        /// <summary>
        /// Event handler for the DataReceived event fired when a bank card is read by the magnetic stripe reader 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"> Contains the MagneticStripeReaderBankCardDataReceivedEventArgs which contains the data obtained in the scan</param>
        //<SnippetMagStripeReaderDataReceived>
        async void OnBankCardDataReceived(object sender, MagneticStripeReaderBankCardDataReceivedEventArgs args)
        {
            // Read the data and display
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {
                ScenarioOutputAccountNumber.Text = args.AccountNumber;
                ScenarioOutputExpirationDate.Text = args.ExpirationDate;
                ScenarioOutputFirstName.Text = args.FirstName;
                ScenarioOutputMiddleInitial.Text = args.MiddleInitial;
                ScenarioOutputServiceCode.Text = args.ServiceCode;
                ScenarioOutputSuffix.Text = args.Suffix;
                ScenarioOutputSurname.Text = args.Surname;
                ScenarioOutputTitle.Text = args.Title;
            });

        }
        //</SnippetMagStripeReaderDataReceived>

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ResetTheScenarioState();
        }

        /// <summary>
        /// Invoked when this page is no longer displayed.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            ResetTheScenarioState();
            base.OnNavigatedFrom(e);
        }

        /// <summary>
        /// Reset the Scenario state
        /// </summary>
        void ResetTheScenarioState()
        {
            if (_claimedReader != null)
            {
                // Detach the datareceived event handler and releasedevicerequested event handler
                _claimedReader.BankCardDataReceived -= OnBankCardDataReceived;
                _claimedReader.ReleaseDeviceRequested -= OnReleaseDeviceRequested;
        
                // release the Claimed Magnetic Stripe Reader and set to null
                _claimedReader.Dispose();		
                _claimedReader = null;
            }

            if (_reader != null)
            {
                // release the Magnetic Stripe Reader and set to null
                _reader = null;
            }

            // Reset the strings in the UI
            ReaderStatusText.Text = "Click the Start Receiving Data Button.";
            ScenarioOutputAccountNumber.Text = "No data";
            ScenarioOutputExpirationDate.Text = "No data";
            ScenarioOutputFirstName.Text = "No data";
            ScenarioOutputMiddleInitial.Text = "No data";
            ScenarioOutputServiceCode.Text = "No data";
            ScenarioOutputSuffix.Text = "No data";
            ScenarioOutputSurname.Text = "No data";
            ScenarioOutputTitle.Text = "No data";

            // reset the button state
            ScenarioEndReadButton.IsEnabled = false;
            ScenarioStartReadButton.IsEnabled = true;
        }
    }
}
