//
// MainPage.xaml.cpp
// Implementation of the MainPage class.
//

#include "pch.h"
#include "MainPage.xaml.h"

using namespace IValueConverterExample;

using namespace Platform;
using namespace Platform::Collections;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::Globalization;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Controls::Primitives;
using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Input;
using namespace Windows::UI::Xaml::Media;
using namespace Windows::UI::Xaml::Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

//MainPage::MainPage()
//{	
//	m_myMusic = ref new Vector<Recording^>();
//
//	// Add items to the collection.
//	Calendar^ c = ref new Calendar();
//	c->Year = 2008;
//	c->Month = 2;
//	c->Day = 5;
//	m_myMusic->Append(ref new Recording("Chris Sells", "Chris Sells Live",
//		c->GetDateTime()));
//
//	c->Year = 2007;
//	c->Month = 4;
//	c->Day = 3;
//	m_myMusic->Append(ref new Recording("Luka Abrus",
//		"The Road to Redmond", c->GetDateTime()));
//	
//	// Another way to make a Windows::Foundation::DateTime	
//	SYSTEMTIME st = {0};
//	st.wYear = 2007;
//	st.wMonth = 2;
//	st.wDay = 3;	
//	FILETIME ft;
//	SystemTimeToFileTime(&st, &ft);
//
//	DateTime dt;
//	dt.UniversalTime = ((dt.UniversalTime = ft.dwHighDateTime) << 32) | ft.dwLowDateTime;
//	
//	m_myMusic->Append(ref new Recording("Jim Hance",
//		"The Best of Jim Hance", dt));
//	InitializeComponent();
//
//	// Set the data context for the combo box.
//	MusicCombo->DataContext = m_myMusic;	
//}

/// <summary>
/// Invoked when this page is about to be displayed in a Frame.
/// </summary>
/// <param name="e">Event data that describes how this page was reached.  The Parameter
/// property is typically used to configure the page.</param>
void MainPage::OnNavigatedTo(NavigationEventArgs^ e)
{
	(void) e;	// Unused parameter
}
