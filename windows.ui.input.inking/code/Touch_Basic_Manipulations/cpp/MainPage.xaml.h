//
// MainPage.xaml.h
// Declaration of the MainPage class.
//

#pragma once

#include "MainPage.g.h"

namespace Touch_Basic_Manipulations_CPP
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public ref class MainPage sealed
	{
	public:
		MainPage();

	private:
		// <SnippetGlobals>
		// Global translation transform used for changing the position of 
		// the Rectangle based on input data from the touch contact.
		Windows::UI::Xaml::Media::TranslateTransform^ dragTranslation;
		// </SnippetGlobals>

		void touchRectangle_ManipulationDelta(Platform::Object^ sender, Windows::UI::Xaml::Input::ManipulationDeltaRoutedEventArgs^ e);
	};
}
