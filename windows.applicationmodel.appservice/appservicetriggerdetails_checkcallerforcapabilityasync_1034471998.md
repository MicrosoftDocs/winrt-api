---
-api-id: M:Windows.ApplicationModel.AppService.AppServiceTriggerDetails.CheckCallerForCapabilityAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> AppServiceTriggerDetails.CheckCallerForCapabilityAsync(String capabilityName)
-->

# Windows.ApplicationModel.AppService.AppServiceTriggerDetails.CheckCallerForCapabilityAsync

## -description
Determines whether the caller of the app service has the specified capability.

## -parameters
### -param capabilityName
The name of the capability.

## -returns
**True** if it was possible to get the capabilities of the caller and the caller has the specified capability; **false** otherwise.

## -remarks
This API can only be called from within an app that is marked as an app service in its manifest.
One use of this function is to determine whether a caller has the specified capability and, based on that, decide whether to share the requested data, a subset of the data, or no data.

## -see-also

## -examples
