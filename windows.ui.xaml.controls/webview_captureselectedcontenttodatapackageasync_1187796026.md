---
-api-id: M:Windows.UI.Xaml.Controls.WebView.CaptureSelectedContentToDataPackageAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.DataTransfer.DataPackage> CaptureSelectedContentToDataPackageAsync()
-->

# Windows.UI.Xaml.Controls.WebView.CaptureSelectedContentToDataPackageAsync

## -description
Asynchronously gets a [DataPackage](../windows.applicationmodel.datatransfer/datapackage.md) that contains the selected content within the [WebView](webview.md).

## -returns
When this method completes, it returns the selected content as a [DataPackage](../windows.applicationmodel.datatransfer/datapackage.md).

## -remarks
You can use this method during a share operation to send the selected [WebView](webview.md) content to a target app. This method is asynchronous, so you must use a deferral to prevent your [DataRequested](../windows.applicationmodel.datatransfer/datatransfermanager_datarequested.md) event handler from returning before the asynchronous call is complete. Call [DataRequestedEventArgs.Request.GetDeferral](../windows.applicationmodel.datatransfer/datarequest_getdeferral_254836512.md) to create the deferral and [DataRequestDeferral.Complete](../windows.applicationmodel.datatransfer/datarequestdeferral_complete_1807836922.md) to end it.

## -examples

## -see-also
[DataPackage](../windows.applicationmodel.datatransfer/datapackage.md), [WebView control (XAML) sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlWebView)
