//
// MainPage.xaml.cpp
// Implementation of the MainPage class.
//

#include "pch.h"
#include "MainPage.xaml.h"

using namespace Touch_Basic_Manipulations_CPP;

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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

// <SnippetInitialize>
MainPage::MainPage()
{
	InitializeComponent();

	// Listener for the ManipulationDelta event.
	touchRectangle->ManipulationDelta += 
		ref new ManipulationDeltaEventHandler(
			this, 
			&MainPage::touchRectangle_ManipulationDelta);
	// New translation transform populated in 
	// the ManipulationDelta handler.
	dragTranslation = ref new TranslateTransform();
	// Apply the translation to the Rectangle.
	touchRectangle->RenderTransform = dragTranslation;
}
// </SnippetInitialize>

// <SnippettestRectangle_ManipulationDelta>
// Handler for the ManipulationDelta event.
// ManipulationDelta data is loaded into the
// translation transform and applied to the Rectangle.
void MainPage::touchRectangle_ManipulationDelta(Object^ sender,
	ManipulationDeltaRoutedEventArgs^ e)
{
	// Move the rectangle.
	dragTranslation->X += e->Delta.Translation.X;
	dragTranslation->Y += e->Delta.Translation.Y;
	
}
// </SnippettestRectangle_ManipulationDelta>

