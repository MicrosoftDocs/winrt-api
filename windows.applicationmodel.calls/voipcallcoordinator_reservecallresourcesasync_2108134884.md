---
-api-id: M:Windows.ApplicationModel.Calls.VoipCallCoordinator.ReserveCallResourcesAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Calls.VoipPhoneCallResourceReservationStatus> ReserveCallResourcesAsync(System.String taskEntryPoint)
-->

# Windows.ApplicationModel.Calls.VoipCallCoordinator.ReserveCallResourcesAsync

## -description
Reserves the CPU and memory resources necessary for a VoIP call.

## -parameters
### -param taskEntryPoint
The name of an application-defined class that performs the work of a background task. For more information, see [TaskEntryPoint](../windows.applicationmodel.background/backgroundtaskbuilder_taskentrypoint.md).

## -returns
The result of the reservation action.

## -remarks
Use this method when your VoIP application receives an incoming call notification, or before creating an outgoing VoIP call.

Each call requires separate resources. To handle multiple VoIP calls simultaneously, you must invoke this method once for each call.

Resources are freed automatically when a call is completed.

## -examples

## -see-also


## -capabilities
phoneCallHistory, phoneCallHistorySystem
voipCall
