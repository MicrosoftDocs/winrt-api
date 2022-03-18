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

## -parameters

### -param inUse

**True** to specify that the package is in use; **false** otherwise.

## -returns

**True** indicates that the operation to set whether the package is in use or not was successful; **false** otherwise.

## -remarks

This API specifies whether the app is using an optional package. With this information the system can determine whether servicing the optional package will require shutting down the app. This provides a better user experience because the app can manage when it is shut down for optional package updates or removals.

By default, all optional packages are in use. Servicing an optional package causes the app to shut down. To avoid shutting down the app when an optional package that is not being used is updated or removed, call this API with **inUse** set to **false**.

## -see-also

## -examples

