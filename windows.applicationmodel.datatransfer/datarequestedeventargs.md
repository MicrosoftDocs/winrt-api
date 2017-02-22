---
-api-id: T:Windows.ApplicationModel.DataTransfer.DataRequestedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class DataRequestedEventArgs : Windows.ApplicationModel.DataTransfer.IDataRequestedEventArgs
-->

# Windows.ApplicationModel.DataTransfer.DataRequestedEventArgs

## -description
Contains information about the [DataRequested](datatransfermanager_datarequested.md) event. The system fires this event when the user invokes the Share UI.

## -remarks
To share content from one app to another, a user invokes the Share UI. The most common way to do this is through the charms, although you can use the [DataTransferManager](datatransfermanager.md) class to launch the UI programmatically. When the Share UI launches, the system fires a [datarequested](datatransfermanager_datarequested.md) event. The object included with this event is an instance of the **DataRequestedEventArgs** class.

This event has one property, [request](datarequestedeventargs_request.md). This property contains an instance of the [DataRequest](datarequest.md) class, which your app uses to supply the content the user wants to share with the target app.

## -examples


[!code-csharp[HowToShareTextBasic](../windows.applicationmodel.datatransfer/code/ShareMainBeta/cs/ShareText.xaml.cs#SnippetHowToShareTextBasic)]

[!code-js[HowToShareTextBasic](../windows.applicationmodel.datatransfer/code/ShareMainBeta/javascript/js/ShareText.js#SnippetHowToShareTextBasic)]

## -see-also
