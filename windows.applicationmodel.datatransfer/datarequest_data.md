---
-api-id: P:Windows.ApplicationModel.DataTransfer.DataRequest.Data
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.DataTransfer.DataPackage Data { get;  set; }
-->

# Windows.ApplicationModel.DataTransfer.DataRequest.Data

## -description
Sets or gets a [DataPackage](datapackage.md) object that contains the content a user wants to share.

## -property-value
Contains the content a user wants to share.

## -remarks
The Data property enables your app to supply data to a target app. Your app must supply this data by using a [DataPackage](datapackage.md) object.

Use this property when your app has the content immediately available that the user wants to share. If you need to call a function to generate the [DataPackage](datapackage.md), use the [GetDeferral](datarequest_getdeferral_254836512.md) method.

When your app cannot supply a [DataPackage](datapackage.md) object, use the [FailWithDisplayText](datarequest_failwithdisplaytext_760676443.md) method to cancel the share and provide a message that the target app can display to the user.

## -examples
The following code shows how to get a [DataPackage](datapackage.md) object from the Data property as part of setting the data on a [DataPackage](datapackage.md) to share with another app.



[!code-csharp[HowToShareTextBasic](../windows.applicationmodel.datatransfer/code/ShareMainBeta/cs/ShareText.xaml.cs#SnippetHowToShareTextBasic)]

## -see-also
