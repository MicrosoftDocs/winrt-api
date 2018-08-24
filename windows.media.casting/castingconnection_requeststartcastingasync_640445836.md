---
-api-id: M:Windows.Media.Casting.CastingConnection.RequestStartCastingAsync(Windows.Media.Casting.CastingSource)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Casting.CastingConnectionErrorStatus> RequestStartCastingAsync(Windows.Media.Casting.CastingSource value)
-->

# Windows.Media.Casting.CastingConnection.RequestStartCastingAsync

## -description
Starts the process of casting to a casting device. When called, this method pairs the c sting device, if necessary, and verifies access to the casting device with the user. If the user denies the app access to the device, casting fails. Otherwise, a connection is established, and content is sent to the device. During this time, the connection state changes to connecting, then to connected. If a casting source is set, the state changes to rendering once playback begins.

## -parameters
### -param value
The content to be casted.

## -returns
The status of the casting connection request.

## -remarks
This method must be called from the UI thread or an exception will be thrown. To dispatch the call to the UI thread from another thread, you can use [CoreDispatcher.RunAsync](../windows.ui.core/coredispatcher_runasync_447339746.md).

## -examples

## -see-also
