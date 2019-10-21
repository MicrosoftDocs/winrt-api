---
-api-id: T:Windows.ApplicationModel.DataTransfer.DataProviderHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void DataProviderHandler(Windows.ApplicationModel.DataTransfer.DataProviderRequest request)
-->
# Windows.ApplicationModel.DataTransfer.DataProviderHandler

## -description
Provides data when the target app requests it, instead of including the data in the [DataPackage](datapackage_datapackage_1221375020.md) ahead of time. [ DataProviderHandler is used when the source app wants to avoid unnecessary work that is resource intensive, such as performing format conversions.

## -parameters
### -param request
Contains the data that the user wants to share.


## -remarks

## -examples

## -see-also
