//
// WebViewPage.xaml.h
// Declaration of the WebViewPage class
//

#pragma once

#include "WebViewPage.g.h"

namespace AppBarSample
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public ref class WebViewPage sealed
	{
	public:
		WebViewPage();

	protected:
		virtual void OnNavigatedTo(Windows::UI::Xaml::Navigation::NavigationEventArgs^ e) override;
	private:
		void AppBar_Opened(Platform::Object^ sender, Platform::Object^ e);
		void AppBar_Closed(Platform::Object^ sender, Platform::Object^ e);
		void Refresh_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e);
	};
}
