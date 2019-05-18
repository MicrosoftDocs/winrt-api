---
-api-id: M:Windows.ApplicationModel.Preview.Notes.NotesWindowManagerPreview.GetNotePlacement(System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Streams.IBuffer GetNotePlacement(System.Int32 noteViewId)
-->

# Windows.ApplicationModel.Preview.Notes.NotesWindowManagerPreview.GetNotePlacement

## -description
Gets the view placement of a given note, to be stored in program memory or on disk storage and then restored by the application at a later time.

## -parameters
### -param noteViewId
The unique identifier of the note whose placement is to be retrieved.

## -returns
An array of bytes holding note placement data.

## -remarks
GetNotePlacement and [ShowNoteWithPlacement](/uwp/api/windows.applicationmodel.preview.notes.noteswindowmanagerpreview.shownotewithplacement) can be used together to store the placement of a note (say, while the application is exiting) and then restore the note to its previous placement on the screen (when the application is opened again).

## -examples

## -see-also
