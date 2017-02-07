//
// SnippetsPage.xaml.cpp
// Implementation of the SnippetsPage class
//

#include "pch.h"
#include "SnippetsPage.xaml.h"

using namespace AppBarSample;

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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

SnippetsPage::SnippetsPage()
{
	InitializeComponent();
}

/// <summary>
/// Invoked when this page is about to be displayed in a Frame.
/// </summary>
/// <param name="e">Event data that describes how this page was reached.  The Parameter
/// property is typically used to configure the page.</param>

// <SnippetAddButtonCode>
Button^ addButton;
Windows::Foundation::EventRegistrationToken buttonClickHandler;

void SnippetsPage::OnNavigatedTo(NavigationEventArgs^ e)
{
	(void) e;	// Unused parameter
	            	
	if (rightPanel)
    {    
         // Create the button to add
         addButton = ref new Button();
	
	     //Apply the button style so that it looks like an AppBar button
         addButton->Style = safe_cast<Windows::UI::Xaml::Style^>(App::Current->Resources->Lookup("AddAppBarButtonStyle"));
			 
	    // Add the Click handler for the new button
         buttonClickHandler = addButton->Click += 
			 ref new Windows::UI::Xaml::RoutedEventHandler(this, &AppBarSample::SnippetsPage::Button_Click);
	
	     // Add the button to the AppBar
         rightPanel->Children->Append(addButton);
    }

}

void AppBarSample::SnippetsPage::Button_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
	// Perform action here.
}
// </SnippetAddButtonCode>

// <SnippetRemoveButtonCode>
void SnippetsPage::OnNavigatingFrom(NavigatingCancelEventArgs^ e)
{
    // Unhook the Click event handler for the button
    addButton->Click -= buttonClickHandler;
	
	// Add the button to the AppBar
	uint32 index = rightPanel->Children->IndexOf(addButton, &index);
    rightPanel->Children->RemoveAt(index);
}
// </SnippetRemoveButtonCode>

// <SnippetAppBarMenuCode>
void AppBarSample::SnippetsPage::SortMenuButton_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
	// <SnippetAppBarMenu1>
	Popup^ popUp = ref new Popup();
	// </SnippetAppBarMenu1>
	// <SnippetAppBarMenu2>
    popUp->IsLightDismissEnabled = true;
	// </SnippetAppBarMenu2>

	// <SnippetAppBarMenu3>
    StackPanel^ panel = ref new StackPanel();
    panel->Background = bottomAppBar->Background;
    panel->Height = 140;
    panel->Width = 180;
	// </SnippetAppBarMenu3>

	// <SnippetAppBarMenu4>
    //panel->Transitions = ref new Windows::UI::Xaml::Media::Animation::TransitionCollection();
    //panel->Transitions->Append(ref new Windows::UI::Xaml::Media::Animation::PopupThemeTransition());
	// </SnippetAppBarMenu4>

	// <SnippetAppBarMenu5>
    Button^ byRatingButton = ref new Button();
    byRatingButton->Content = "By rating";
    byRatingButton->Style = safe_cast<Windows::UI::Xaml::Style^>(App::Current->Resources->Lookup("TextButtonStyle"));
	byRatingButton->Margin = *(new Thickness(20, 5, 20, 5));
    byRatingButton->Click += ref new Windows::UI::Xaml::RoutedEventHandler(this, &AppBarSample::SnippetsPage::SortButton_Click);
    panel->Children->Append(byRatingButton);
	// </SnippetAppBarMenu5>

    Button^ byMatchButton = ref new Button();
    byMatchButton->Content = "By match";
    byMatchButton->Style = safe_cast<Windows::UI::Xaml::Style^>(App::Current->Resources->Lookup("TextButtonStyle"));
    byMatchButton->Margin = *(new Thickness(20, 5, 20, 5));
    byMatchButton->Click += ref new Windows::UI::Xaml::RoutedEventHandler(this, &AppBarSample::SnippetsPage::SortButton_Click);
    panel->Children->Append(byMatchButton);

    Button^ byDistanceButton = ref new Button();
    byDistanceButton->Content = "By distance";
    byDistanceButton->Style = safe_cast<Windows::UI::Xaml::Style^>(App::Current->Resources->Lookup("TextButtonStyle"));
    byDistanceButton->Margin = *(new Thickness(20, 5, 20, 5));
    byDistanceButton->Click += ref new Windows::UI::Xaml::RoutedEventHandler(this, &AppBarSample::SnippetsPage::SortButton_Click);
    panel->Children->Append(byDistanceButton);

	// <SnippetAppBarMenu6>
    popUp->Child = panel;
	// </SnippetAppBarMenu6>
	// <SnippetAppBarMenu7>
    popUp->HorizontalOffset = Window::Current->CoreWindow->Bounds.Right - panel->Width - 4;
    popUp->VerticalOffset = Window::Current->CoreWindow->Bounds.Bottom - bottomAppBar->ActualHeight - panel->Height - 4;
	// </SnippetAppBarMenu7>

	// <SnippetAppBarMenu8>
    popUp->IsOpen = true;
	// </SnippetAppBarMenu8>
}

void AppBarSample::SnippetsPage::SortButton_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
	// Sort.
}
// </SnippetAppBarMenuCode>

// <SnippetHideAppBarCommandsCode>
void AppBarSample::SnippetsPage::ToggleSwitch_Toggled(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
	ToggleSwitch^ toggle = safe_cast<ToggleSwitch^>(sender);

	if (toggle->IsOn == true)
    {
        pinCommands->Visibility = Windows::UI::Xaml::Visibility::Visible;
    }
    else
    {
        pinCommands->Visibility = Windows::UI::Xaml:: Visibility::Collapsed;
    }
}
// </SnippetHideAppBarCommandsCode>

