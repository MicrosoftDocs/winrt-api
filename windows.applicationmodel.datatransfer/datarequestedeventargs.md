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
When you use the [DataTransferManager](datatransfermanager.md) class to launch the Share UI programmatically, the system fires a [DataRequested](datatransfermanager_datarequested.md) event. The object included with this event is an instance of the **DataRequestedEventArgs** class.

This event has one property, [Request](datarequestedeventargs_request.md). This property contains an instance of the [DataRequest](datarequest.md) class, which your app uses to supply the content the user wants to share with the target app.

## -examples


[!code-csharp[HowToShareTextBasic](../windows.applicationmodel.datatransfer/code/ShareMainBeta/cs/ShareText.xaml.cs#SnippetHowToShareTextBasic)]

## -see-also
