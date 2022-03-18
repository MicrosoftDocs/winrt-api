---
-api-id: P:Windows.UI.Xaml.Controls.WebView.DataTransferPackage
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.DataTransfer.DataPackage DataTransferPackage { get; }
-->

# Windows.UI.Xaml.Controls.WebView.DataTransferPackage

## -description
> [!NOTE]
> DataTransferPackage may be altered or unavailable for releases after Windows 8.1. Instead, use [CaptureSelectedContentToDataPackageAsync](webview_captureselectedcontenttodatapackageasync_1187796026.md).

Gets a clipboard [DataPackage](../windows.applicationmodel.datatransfer/datapackage.md) as passed to the [WebView](webview.md).

## -property-value
A clipboard data package.

## -remarks
This property is typically used to support sharing. During a share operation, the source app puts the data being shared in a [DataPackage](../windows.applicationmodel.datatransfer/datapackage.md) object and sends that object to the target app for processing.

## -examples
The following code example demonstrates how to use this property to implement sharing support.



[!code-cpp[DataTransferPackage](../windows.ui.xaml.input/code/Controls_WebView/cpp/Scenario7.xaml.cpp#SnippetDataTransferPackage)]

[!code-csharp[DataTransferPackage](../windows.ui.xaml.input/code/Controls_WebView/csharp/Scenario7.xaml.cs#SnippetDataTransferPackage)]

[!code-vb[DataTransferPackage](../windows.ui.xaml.input/code/Controls_WebView/vbnet/Scenario7.xaml.vb#SnippetDataTransferPackage)]

## -see-also
[XAML WebView control sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/XamlWebView)
