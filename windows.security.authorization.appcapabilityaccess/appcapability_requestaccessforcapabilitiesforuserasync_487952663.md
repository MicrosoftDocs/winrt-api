---
-api-id: M:Windows.Security.Authorization.AppCapabilityAccess.AppCapability.RequestAccessForCapabilitiesForUserAsync(Windows.System.User,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<AppCapabilityAccessStatus>> AppCapability.RequestAccessForCapabilitiesForUserAsync(User user, IIterable<String> capabilityNames)
-->

# Windows.Security.Authorization.AppCapabilityAccess.AppCapability.RequestAccessForCapabilitiesForUserAsync

## -description
Requests access to multiple capabilities simultaneously.

## -parameters
### -param user
The user property for which the object was created.

### -param capabilityNames
The capability name strings.

## -returns
Returns a read-only Dictionary with string capabilities as keys to AppCapabilityAccessStatus enums.

## -remarks
RequestAccessForCapabilitiesForUserAsync does not create any new objects and can cause a user prompt to appear.

> Note: Must be called from the UI thread.

## -see-also
[RequestAccessForCapabilitiesAsync](appcapability_requestaccessforcapabilitiesasync_382595932.md)

## -examples

