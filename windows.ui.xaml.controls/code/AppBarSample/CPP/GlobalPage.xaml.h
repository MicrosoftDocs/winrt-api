//
// GlobalPage.xaml.h
// Declaration of the GlobalPage class
//

#pragma once

#include "GlobalPage.g.h"
#include "Page1.xaml.h"

namespace AppBarSample
{
	public ref class GlobalPage sealed
	{
	public:
		GlobalPage();

	protected:
		virtual void OnNavigatedTo(Windows::UI::Xaml::Navigation::NavigationEventArgs^ e) override;
	private:
		void Back_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e);
		void Page1Button_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e);
		void Page2Button_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e);

		Page^ rootPage;

	};
}
