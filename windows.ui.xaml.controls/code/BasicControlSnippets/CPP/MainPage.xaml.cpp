//
// MainPage.xaml.cpp
// Implementation of the MainPage class.
//

#include "pch.h"
#include "MainPage.xaml.h"

using namespace BasicControlSnippets;

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

MainPage::MainPage()
{
	InitializeComponent();
}

/// <summary>
/// Invoked when this page is about to be displayed in a Frame.
/// </summary>
/// <param name="e">Event data that describes how this page was reached.  The Parameter
/// property is typically used to configure the page.</param>
void MainPage::OnNavigatedTo(NavigationEventArgs^ e)
{
	(void) e;	// Unused parameter

	AddToolTip();
	AddButton();
	AddToggleButton();
    AddRepeatButton();
    AddHyperlinkButton();
    AddCheckBox();
    AddRadioButtons();
    AddSlider();
    AddToggleSwitch();
    AddBoundComboBox();
    AddComboBox();
    AddBoundListBox();
    AddListBox();
    AddProgressBar();
    AddIndeterminateProgressBar();
    AddProgressRing();
    AddImage();
    AddTextBlock();
    AddTextBox();
    AddPasswordBox();
	AddBoundListView();
	AddListView();
	AddBoundGridView();
	AddGridView();
	AddBoundFlipView();
	AddFlipView();
}

// TOOLTIP
void MainPage::AddToolTip()
{
    // <SnippetBasicToolTipCode>
    ToolTip^ toolTip1 = ref new ToolTip();
    toolTip1->Content = "Click to perform action";
    ToolTipService::SetToolTip(button1, toolTip1);
    // </SnippetBasicToolTipCode>
}

// BUTTON
void MainPage::AddButton()
{
    // <SnippetBasicButtonCode>
    // Create a new button, set its content,
    // and add a Click event handler.
    Button^ button1 = ref new Button();
    button1->Content = "Button";
    button1->Click += ref new RoutedEventHandler(this, &MainPage::Button_Click);

    // Add the button to a parent container in the visual tree.
    stackPanel1->Children->Append(button1);
    // </SnippetBasicButtonCode>
}

// <SnippetBasicButtonClick>
void MainPage::Button_Click(Object^ sender, RoutedEventArgs^ e)
{
    // Add code to perform some action here.
}
// </SnippetBasicButtonClick>

        // TOGGLEBUTTON
void MainPage::AddToggleButton()
{
    // <SnippetBasicToggleButtonCode>
    // Create a new toggle button, set its content,
    // and add a Checked event handler.
    ToggleButton^ toggleButton1 = ref new ToggleButton();
    toggleButton1->Content = "Button";
    toggleButton1->Checked += 
		ref new RoutedEventHandler(this, &MainPage::ToggleButton_Checked);

    // Add the toggle button to a parent container in the visual tree.
    stackPanel1->Children->Append(toggleButton1);
    // </SnippetBasicToggleButtonCode>
}

// <SnippetBasicToggleButtonChecked>
void MainPage::ToggleButton_Checked(Object^ sender, RoutedEventArgs^ e)
{
    // Add code to perform some action here.
}
// </SnippetBasicToggleButtonChecked>

// REPEATBUTTON
void MainPage::AddRepeatButton()
{
    // <SnippetBasicRepeatButtonCode>
    // Create a new repeat button, set its content,
    // and add a Click event handler.
    RepeatButton^ repeatButton1 = ref new RepeatButton();
    repeatButton1->Content = "Repeat Button";
    repeatButton1->Click += 
		ref new RoutedEventHandler(this, &MainPage::RepeatButton_Click);

    // Add the button to a parent container in the visual tree.
    stackPanel1->Children->Append(repeatButton1);
    // </SnippetBasicRepeatButtonCode>
}

// <SnippetBasicRepeatClick>
void MainPage::RepeatButton_Click(Object^ sender, RoutedEventArgs^ e)
{
    // Add code to perform some action here.
    // The Click event occurs continuously while the repeat button is pressed.
}
// </SnippetBasicRepeatClick>

