' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    ''' <summary>
    ''' Invoked when this page is about to be displayed in a Frame.
    ''' </summary>
    ''' <param name="e">Event data that describes how this page was reached.  The Parameter
    ''' property is typically used to configure the page.</param>
    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)
        AddToolTip()
        AddButton()
        AddRepeatButton()
        AddHyperlinkButton()
        AddCheckBox()
        AddRadioButtons()
        AddSlider()
        AddToggleSwitch()
        AddBoundComboBox()
        AddComboBox()
        AddBoundListBox()
        AddListBox()
        AddProgressBar()
        AddIndeterminateProgressBar()
        AddProgressRing()
        AddImage()
        AddTextBlock()
        AddTextBox()
        AddPasswordBox()
        AddBoundListView()
        AddListView()
        AddBoundGridView()
        AddGridView()
        AddBoundFlipView()
        AddFlipView()
    End Sub

    ' TOOLTIP
    Private Sub AddToolTip()
        ' <SnippetBasicToolTipCode>
        Dim toolTip1 = New ToolTip()
        toolTip1.Content = "Click to perform action"
        ToolTipService.SetToolTip(button1, toolTip1)
        ' </SnippetBasicToolTipCode>
    End Sub

    ' BUTTON
    Private Sub AddButton()
        ' <SnippetBasicButtonCode>
        ' Create a new button, set its content,
        ' and add a Click event handler.
        Dim button1 = New Button()
        button1.Content = "Button"
        AddHandler button1.Click, AddressOf Me.Button_Click

        ' Add the button to a parent container in the visual tree.
        stackPanel1.Children.Add(button1)
        ' </SnippetBasicButtonCode>
    End Sub

    ' <SnippetBasicButtonClick>
    Private Sub Button_Click()
        ' Add code to perform some action here.
    End Sub
    ' </SnippetBasicButtonClick>

    ' TOGGLEBUTTON
    Private Sub AddToggleButton()
        ' <SnippetBasicToggleButtonCode>
        ' Create a new toggle button, set its content,
        ' and add a Checked event handler.
        Dim toggleButton1 = New ToggleButton()
        toggleButton1.Content = "Button"
        AddHandler toggleButton1.Checked, AddressOf Me.ToggleButton_Checked

        ' Add the button to a parent container in the visual tree.
        stackPanel1.Children.Add(toggleButton1)
        ' </SnippetBasicToggleButtonCode>
    End Sub

    ' <SnippetBasicToggleButtonChecked>
    Private Sub ToggleButton_Checked()
        ' Add code to perform some action here.
    End Sub
    ' <SnippetBasicToggleButtonChecked>

    Private Sub AddRepeatButton()
        ' <SnippetBasicRepeatButtonCode>
        ' Create a new repeat button, set its content,
        ' and add a Click event handler.
        Dim repeatButton1 = New RepeatButton()
        repeatButton1.Content = "Repeat Button"
        AddHandler repeatButton1.Click, AddressOf Me.RepeatButton_Click

        ' Add the button to a parent container in the visual tree.
        stackPanel1.Children.Add(repeatButton1)
        ' </SnippetBasicRepeatButtonCode>
    End Sub

    ' <SnippetBasicRepeatClick>
    Private Sub RepeatButton_Click()
        ' Add code to perform some action here.
        ' The Click event occurs continuously while the repeat button is pressed.
    End Sub
    ' </SnippetBasicRepeatClick>

    ' HYPERLINKBUTTON
    Private Sub AddHyperlinkButton()
        ' <SnippetBasicHyperlinkButtonCode>
        ' Create a new button, set its content,
        ' and set Uri to navigate to.
        Dim hyperlinkButton1 = New HyperlinkButton()
        hyperlinkButton1.Content = "www.microsoft.com"
        hyperlinkButton1.NavigateUri = New Uri("http://www.microsoft.com")

        ' Add the button to a parent container in the visual tree.
        stackPanel1.Children.Add(hyperlinkButton1)
        ' </SnippetBasicHyperlinkButtonCode>
    End Sub

    ' CHECKBOX
    Private Sub AddCheckBox()
        ' <SnippetBasicCheckBoxCode>
        ' Create a new check box, set its content, 
        ' and add a Checked event handler.
        Dim checkBox1 = New CheckBox()
        checkBox1.Content = "CheckBox"
        AddHandler checkBox1.Checked, AddressOf Me.CheckBox_Checked

        ' Add the check box to a parent container in the visual tree.
        stackPanel1.Children.Add(checkBox1)
        ' </SnippetBasicCheckBoxCode>
    End Sub

    ' <SnippetBasicCheckBoxChecked>
    Private Sub CheckBox_Checked()
        ' Add code to perform some action here.
    End Sub
    ' </SnippetBasicCheckBoxChecked>

    Private Sub AddRadioButtons()
        ' <SnippetBasicRadioButtonCode>
        ' Create new radio buttons, set their content, 
        ' and add a Checked event handler.
        Dim radioButton1 = New RadioButton()
        radioButton1.Content = "Radio Button 1"
        radioButton1.GroupName = "Group1"
        AddHandler radioButton1.Checked, AddressOf Me.RadioButton_Checked

        Dim radioButton2 = New RadioButton()
        radioButton2.Content = "Radio Button 2"
        radioButton2.GroupName = "Group1"
        AddHandler radioButton2.Checked, AddressOf Me.RadioButton_Checked

        ' Add the radio buttons to a parent container in the visual tree.
        stackPanel1.Children.Add(radioButton1)
        stackPanel1.Children.Add(radioButton2)
        ' </SnippetBasicRadioButtonCode>
    End Sub

    ' <SnippetBasicRadioButtonChecked>
    Private Sub RadioButton_Checked()
        ' Add code to perform some action here.
    End Sub
    ' </SnippetBasicRadioButtonChecked>

    Private Sub AddSlider()
        ' <SnippetBasicSliderCode>
        ' Create a new slider and add a ValueChanged event handler.
        Dim slider1 = New Slider()
        slider1.Width = 100
        AddHandler slider1.ValueChanged, AddressOf Me.Slider_ValueChanged

        ' Add the slider to a parent container in the visual tree.
        stackPanel1.Children.Add(slider1)
        ' </SnippetBasicSliderCode>
    End Sub

    ' <SnippetBasicSliderValueChanged>
    Private Sub Slider_ValueChanged()
        ' Add code to perform some action here.
    End Sub
    ' </SnippetBasicSliderValueChanged>

    Private Sub AddToggleSwitch()
        ' <SnippetBasicToggleSwitchCode>
        ' Create a new toggle switch, set its content, 
        ' and add a Toggled event handler.
        Dim toggleSwitch1 = New ToggleSwitch()
        toggleSwitch1.Header = "Toggle Switch"
        toggleSwitch1.OnContent = "On"
        toggleSwitch1.OffContent = "Off"
        AddHandler toggleSwitch1.Toggled, AddressOf Me.ToggleSwitch_Toggled

        ' Add the toggle switch to a parent container in the visual tree.
        stackPanel1.Children.Add(toggleSwitch1)
        ' </SnippetBasicToggleSwitchCode>
    End Sub

    ' <SnippetBasicToggleSwitchToggled>
    Private Sub ToggleSwitch_Toggled()
        ' Add code to perform some action here.
    End Sub
    ' </SnippetBasicToggleSwitchToggled>

    Private Sub AddBoundComboBox()
        ' <SnippetBoundComboBoxCode>
        ' Data collection
        Dim fonts = New List(Of String)()
        fonts.Add("Item 1")
        fonts.Add("Item 2")
        fonts.Add("Item 3")

        ' Create a new combo box, set its items source, and add a SelectionChanged handler.
        Dim comboBox1 = New ComboBox()
        comboBox1.Width = 200
        comboBox1.ItemsSource = fonts
        AddHandler comboBox1.SelectionChanged, AddressOf Me.ComboBox_SelectionChanged

        ' Add the combo box to a parent container in the visual tree.
        stackPanel1.Children.Add(comboBox1)
        ' </SnippetBoundComboBoxCode>
    End Sub

    Private Sub AddComboBox()
        ' <SnippetBasicComboBoxCode>
        ' Create a new combo box, add items, and add a SelectionChanged handler.
        Dim comboBox1 = New ComboBox()
        comboBox1.Items.Add("Item 1")
        comboBox1.Items.Add("Item 2")
        comboBox1.Items.Add("Item 3")
        comboBox1.Width = 200
        AddHandler comboBox1.SelectionChanged, AddressOf Me.ComboBox_SelectionChanged

        ' Add the combo box to a parent container in the visual tree.
        stackPanel1.Children.Add(comboBox1)
        ' <SnippetBasicComboBoxCode>
    End Sub

    ' <SnippetBasicComboBoxSelectionChanged>
    Private Sub ComboBox_SelectionChanged()
        ' Add code to perform some action here.
    End Sub
    ' </SnippetBasicComboBoxSelectionChanged>

    Private Sub AddBoundListBox()
        ' <SnippetBoundListBoxCode>
        ' Data collection
        Dim fonts = New List(Of String)()
        fonts.Add("Item 1")
        fonts.Add("Item 2")
        fonts.Add("Item 3")

        ' Create a new list box, set its items source, and add a SelectionChanged handler.
        Dim listBox1 = New ListBox()
        listBox1.Width = 140
        listBox1.ItemsSource = fonts
        AddHandler listBox1.SelectionChanged, AddressOf Me.ListBox_SelectionChanged

        ' Add the list box to a parent container in the visual tree.
        stackPanel1.Children.Add(listBox1)
        ' </SnippetBoundListBoxCode>
    End Sub

    Private Sub AddListBox()
        ' <SnippetBasicListBoxCode>
        ' Create a new list box, add items, and add a SelectionChanged handler.
        Dim listBox1 = New ListBox()
        listBox1.Items.Add("Item 1")
        listBox1.Items.Add("Item 2")
        listBox1.Items.Add("Item 3")
        listBox1.Width = 140
        AddHandler listBox1.SelectionChanged, AddressOf Me.ListBox_SelectionChanged

        ' Add the list box to a parent container in the visual tree.
        stackPanel1.Children.Add(listBox1)
        ' </SnippetBasicListBoxCode>
    End Sub

    ' <SnippetBasicListBoxSelectionChanged>
    Private Sub ListBox_SelectionChanged()
        ' Add code to perform some action here.
    End Sub
    ' </SnippetBasicListBoxSelectionChanged>

    Private Sub AddProgressBar()
        Dim progressValue = 45.0
        ' <SnippetBasicProgressBarCode>
        ' Create a new progress bar and set its Value property to a double value.
        Dim progressBar1 = New ProgressBar()
        progressBar1.Value = progressValue
        progressBar1.Width = 100

        ' Add the progress bar to a parent container in the visual tree.
        stackPanel1.Children.Add(progressBar1)
        ' </SnippetBasicProgressBarCode>
    End Sub

    Private Sub AddIndeterminateProgressBar()
        ' <SnippetInderminateProgressBarCode>
        ' Create a new progress bar and set its IsIndeterminate property to true.
        Dim progressBar1 = New ProgressBar()
        progressBar1.IsIndeterminate = True
        progressBar1.Width = 100

        ' Add the progress bar to a parent container in the visual tree.
        stackPanel1.Children.Add(progressBar1)
        ' </SnippetIndeterminateProgressBarCode>
    End Sub

    Private Sub AddProgressRing()
        ' <SnippetBasicProgressRingCode>
        ' Create a new progress ring and set its IsActive property to true.
        Dim progressRing1 = New ProgressRing()
        progressRing1.IsActive = True
        progressRing1.Visibility = Visibility.Visible

        ' Add the progress ring to a parent container in the visual tree.
        stackPanel1.Children.Add(progressRing1)
        ' </SnippetBasicProgressRingCode>
    End Sub

    Private Sub AddImage()
        Dim canvas1 = New Canvas()
        canvas1.Height = 150
        stackPanel1.Children.Add(canvas1)

        ' <SnippetBasicImageCode>
        ' Create a new image control and set its Source property.
        Dim image1 = New Image()
        image1.Source = New Windows.UI.Xaml.Media.Imaging.BitmapImage(New Uri("ms-appx:///Assets/Logo.png"))

        ' Add the image to a parent container in the visual tree.
        canvas1.Children.Add(image1)
        ' </SnippetBasicImageCode>
    End Sub

    Private Sub AddTextBlock()
        ' <SnippetBasicTextBlockCode>
        ' Create a new text block and set its Text property.
        Dim textBlock1 = New TextBlock()
        textBlock1.Text = "I am a TextBlock."

        ' Add the text block to a parent container in the visual tree.
        stackPanel1.Children.Add(textBlock1)
        ' </SnippetBasicTextBlockCode>
    End Sub

    Private Sub AddTextBox()
        ' <SnippetBasicTextBoxCode>
        ' Create a new text box, set its Text property, 
        ' and add a TextChanged event handler.
        Dim textBox1 = New TextBox()
        textBox1.Text = "I am a TextBox."
        AddHandler textBox1.TextChanged, AddressOf Me.TextBox_TextChanged

        ' Add the text box to a parent container in the visual tree.
        stackPanel1.Children.Add(textBox1)
        ' </SnippetBasicTextBoxCode>
    End Sub

    ' <SnippetBasicTextBoxTextChanged>
    Private Sub TextBox_TextChanged()
        ' Add code to perform some action here.
    End Sub
    ' </SnippetBasicTextBoxTextChanged>

    Private Sub AddPasswordBox()
        ' <SnippetBasicPasswordBoxCode>
        ' Create a new password box and add a PasswordChanged event handler.
        Dim passwordBox1 = New PasswordBox()
        AddHandler passwordBox1.PasswordChanged, AddressOf Me.PasswordBox_PasswordChanged

        ' Add the password box to a parent container in the visual tree.
        stackPanel1.Children.Add(passwordBox1)
        ' </SnippetBasicPasswordBoxCode>
    End Sub

    ' <SnippetBasicPasswordBoxPasswordChanged>
    Private Sub PasswordBox_PasswordChanged()
        ' Add code to perform some action here.
    End Sub
    ' </SnippetBasicPasswordBoxPasswordChanged>

    ' LISTVIEW
    Private Sub AddBoundListView()
        ' <SnippetBasicBoundListViewCode>
        ' Data source.
        Dim itemsList = New List(Of String)()
        itemsList.Add("Item 1")
        itemsList.Add("Item 2")

        ' Create a new list view, add content, 
        ' and add a SelectionChanged event handler.
        Dim listView1 = New ListView()
        listView1.ItemsSource = itemsList
        AddHandler listView1.SelectionChanged, AddressOf Me.ListView_SelectionChanged

        ' Add the list view to a parent container in the visual tree.
        stackPanel1.Children.Add(listView1)
        ' </SnippetBasicBoundListViewCode>
    End Sub

    Private Sub AddListView()
        ' <SnippetBasicListViewCode>
        ' Create a new list view, add content, 
        ' and add a SelectionChanged event handler.
        Dim listView1 = New ListView()
        listView1.Items.Add("Item 1")
        listView1.Items.Add("Item 2")
        AddHandler listView1.SelectionChanged, AddressOf Me.ListView_SelectionChanged

        ' Add the list view to a parent container in the visual tree.
        stackPanel1.Children.Add(listView1)
        ' </SnippetBasicListViewCode>
    End Sub

    ' <SnippetBasicListViewSelectionChanged>
    Private Sub ListView_SelectionChanged()
        ' Add code to perform some action here.
    End Sub
    ' </SnippetBasicListViewSelectionChanged>

    ' GRIDVIEW
    Private Sub AddBoundGridView()
        ' <SnippetBasicBoundGridViewCode>
        ' Data source.
        Dim itemsList = New List(Of String)()
        itemsList.Add("Item 1")
        itemsList.Add("Item 2")

        ' Create a new grid view, add content, 
        ' and add a SelectionChanged event handler.
        Dim gridView1 = New GridView()
        gridView1.ItemsSource = itemsList
        AddHandler gridView1.SelectionChanged, AddressOf Me.GridView_SelectionChanged

        ' Add the grid view to a parent container in the visual tree.
        stackPanel1.Children.Add(gridView1)
        ' </SnippetBasicBoundGridViewCode>
    End Sub

    Private Sub AddGridView()
        ' <SnippetBasicGridViewCode>
        ' Create a new grid view, add content, 
        ' and add a SelectionChanged event handler.
        Dim gridView1 = New GridView()
        gridView1.Items.Add("Item 1")
        gridView1.Items.Add("Item 2")
        AddHandler gridView1.SelectionChanged, AddressOf Me.GridView_SelectionChanged

        ' Add the grid view to a parent container in the visual tree.
        stackPanel1.Children.Add(gridView1)
        ' </SnippetBasicGridViewCode>
    End Sub

    ' <SnippetBasicGridViewSelectionChanged>
    Private Sub GridView_SelectionChanged()
        ' Add code to perform some action here.
    End Sub
    ' </SnippetBasicGridViewSelectionChanged>


    ' FLIPVIEW
    Private Sub AddBoundFlipView()

        ' <SnippetBasicBoundFlipViewCode>
        ' Data source.
        Dim itemsList = New List(Of String)()
        itemsList.Add("Item 1")
        itemsList.Add("Item 2")

        ' Create a new flip view, add content, 
        ' and add a SelectionChanged event handler.
        Dim flipView1 = New FlipView()
        flipView1.ItemsSource = itemsList
        AddHandler flipView1.SelectionChanged, AddressOf Me.FlipView_SelectionChanged

        ' Add the flip view to a parent container in the visual tree.
        stackPanel1.Children.Add(flipView1)
        ' </SnippetBasicBoundFlipViewCode>
    End Sub

    Private Sub AddFlipView()
        ' <SnippetBasicFlipViewCode>
        ' Create a new flip view, add content, 
        ' and add a SelectionChanged event handler.
        Dim flipView1 = New FlipView()
        flipView1.Items.Add("Item 1")
        flipView1.Items.Add("Item 2")
        AddHandler flipView1.SelectionChanged, AddressOf Me.FlipView_SelectionChanged

        ' Add the flip view to a parent container in the visual tree.
        stackPanel1.Children.Add(flipView1)
        ' </SnippetBasicFlipViewCode>
    End Sub

    ' <SnippetBasicFlipViewSelectionChanged>
    Private Sub FlipView_SelectionChanged()
        ' Add code to perform some action here.
    End Sub
    ' </SnippetBasicFlipViewSelectionChanged>

End Class
