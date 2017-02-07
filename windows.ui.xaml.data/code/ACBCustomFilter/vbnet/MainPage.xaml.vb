Imports System.Windows.Input


Partial Public Class MainPage
    Inherits UserControl
    ' Use snippets 1,10,11,13,14,16 for custom string search. 
    ' Use snippets 1,10,11,12,13,15,16 for custom object search. 

    '<snippet10> 
    Private employees As New List(Of Employee)()
    Public Sub New()
        InitializeComponent()
        ' Add some items to the employee list. 
        employees.Add(New Employee("Sells", "Chris", "csells", 1234))
        employees.Add(New Employee("Cabatana", "Reina", "rcaba", 5678))
        employees.Add(New Employee("Sprenger", "Christof", "cspreng", 9123))
        employees.Add(New Employee("Brandel", "Jonas", "jbrandel", 4567))
        employees.Add(New Employee("Bye", "Dennis", "dbye", 8912))
        employees.Add(New Employee("Reid", "Miles", "mreid", 3456))

        ' Set the item source. 
        myACB.ItemsSource = employees
        '</snippet10> 

        '<snippet11> 
        ' Set the TextFilter property to the search method. 
        myACB.TextFilter = AddressOf SearchEmployees
        '</snippet11> 

        '<snippet12> 
        ' Set the ItemFilter property to the search method. 
 	 myACB.ItemFilter = AddressOf SearchEmployees
        '</snippet12> 
      
       
    '<snippet13> 
    End Sub
    '</snippet13> 

    '<snippet14> 
    Private Function SearchEmployees(ByVal search As String, ByVal value As String) As Boolean
        value = value.ToLower()
        ' Split the string a new line. 
        Dim words As String() = value.Split(System.Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)

        Dim names As String() = words(0).Split(" "c)

        ' Look for a match in the first line; discarding the "employee:" entry. 
        For Each name As String In names
            If name <> "employee:" Then
                If name.StartsWith(search) Then
                    Return True
                End If
            End If
        Next
        ' If no match, return false. 
        Return False
    End Function
    '</snippet14> 

    '<snippet15> 
    Private Function SearchEmployees(ByVal search As String, ByVal value As Object) As Boolean
        ' Cast the value to an Employee. 
        Dim emp As Employee = TryCast(value, Employee)
        If emp IsNot Nothing Then
            ' Look for a match in the first and last names. 
            If emp.LastName.ToLower().StartsWith(search) Then
                Return True

            ElseIf emp.FirstName.ToLower().StartsWith(search) Then
                Return True
            End If
        End If
        ' If no match, return false. 
        Return False
    End Function
    '</snippet15> 
End Class

    '<snippet16> 
    Public Class Employee
        Private _LastName As String
        Public Property LastName() As String
            Get
                Return _LastName
            End Get
            Set(ByVal value As String)
                _LastName = value
            End Set
        End Property
        Private _FirstName As String
        Public Property FirstName() As String
            Get
                Return _FirstName
            End Get
            Set(ByVal value As String)
                _FirstName = value
            End Set
        End Property
        Private _EmailName As String
        Public Property EmailName() As String
            Get
                Return _EmailName
            End Get
            Set(ByVal value As String)
                _EmailName = value
            End Set
        End Property
        Private _ID As Integer
        Public Property ID() As Integer
            Get
                Return _ID
            End Get
            Set(ByVal value As Integer)
                _ID = value
            End Set
        End Property
        Public Sub New(ByVal empLastName As String, ByVal empFirstName As String, ByVal empEmail As String, ByVal empID As Integer)
            LastName = empLastName
            FirstName = empFirstName
            EmailName = empEmail
            ID = empID
        End Sub
        Public Overloads Overrides Function ToString() As String
            Return ((("Employee: " & FirstName & " ") + LastName + System.Environment.NewLine & "Email: ") + EmailName + System.Environment.NewLine & "ID: ") + ID.ToString()
        End Function
    End Class
    '</snippet16> 