// HYPERLINKBUTTON
void MainPage::AddHyperlinkButton()
{
    // <SnippetBasicHyperlinkButtonCode>
    // Create a new button, set its content,
    // and a Click event handler.
    HyperlinkButton^ hyperlinkButton1 = ref new HyperlinkButton();
    hyperlinkButton1->Content = "www.microsoft.com";
    hyperlinkButton1->NavigateUri = ref new Uri("http://www.microsoft.com");

    // Add the button to a parent container in the visual tree.
    stackPanel1->Children->Append(hyperlinkButton1);
    // </SnippetBasicHyperlinkButtonCode>
}

// CHECKBOX
void MainPage::AddCheckBox()
{
    // <SnippetBasicCheckBoxCode>
    // Create a new check box, set its content, 
    // and add a Checked event handler.
    CheckBox^ checkBox1 = ref new CheckBox();
    checkBox1->Content = "CheckBox";
    checkBox1->Checked += 
		ref new RoutedEventHandler(this, &MainPage::CheckBox_Checked);

    // Add the check box to a parent container in the visual tree.
    stackPanel1->Children->Append(checkBox1);
    // </SnippetBasicCheckBoxCode>
}

// <SnippetBasicCheckBoxChecked>
void MainPage::CheckBox_Checked(Object^ sender, RoutedEventArgs^ e)
{
    // Add code to perform some action here.
}
// </SnippetBasicCheckBoxChecked>


// RADIOBUTTON
void MainPage::AddRadioButtons()
{
    // <SnippetBasicRadioButtonCode>
    // Create new radio buttons, set their content, 
    // and add a Checked event handler.
    RadioButton^ radioButton1 = ref new RadioButton();
    radioButton1->Content = "Radio Button 1";
    radioButton1->GroupName = "Group1";
    radioButton1->Checked += 
		ref new RoutedEventHandler(this, &MainPage::RadioButton_Checked);

    RadioButton^ radioButton2 = ref new RadioButton();
    radioButton2->Content = "Radio Button 2";
    radioButton2->GroupName = "Group1";
    radioButton2->Checked += 
		ref new RoutedEventHandler(this, &MainPage::RadioButton_Checked);

    // Add the radio buttons to a parent container in the visual tree.
    stackPanel1->Children->Append(radioButton1);
    stackPanel1->Children->Append(radioButton2);
    // </SnippetBasicRadioButtonCode>
}

// <SnippetBasicRadioButtonChecked>
void MainPage::RadioButton_Checked(Object^ sender, RoutedEventArgs^ e)
{
    // Add code to perform some action here.
}
// </SnippetBasicRadioButtonChecked>

// SLIDER
void MainPage::AddSlider()
{
    // <SnippetBasicSliderCode>
    // Create a new slider and add a ValueChanged event handler.
    Slider^ slider1 = ref new Slider();
    slider1->Width = 100;
    slider1->ValueChanged += 
		ref new RangeBaseValueChangedEventHandler(this, &MainPage::Slider_ValueChanged);

    // Add the slider to a parent container in the visual tree.
    stackPanel1->Children->Append(slider1);
    // </SnippetBasicSliderCode>
}

// <SnippetBasicSliderValueChanged>
void MainPage::Slider_ValueChanged(Object^ sender, RangeBaseValueChangedEventArgs^ e)
{
    // Add code to perform some action here.
}
// </SnippetBasicSliderValueChanged>


// TOGGLESWITCH
void MainPage::AddToggleSwitch()
{
    // <SnippetBasicToggleSwitchCode>
    // Create a new toggle switch, set its content, 
    // and add a Toggled event handler.
    ToggleSwitch^ toggleSwitch1 = ref new ToggleSwitch();
    toggleSwitch1->Header = "Toggle Switch";
    toggleSwitch1->OnContent = "On";
    toggleSwitch1->OffContent = "Off";
    toggleSwitch1->Toggled += 
		ref new RoutedEventHandler(this, &MainPage::ToggleSwitch_Toggled);

    // Add the toggle switch to a parent container in the visual tree.
    stackPanel1->Children->Append(toggleSwitch1);
    // </SnippetBasicToggleSwitchCode>
}

// <SnippetBasicToggleSwitchToggled>
void MainPage::ToggleSwitch_Toggled(Object^ sender, RoutedEventArgs^ e)
{
    // Add code to perform some action here.
}
// </SnippetBasicToggleSwitchToggled>


