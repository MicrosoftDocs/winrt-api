Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        InitializeComponent()

        '<snippet11> 
        Dim tBlock1 As New TextBlock()
        tBlock1.Text = "TextBlock"
        LayoutRoot.Children.Add(tBlock1)
        '</snippet11> 

        '<snippet21> 
        Dim tBlock2 As New TextBlock()
        Dim run1 As New Run()
        run1.Text = "Text"
        run1.FontFamily = New FontFamily("Arial")
        run1.FontSize = 20
        tBlock2.Inlines.Add(run1)
        tBlock2.Inlines.Add(New LineBreak())
        run1 = New Run()
        run1.Text = "using Inlines"
        run1.FontFamily = New FontFamily("Courier New")
        run1.FontSize = 14
        run1.FontWeight = FontWeights.Bold
        tBlock2.Inlines.Add(run1)
        LayoutRoot.Children.Add(tBlock2)
        '</snippet21> 

        '<snippet31> 
        Dim tBox1 As New TextBox()
        tBox1.Text = "TextBox with a line of text that wraps."
        tBox1.FontFamily = New FontFamily("Arial")
        tBox1.TextWrapping = TextWrapping.Wrap
        tBox1.Width = 100
        LayoutRoot.Children.Add(tBox1)
        '</snippet31> 

        '<snippet41> 
        Dim button1 As New Button()
        button1.Width = 50
        button1.Height = 30
        Dim panel1 As New StackPanel()
        panel1.Orientation = Orientation.Horizontal
        Dim rect1 As New Rectangle()
        rect1.Width = 10
        rect1.Fill = New SolidColorBrush(Colors.Green)
        Dim tb3 As New TextBlock()
        tb3.Margin = New Thickness(2)
        tb3.Text = "Green"
        tb3.TextAlignment = TextAlignment.Center
        panel1.Children.Add(tb3)
        panel1.Children.Add(rect1)
        button1.Content = panel1
        LayoutRoot.Children.Add(button1)
        '</snippet41> 

        '<snippet61> 
        Dim cb1 As New ComboBox()
        cb1.Items.Add("Item 1")
        cb1.Items.Add("Item 2")
        cb1.Items.Add("Item 3")
        LayoutRoot.Children.Add(cb1)
        '</snippet61> 


    End Sub
End Class
