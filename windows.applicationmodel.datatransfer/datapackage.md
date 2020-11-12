---
-api-id: T:Windows.ApplicationModel.DataTransfer.DataPackage
-api-type: winrt class
---

<!-- Class syntax.
public class DataPackage : Windows.ApplicationModel.DataTransfer.IDataPackage, Windows.ApplicationModel.DataTransfer.IDataPackage2, Windows.ApplicationModel.DataTransfer.IDataPackage3
-->

# Windows.ApplicationModel.DataTransfer.DataPackage

## -description
Contains the data that a user wants to exchange with another app.

## -remarks
During a share operation, the source app puts the data being shared in a **DataPackage** object and sends that object to the target app for processing. The **DataPackage** class includes a number of methods to support the following default formats: [text](standarddataformats_text.md), [Rtf](standarddataformats_rtf.md), [Html](standarddataformats_html.md), [Bitmap](standarddataformats_bitmap.md), and [StorageItems](standarddataformats_storageitems.md). It also has methods to support custom data formats. To use these formats, both the source app and target app must already be aware that the custom format exists.

Source apps have the option of using [SetDataProvider](datapackage_setdataprovider_375548563.md) to assign a delegate to a **DataPackage**, instead of providing the data immediately. This process is useful when the source app supports a given format but does not want to generate the data unless the target app requests the data. For example, a source app might support a variety of image formats for sharing photos. Instead of creating multiple copies of each image using these formats, the source app can use a delegate that is called when the target app requests a specific format type.

Target apps can use the [DataPackageView](datapackageview.md) object to acquire the data being shared. In addition, these apps can use the [AvailableFormats](datapackageview_availableformats.md) property to identify which formats the [DataPackageView](datapackageview.md) supports, or use the [Contains](datapackageview_contains_1741733936.md) method to query for a specific format.

### Windows Phone 8

This API is supported in native apps only.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | ShareCompleted |
| 2004 | 19041 | ShareCanceled |

## -examples


[!code-csharp[HowToShareTextBasic](../windows.applicationmodel.datatransfer/code/ShareMainBeta/cs/ShareText.xaml.cs#SnippetHowToShareTextBasic)]

## -see-also
[Clipboard sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Clipboard), [Sharing content source app sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620596)
soft.com/fwlink/p/?LinkId=620596)
