---
-api-id: M:Windows.ApplicationModel.DataTransfer.DataPackage.SetUri(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public void SetUri(Windows.Foundation.Uri value)
-->

# Windows.ApplicationModel.DataTransfer.DataPackage.SetUri

## -description
> [!NOTE]
> SetUri may be altered or unavailable for releases after Windows 8.1. Instead, use [ApplicationLink](datapackage_setapplicationlink_1143215413.md) or [WebLink](datapackage_setweblink_224257999.md).

Sets the Uniform Resource Identifier (URI) that is contained in the [DataPackage](datapackage.md).

## -parameters
### -param value
The Uniform Resource Identifier (URI) that is contained in the [DataPackage](datapackage.md).

## -remarks
This method sets the value for [StandardFormats.Uri](standarddataformats_uri.md).

Uniform Resource Identifier (URI) is one of the data types that the [DataPackage](datapackage.md) object supports directly. See the [StandardDataFormats](standarddataformats.md) class for information on other supported data types.

## -examples
The following code sample demonstrates how an app can set the URI on a [DataPackage](datapackage.md) object.



[!code-csharp[HowToShareLink_CS](../windows.applicationmodel.datatransfer/code/ShareMainBeta/cs/ShareLinks.xaml.cs#SnippetHowToShareLink_CS)]

## -see-also
