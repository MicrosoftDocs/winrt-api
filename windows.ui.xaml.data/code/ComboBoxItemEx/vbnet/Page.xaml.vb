Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
        myCombo.Items.Add(New FontFamily("Arial"))
        myCombo.Items.Add(New FontFamily("Courier New"))
        myCombo.Items.Add(New FontFamily("Times New Roman"))


    End Sub

End Class