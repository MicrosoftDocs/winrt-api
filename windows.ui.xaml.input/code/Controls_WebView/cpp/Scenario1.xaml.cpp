//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

//
// Scenario1.xaml.cpp
// Implementation of the Scenario1 class
//

#include "pch.h"
#include "Scenario1.xaml.h"

using namespace SDKSample::WebViewControl;

using namespace Platform;
using namespace Windows::Foundation;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Input;
using namespace Windows::UI::Xaml::Navigation;

Scenario1::Scenario1()
{
    InitializeComponent();
    
}

// Invoked when this page is about to be displayed in a Frame.
void Scenario1::OnNavigatedTo(NavigationEventArgs^ e)
{
    // A pointer back to the main page.  This is needed if you want to call methods in MainPage such
    // as NotifyUser()
    rootPage = MainPage::Current;
    Address->KeyUp += ref new KeyEventHandler(this, &SDKSample::WebViewControl::Scenario1::Address_KeyUp);
    Address->Text = "http://www.msn.com";
    
}

//<snippetWebViewNavigation>
void SDKSample::WebViewControl::Scenario1::NavigateButton_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
    ProgressRing1->IsActive = true;

    // Provide an indication as to where we are trying to navigate to
    String^ str = "Navigating to: {0}" + Address->Text;
    rootPage->NotifyUser(str, NotifyType::StatusMessage);

    // Hook the LoadCompleted event for the WebView to know when the URL is fully loaded
    webViewA->LoadCompleted += ref new LoadCompletedEventHandler(this, &Scenario1::webViewA_LoadCompleted);

    // Attempt to navigate to the specified URL.  Notice that a malformed URL will raise a FormatException
    // which we catch and let the user know that the URL is bad and to enter a new well-formed one.
    try
    {
        Uri^ targetUri = ref new Uri(Address->Text);
        webViewA->Navigate(targetUri);
    }
    catch (FailureException^ myE)
    {
        // Bad address
        String^ str = "Address is invalid, try again.  Details --> {0}" + myE->Message;
        rootPage->NotifyUser(str, NotifyType::ErrorMessage);
    }    
}

void SDKSample::WebViewControl::Scenario1::webViewA_LoadCompleted(Platform::Object^ sender, Windows::UI::Xaml::Navigation::NavigationEventArgs^ e)
{
    webViewA->Visibility = Windows::UI::Xaml::Visibility::Visible;
    BlockingRect->Visibility = Windows::UI::Xaml::Visibility::Collapsed;
    ProgressRing1->IsActive = false;
    
    // Tell the user that the page has loaded
    rootPage->NotifyUser("Page loaded", NotifyType::StatusMessage);
}


void SDKSample::WebViewControl::Scenario1::Address_KeyUp(Platform::Object^ sender, Windows::UI::Xaml::Input::KeyRoutedEventArgs^ e)
{
     if (e->Key == Windows::System::VirtualKey::Enter)
    {
        NavigateButton_Click(this, ref new RoutedEventArgs());
    }
}
//</snippetWebViewNavigation>
