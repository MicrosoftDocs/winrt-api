---
-api-id: T:Windows.Media.Capture.CapturedFrame
-api-type: winrt class
---

<!-- Class syntax.
public class CapturedFrame : Windows.Foundation.IClosable, Windows.Media.Capture.ICapturedFrame, Windows.Media.Capture.ICapturedFrameWithSoftwareBitmap, Windows.Storage.Streams.IContentTypeProvider, Windows.Storage.Streams.IInputStream, Windows.Storage.Streams.IOutputStream, Windows.Storage.Streams.IRandomAccessStream, Windows.Storage.Streams.IRandomAccessStreamWithContentType
-->

# Windows.Media.Capture.CapturedFrame

## -description
Represents a captured video frame.

## -remarks
There are several different techniques for capturing photos using the [MediaCapture](mediacapture.md) class, including [AdvancedPhotoCapture](advancedphotocapture.md), [LowLagPhotoCapture](lowlagphotocapture.md), [LowLagPhotoSequenceCapture](lowlagphotosequencecapture.md), and [VariablePhotoSequenceCapture](../windows.media.capture.core/variablephotosequencecapture.md). Though the sets of APIs used for each of these techniques vary, ultimately they all return the captured photo to you in the form of a **CapturedFrame** object.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | BitmapProperties |
| 1803 | 17134 | ControlValues |

## -examples

## -see-also
[AdvancedPhotoCapture](advancedphotocapture.md), [LowLagPhotoCapture](lowlagphotocapture.md), [LowLagPhotoSequenceCapture](lowlagphotosequencecapture.md), [VariablePhotoSequenceCapture](../windows.media.capture.core/variablephotosequencecapture.md),
[IRandomAccessStreamWithContentType](../windows.storage.streams/irandomaccessstreamwithcontenttype.md), [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md), [IClosable](../windows.foundation/iclosable.md), [IInputStream](../windows.storage.streams/iinputstream.md), [IOutputStream](../windows.storage.streams/ioutputstream.md), [IContentTypeProvider](../windows.storage.streams/icontenttypeprovider.md)
