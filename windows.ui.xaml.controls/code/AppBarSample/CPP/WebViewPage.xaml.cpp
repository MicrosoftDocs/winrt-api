//
// WebViewPage.xaml.cpp
// Implementation of the WebViewPage class
//

#include "pch.h"
#include "WebViewPage.xaml.h"

using namespace AppBarSample;

using namespace Platform;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Controls::Primitives;
using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Input;
using namespace Windows::UI::Xaml::Media;
using namespace Windows::UI::Xaml::Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

WebViewPage::WebViewPage()
{
	InitializeComponent();
}

/// <summary>
/// Invoked when this page is about to be displayed in a Frame.
/// </summary>
/// <param name="e">Event data that describes how this page was reached.  The Parameter
/// property is typically used to configure the page.</param>
void WebViewPage::OnNavigatedTo(NavigationEventArgs^ e)
{
	(void) e;	// Unused parameter
}

// <SnippetAppBarOpenClose>
// .h
//	private:
//		void AppBar_Opened(Platform::Object^ sender, Platform::Object^ e);
//		void AppBar_Closed(Platform::Object^ sender, Platform::Object^ e);
//		void Refresh_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e);

void AppBarSample::WebViewPage::AppBar_Opened(Platform::Object^ sender, Platform::Object^ e)
{
	WebViewBrush^ wvb = ref new WebViewBrush();
    wvb->SourceName = "contentView";
    wvb->Redraw();
    contentViewRect->Fill = wvb;
    contentView->Visibility = Windows::UI::Xaml::Visibility::Collapsed;  
}

void AppBarSample::WebViewPage::AppBar_Closed(Platform::Object^ sender, Platform::Object^ e)
{
    contentView->Visibility = Windows::UI::Xaml::Visibility::Visible;
    contentViewRect->Fill = ref new SolidColorBrush(Windows::UI::Colors::Transparent);
}

void AppBarSample::WebViewPage::Refresh_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
	contentView->Navigate(ref new Uri("http://www.contoso.com"));
    bottomAppBar->IsOpen = false;

}
// </SnippetAppBarOpenClose>