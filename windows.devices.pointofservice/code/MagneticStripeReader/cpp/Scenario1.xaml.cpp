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
using namespace SDKSample::MagneticStripeReaderSample;

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
}

//<SnippetCreateMagStripeReader>
// Creates the magnetic stripe reader.
task<void> Scenario1::CreateDefaultReaderObject()
{
    return create_task(MagneticStripeReader::GetDefaultAsync()).then([this] (MagneticStripeReader^ reader)
    {
        _reader = reader;
        if (_reader != nullptr)
        {			
            // UpdateReaderStatusTextBlock("Magnetic stripe reader created.");
            // UpdateReaderStatusTextBlock("Device Id is:" + _reader->DeviceId);
        }
        else
        {
            // UpdateReaderStatusTextBlock("Magnetic stripe reader not found. Connect a magnetic stripe reader.");
        }
    });

}
//</SnippetCreateMagStripeReader>

/// <summary>
/// Update the status in the UI with the string passed.
/// </summary>
/// <param name="message"></param>
void Scenario1::UpdateReaderStatusTextBlock(Platform::String^ strMessage)
{
    ReaderStatusText->Text += "\r";
    ReaderStatusText->Text += strMessage;
}

//<SnippetClaimMagStripeReader>
// Claims the magnetic stripe reader for exclusive use
task<void> Scenario1::ClaimReader()
{
    
    return create_task(_reader->ClaimReaderAsync()).then([this] (ClaimedMagneticStripeReader^ claimedReader)
    {
        _claimedReader = claimedReader;
        if (_claimedReader != nullptr)
        {
            // UpdateReaderStatusTextBlock("Magnetic stripe reader claimed successfully.");		
        }
        else
        {
            // UpdateReaderStatusTextBlock("Failed to claim the magnetic stripe reader.");
        }
    });
}
//</SnippetClaimMagStripeReader>

//<SnippetEnableMagStripeReader>
// Enables the magnetic stripe reader to receive data.
task<void> Scenario1::EnableReader()
{
    return create_task(_claimedReader->EnableAsync()).then([this](void)
    {
        // UpdateReaderStatusTextBlock("Magnetic stripe reader enabled successfully.");
    });

}
//</SnippetEnableMagStripeReader>

//<SnippetSetupMagStripeReader>
void Scenario1::ScenarioStartReadButton_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
    create_task(CreateDefaultReaderObject()).then([this](void)
    {
        if (_reader != nullptr)
        {
            // Claim the magnetic stripe reader for exclusive use by your application.
            create_task(ClaimReader()).then([this](void)
            {
                if (_claimedReader)
                {
                    // Add a release device requested event handler. If this event is not handled,  
                    // another app can claim the magnetic stripe reader.
                    _releaseDeviceRequestedToken = _claimedReader->ReleaseDeviceRequested::add(ref new EventHandler<ClaimedMagneticStripeReader^>(this, &Scenario1::OnReleaseDeviceRequested));

                    // Add a data receive event handler.
                    _bankCardDataReceivedToken =  _claimedReader->BankCardDataReceived::add(ref new TypedEventHandler<ClaimedMagneticStripeReader^, MagneticStripeReaderBankCardDataReceivedEventArgs^>(this, &Scenario1::OnBankCardDataReceived));
                    UpdateReaderStatusTextBlock("Attached the BankCardDataReceived event handler..");

                    // Set the app to decode the raw data from the magnetic stripe reader.
                    _claimedReader->IsDecodeDataEnabled = true;

					// Enable the magnetic stripe reader.
                    create_task(EnableReader()).then([this](void)
                    {
                        UpdateReaderStatusTextBlock("Ready to Swipe..");

                        // Reset the button state
                        ScenarioEndReadButton->IsEnabled = true;
                        ScenarioStartReadButton->IsEnabled = false;

                    });
                }
            });
        }
    });
}
//</SnippetSetupMagStripeReader>

/// <summary>
/// Event handler for End button
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
void Scenario1::ScenarioEndReadButton_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
    ResetTheScenarioState();
}

/// <summary>
/// Event handler for the Release Device Requested event fired when magnetic stripe reader receives Claim request from another application
/// </summary>
/// <param name="sender"></param>
/// <param name="args"> Contains the ClaimedMagneticStripeReader that is sending this request</param>

//<SnippetMagStripeReaderReleaseDeviceRequested>
void Scenario1::OnReleaseDeviceRequested(Platform::Object ^sender, Windows::Devices::PointOfService::ClaimedMagneticStripeReader ^args)
{
    // Always retain the device. If it is not retained, this exclusive claim will be lost.
    args->RetainDevice(); 
}
//</SnippetMagStripeReaderReleaseDeviceRequested>

/// <summary>
/// Event handler for the BankCardDataReceived event fired when a bank card is read by the magnetic stripe reader 
/// </summary>
/// <param name="sender"></param>
/// <param name="args"> Contains the MagneticStripeReaderBankCardDataReceivedEventArgs which contains the data obtained in the swipe</param>

//<SnippetMagStripeReaderDataReceived>
void Scenario1::OnBankCardDataReceived(Windows::Devices::PointOfService::ClaimedMagneticStripeReader^sender, Windows::Devices::PointOfService::MagneticStripeReaderBankCardDataReceivedEventArgs^args)
{
    // Read the data and display
    Dispatcher->RunAsync(CoreDispatcherPriority::Normal, ref new DispatchedHandler( 
        [this,args]() 
    {
        ScenarioOutputAccountNumber->Text = args->AccountNumber;
        ScenarioOutputExpirationDate->Text = args->ExpirationDate;
        ScenarioOutputFirstName->Text = args->FirstName;
        ScenarioOutputMiddleInitial->Text = args->MiddleInitial;
        ScenarioOutputServiceCode->Text = args->ServiceCode;
        ScenarioOutputSuffix->Text = args->Suffix;
        ScenarioOutputSurname->Text = args->Surname;
        ScenarioOutputTitle->Text = args->Title;
    }));

}
//</SnippetMagStripeReaderDataReceived>

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
/// Reset the Scenario state
/// </summary>
void Scenario1::ResetTheScenarioState()
{
    if (_claimedReader != nullptr)
    {
        // Detach the datareceived event handler and releasedevicerequested event handler
        _claimedReader->BankCardDataReceived::remove(_bankCardDataReceivedToken);
        _claimedReader->ReleaseDeviceRequested::remove(_releaseDeviceRequestedToken);
        
        // release the Claimed Magnetic Stripe Reader and set to null
        delete _claimedReader;		
        _claimedReader = nullptr;
    }

    if (_reader != nullptr)
    {
        // release the Magnetic Stripe Reader and set to null
        delete _reader;
        _reader = nullptr;
    }

    // Reset the strings in the UI
    ReaderStatusText->Text = "Click the Start Receiving Data Button.";
    ScenarioOutputAccountNumber->Text = "No data";
    ScenarioOutputExpirationDate->Text = "No data";
    ScenarioOutputFirstName->Text = "No data";
    ScenarioOutputMiddleInitial->Text = "No data";
    ScenarioOutputServiceCode->Text = "No data";
    ScenarioOutputSuffix->Text = "No data";
    ScenarioOutputSurname->Text = "No data";
    ScenarioOutputTitle->Text = "No data";

    // reset the button state
    ScenarioEndReadButton->IsEnabled = false;
    ScenarioStartReadButton->IsEnabled = true;
}
