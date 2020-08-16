---
-api-id: E:Windows.Security.Authorization.AppCapabilityAccess.AppCapability.AccessChanged
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler AccessChanged<AppCapability, AppCapabilityAccessChangedEventArgs>
-->

# Windows.Security.Authorization.AppCapabilityAccess.AppCapability.AccessChanged

## -description
Raised when there is a change to access status. 

## -remarks
This event is guaranteed to be invoked when access status changes for the indicated capability on the system, but only if the app is not suspended. This event has no payload, as the application cannot rely on this potentially delayed information and must return to their held AppCapability object to determine the current access status.

## -see-also

## -examples

