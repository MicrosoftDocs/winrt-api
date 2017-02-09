---
-api-id: M:Windows.ApplicationModel.Package.SetInUseAsync(System.Boolean)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> Package.SetInUseAsync(Boolean inUse)
-->

# Windows.ApplicationModel.Package.SetInUseAsync

## -description
Sets whether the package is in use or not.

## -params

## -param inUse
**True** to indicate that the package is in use; **false** otherwise.

## -returns
**True** indicates that the package was set to in use. **False** indicates that the package is being serviced and could not be set to in use.

## -remarks
This API provides a way to indicate whether the app is using an optional package. With this information the system can determine whether servicing the optional package requires shutting down the app or not. This provides a better user experience because the app can mitigate when it is shut down for optional package updates or removals.

## -see-also

## -examples
