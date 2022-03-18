---
-api-id: M:Windows.ApplicationModel.DataTransfer.DataTransferManager.GetForCurrentView
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.ApplicationModel.DataTransfer.DataTransferManager GetForCurrentView()
-->

# Windows.ApplicationModel.DataTransfer.DataTransferManager.GetForCurrentView

## -description
Returns the [DataTransferManager](datatransfermanager.md) object associated with the current window.

## -returns
The [DataTransferManager](datatransfermanager.md) object associated with the current window.

## -remarks
Each window has a [DataTransferManager](datatransfermanager.md) object associated with it. When sharing content, you use the **GetForCurrentView** method to get the [DataTransferManager](datatransfermanager.md) object that is associated with the active window. After you have the appropriate [DataTransferManager](datatransfermanager.md) object, you can add an event listener to it to handle the [DataRequested](datatransfermanager_datarequested.md) event, which the system fires when a share operation is initiated. Your app uses the [DataRequest](datarequest.md) object returned with this event to set the data that the user wants to share with a target app.

## -examples
This example calls the **GetForCurrentView** method to get the [DataTransferManager](datatransfermanager.md) object associated with the active window for the app.



[!code-csharp[HowToShareTextBasic](../windows.applicationmodel.datatransfer/code/ShareMainBeta/cs/ShareText.xaml.cs#SnippetHowToShareTextBasic)]

## -see-also
