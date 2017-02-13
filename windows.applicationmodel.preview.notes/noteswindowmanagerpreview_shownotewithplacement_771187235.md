---
-api-id: M:Windows.ApplicationModel.Preview.Notes.NotesWindowManagerPreview.ShowNoteWithPlacement(System.Int32,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public void ShowNoteWithPlacement(System.Int32 noteViewId, Windows.Storage.Streams.IBuffer data)
-->

# Windows.ApplicationModel.Preview.Notes.NotesWindowManagerPreview.ShowNoteWithPlacement

## -description
Makes a note visible and sets its placement data (dimensions and location) as specified.

## -parameters
### -param noteViewId
The unique identifier of the note to be shown.

### -param data
An array of bytes holding note placement data.

## -remarks
[GetNotePlacement](noteswindowmanagerpreview_getnoteplacement.md) and [ShowNoteWithPlacement](noteswindowmanagerpreview_shownotewithplacement.md) can be used together to store the placement of a note (say, while the application is exiting) and then restore the note to its previous placement on the screen (when the application is opened again).

## -examples

## -see-also
