Imports System.Collections.ObjectModel

Public NotInheritable Class BlankPage
    Inherits Page

    Dim MyBills As Bills

    Public Sub New()
        InitializeComponent()

        MyBills = New Bills()
        DataContext = MyBills.GetStatements()
    End Sub

    Private Sub LoadedHandler(ByVal sender As Object, ByVal e As RoutedEventArgs)


    End Sub

    Public Class Statements
        Implements INotifyPropertyChanged
        Private _Month As DateTime
        Private _Total As Double

#Region "INotifyPropertyChanged Members"

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

#End Region

        Public Property Month() As DateTime
            Get
                Return _Month
            End Get
            Set(ByVal value As DateTime)
                _Month = value
                NotifyPropertyChanged("Month")
            End Set
        End Property
        Public Property Total() As Double
            Get
                Return _Total
            End Get
            Set(ByVal value As Double)
                _Total = value
                NotifyPropertyChanged("Total")
            End Set
        End Property
        Public Sub New(ByVal month As DateTime, ByVal total As Double)
            Me.Month = month
            Me.Total = total
        End Sub


        Public Sub NotifyPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

    End Class

    Public Class Bills

        Private _AllStatements As ObservableCollection(Of Statements)

        Public ReadOnly Property AllStatements() As ObservableCollection(Of Statements)
            Get
                If _AllStatements Is Nothing Then
                    _AllStatements = New ObservableCollection(Of Statements)()
                End If
                Return _AllStatements
            End Get
        End Property

        Public Function GetStatements() As ObservableCollection(Of Statements)
            If _AllStatements Is Nothing Then
                _AllStatements = New ObservableCollection(Of Statements)()
            End If
            Dim dt As New DateTime(2007, 1, 1)
            Dim amt As Double = 1242.54
            _AllStatements.Add(New Statements(dt, amt))
            _AllStatements.Add(New Statements(New DateTime(2007, 2, 1), 435.98))
            Return _AllStatements
        End Function

    End Class
End Class
