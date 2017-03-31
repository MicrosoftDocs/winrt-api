---
-api-id: E:Windows.ApplicationModel.DataTransfer.DataTransferManager.DataRequested
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler DataRequested<Windows.ApplicationModel.DataTransfer.DataTransferManager,  Windows.ApplicationModel.DataTransfer.DataRequestedEventArgs>
-->

# Windows.ApplicationModel.DataTransfer.DataTransferManager.DataRequested

## -description
Occurs when a share operation starts.

## -remarks
This event is fired when a sharing operation starts— typically when the user taps the Share charm, although it is also fired if your app starts a share operation programmatically. To handle this event, you need to add an event listener to the [DataTransferManager](datatransfermanager.md) object for the active window. You can get this object through the [GetForCurrentView](datatransfermanager_getforcurrentview.md) method.

When handling a **datarequested** event, the most important property you need to be aware of is its [request](datarequestedeventargs_request.md) property. This property contains a [DataRequest](datarequest.md) object. Your app uses this object to provide the data that the user wants to share with a selected target app.



## -examples
This example uses an inline function to handle a **datarequested** event.



[!code-csharp[HowToShareTextBasic](../windows.applicationmodel.datatransfer/code/ShareMainBeta/cs/ShareText.xaml.cs#SnippetHowToShareTextBasic)]

[!code-js[HowToShareTextBasic](../windows.applicationmodel.datatransfer/code/ShareMainBeta/javascript/js/ShareText.js#SnippetHowToShareTextBasic)]

## -see-also
