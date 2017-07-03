---
-api-id: T:Windows.Media.Capture.AppCaptureMetadataWriter
-api-type: winrt class
---

<!-- Class syntax.
public class AppCaptureMetadataWriter : IClosable
-->

# Windows.Media.Capture.AppCaptureMetadataWriter

## -description
Enables an app to store metadata that the system will insert into captured video files or broadcast streams of app content.

## -remarks
When you create an instance of **AppCaptureMetadataWriter**, the system initializes a unique instance for your app and is then ready for you to write metadata items. Although only one app can be capturing or broadcasting at a time, the system can accumulate metadata for multiple apps simultaneously. **AppCaptureMetadataWriter** does not initiate or modify the current capture or broadcast state. 

When you write a metadata item, the system associates a timestamp with the item so that it is automatically included with the captured or broadcast time range to which it applies. 

Currently, two different types of metadata items are supported **AppCaptureMetadataWriter**: events and state. A metadata event is associated with a single point in time and usually is associated with a instantaneous action, such as a player in a game scoring a point. A state is a metadata item that applies across a window of time. An example of this is a state that contains the name of the game map that a player is currently in. Once a state value has been set, the system maintains that value for the state until it is set to a different value, until it is stopped with a call [**StopState**](https://docs.microsoft.com/uwp/api/windows.media.capture.appcapturemetadatawriter#Windows_Media_Capture_AppCaptureMetadataWriter_StopState_System_String_), or until all states are ended with a call to [**StopAllStates**](https://docs.microsoft.com/uwp/api/windows.media.capture.appcapturemetadatawriter#Windows_Media_Capture_AppCaptureMetadataWriter_StopAllStates). Both events and states are represented as a key/value pair where the key is the state or event name and the value is either an integer, a double, or a string value. 

Because historical app capture is supported, the system accumulates metadata written with **AppCaptureMetadataWriter** even when not actively capturing or broadcasting. When, for example, a capture of the previous 30 seconds is written to a video file on disk, the metadata associated with the recorded time window is included in the file. The system imposes a limit on the storage space that is allocated per app for storing accumulated metadata. You can get the currently available storage space by checking the [**RemainingStorageBytesAvailable**](https://docs.microsoft.com/uwp/api/windows.media.capture.appcapturemetadatawriter#Windows_Media_Capture_AppCaptureMetadataWriter_RemainingStorageBytesAvailable) property.

When the all of the allotted space has been filled, the system will begin purging metadata using the [**AppCaptureMetadataPriority**](https://review.docs.microsoft.com/uwp/api/windows.media.capture.appcapturemetadatapriority) value, specified when the metadata items were written, and the age of each item in order to delete the oldest, least important data first. When this occurs, the [**MetadataPurged**](https://docs.microsoft.com/uwp/api/windows.media.capture.appcapturemetadatawriter#Windows_Media_Capture_AppCaptureMetadataWriter_MetadataPurged) event is raised. In response to this event, you may choose to reduce the amount of metadata your app is writing, but this is not required.

## -see-also

## -examples

