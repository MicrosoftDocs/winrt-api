// <SnippetGlobalPageCode>
//
// GlobalPage.xaml.h
// Declaration of the GlobalPage class
//
//#pragma once
//
//#include "GlobalPage.g.h"
//#include "Page1.xaml.h"
//
//namespace AppBarSample
//{
//	public ref class GlobalPage sealed
//	{
//	public:
//		GlobalPage();
//
//	protected:
//		virtual void OnNavigatedTo(Windows::UI::Xaml::Navigation::NavigationEventArgs^ e) override;
//	private:
//		void Back_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e);
//		void Page1Button_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e);
//		void Page2Button_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e);
//
//		Page^ rootPage;
//
//	};
//}

//
// GlobalPage.xaml.cpp
// Implementation of the GlobalPage class
//

#include "pch.h"
#include "GlobalPage.xaml.h"

using namespace AppBarSample;
using namespace Platform;
using namespace Windows::Foundation;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Navigation;

GlobalPage::GlobalPage()
{
	InitializeComponent();
}

// <SnippetNavCommands>
void GlobalPage::OnNavigatedTo(NavigationEventArgs^ e)
{
	rootPage = safe_cast<Page^>(e->Parameter);
	frame1->Navigate(Windows::UI::Xaml::Interop::TypeName(Page1::typeid), this);
}

void AppBarSample::GlobalPage::Back_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
	if (frame1->CanGoBack == true)
    {
        frame1->GoBack();
    }
    else if (rootPage && rootPage->Frame->CanGoBack == true)
    {
        rootPage->Frame->GoBack();
    }
}

void AppBarSample::GlobalPage::Page1Button_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
		frame1->Navigate(Windows::UI::Xaml::Interop::TypeName(Page1::typeid), this);
}

void AppBarSample::GlobalPage::Page2Button_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
		frame1->Navigate(Windows::UI::Xaml::Interop::TypeName(Page2::typeid), this);
}
// </SnippetNavCommands>
// </SnippetGlobalPageCode>
