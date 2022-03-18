---
-api-id: M:Windows.ApplicationModel.DataTransfer.DataRequest.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.DataTransfer.DataRequestDeferral GetDeferral()
-->

# Windows.ApplicationModel.DataTransfer.DataRequest.GetDeferral

## -description
Supports asynchronous sharing operations by creating and returning a [DataRequestDeferral](datarequestdeferral.md) object.

## -returns
An object that allows you to share or send content asynchronously.

## -remarks
The **GetDeferral** method allows your app to call a function during a share operation, so that your app can asynchronously generate the [DataPackage](datapackage.md) object for the target app.

Use this method when you want to use an asynchronous function call to generate the [DataPackage](datapackage.md) during a share operation. This function must return a [DataPackage](datapackage.md) object within 200ms to prevent the operation from timing out. If your app shares content that takes more time to package, such as a collection of files or photos, don't use this method. Instead, use the [SetDataProvider](datapackage_setdataprovider_375548563.md) method to assign a delegate to a [DataPackage](datapackage.md) and return that [DataPackage](datapackage.md) to the target app.

## -examples
The following sample shows how to get a [DataRequestDeferral](datarequestdeferral.md) object by using the **GetDeferral** method.



[!code-csharp[HowToShareImage](../windows.applicationmodel.datatransfer/code/ShareMainBeta/cs/ShareImage.xaml.cs#SnippetHowToShareImage)]

## -see-also
