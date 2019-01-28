---
-api-id: M:Windows.ApplicationModel.Calls.VoipCallCoordinator.ReserveCallResourcesAsync
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperation<VoipPhoneCallResourceReservationStatus> VoipCallCoordinator.ReserveCallResourcesAsync()
-->

# Windows.ApplicationModel.Calls.VoipCallCoordinator.ReserveCallResourcesAsync

## -description
Reserves the CPU and memory resources necessary for a VoIP call. You should use this method only in a single-process application model.

## -returns
The result of the reservation action.

## -examples
You should call **ReserveCallResourcesAsync** only once for each call. Calling it a subsequent time for a new call while another call already exists results in an exception with an HRESULT of -2147024713 (0x800700b7), as shown in the code example.

```csharp
...
try
{
    status = await vCC.ReserveCallResourcesAsync();
}
catch (System.Exception ex)
{
    if (ex.HResult == -2147024713)
    {
        Debug.WriteLine("CPU and memory resources have already been reserved for your application. Ignore the return value from your call to ReserveCallResourcesAsync, and proceed to handle a new VoIP call.");
    }
}
...
```

## -remarks
Use this method when your VoIP application receives an incoming call notification, or before creating an outgoing VoIP call.

Each call requires separate resources. To handle multiple VoIP calls simultaneously, you must invoke this method once for each call.

Resources are freed automatically when the last call is completed.

## -see-also

## -capabilities
oneProcessVoIP, phoneCallHistory, phoneCallHistorySystem, voipCall
