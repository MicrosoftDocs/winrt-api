Imports System 
Imports System.Windows 
Imports System.Windows.Controls 
Imports System.Windows.Data 
Imports System.Windows.Documents 
Imports System.Windows.Media 
Imports System.Windows.Shapes 

Namespace DPO 
    ''' <summary> 
    ''' Interaction logic for Page1.xaml 
    ''' </summary> 
    
    Public Partial Class Page1 
        Inherits UserControl 
        Public Sub New() 
            InitializeComponent() 
            DoStuff(Nothing, Nothing) 
        End Sub 
        Private Sub DoStuff(ByVal sender As Object, ByVal e As EventArgs) 
            '<SnippetProceduralPropertySet> 
            Dim myC As New Canvas() 
            myC.Width = 200R 
            '</SnippetProceduralPropertySet> 
            '<SnippetProceduralPropertyGet> 
            Dim whatWidth As Double 
            whatWidth = myC.Width 
            '</SnippetProceduralPropertyGet> 
            Dim checkWidth As Double 
            '<SnippetPropertyMixedDeclProcCB> 
            checkWidth = myC.Width 
            If checkWidth = 200R Then 
                anotherButton.Width = 300R 
            End If 
            '</SnippetPropertyMixedDeclProcCB> 
            myC.Height = myC.Width 
            root.Children.Add(myC) 
            Dim tb As New TextBlock() 
            tb.Text = "Hello" 
            tb.SetValue(Canvas.LeftProperty, 10R) 
            tb.SetValue(Canvas.TopProperty, 200R) 
            myC.Children.Add(tb) 
            Dim tb2 As New TextBlock() 
            tb2.Text = "Hello" 
            tb2.SetValue(Canvas.LeftProperty, 40R) 
            tb2.SetValue(Canvas.TopProperty, 300R) 
            myC.Children.Add(tb2) 
        End Sub 
    End Class 
    
End Namespace 