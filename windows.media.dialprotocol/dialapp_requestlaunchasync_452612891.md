---
-api-id: M:Windows.Media.DialProtocol.DialApp.RequestLaunchAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.DialProtocol.DialAppLaunchResult> RequestLaunchAsync(System.String appArgument)
-->

# Windows.Media.DialProtocol.DialApp.RequestLaunchAsync

## -description
Initiates the launching of the app on the remote device. When this method is called, the [DialDevice](dialdevice.md) is paired if necessary, the user is prompted to allow access to the device, connection is established, app existence is validated on the device, and finally the application is launched with the provided argument.

## -parameters
### -param appArgument
Optional.

## -returns
Indicates the result of attempting to launch the app.

## -remarks
This method must be called from the UI thread or an exception will be thrown. To dispatch the call to the UI thread from another thread, you can use [CoreDispatcher.RunAsync](../windows.ui.core/coredispatcher_runasync_447339746.md).

## -examples

## -see-also
[DialAppLaunchResult](dialapplaunchresult.md)