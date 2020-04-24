---
-api-id: N:Windows.ApplicationModel.Appointments.AppointmentsProvider
-api-type: winrt namespace
---

# Windows.ApplicationModel.Appointments.AppointmentsProvider

## -description

Defines operations classes for add appointment and remove appointment requests through activations that an appointments provider interacts with.

## -remarks

A show timeframe / show appointments UI activation doesn't have an operations class. This is because the provider doesn't need to communicate anything back to the call that starts the activation sequence. To respond to a show timeframe activation, the provider app should cast the event data to [IAppointmentsProviderShowTimeFrameActivatedEventArgs](../windows.applicationmodel.activation/iappointmentsprovidershowtimeframeactivatedeventargs.md) and use the properties of that event data to obtain the activating app's hints for how the appointments provider UI should be shown.

## -examples

## -see-also

[Appointment calendar sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Appointments)

## -capabilities

appointmentsSystem
