---
-api-id: M:Windows.ApplicationModel.Preview.Notes.NotesWindowManagerPreview.SetNotesThumbnailAsync(Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SetNotesThumbnailAsync(Windows.Storage.Streams.IBuffer thumbnail)
-->

# Windows.ApplicationModel.Preview.Notes.NotesWindowManagerPreview.SetNotesThumbnailAsync

## -description
Sets the thumbnail image for this application as it appears in the Windows Ink Workspace, in the Alt+TAB task switcher, or on hovering in the taskbar.

## -parameters
### -param thumbnail
A byte array describing the thumbnail image and usage (see Remarks).

## -returns
This method does not return a value.

## -remarks
The *thumbnail* byte array must adhere to the following format in order to describe a thumbnail image: Bytes 0-3: thumbnail type – a string value of either "NTPW" (for Ink Workspace appearance) or "NTTS" (for Alt+TAB switching and taskbar hover).

Bytes 4-7: Image width in pixels – an integer value.

Bytes 8-11: Image height in pixels – an integer value.

The final section must contain 4 * **image width** * **image height** number of bytes. Every 4-byte integer of this section corresponds to the BGRA color data of one pixel.

> [!NOTE]
> If the size of the image used (in pixels) exceeds the size of the primary monitor, an InvalidArgumentException will be thrown.

## -examples

## -see-also
