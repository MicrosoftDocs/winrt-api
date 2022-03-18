---
-api-id: M:Windows.ApplicationModel.DataTransfer.DataRequestDeferral.Complete
-api-type: winrt method
---

<!-- Method syntax
public void Complete()
-->

# Windows.ApplicationModel.DataTransfer.DataRequestDeferral.Complete

## -description
Indicates that the content for an asynchronous share is ready for a target app, or that an error in the sharing operation occurred.

## -remarks
Your app must call the **complete** method when its finished adding data to a [DataPackage](datapackage.md).

## -examples
This example shows how to call the **complete** method after getting a [DataRequestDeferral](datarequestdeferral.md) object.



[!code-csharp[HowToShareImage](../windows.applicationmodel.datatransfer/code/ShareMainBeta/cs/ShareImage.xaml.cs#SnippetHowToShareImage)]

## -see-also
