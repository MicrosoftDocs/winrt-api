//<snippet2>
//
// MainPage.xaml.h
// Declaration of the MainPage class.
// 

#pragma once

#include "MainPage.g.h"

namespace IValueConverterExample
{

	// Simple business object.
	[Windows::UI::Xaml::Data::Bindable]
	public ref class Recording sealed 
	{
	public: 
		Recording (Platform::String^ artistName, Platform::String^ cdName, Windows::Foundation::DateTime release)
		{
			Artist = artistName;
			Name = cdName;
			ReleaseDate = release;
		}
		property Platform::String^ Artist;
		property Platform::String^ Name;
		property Windows::Foundation::DateTime ReleaseDate;
	};

	public ref class DateFormatter  sealed : Windows::UI::Xaml::Data::IValueConverter 
	{
		// This converts the DateTime object to the Platform::String^ to display.
	public:
		virtual Platform::Object^ Convert(Platform::Object^ value, Windows::UI::Xaml::Interop::TypeName targetType, 
			Platform::Object^ parameter, Platform::String^ language)
		{
			Windows::Foundation::DateTime dt = safe_cast<Windows::Foundation::DateTime>(value); 
			Windows::Globalization::DateTimeFormatting::DateTimeFormatter^ dtf =
				Windows::Globalization::DateTimeFormatting::DateTimeFormatter::ShortDate;
			return dtf->Format(dt); 
		}

		// No need to implement converting back on a one-way binding 
		virtual Platform::Object^ ConvertBack(Platform::Object^ value, Windows::UI::Xaml::Interop::TypeName targetType, 
			Platform::Object^ parameter, Platform::String^ language)
		{
			throw ref new Platform::NotImplementedException();
		}
	};

	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public ref class MainPage sealed
	{
	public:
		MainPage()
		{	
			m_myMusic = ref new Platform::Collections::Vector<Recording^>();

			// Add items to the collection.

			// You can use a Calendar object to create a Windows::Foundation::DateTime
			auto c = ref new Windows::Globalization::Calendar();
			c->Year = 2008;
			c->Month = 2;
			c->Day = 5;
			m_myMusic->Append(ref new Recording("Chris Sells", "Chris Sells Live",
				c->GetDateTime()));

			c->Year = 2007;
			c->Month = 4;
			c->Day = 3;
			m_myMusic->Append(ref new Recording("Luka Abrus",
				"The Road to Redmond", c->GetDateTime()));
			
			c->Year = 2007;
			c->Month = 2;
			c->Day = 3;
			m_myMusic->Append(ref new Recording("Jim Hance",
				"The Best of Jim Hance", dt));
			InitializeComponent();

			// Set the data context for the combo box.
			MusicCombo->DataContext = m_myMusic;	
		}


	protected:
		virtual void OnNavigatedTo(Windows::UI::Xaml::Navigation::NavigationEventArgs^ e) override;

	private:
		Windows::Foundation::Collections::IVector<Recording^>^ m_myMusic;
	};
}
//</snippet2>