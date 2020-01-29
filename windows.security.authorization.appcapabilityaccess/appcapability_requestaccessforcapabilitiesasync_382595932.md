---
-api-id: M:Windows.Security.Authorization.AppCapabilityAccess.AppCapability.RequestAccessForCapabilitiesAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<AppCapabilityAccessStatus>> AppCapability.RequestAccessForCapabilitiesAsync(IIterable<String> capabilityNames)
-->

# Windows.Security.Authorization.AppCapabilityAccess.AppCapability.RequestAccessForCapabilitiesAsync

## -description
Requests access to multiple capabilities simultaneously.

## -parameters
### -param capabilityNames
The capability name strings. 

## -returns
Returns a read-only Dictionary with string capabilities as keys to AppCapabilityAccessStatus enums.

## -remarks
RequestAccessForCapabilitiesAsync does not create any new objects and can cause a user prompt to appear.
> Note: Must be called from the UI thread.

## -see-also

## -examples

