---
-api-id: P:Windows.ApplicationModel.AppInfo.Current
-api-type: winrt property
---

<!-- Property syntax.
public AppInfo Current { get; }
-->

# Windows.ApplicationModel.AppInfo.Current

## -description
Retrieves the AppInfo object corresponding to the currently running process.

## -property-value
The AppInfo that corresponds to the process.

## -remarks
When used by an unpackaged application, accessing this property throws an **InvalidOperationException** with HRESULT `80073D54`, indicating "The process has no package identity."


## -see-also


## -examples
