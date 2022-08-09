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
When you create an instance of **AppCaptureMetadataWriter**, the system initializes a unique instance for your app and is then ready for you to write metadata items. Although only one app can be capturing or broadcasting at a time, the system can accumulate metadata for multiple apps simultaneously. **AppCaptureMetadataWriter** does not initiate or modify the current capture or broadcast state. You should create and hold onto the instance of **AppCaptureMetadataWriter** as long as you want the system to hold the metadata in memory.
When the instance of **AppCaptureMetadataWriter** is released, all metadata associated with that instance of **AppCaptureMetadataWriter** is released as well.


When you write a metadata item, the system associates a timestamp with the item so that it is automatically included with the captured or broadcast time range to which it applies. 

Currently, two different types of metadata items are supported **AppCaptureMetadataWriter**: events and state. A metadata event is associated with a single point in time and usually is associated with a instantaneous action, such as a player in a game scoring a point. A state is a metadata item that applies across a window of time. An example of this is a state that contains the name of the game map that a player is currently in. Once a state value has been set, the system maintains that value for the state until it is set to a different value, until it is stopped with a call [StopState](/uwp/api/windows.media.capture.appcapturemetadatawriter#Windows_Media_Capture_AppCaptureMetadataWriter_StopState_System_String_), or until all states are ended with a call to [StopAllStates](/uwp/api/windows.media.capture.appcapturemetadatawriter.StopAllStates). Both events and states are represented as a key/value pair where the key is the state or event name and the value is either an integer, a double, or a string value. 

When historical app capture is enabled, the system accumulates metadata written with **AppCaptureMetadataWriter** even when not actively capturing or broadcasting. When, for example, a capture of the previous 30 seconds is written to a video file on disk, the metadata associated with the recorded time window is included in the file. The system imposes a limit on the storage space that is allocated per app for storing accumulated metadata. You can get the currently available storage space by checking the [**RemainingStorageBytesAvailable**](/uwp/api/windows.media.capture.appcapturemetadatawriter.RemainingStorageBytesAvailable) property.

When the all of the allotted space has been filled, the system will begin purging metadata using the [AppCaptureMetadataPriority](/uwp/api/windows.media.capture.appcapturemetadatapriority) value, specified when the metadata items were written, and the age of each item in order to delete the oldest, least important data first. When this occurs, the [MetadataPurged](/uwp/api/windows.media.capture.appcapturemetadatawriter.MetadataPurged) event is raised. In response to this event, you may choose to reduce the amount of metadata your app is writing, but this is not required.



Metadata items are classified as **Important** or **Informational** as specified with the [AppCaptureMetadataPriority](appcapturemetadatapriority.md) enumeration. **Important** priority means the metadata will be uploaded to the Xbox Live service.  The metadata will be used to help users search clips or annotate broadcasts, among other things.
Both **Important** and **Informational** metadata are embedded in the generated .mp4 file, so you should not include any private user information in the metadata.

This API may throw an error if the background service has shut down due to idle timeout.

## -see-also

## -examples

