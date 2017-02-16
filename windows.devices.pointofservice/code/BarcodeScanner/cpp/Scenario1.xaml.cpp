//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
//
//*********************************************************

//
// Scenario1.xaml.cpp
// Implementation of the Scenario1 class
//

#include "pch.h"
#include "Scenario1.xaml.h"
#include "MainPage.xaml.h"

using namespace SDKSample;
using namespace SDKSample::BarcodeScannerCPP;

using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Concurrency;
using namespace Windows::Devices::PointOfService;
using namespace Windows::Foundation;
using namespace Windows::Storage::Streams;
using namespace Windows::UI::Core;
using namespace Windows::UI::Xaml::Navigation;

Scenario1::Scenario1()
{
    InitializeComponent();
	rootPage = MainPage::Current;
}

//<SnippetCreateBarcodeScanner>
// Creates the barcode scanner.
task<void> Scenario1::CreateDefaultScannerObject()
{
    return create_task(BarcodeScanner::GetDefaultAsync()).then([this] (BarcodeScanner^ _scanner)
    {
        this->scanner = _scanner;
        if (this->scanner != nullptr)
        {			
            // UpdateOutput("Barcode Scanner created.");
            // UpdateOutput("Device Id is:" + this->scanner->DeviceId);
        }
        else
        {
            // UpdateOutput("Barcode scanner not found. Connect a barcode scanner.");
        }
    });

}
//</SnippetCreateBarcodeScanner>

/// <summary>
/// Update the status in the UI with the string passed.
/// </summary>
/// <param name="message"></param>
void Scenario1::UpdateOutput(Platform::String^ strMessage)
{
   StatusBlock->Text +=  strMessage;
   StatusBlock->Text +=  "\r";
}

//<SnippetClaimBarcodeScanner>
// Claims the barcode scanner for exclusive use
task<void> Scenario1::ClaimScanner()
{
    return create_task(scanner->ClaimScannerAsync()).then([this] (ClaimedBarcodeScanner^ _claimedScanner)
    {
        this->claimedScanner = _claimedScanner;
        if (claimedScanner != nullptr)
        {
            // UpdateOutput("Barcode scanner claimed successfully.");		
        }
        else
        {
            // UpdateOutput("Failed to claim barcode scanner.");
        }
    });
}
//</SnippetClaimBarcodeScanner>

//<SnippetEnableBarcodeScanner>
// Enables the barcode scanner to receive data.
task<void> Scenario1::EnableScanner()
{
    return create_task(claimedScanner->EnableAsync()).then([this](void)
    {
        // UpdateOutput("Barcode scanner enabled successfully.");
    });
}	
//</SnippetEnableBarcodeScanner>


 // <summary>
/// Setup the barcode scanner to be ready to receive the data events from the scan.
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
//<SnippetSetupBarcodeScanner>
void Scenario1::ScenarioStartScanButton_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
     // Create the barcode scanner. 
    create_task(CreateDefaultScannerObject()).then([this](void)
    {
        if (scanner != nullptr)
        {
            // Claim the scanner for exclusive use by your application.
            create_task(ClaimScanner()).then([this](void)
            {
                if (claimedScanner)
                {
                        
                    // Add a release device requested event handler. If this event is not handled,  
                    // another app can claim the barcode scanner.
                    releaseDeviceRequestedToken = claimedScanner->ReleaseDeviceRequested::add(ref new EventHandler<ClaimedBarcodeScanner^>(this, &Scenario1::OnReleaseDeviceRequested));

  
                    /// Add a data receive event handler.
                    dataReceivedToken =  claimedScanner->DataReceived::add(ref new TypedEventHandler<ClaimedBarcodeScanner^, BarcodeScannerDataReceivedEventArgs^>(this, &Scenario1::OnDataReceived));
                    UpdateOutput("Attached the DataReceived Event handler.");

                    // Set the app to decode the raw data from the barcode scanner 
                    claimedScanner->IsDecodeDataEnabled = true;

                    // Enable the scanner.
                    create_task(EnableScanner()).then([this](void)
                    {
                        UpdateOutput("Ready to Scan.");

                        // Reset the button state
                        ScenarioEndScanButton->IsEnabled = true;
                        ScenarioStartScanButton->IsEnabled = false;
                    });
                }
            });
        }
    });

}
//</SnippetSetupBarcodeScanner>



