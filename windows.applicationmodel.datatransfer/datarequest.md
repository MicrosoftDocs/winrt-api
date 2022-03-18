---
-api-id: T:Windows.ApplicationModel.DataTransfer.DataRequest
-api-type: winrt class
---

<!-- Class syntax.
public class DataRequest : Windows.ApplicationModel.DataTransfer.IDataRequest
-->

# Windows.ApplicationModel.DataTransfer.DataRequest

## -description
Lets your app supply the content the user wants to share or specify a message, if an error occurs.

## -remarks
Your app receives a **DataRequest** object when a [datarequested](datatransfermanager_datarequested.md) event occurs. With this object, your app can supply data to a target app by using a [DataPackage](datapackage.md) object, use a deferral object to call a function, or inform the target app that an error occurred.

## -examples
The following code shows how to use the **DataRequest** object as part of setting the data on a [DataPackage](datapackage.md) to share with another app.



[!code-csharp[HowToShareTextBasic](../windows.applicationmodel.datatransfer/code/ShareMainBeta/cs/ShareText.xaml.cs#SnippetHowToShareTextBasic)]

## -see-also
