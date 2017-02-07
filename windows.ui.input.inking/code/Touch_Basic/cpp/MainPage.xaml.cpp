//
// MainPage.xaml.cpp
// Implementation of the MainPage class.
//

#include "pch.h"
#include "MainPage.xaml.h"

using namespace Touch_Basic_CPP;

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
using namespace Windows::UI::Xaml::Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

// <SnippetInitialize>
MainPage::MainPage()
{
	InitializeComponent();

	// Pointer event listeners.
	touchRectangle->PointerPressed += ref new PointerEventHandler(this, &MainPage::touchRectangle_PointerPressed);
	touchRectangle->PointerReleased += ref new PointerEventHandler(this, &MainPage::touchRectangle_PointerReleased);
	touchRectangle->PointerExited += ref new PointerEventHandler(this, &MainPage::touchRectangle_PointerExited);
}
// </SnippetInitialize>

// <SnippetEventHandlers>
// <SnippettouchRectangle_PointerExited>
// Handler for pointer exited event.
void MainPage::touchRectangle_PointerExited(Object^ sender, PointerRoutedEventArgs^ e)
{
	Rectangle^ rect = (Rectangle^)sender;

	// Pointer moved outside Rectangle hit test area.
	// Reset the dimensions of the Rectangle.
	if (nullptr != rect)
	{
		rect->Width = 200;
		rect->Height = 100;
	}
}
// </SnippettouchRectangle_PointerExited>

// <SnippettouchRectangle_PointerReleased>
// Handler for pointer released event.
void MainPage::touchRectangle_PointerReleased(Object^ sender, PointerRoutedEventArgs^ e)
{
	Rectangle^ rect = (Rectangle^)sender;

	// Reset the dimensions of the Rectangle.
	if (nullptr != rect)
	{
		rect->Width = 200;
		rect->Height = 100;
	}
}
// </SnippettouchRectangle_PointerReleased>

// <SnippettouchRectangle_PointerPressed>
// Handler for pointer pressed event.
void MainPage::touchRectangle_PointerPressed(Object^ sender, PointerRoutedEventArgs^ e)
{
	Rectangle^ rect = (Rectangle^)sender;

	// Change the dimensions of the Rectangle.
	if (nullptr != rect)
	{
		rect->Width = 250;
		rect->Height = 150;
	}
}
// </SnippettouchRectangle_PointerPressed>
// </SnippetEventHandlers>

