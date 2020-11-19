---
-api-id: P:Windows.ApplicationModel.DataTransfer.DataPackagePropertySet.Thumbnail
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.Streams.IRandomAccessStreamReference Thumbnail { get;  set; }
-->

# Windows.ApplicationModel.DataTransfer.DataPackagePropertySet.Thumbnail

## -description
Gets or sets a thumbnail image for the [DataPackage](datapackage.md).

## -property-value
The [IRandomAccessStreamReference](../windows.storage.streams/irandomaccessstreamreference.md) that represents the thumbnail image.

## -remarks
We recommend that any time you create a [DataPackage](datapackage.md) that contains images, you also assign a thumbnail image. Doing so gives target apps the opportunity to display a visual representation of the images being shared to the user while the share operation completes.

The minimum recommended size is 80x80. The maximum size is 240x160. These sizes are in device-independent pixels, so if the system plateau setting is other than 1.0, appropriate multiplier should be used. For example, minimum recommended size for 1.4 plateau would be 80*1.4x80*1.4=112x112 physical pixels. If you're writing a target app, remember that while we recommend a minimum and maximum size, there is no enforcement of these sizes. Your app should have code to handle thumbnails that are an unexpected size—such as to scale them up or down as needed. Take care, however, not to alter the aspect ratio of the image.

You can use any data format (JPG, GIF, and so on) for a thumbnail. You also have the option of loading the thumbnail from the disk, or creating it on the fly.

## -examples
This example shows how you can add a thumbnail image to a [DataPackage](datapackage.md) when sharing an image with a target app.



[!code-csharp[HowToShareImage](../windows.applicationmodel.datatransfer/code/ShareMainBeta/cs/ShareImage.xaml.cs#SnippetHowToShareImage)]

## -see-also
