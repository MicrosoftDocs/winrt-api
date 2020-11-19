---
-api-id: M:Windows.ApplicationModel.DataTransfer.DataPackage.SetBitmap(Windows.Storage.Streams.RandomAccessStreamReference)
-api-type: winrt method
---

<!-- Method syntax
public void SetBitmap(Windows.Storage.Streams.RandomAccessStreamReference value)
-->

# Windows.ApplicationModel.DataTransfer.DataPackage.SetBitmap

## -description
Sets the bitmap image contained in the [DataPackage](datapackage.md).

## -parameters
### -param value
A stream that contains the bitmap image.

## -remarks
This method sets the value for [StandardFormats.Bitmap](standarddataformats_bitmap.md).

Bitmap is one of the data types that the [DataPackage](datapackage.md) object supports directly. See the [StandardDataFormats](standarddataformats.md) class for information on other supported data types.

## -examples
The following example uses the **setBitmap** method to share an image with a target app.



[!code-csharp[HowToShareImage](../windows.applicationmodel.datatransfer/code/ShareMainBeta/cs/ShareImage.xaml.cs#SnippetHowToShareImage)]

## -see-also
