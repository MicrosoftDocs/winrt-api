---
-api-id: M:Windows.Storage.ApplicationData.SetVersionAsync(System.UInt32,Windows.Storage.ApplicationDataSetVersionHandler)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SetVersionAsync(System.UInt32 desiredVersion, Windows.Storage.ApplicationDataSetVersionHandler handler)
-->

# Windows.Storage.ApplicationData.SetVersionAsync

## -description
Sets the version number of the application data in the app data store.

## -parameters
### -param desiredVersion
The new version number.

### -param handler
The set version event handler.

## -returns
An object that is used to manage the asynchronous set version operation.

## -remarks
Versioning enables you to change the application data format used in a future release of your app without causing compatibility problems with previous releases of your app. The app checks the version of the data in the data store, and if it is less than the version the app expects, the app should update the application data to the new format and update the version.

It is strongly recommended that you use sequential and incrementing version numbers, starting at 1.

## -examples

## -see-also
