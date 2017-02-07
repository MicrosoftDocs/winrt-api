'<SnippetGridClassCode> 
Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
        LayoutDesign()
    End Sub

    Private Sub LayoutDesign()
        'Create Stackpanel for ListBox Control and its description 
        Dim DeptStackPanel As New StackPanel()
        DeptStackPanel.Margin = New Thickness(10)

        LayoutRoot.Children.Add(DeptStackPanel)
        Grid.SetColumn(DeptStackPanel, 1)
        Grid.SetRow(DeptStackPanel, 1)

        Dim DeptListHeading As New TextBlock()
        DeptListHeading.Text = "Department"

        Dim DeptList As New ListBox()
        DeptList.Items.Add("Finance")
        DeptList.Items.Add("Marketing")
        DeptList.Items.Add("Human Resources")
        DeptList.Items.Add("Payroll")

        DeptStackPanel.Children.Add(DeptListHeading)
        DeptStackPanel.Children.Add(DeptList)

        'Create StackPanel for buttons 
        Dim ButtonsStackPanel As New StackPanel()
        ButtonsStackPanel.Margin = New Thickness(10)
        ButtonsStackPanel.Orientation = Orientation.Horizontal
        ButtonsStackPanel.HorizontalAlignment = HorizontalAlignment.Center

        LayoutRoot.Children.Add(ButtonsStackPanel)
        Grid.SetColumn(ButtonsStackPanel, 0)
        Grid.SetRow(ButtonsStackPanel, 2)
        Grid.SetColumnSpan(ButtonsStackPanel, 2)

        Dim BackButton As New Button()
        BackButton.Content = "Back"
        BackButton.Height = 30
        BackButton.Width = 100

        Dim CancelButton As New Button()
        CancelButton.Content = "Cancel"
        CancelButton.Height = 30
        CancelButton.Width = 100

        Dim NextButton As New Button()
        NextButton.Content = "Next"
        NextButton.Height = 30
        NextButton.Width = 100

        ButtonsStackPanel.Children.Add(BackButton)
        ButtonsStackPanel.Children.Add(CancelButton)
        ButtonsStackPanel.Children.Add(NextButton)

        BackButton.Margin = New Thickness(10)
        CancelButton.Margin = New Thickness(10)
        NextButton.Margin = New Thickness(10)
    End Sub
End Class
'</SnippetGridClassCode> 