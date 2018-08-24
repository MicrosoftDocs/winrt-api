---
-api-id: M:Windows.ApplicationModel.Appointments.AppointmentsProvider.AddAppointmentOperation.DismissUI
-api-type: winrt method
---

<!-- Method syntax
public void DismissUI()
-->

# Windows.ApplicationModel.Appointments.AppointmentsProvider.AddAppointmentOperation.DismissUI

## -description
Dismisses the UI for the operation that adds a new appointment.

## -remarks
A call to [DismissUI](addappointmentoperation_dismissui_451152495.md) is similar to when the user dismisses the appointment provider’s UI by tapping away from it. When the appointment provider’s UI is dismissed, the appointment provider app can continue to save the appointment in the background until the appointment provider app calls [ReportCompleted](addappointmentoperation_reportcompleted_458863373.md) or [ReportError](addappointmentoperation_reporterror_1034694985.md) or up to 15 seconds elapses, which causes the appointments provider app to stop running.

## -examples

## -see-also

## -capabilities
appointmentsSystem