// COMBOBOX
void MainPage::AddBoundComboBox()
{
    // <SnippetBoundComboBoxCode>
    // Data collection
    Platform::Collections::Vector<String^>^ fonts = 
		ref new Platform::Collections::Vector<String^>();
    fonts->Append("Item 1");
    fonts->Append("Item 2");
    fonts->Append("Item 3");

    // Create a new combo box, set its items source, and add a SelectionChanged handler.
    ComboBox^ comboBox1 = ref new ComboBox();
    comboBox1->Width = 200;
    comboBox1->ItemsSource = fonts;
    comboBox1->SelectionChanged += 
		ref new SelectionChangedEventHandler(this, &MainPage::ComboBox_SelectionChanged);

    // Add the combo box to a parent container in the visual tree.
    stackPanel1->Children->Append(comboBox1);
    // </SnippetBoundComboBoxCode>

}

void MainPage::AddComboBox()
{
    // <SnippetBasicComboBoxCode>
    // Create a new combo box, add items, and add a SelectionChanged handler.
    ComboBox^ comboBox1 = ref new ComboBox();
    comboBox1->Items->Append("Item 1");
    comboBox1->Items->Append("Item 2");
    comboBox1->Items->Append("Item 3");
    comboBox1->Width = 200;
    comboBox1->SelectionChanged += 
		ref new SelectionChangedEventHandler(this, &MainPage::ComboBox_SelectionChanged);

    // Add the combo box to a parent container in the visual tree.
    stackPanel1->Children->Append(comboBox1);
    // <SnippetBasicComboBoxCode>
}

// <SnippetBasicComboBoxSelectionChanged>
void MainPage::ComboBox_SelectionChanged(Object^ sender, SelectionChangedEventArgs^ e)
{
    // Add code to perform some action here.
}
// </SnippetBasicComboBoxSelectionChanged>


// LISTBOX
void MainPage::AddBoundListBox()
{
    // <SnippetBoundListBoxCode>
    // Data collection
    Platform::Collections::Vector<String^>^ fonts = 
		ref new Platform::Collections::Vector<String^>();
    fonts->Append("Item 1");
    fonts->Append("Item 2");
    fonts->Append("Item 3");

    // Create a new list box, set its items source, and add a SelectionChanged handler.
    ListBox^ listBox1 = ref new ListBox();
    listBox1->Width = 140;
    listBox1->ItemsSource = fonts;
    listBox1->SelectionChanged += 
		ref new SelectionChangedEventHandler(this, &MainPage::ListBox_SelectionChanged);

    // Add the list box to a parent container in the visual tree.
    stackPanel1->Children->Append(listBox1);
    // </SnippetBoundListBoxCode>

}

void MainPage::AddListBox()
{
    // <SnippetBasicListBoxCode>
    // Create a new list box, add items, and add a SelectionChanged handler.
    ListBox^ listBox1 = ref new ListBox();
    listBox1->Items->Append("Item 1");
    listBox1->Items->Append("Item 2");
    listBox1->Items->Append("Item 3");
    listBox1->Width = 140;
    listBox1->SelectionChanged += 
		ref new SelectionChangedEventHandler(this, &MainPage::ListBox_SelectionChanged);

    // Add the list box to a parent container in the visual tree.
    stackPanel1->Children->Append(listBox1);
    // </SnippetBasicListBoxCode>
}

// <SnippetBasicListBoxSelectionChanged>
void MainPage::ListBox_SelectionChanged(Object^ sender, SelectionChangedEventArgs^ e)
{
    // Add code to perform some action here.
}
// </SnippetBasicListBoxSelectionChanged>

// PROGRESSBAR
void MainPage::AddProgressBar()
{
    double progressValue = 45.0;

    // <SnippetBasicProgressBarCode>
    // Create a new progress bar and set its Value property to a double value.
    ProgressBar^ progressBar1 = ref new ProgressBar();
    progressBar1->Value = (double)progressValue;
    progressBar1->Width = 100;

    // Add the progress bar to a parent container in the visual tree.
    stackPanel1->Children->Append(progressBar1);
    // </SnippetBasicProgressBarCode>
}

