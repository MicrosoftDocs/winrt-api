// <SnippetPage2Code>
//
// Page2.xaml.h
// Declaration of the Page2 class
//
//#pragma once
//
//#include "Page2.g.h"
//
//namespace AppBarSample
//{
//	/// <summary>
//	/// An empty page that can be used on its own or navigated to within a Frame.
//	/// </summary>
//	public ref class Page2 sealed
//	{
//	public:
//		Page2();
//
//	protected:
//		virtual void OnNavigatedTo(Windows::UI::Xaml::Navigation::NavigationEventArgs^ e) override;
//
//	private:
//		void StarButton_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e);
//		Page^ rootPage;
//	};
//}

//
// Page2.xaml.cpp
// Implementation of the Page2 class
//

#include "pch.h"
#include "Page2.xaml.h"

using namespace AppBarSample;

using namespace Platform;
using namespace Windows::Foundation;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Navigation;

Page2::Page2()
{
	InitializeComponent();
}

void Page2::OnNavigatedTo(NavigationEventArgs^ e)
{
	rootPage = safe_cast<Page^>(e->Parameter);
}

void AppBarSample::Page2::StarButton_Click
	(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
	Windows::UI::Popups::MessageDialog^ dialog = 
		ref new Windows::UI::Popups::MessageDialog("You're a Superstar!");
    dialog->ShowAsync();
}
// </SnippetPage2Code>
