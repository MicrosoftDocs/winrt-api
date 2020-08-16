---
-api-id: M:Windows.ApplicationModel.Preview.Notes.NotesWindowManagerPreview.ShowNoteWithPlacement(System.Int32,Windows.Storage.Streams.IBuffer,Windows.ApplicationModel.Preview.Notes.NotesWindowManagerPreviewShowNoteOptions)
-api-type: winrt method
---

<!-- Method syntax.
public void NotesWindowManagerPreview.ShowNoteWithPlacement(Int32 noteViewId, IBuffer data, NotesWindowManagerPreviewShowNoteOptions options)
-->

# Windows.ApplicationModel.Preview.Notes.NotesWindowManagerPreview.ShowNoteWithPlacement


## -description

Makes a note visible and sets its placement data (dimensions and location) as specified.

## -parameters

### -param noteViewId

The unique identifier of the note to be shown.

### -param data

An array of bytes holding note placement data.

### -param options

Options for showing the note specified by the *noteViewId* parameter. For example, show the note with focus.

## -remarks

[GetNotePlacement](noteswindowmanagerpreview_getnoteplacement_639894587.md) and ShowNoteWithPlacement can be used together to store the placement of a note (say, while the application is exiting) and then restore the note to its previous placement on the screen (when the application is opened again).

## -see-also

[NotesWindowManagerPreviewShowNoteOptions](noteswindowmanagerpreviewshownoteoptions.md)

## -examples