void MainPage::AddIndeterminateProgressBar()
{
    // <SnippetInderminateProgressBarCode>
    // Create a new progress bar and set its IsIndeterminate property to true.
    ProgressBar^ progressBar1 = ref new ProgressBar();
    progressBar1->IsIndeterminate = true;
    progressBar1->Width = 100;

    // Add the progress bar to a parent container in the visual tree.
    stackPanel1->Children->Append(progressBar1);
    // </SnippetIndeterminateProgressBarCode>
}

// PROGRESSRING
void MainPage::AddProgressRing()
{
    // <SnippetBasicProgressRingCode>
    // Create a new progress ring and set its IsActive property to true.
    ProgressRing^ progressRing1 = ref new ProgressRing();
    progressRing1->IsActive = true;
    progressRing1->Visibility = Windows::UI::Xaml::Visibility::Visible;

    // Add the progress ring to a parent container in the visual tree.
    stackPanel1->Children->Append(progressRing1);
    // </SnippetBasicProgressRingCode>
}

// IMAGE
void MainPage::AddImage()
{
    Canvas^ canvas1 = ref new Canvas();
    canvas1->Height = 150;
    stackPanel1->Children->Append(canvas1);

    // <SnippetBasicImageCode>
    // Create a new image control and set its Source property.
    Image^ image1 = ref new Image();
    image1->Source = 
		ref new Windows::UI::Xaml::Media::Imaging::BitmapImage
		(ref new Uri("ms-appx:///Assets/Logo.png"));

    // Add the image to a parent container in the visual tree.
    canvas1->Children->Append(image1);
    // </SnippetBasicImageCode>
}

// TEXTBLOCK
void MainPage::AddTextBlock()
{
    // <SnippetBasicTextBlockCode>
    // Create a new text block and set its Text property.
    TextBlock^ textBlock1 = ref new TextBlock();
    textBlock1->Text = "I am a TextBlock.";

    // Add the text block to a parent container in the visual tree.
    stackPanel1->Children->Append(textBlock1);
    // </SnippetBasicTextBlockCode>
}

// TEXTBOX
void MainPage::AddTextBox()
{
    // <SnippetBasicTextBoxCode>
    // Create a new text box, set its Text property, 
    // and add a TextChanged event handler.
    TextBox^ textBox1 = ref new TextBox();
    textBox1->Text = "I am a TextBox.";
    textBox1->TextChanged += 
		ref new TextChangedEventHandler(this, &MainPage::TextBox_TextChanged);

    // Add the text box to a parent container in the visual tree.
    stackPanel1->Children->Append(textBox1);
    // </SnippetBasicTextBoxCode>
}

// <SnippetBasicTextBoxTextChanged>
void MainPage::TextBox_TextChanged(Object^ sender, TextChangedEventArgs^ e)
{
    // Add code to perform some action here.
}
// </SnippetBasicTextBoxTextChanged>


// PASSWORDBOX
void MainPage::AddPasswordBox()
{
    // <SnippetBasicPasswordBoxCode>
    // Create a new password box and add a PasswordChanged event handler.
    PasswordBox^ passwordBox1 = ref new PasswordBox();
    passwordBox1->PasswordChanged += 
		ref new RoutedEventHandler(this, &MainPage::PasswordBox_PasswordChanged);

    // Add the password box to a parent container in the visual tree.
    stackPanel1->Children->Append(passwordBox1);
    // </SnippetBasicPasswordBoxCode>
}

// <SnippetBasicPasswordBoxPasswordChanged>
void MainPage::PasswordBox_PasswordChanged(Object^ sender, RoutedEventArgs^ e)
{
    // Add code to perform some action here.
}
// </SnippetBasicPasswordBoxPasswordChanged>


// LISTVIEW
void MainPage::AddBoundListView()
{
    // <SnippetBasicBoundListViewCode>
    // Data source.
    Platform::Collections::Vector<String^>^ itemsList = 
		ref new Platform::Collections::Vector<String^>();
    itemsList->Append("Item 1");
    itemsList->Append("Item 2");

    // Create a new list view, add content, 
    // and add a SelectionChanged event handler.
    ListView^ listView1 = ref new ListView();
    listView1->ItemsSource = itemsList;
    listView1->SelectionChanged += 
		ref new SelectionChangedEventHandler(this, &MainPage::ListView_SelectionChanged);

    // Add the list view to a parent container in the visual tree.
    stackPanel1->Children->Append(listView1);
    // </SnippetBasicBoundListViewCode>
}

