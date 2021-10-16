using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BasicControlSnippets
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            //tb1.InputScope = new InputScope()
            //{
            //    Names = { new InputScopeName() { NameValue = InputScopeNameValue.Search } }
            //};

            AddButton();
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
        }

        // TOOLTIP
        private void AddToolTip()
        {
            // <SnippetBasicToolTipCode>
            ToolTip toolTip1 = new ToolTip();
            toolTip1.Content = "Click to perform action";
            ToolTipService.SetToolTip(button1, toolTip1);
            // </SnippetBasicToolTipCode>
        }

        // BUTTON
        private void AddButton()
        {
            // <SnippetBasicButtonCode>
            // Create a new button, set its content,
            // and add a Click event handler.
            Button button1 = new Button();
            button1.Content = "Button";
            button1.Click += Button_Click;

            // Add the button to a parent container in the visual tree.
            stackPanel1.Children.Add(button1);
            // </SnippetBasicButtonCode>
        }

        // <SnippetBasicButtonClick>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Add code to perform some action here.
        }
        // </SnippetBasicButtonClick>

        // TOGGLEBUTTON
        private void AddToggleButton()
        {
            // <SnippetBasicToggleButtonCode>
            // Create a new toggle button, set its content,
            // and add a Checked event handler.
            ToggleButton toggleButton1 = new ToggleButton();
            toggleButton1.Content = "Button";
            toggleButton1.Checked += ToggleButton_Checked;

            // Add the toggle button to a parent container in the visual tree.
            stackPanel1.Children.Add(toggleButton1);
            // </SnippetBasicToggleButtonCode>
        }

        // <SnippetBasicToggleButtonChecked>
        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            // Add code to perform some action here.
        }
        // </SnippetBasicToggleButtonChecked>

        // REPEATBUTTON
        private void AddRepeatButton()
        {
            // <SnippetBasicRepeatButtonCode>
            // Create a new repeat button, set its content,
            // and add a Click event handler.
            RepeatButton repeatButton1 = new RepeatButton();
            repeatButton1.Content = "Repeat Button";
            repeatButton1.Click += RepeatButton_Click;

            // Add the button to a parent container in the visual tree.
            stackPanel1.Children.Add(repeatButton1);
            // </SnippetBasicRepeatButtonCode>
        }

        // <SnippetBasicRepeatClick>
        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            // Add code to perform some action here.
            // The Click event occurs continuously while the repeat button is pressed.
        }
        // </SnippetBasicRepeatClick>

        // HYPERLINKBUTTON
        private void AddHyperlinkButton()
        {
            // <SnippetBasicHyperlinkButtonCode>
            // Create a new button, set its content,
            // and a Click event handler.
            HyperlinkButton hyperlinkButton1 = new HyperlinkButton();
            hyperlinkButton1.Content = "www.microsoft.com";
            hyperlinkButton1.NavigateUri = new Uri("http://www.microsoft.com");

            // Add the button to a parent container in the visual tree.
            stackPanel1.Children.Add(hyperlinkButton1);
            // </SnippetBasicHyperlinkButtonCode>
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            // Add code to perform some action here.
        }

        // CHECKBOX
        private void AddCheckBox()
        {
            // <SnippetBasicCheckBoxCode>
            // Create a new check box, set its content, 
            // and add a Checked event handler.
            CheckBox checkBox1 = new CheckBox();
            checkBox1.Content = "CheckBox";
            checkBox1.Checked += CheckBox_Checked;

            // Add the check box to a parent container in the visual tree.
            stackPanel1.Children.Add(checkBox1);
            // </SnippetBasicCheckBoxCode>
        }

        // <SnippetBasicCheckBoxChecked>
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            // Add code to perform some action here.
        }
        // </SnippetBasicCheckBoxChecked>


        // RADIOBUTTON
        private void AddRadioButtons()
        {
            // <SnippetBasicRadioButtonCode>
            // Create new radio buttons, set their content, 
            // and add a Checked event handler.
            RadioButton radioButton1 = new RadioButton();
            radioButton1.Content = "Radio Button 1";
            radioButton1.GroupName = "Group1";
            radioButton1.Checked += RadioButton_Checked;

            RadioButton radioButton2 = new RadioButton();
            radioButton2.Content = "Radio Button 2";
            radioButton2.GroupName = "Group1";
            radioButton2.Checked += RadioButton_Checked;

            // Add the radio buttons to a parent container in the visual tree.
            stackPanel1.Children.Add(radioButton1);
            stackPanel1.Children.Add(radioButton2);
            // </SnippetBasicRadioButtonCode>
        }

        // <SnippetBasicRadioButtonChecked>
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // Add code to perform some action here.
        }
        // </SnippetBasicRadioButtonChecked>

        // SLIDER
        private void AddSlider()
        {
            // <SnippetBasicSliderCode>
            // Create a new slider and add a ValueChanged event handler.
            Slider slider1 = new Slider();
            slider1.Width = 100;
            slider1.ValueChanged += Slider_ValueChanged;

            // Add the slider to a parent container in the visual tree.
            stackPanel1.Children.Add(slider1);
            // </SnippetBasicSliderCode>
        }

        // <SnippetBasicSliderValueChanged>
        private void Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            // Add code to perform some action here.
        }
        // </SnippetBasicSliderValueChanged>


        // TOGGLESWITCH
        private void AddToggleSwitch()
        {
            // <SnippetBasicToggleSwitchCode>
            // Create a new toggle switch, set its content, 
            // and add a Toggled event handler.
            ToggleSwitch toggleSwitch1 = new ToggleSwitch();
            toggleSwitch1.Header = "Toggle Switch";
            toggleSwitch1.OnContent = "On";
            toggleSwitch1.OffContent = "Off";
            toggleSwitch1.Toggled += ToggleSwitch_Toggled;

            // Add the toggle switch to a parent container in the visual tree.
            stackPanel1.Children.Add(toggleSwitch1);
            // </SnippetBasicToggleSwitchCode>
        }

        // <SnippetBasicToggleSwitchToggled>
        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            // Add code to perform some action here.
        }
        // </SnippetBasicToggleSwitchToggled>


        // COMBOBOX
        private void AddBoundComboBox()
        {
            // <SnippetBoundComboBoxCode>
            // Data collection
            List<string> fonts = new List<string>();
            fonts.Add("Item 1");
            fonts.Add("Item 2");
            fonts.Add("Item 3");

            // Create a new combo box, set its items source, and add a SelectionChanged handler.
            ComboBox comboBox1 = new ComboBox();
            comboBox1.Width = 200;
            comboBox1.ItemsSource = fonts;
            comboBox1.SelectionChanged += ComboBox_SelectionChanged;

            // Add the combo box to a parent container in the visual tree.
            stackPanel1.Children.Add(comboBox1);
            // </SnippetBoundComboBoxCode>

        }

        private void AddComboBox()
        {
            // <SnippetBasicComboBoxCode>
            // Create a new combo box, add items, and add a SelectionChanged handler.
            ComboBox comboBox1 = new ComboBox();
            comboBox1.Items.Add("Item 1");
            comboBox1.Items.Add("Item 2");
            comboBox1.Items.Add("Item 3");
            comboBox1.Width = 200;
            comboBox1.SelectionChanged += ComboBox_SelectionChanged;

            // Add the combo box to a parent container in the visual tree.
            stackPanel1.Children.Add(comboBox1);
            // </SnippetBasicComboBoxCode>
        }

        // <SnippetBasicComboBoxSelectionChanged>
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Add code to perform some action here.
        }
        // </SnippetBasicComboBoxSelectionChanged>


        // LISTBOX
        private void AddBoundListBox()
        {
            // <SnippetBoundListBoxCode>
            // Data collection
            List<string> fonts = new List<string>();
            fonts.Add("Item 1");
            fonts.Add("Item 2");
            fonts.Add("Item 3");

            // Create a new list box, set its items source, and add a SelectionChanged handler.
            ListBox listBox1 = new ListBox();
            listBox1.Width = 140;
            listBox1.ItemsSource = fonts;
            listBox1.SelectionChanged += ListBox_SelectionChanged;

            // Add the list box to a parent container in the visual tree.
            stackPanel1.Children.Add(listBox1);
            // </SnippetBoundListBoxCode>

        }

        private void AddListBox()
        {
            // <SnippetBasicListBoxCode>
            // Create a new list box, add items, and add a SelectionChanged handler.
            ListBox listBox1 = new ListBox();
            listBox1.Items.Add("Item 1");
            listBox1.Items.Add("Item 2");
            listBox1.Items.Add("Item 3");
            listBox1.Width = 140;
            listBox1.SelectionChanged += ListBox_SelectionChanged;

            // Add the list box to a parent container in the visual tree.
            stackPanel1.Children.Add(listBox1);
            // </SnippetBasicListBoxCode>
        }

        // <SnippetBasicListBoxSelectionChanged>
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Add code to perform some action here.
        }
        // </SnippetBasicListBoxSelectionChanged>

        // PROGRESSBAR
        private void AddProgressBar()
        {
            double progressValue = 45.0;

            // <SnippetBasicProgressBarCode>
            // Create a new progress bar and set its Value property to a double value.
            ProgressBar progressBar1 = new ProgressBar();
            progressBar1.Value = (double)progressValue;
            progressBar1.Width = 100;

            // Add the progress bar to a parent container in the visual tree.
            stackPanel1.Children.Add(progressBar1);
            // </SnippetBasicProgressBarCode>
        }

        private void AddIndeterminateProgressBar()
        {
            // <SnippetInderminateProgressBarCode>
            // Create a new progress bar and set its IsIndeterminate property to true.
            ProgressBar progressBar1 = new ProgressBar();
            progressBar1.IsIndeterminate = true;
            progressBar1.Width = 100;

            // Add the progress bar to a parent container in the visual tree.
            stackPanel1.Children.Add(progressBar1);
            // </SnippetIndeterminateProgressBarCode>
        }

        // PROGRESSRING
        private void AddProgressRing()
        {
            // <SnippetBasicProgressRingCode>
            // Create a new progress ring and set its IsActive property to true.
            ProgressRing progressRing1 = new ProgressRing();
            progressRing1.IsActive = true;
            progressRing1.Visibility = Visibility.Visible;

            // Add the progress ring to a parent container in the visual tree.
            stackPanel1.Children.Add(progressRing1);
            // </SnippetBasicProgressRingCode>
        }

        // IMAGE
        private void AddImage()
        {
            Canvas canvas1 = new Canvas();
            canvas1.Height = 150;
            stackPanel1.Children.Add(canvas1);

            // <SnippetBasicImageCode>
            // Create a new image control and set its Source property.
            Image image1 = new Image();
            image1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/Logo.png"));

            // Add the image to a parent container in the visual tree.
            canvas1.Children.Add(image1);
            // </SnippetBasicImageCode>
        }

        // TEXTBLOCK
        private void AddTextBlock()
        {
            // <SnippetBasicTextBlockCode>
            // Create a new text block and set its Text property.
            TextBlock textBlock1 = new TextBlock();
            textBlock1.Text = "I am a TextBlock.";

            // Add the text block to a parent container in the visual tree.
            stackPanel1.Children.Add(textBlock1);
            // </SnippetBasicTextBlockCode>
        }

        // TEXTBOX
        private void AddTextBox()
        {
            // <SnippetBasicTextBoxCode>
            // Create a new text box, set its Text property, 
            // and add a TextChanged event handler.
            TextBox textBox1 = new TextBox();
            textBox1.Text = "I am a TextBox.";
            textBox1.TextChanged += TextBox_TextChanged;

            // Add the text box to a parent container in the visual tree.
            stackPanel1.Children.Add(textBox1);
            // </SnippetBasicTextBoxCode>
        }

        // <SnippetBasicTextBoxTextChanged>
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Add code to perform some action here.
        }
        // </SnippetBasicTextBoxTextChanged>


        // PASSWORDBOX
        private void AddPasswordBox()
        {
            // <SnippetBasicPasswordBoxCode>
            // Create a new password box and add a PasswordChanged event handler.
            PasswordBox passwordBox1 = new PasswordBox();
            passwordBox1.PasswordChanged += PasswordBox_PasswordChanged;

            // Add the password box to a parent container in the visual tree.
            stackPanel1.Children.Add(passwordBox1);
            // </SnippetBasicPasswordBoxCode>
        }

        // <SnippetBasicPasswordBoxPasswordChanged>
        void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            // Add code to perform some action here.
        }
        // </SnippetBasicPasswordBoxPasswordChanged>


        // LISTVIEW
        private void AddBoundListView()
        {
            // <SnippetBasicBoundListViewCode>
            // Data source.
            List<String> itemsList = new List<string>();
            itemsList.Add("Item 1");
            itemsList.Add("Item 2");

            // Create a new list view, add content, 
            // and add a SelectionChanged event handler.
            ListView listView1 = new ListView();
            listView1.ItemsSource = itemsList;
            listView1.SelectionChanged += ListView_SelectionChanged;

            // Add the list view to a parent container in the visual tree.
            stackPanel1.Children.Add(listView1);
            // </SnippetBasicBoundListViewCode>
        }

        private void AddListView()
        {
            // <SnippetBasicListViewCode>
            // Create a new list view, add content, 
            // and add a SelectionChanged event handler.
            ListView listView1 = new ListView();
            listView1.Items.Add("Item 1");
            listView1.Items.Add("Item 2");
            listView1.SelectionChanged += ListView_SelectionChanged;

            // Add the list view to a parent container in the visual tree.
            stackPanel1.Children.Add(listView1);
            // </SnippetBasicListViewCode>
        }

        // <SnippetBasicListViewSelectionChanged>
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Add code to perform some action here.
        }
        // </SnippetBasicListViewSelectionChanged>

        // GRIDVIEW
        private void AddBoundGridView()
        {
            // <SnippetBasicBoundGridViewCode>
            // Data source.
            List<String> itemsList = new List<string>();
            itemsList.Add("Item 1");
            itemsList.Add("Item 2");

            // Create a new grid view, add content, 
            // and add a SelectionChanged event handler.
            GridView gridView1 = new GridView();
            gridView1.ItemsSource = itemsList;
            gridView1.SelectionChanged += GridView_SelectionChanged;

            // Add the grid view to a parent container in the visual tree.
            stackPanel1.Children.Add(gridView1);
            // </SnippetBasicBoundGridViewCode>
        }

        private void AddGridView()
        {
            // <SnippetBasicGridViewCode>
            // Create a new grid view, add content, 
            // and add a SelectionChanged event handler.
            GridView gridView1 = new GridView();
            gridView1.Items.Add("Item 1");
            gridView1.Items.Add("Item 2");
            gridView1.SelectionChanged += GridView_SelectionChanged;

            // Add the grid view to a parent container in the visual tree.
            stackPanel1.Children.Add(gridView1);
            // </SnippetBasicGridViewCode>
        }

        // <SnippetBasicGridViewSelectionChanged>
        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Add code to perform some action here.
        }
        // </SnippetBasicGridViewSelectionChanged>


        // FLIPVIEW
        private void AddBoundFlipView()
        {
            // <SnippetBasicBoundFlipViewCode>
            // Data source.
            List<String> itemsList = new List<string>();
            itemsList.Add("Item 1");
            itemsList.Add("Item 2");

            // Create a new flip view, add content, 
            // and add a SelectionChanged event handler.
            FlipView flipView1 = new FlipView();
            flipView1.ItemsSource = itemsList;
            flipView1.SelectionChanged += FlipView_SelectionChanged;

            // Add the flip view to a parent container in the visual tree.
            stackPanel1.Children.Add(flipView1);
            // </SnippetBasicBoundFlipViewCode>
        }

        private void AddFlipView()
        {
            // <SnippetBasicFlipViewCode>
            // Create a new flip view, add content, 
            // and add a SelectionChanged event handler.
            FlipView flipView1 = new FlipView();
            flipView1.Items.Add("Item 1");
            flipView1.Items.Add("Item 2");
            flipView1.SelectionChanged += FlipView_SelectionChanged;

            // Add the flip view to a parent container in the visual tree.
            stackPanel1.Children.Add(flipView1);
            // </SnippetBasicFlipViewCode>
        }

        // <SnippetBasicFlipViewSelectionChanged>
        private void FlipView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Add code to perform some action here.
        }
        // </SnippetBasicFlipViewSelectionChanged>
    }
}
