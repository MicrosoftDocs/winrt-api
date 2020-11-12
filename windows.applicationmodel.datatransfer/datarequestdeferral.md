---
-api-id: T:Windows.ApplicationModel.DataTransfer.DataRequestDeferral
-api-type: winrt class
---

<!-- Class syntax.
public class DataRequestDeferral : Windows.ApplicationModel.DataTransfer.IDataRequestDeferral
-->

# Windows.ApplicationModel.DataTransfer.DataRequestDeferral

## -description
Enables you to exchange content with a target app asynchronously.

## -remarks
You get an instance of the DataRequestDeferral class when you call the [getDeferral](datarequest_getdeferral_254836512.md) method of a [DataPackage.](datapackage.md)

## -examples
This example shows how to get a DataRequestDeferral object as part of sharing an image with a target app.



[!code-csharp[HowToShareImage](../windows.applicationmodel.datatransfer/code/ShareMainBeta/cs/ShareImage.xaml.cs#SnippetHowToShareImage)]

## -see-also
