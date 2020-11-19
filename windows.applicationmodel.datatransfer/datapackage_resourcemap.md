---
-api-id: P:Windows.ApplicationModel.DataTransfer.DataPackage.ResourceMap
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IMap<string, Windows.Storage.Streams.RandomAccessStreamReference> ResourceMap { get; }
-->

# Windows.ApplicationModel.DataTransfer.DataPackage.ResourceMap

## -description
Maps a URI to a file. Used to ensure that referenced content (such as an image) in HTML content is added to the [DataPackage](datapackage.md).

## -property-value
Specifies a name/value pair that specifies the an HTML path with a corresponding [StreamReference](../windows.storage.streams/randomaccessstreamreference.md) object.

## -remarks
HTML content often contains references to other files. The most common example is an img tag that refers to a specific file. To ensure that the image is sent with the rest of the HTML content, you need to use `ResourceMap`, which maps the URI string to the actual data. You can learn more about this in [How to share HTML](/previous-versions/windows/apps/hh758310(v=win.10)).

## -examples


[!code-csharp[HowToShareHtml](../windows.applicationmodel.datatransfer/code/ShareMainBeta/cs/ShareHTML.xaml.cs#SnippetHowToShareHtml_CS)]

## -see-also
