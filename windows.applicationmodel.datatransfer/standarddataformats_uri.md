---
-api-id: P:Windows.ApplicationModel.DataTransfer.StandardDataFormats.Uri
-api-type: winrt property
---

<!-- Property syntax
public string Uri { get; }
-->

# Windows.ApplicationModel.DataTransfer.StandardDataFormats.Uri

## -description
> [!NOTE]
> Uri may be altered or unavailable for releases after Windows 8.1. Instead, use [ApplicationLink](standarddataformats_applicationlink.md) or [WebLink](standarddataformats_weblink.md).

A read-only property that returns the format ID string value corresponding to the Uniform Resource Identifier (URI) format.

## -property-value
The format ID string value corresponding to the Uniform Resource Identifier (URI) format.

## -remarks

## -examples
This example demonstrates the use of the **Uri** property. To use the code in this example, add an event listener to your app to handle the [activated](../windows.applicationmodel.core/coreapplicationview_activated.md) event. Then put this code in the function that this event listener calls.



[!code-csharp[HowToShareLink_CS](../windows.applicationmodel.datatransfer/code/ShareMainBeta/cs/ShareLinks.xaml.cs#SnippetHowToShareLink_CS)]

## -see-also
