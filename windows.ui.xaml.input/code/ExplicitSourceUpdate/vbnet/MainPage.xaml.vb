Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data


Partial Public Class MainPage
    inherits UserControl

    '<snippetCode>
    Public Class TestData
        Private testValue As String
        Public Property Test() As String
            Get
                Return testValue
            End Get
            Set(ByVal value As String)
                testValue = value
            End Set
        End Property
    End Class

    Private data As TestData

    Public Sub New()

        InitializeComponent()

        data = New TestData
        With data
            .Test = "one"
        End With

        textBox1.DataContext = data

    End Sub

    Private Sub Button_Click(ByVal sender As Object, _
        ByVal e As RoutedEventArgs)

        Dim expression As BindingExpression = _
            textBox1.GetBindingExpression(TextBox.TextProperty)
        MessageBox.Show("Before UpdateSource, Test = " & data.Test)
        expression.UpdateSource()
        MessageBox.Show("After UpdateSource, Test = " & data.Test)

    End Sub
    '</snippetCode>

End Class


