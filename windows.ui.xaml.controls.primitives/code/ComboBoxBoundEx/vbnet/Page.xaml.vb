Imports System.Collections.ObjectModel


Public Class Page
    Inherits UserControl

    '<snippet2>
    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Dim fonts As New ObservableCollection(of FontFamily) 
        fonts.Add(New FontFamily("Arial"))
        fonts.Add(New FontFamily("Courier New"))
        fonts.Add(New FontFamily("Times New Roman"))
        FontsCombo.DataContext = fonts
    End Sub
    '</snippet2>
End Class