/// <summary>
/// Event handler for the Release Device Requested event fired when barcode scanner receives Claim request from another application
/// </summary>
/// <param name="sender"></param>
/// <param name="args"> Contains the ClaimedBarcodeScanner that is sending this request</param>
//<SnippetReleaseDeviceRequested>
void Scenario1::OnReleaseDeviceRequested(Platform::Object ^sender, Windows::Devices::PointOfService::ClaimedBarcodeScanner ^args)
{
    Dispatcher->RunAsync(CoreDispatcherPriority::Normal, ref new DispatchedHandler( 
        [this,args]() 
    {
        args->RetainDevice(); 
		UpdateOutput("Received event ReleaseDeviceRequested. Retaining the barcode scanner.");
    }));
}
//</SnippetReleaseDeviceRequested>

/// <summary>
/// Event handler for the DataReceived event fired when a barcode is scanned by the barcode scanner 
/// </summary>
/// <param name="sender"></param>
/// <param name="args"> Contains the BarcodeScannerReport which contains the data obtained in the scan</param>
//<SnippetDataReceived>
void Scenario1::OnDataReceived(Windows::Devices::PointOfService::ClaimedBarcodeScanner ^sender, Windows::Devices::PointOfService::BarcodeScannerDataReceivedEventArgs ^args)
{
    // read the data from the buffer and convert to string.
    Dispatcher->RunAsync(CoreDispatcherPriority::Normal, ref new DispatchedHandler( 
        [this,args]() 
    {
        DataReader^ scanDataLabelReader = DataReader::FromBuffer(args->Report->ScanDataLabel);
        ScenarioOutputScanDataLabel->Text = scanDataLabelReader->ReadString(args->Report->ScanDataLabel->Length);

        DataReader^  scanDataReader = DataReader::FromBuffer(args->Report->ScanData);
        ScenarioOutputScanData->Text = scanDataReader->ReadString(args->Report->ScanData->Length);

        ScenarioOutputScanDataType->Text = BarcodeSymbologies::GetName(args->Report->ScanDataType);
    }));
}
//</SnippetDataReceived>

/// <summary>
/// Invoked when this page is about to be displayed in a Frame.
/// </summary>
/// <param name="e">Event data that describes how this page was reached.  The Parameter
/// property is typically used to configure the page.</param>
void Scenario1::OnNavigatedTo(NavigationEventArgs^ e)
{
    ResetTheScenarioState();
}

/// <summary>
/// Invoked when this page is no longer displayed.
/// </summary>
/// <param name="e"></param>
void Scenario1::OnNavigatedFrom(NavigationEventArgs^ e)
{
    ResetTheScenarioState();
}



/// <summary>
/// Event handler for End Scan Button Click. 
/// Releases the Barcode Scanner and resets the text in the UI
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
void Scenario1::ScenarioEndScanButton_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
    ResetTheScenarioState();
}

/// <summary>
/// Reset the Scenario state
/// </summary>
void Scenario1::ResetTheScenarioState()
{
    if (claimedScanner != nullptr)
    {
        // Detach the event handlers
        claimedScanner->DataReceived::remove(dataReceivedToken);
        claimedScanner->ReleaseDeviceRequested::remove(releaseDeviceRequestedToken);
        
        // release the Barcode Scanner and set to null
        delete claimedScanner;		
        claimedScanner = nullptr;
    }

    if (scanner != nullptr)
    {
        delete scanner;
        scanner = nullptr;
    }

    // Reset the strings in the UI
    UpdateOutput("Click the Start Scanning Button.");
    ScenarioOutputScanData->Text = "No data";
    ScenarioOutputScanDataLabel->Text = "No data";
    ScenarioOutputScanDataType->Text = "No data";

    // reset the button state
    ScenarioEndScanButton->IsEnabled = false;
    ScenarioStartScanButton->IsEnabled = true;
}
