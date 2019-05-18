---
-api-id: P:Windows.Media.PlayTo.PlayToConnectionErrorEventArgs.Code
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.PlayTo.PlayToConnectionError Code { get; }
-->

# Windows.Media.PlayTo.PlayToConnectionErrorEventArgs.Code

## -description
Gets the error code for a Play To connection error.

## -property-value
The error code for a Play To connection error.

## -remarks
In Windows 8UWP apps, Code is always set to **DeviceError**.

In Windows 8.1UWP apps, Code is set to either **DeviceError** or **ProtectedPlaybackFailed**. This enables the app to determine if the failure is related to the media-protection status of the content. The app can continue playing the next item in the playlist or to stop. Apps can also use this new Code value to remove all protected music from the playlist.

## -examples

## -see-also
[PlayToConnection.Error event](playtoconnection_error.md), [Play To sample](https://go.microsoft.com/fwlink/p/?linkid=245166), [PlayToReceiver sample](https://go.microsoft.com/fwlink/p/?linkid=245167), [Media Server sample](https://go.microsoft.com/fwlink/p/?linkid=245168)
