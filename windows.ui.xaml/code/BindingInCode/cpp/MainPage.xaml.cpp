//
// MainPage.xaml.cpp
// Implementation of the MainPage class.
//

#include "pch.h"
#include "MainPage.xaml.h"

using namespace BindingInCode;

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

MainPage::MainPage()
{
	InitializeComponent();

	//<SnippetBindingObject>
	// Create the source string.
	String^ s = ref new String(L"Hello");

	// Create the binding description.
	Binding^ b = ref new Binding();
	b->Mode = BindingMode::OneTime;
	b->Source = s;

	// Attach the binding to the target.
	TextBlock^ MyText = ref new TextBlock();
	MyText->SetBinding(MyText->TextProperty, b);
	//</SnippetBindingObject>
}
