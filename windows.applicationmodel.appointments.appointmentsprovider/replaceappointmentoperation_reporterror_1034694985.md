---
-api-id: M:Windows.ApplicationModel.Appointments.AppointmentsProvider.ReplaceAppointmentOperation.ReportError(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void ReportError(System.String value)
-->

# Windows.ApplicationModel.Appointments.AppointmentsProvider.ReplaceAppointmentOperation.ReportError

## -description
Informs the activating app that the operation couldn't be completed because of a provider error.

## -parameters
### -param value
A string that contains info about the error.
<!--Where does this come out again? Detectable in the IAsyncResult? Should also note in Remarks whether this returns empty string to the ID value of the original async caller.-->

## -remarks
This method logs messages about event tracing for Windows (ETW) events. To view these messages, see: ```

Event Viewer\Applications and Services Logs\Microsoft\Windows\Apps\Microsoft-Windows-TWinUI\Operational
```



## -examples

## -see-also

## -capabilities
appointmentsSystem
