// <SnippetPage1Code>
//
// Page1.xaml.h
// Declaration of the Page1 class
//
//#pragma once
//
//#include "Page1.g.h"
//#include "Page2.xaml.h"
//
//namespace AppBarSample
//{
//	/// <summary>
//	/// An empty page that can be used on its own or navigated to within a Frame.
//	/// </summary>
//	public ref class Page1 sealed
//	{
//	public:
//		Page1();
//
//	protected:
//		virtual void OnNavigatedTo(Windows::UI::Xaml::Navigation::NavigationEventArgs^ e) override;
//	private:
//		Page^ rootPage;
//	};
//}

//
// Page1.xaml.cpp
// Implementation of the Page1 class
//

#include "pch.h"
#include "Page1.xaml.h"

using namespace AppBarSample;

using namespace Platform;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Navigation;

Page1::Page1()
{
	InitializeComponent();
}

void Page1::OnNavigatedTo(NavigationEventArgs^ e)
{
	rootPage = safe_cast<Page^>(e->Parameter);
}
// </SnippetPage1Code>

