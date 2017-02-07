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
using Windows.Devices.PointOfService;
using System.Threading.Tasks;
using Windows.Storage.Streams;

namespace BarcodeScannerCS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Scenario1 : SDKTemplate.Common.LayoutAwarePage
    {
        // A pointer back to the main page.  This is needed if you want to call methods in MainPage such
        // as NotifyUser()
        MainPage rootPage = MainPage.Current;

        BarcodeScanner scanner = null;
        ClaimedBarcodeScanner claimedScanner = null;

        public Scenario1()
        {
            this.InitializeComponent();
        }

       
        //<SnippetCreateBarcodeScanner>
        //Creates a barcode scanner.

        private async Task<bool> CreateDefaultScannerObject()
        {
            if (scanner == null)
            {
                scanner = await BarcodeScanner.GetDefaultAsync();

                if (scanner != null)
                {
                    // UpdateOutput("Default Barcode Scanner created.");
                    // UpdateOutput("Device Id is:" + scanner.DeviceId);
                }
                else
                {
                    // UpdateOutput("Barcode Scanner not found. Please connect a Barcode Scanner.");
                    return false;
                }
            }
            return true;
        }
        //</SnippetCreateBarcodeScanner>

        //<SnippetClaimBarcodeScanner>
        // Claims the barcode scanner for exclusive use. 
        
        private async Task<bool> ClaimScanner()
        {
            if (claimedScanner == null)
            {
                claimedScanner = await scanner.ClaimScannerAsync();

                if (claimedScanner != null)
                {
                    // UpdateOutput("Barcode scanner claimed successfully.");
                   
                }
                else
                {
                    // UpdateOutput("Failed to claim the barcode scanner.");
                    return false;
                }
            }
            return true;
        }
        //</SnippetClaimBarcodeScanner>

        //<SnippetEnableBarcodeScanner>
        // Enables the barcode scanner to receive data 
        
        private async Task<bool> EnableScanner()
        {
            if (claimedScanner == null)
            {
                return false;   
            }
            else
            {   
                await claimedScanner.EnableAsync();
              
                return true;
            }            
        }
        //</SnippetEnableBarcodeScanner>

        /// <summary>
        /// Update the status in the UI with the string passed.
        /// </summary>
        /// <param name="message"></param>
        private void UpdateOutput(string message)
        {
            StatusBlock.Text += message;
            StatusBlock.Text += Environment.NewLine;
        }

      
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
        /// Invoked immediately before the Page is unloaded and is no longer the current source of a parent Frame
        /// </summary>
        /// <param name="e">Provides data for the OnNavigatingFrom callback that can be used to cancel a navigation 
        /// request from origination</param>
        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            ResetTheScenarioState();
        }

        /// <summary>
        /// Event Handler for Start Scan Button Click.
        /// Sets up the barcode scanner to be ready to receive the data events from the scan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //<SnippetSetupBarcodeScanner>
        private async void ScenarioStartScanButton_Click(object sender, RoutedEventArgs e)
        {
            // Create the barcode scanner. 
            if (await CreateDefaultScannerObject())
            {
                // Claim the scanner for exclusive use by your application.
                if (await ClaimScanner())
                {
                    
                    // Add a release device requested event handler. If this event is not handled,  
                    // another app can claim the barcode scanner.
                    claimedScanner.ReleaseDeviceRequested += claimedScanner_ReleaseDeviceRequested;

                    // Add a data receive event handler.
                    claimedScanner.DataReceived += claimedScanner_DataReceived;
                    UpdateOutput("Attached the DataReceived Event handler.");

                    // Set the app to decode the raw data from the barcode scanner 
                    claimedScanner.IsDecodeDataEnabled = true;

                    // Enable the scanner.
                    if (await EnableScanner())
                    {
                        // Reset the button state
                        ScenarioEndScanButton.IsEnabled = true;
                        ScenarioStartScanButton.IsEnabled = false;

                        UpdateOutput("Ready to Scan.");
                    }
                } 
            }
            else
            {
                UpdateOutput("No Barcode Scanner found");
            }
        }
        //</SnippetSetupBarcodeScanner>
        

        /// <summary>
        /// Event handler for the Release Device Requested event fired when barcode scanner receives Claim request from another application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"> Contains the ClaimedBarcodeScanner that is sending this request</param>
        //<SnippetReleaseDeviceRequested>
        async void claimedScanner_ReleaseDeviceRequested(object sender, ClaimedBarcodeScanner e)
        {
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {
                e.RetainDevice();
            }); 
        }
        //</SnippetReleaseDeviceRequested>

        /// <summary>
        /// Event handler for the DataReceived event fired when a barcode is scanned by the barcode scanner 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"> Contains the BarcodeScannerReport which contains the data obtained in the scan</param>
        //<SnippetDataReceived>
        async void claimedScanner_DataReceived(ClaimedBarcodeScanner sender, BarcodeScannerDataReceivedEventArgs args)
        {
            // update the UI with the data received from the scan.
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {
                // read the data from the buffer and convert to string.
                var scanDataLabelReader = DataReader.FromBuffer(args.Report.ScanDataLabel);
                ScenarioOutputScanDataLabel.Text = scanDataLabelReader.ReadString(args.Report.ScanDataLabel.Length);

                var scanDataReader = DataReader.FromBuffer(args.Report.ScanData);
                ScenarioOutputScanData.Text = scanDataReader.ReadString(args.Report.ScanData.Length);

                ScenarioOutputScanDataType.Text = BarcodeSymbologies.GetName(args.Report.ScanDataType);

            }); 
        }
        //</SnippetDataReceived>

        /// <summary>
        /// Reset the Scenario state
        /// </summary>
        private void ResetTheScenarioState()
        {
            if (claimedScanner != null)
            {
                // Detach the event handlers
                claimedScanner.DataReceived -= claimedScanner_DataReceived;
                claimedScanner.ReleaseDeviceRequested -= claimedScanner_ReleaseDeviceRequested;
                // Release the Barcode Scanner and set to null
                claimedScanner.Dispose();
                claimedScanner = null;
            }

            scanner = null;

            // Reset the strings in the UI
            UpdateOutput("Click the Start Receiving Data Button.");
            this.ScenarioOutputScanData.Text = "No data";
            this.ScenarioOutputScanDataLabel.Text = "No data";
            this.ScenarioOutputScanDataType.Text = "No data";

            // reset the button state
            ScenarioEndScanButton.IsEnabled = false;
            ScenarioStartScanButton.IsEnabled = true;
        }

        /// <summary>
        /// Event handler for End Scan Button Click. 
        /// Releases the Barcode Scanner and resets the text in the UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScenarioEndScanButton_Click(object sender, RoutedEventArgs e)
        {
            // reset the scenario state
            this.ResetTheScenarioState();
        }

    }
}
