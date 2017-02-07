Imports Windows.UI.Xaml.Data

'<snippet1>
' Custom class implements the IValueConverter interface.
Public Class DateToStringConverter
    Implements IValueConverter

    ' Define the Convert method to change a DateTime object to
    ' a month string.
    Public Function Convert(ByVal value As Object, _
        ByVal targetType As Type, ByVal parameter As Object, _
        ByVal language As System.String) As Object _
        Implements IValueConverter.Convert

        ' value is the data from the source object.
        Dim thisdate As DateTime = CType(value, DateTime)
        Dim monthnum As Integer = thisdate.Month
        Dim month As String
        Select Case (monthnum)
            Case 1
                month = "January"
            Case 2
                month = "February"
            Case Else
                month = "Month not found"
        End Select
        ' Return the value to pass to the target.
        Return month

    End Function

    ' ConvertBack is not implemented for a OneWay binding.
    Public Function ConvertBack(ByVal value As Object, _
        ByVal targetType As Type, ByVal parameter As Object, _
        ByVal language As System.String) As Object _
        Implements IValueConverter.ConvertBack
        Throw New NotImplementedException

    End Function
End Class
'</snippet1>

