---
-api-id: T:Windows.Storage.ApplicationDataSetVersionHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void ApplicationDataSetVersionHandler(Windows.Storage.SetVersionRequest setVersionRequest)
-->
# Windows.Storage.ApplicationDataSetVersionHandler

## -description
Represents a method that handles the request to set the version of the application data in the application data store.

## -parameters
### -param setVersionRequest
The set version request.


## -remarks
The delegate must transform the existing application data from the app-defined schema format associated with the current version to the schema format associated with the requested version. If an unrecoverable error occurs during this operation, the delegate should throw an exception. If the delegate throws an exception, the system does not update the version number.

## -examples

## -see-also
[ApplicationData.SetVersionAsync](applicationdata_setversionasync.md)