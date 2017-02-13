---
-api-id: P:Windows.ApplicationModel.DataTransfer.DataPackagePropertySetView.Thumbnail
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.Streams.RandomAccessStreamReference Thumbnail { get; }
-->

# Windows.ApplicationModel.DataTransfer.DataPackagePropertySetView.Thumbnail

## -description
Gets the thumbnail image for the [DataPackageView](datapackageview.md).

## -property-value
The [IRandomAccessStreamReference](../windows.storage.streams/irandomaccessstreamreference.md) that represents the thumbnail image.

## -remarks
We recommend that any time you get a [DataPackageView](datapackageview.md) that contains an image, you also check for thumbnail image. Doing so gives allows your app to display a visual representation of the images being shared to the user while the share operation completes.

## -examples
This example shows how you can get a thumbnail image from a [DataPackageView](datapackageview.md).



[!code-js[GetThumbnail](../windows.applicationmodel.datatransfer.sharetarget/code/ShareTargetBeta/javascript/js/ReceivedImage.js#SnippetGetThumbnail)]

## -see-also
