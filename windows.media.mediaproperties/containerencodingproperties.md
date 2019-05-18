---
-api-id: T:Windows.Media.MediaProperties.ContainerEncodingProperties
-api-type: winrt class
---

<!-- Class syntax.
public class ContainerEncodingProperties : Windows.Media.MediaProperties.IContainerEncodingProperties, Windows.Media.MediaProperties.IMediaEncodingProperties
-->

# Windows.Media.MediaProperties.ContainerEncodingProperties

## -description
Describes a media container format.

## -remarks
Media files usually contain at least some of the following elements: 
+ File headers that describe the number of streams, the format of each stream, and so on.
+ An index that enables random access to the content.
+ Metadata that describes the content (for example, the artist or title).

The term *media container* describes the entire package of media data, file headers, indexes, and metadata. The reason for using the term *container* rather than *file* is that some container formats are designed for live broadcast. A container might be generated in real time, without ever being stored as a file.

An early example of a media container is the AVI file format. Other examples include MP4 and Advanced Systems Format (ASF). Containers can be identified by file name extension (for example, ".mp4") or by MIME type.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | Copy |

## -examples

## -see-also
