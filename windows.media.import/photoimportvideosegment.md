---
-api-id: T:Windows.Media.Import.PhotoImportVideoSegment
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PhotoImportVideoSegment : Windows.Media.Import.IPhotoImportVideoSegment
-->

# Windows.Media.Import.PhotoImportVideoSegment

## -description
Represents an imported video segment.

## -remarks
Video segments are produced by some video recorders that split long video files in multiple segments. The reasons might be file format limitations, file size limitations on the storage media file system, or some inherited arbitrary convention, such as the 20mn standard duration of a 35mm movie reel. The naming of the main (“first”) segment and the subsequent (“continuation”) segments depends on the video recorder. The correlation between the segments can be made on based on the full path + the video type + the last four digits, looking for digits in the first four characters to decide which one it the main file. The last continuation is typically smaller than the main file, and the timestamps may also reflect the chronological sequence. Video segments can have siblings.

## -examples

## -see-also