void MainPage::AddListView()
{
    // <SnippetBasicListViewCode>
    // Create a new list view, add content, 
    // and add a SelectionChanged event handler.
    ListView^ listView1 = ref new ListView();
    listView1->Items->Append("Item 1");
    listView1->Items->Append("Item 2");
    listView1->SelectionChanged += 
		ref new SelectionChangedEventHandler(this, &MainPage::ListView_SelectionChanged);

    // Add the list view to a parent container in the visual tree.
    stackPanel1->Children->Append(listView1);
    // </SnippetBasicListViewCode>
}

// <SnippetBasicListViewSelectionChanged>
void MainPage::ListView_SelectionChanged(Object^ sender, SelectionChangedEventArgs^ e)
{
    // Add code to perform some action here.
}
// </SnippetBasicListViewSelectionChanged>

// GRIDVIEW
void MainPage::AddBoundGridView()
{
    // <SnippetBasicBoundGridViewCode>
    // Data source.
    Platform::Collections::Vector<String^>^ itemsList = 
		ref new Platform::Collections::Vector<String^>();
    itemsList->Append("Item 1");
    itemsList->Append("Item 2");

    // Create a new grid view, add content, 
    // and add a SelectionChanged event handler.
    GridView^ gridView1 = ref new GridView();
    gridView1->ItemsSource = itemsList;
    gridView1->SelectionChanged += 
		ref new SelectionChangedEventHandler(this, &MainPage::GridView_SelectionChanged);

    // Add the grid view to a parent container in the visual tree.
    stackPanel1->Children->Append(gridView1);
    // </SnippetBasicBoundGridViewCode>
}

void MainPage::AddGridView()
{
    // <SnippetBasicGridViewCode>
    // Create a new grid view, add content, 
    // and add a SelectionChanged event handler.
    GridView^ gridView1 = ref new GridView();
    gridView1->Items->Append("Item 1");
    gridView1->Items->Append("Item 2");
    gridView1->SelectionChanged += 
		ref new SelectionChangedEventHandler(this, &MainPage::GridView_SelectionChanged);

    // Add the grid view to a parent container in the visual tree.
    stackPanel1->Children->Append(gridView1);
    // </SnippetBasicGridViewCode>
}

// <SnippetBasicGridViewSelectionChanged>
void MainPage::GridView_SelectionChanged(Object^ sender, SelectionChangedEventArgs^ e)
{
    // Add code to perform some action here.
}
// </SnippetBasicGridViewSelectionChanged>


// FLIPVIEW
void MainPage::AddBoundFlipView()
{
    // <SnippetBasicBoundFlipViewCode>
    // Data source.
    Platform::Collections::Vector<String^>^ itemsList = 
		ref new Platform::Collections::Vector<String^>();
    itemsList->Append("Item 1");
    itemsList->Append("Item 2");

    // Create a new flip view, add content, 
    // and add a SelectionChanged event handler.
    FlipView^ flipView1 = ref new FlipView();
    flipView1->ItemsSource = itemsList;
    flipView1->SelectionChanged += 
		ref new SelectionChangedEventHandler(this, &MainPage::FlipView_SelectionChanged);

    // Add the flip view to a parent container in the visual tree.
    stackPanel1->Children->Append(flipView1);
    // </SnippetBasicBoundFlipViewCode>
}

void MainPage::AddFlipView()
{
    // <SnippetBasicFlipViewCode>
    // Create a new flip view, add content, 
    // and add a SelectionChanged event handler.
    FlipView^ flipView1 = ref new FlipView();
    flipView1->Items->Append("Item 1");
    flipView1->Items->Append("Item 2");
    flipView1->SelectionChanged += 
		ref new SelectionChangedEventHandler(this, &MainPage::FlipView_SelectionChanged);

    // Add the flip view to a parent container in the visual tree.
    stackPanel1->Children->Append(flipView1);
    // </SnippetBasicFlipViewCode>
}

// <SnippetBasicFlipViewSelectionChanged>
void MainPage::FlipView_SelectionChanged(Object^ sender, SelectionChangedEventArgs^ e)
{
    // Add code to perform some action here.
}
// </SnippetBasicFlipViewSelectionChanged>
    