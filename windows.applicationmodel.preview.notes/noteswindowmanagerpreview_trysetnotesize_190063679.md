---
-api-id: M:Windows.ApplicationModel.Preview.Notes.NotesWindowManagerPreview.TrySetNoteSize(System.Int32,Windows.Foundation.Size)
-api-type: winrt method
---

<!-- Method syntax
public bool TrySetNoteSize(System.Int32 noteViewId, Windows.Foundation.Size size)
-->

# Windows.ApplicationModel.Preview.Notes.NotesWindowManagerPreview.TrySetNoteSize

## -description
Resizes the specified note to the desired dimensions. If the given size is not recommended due to screen size/space issues, the note's size will not be changed.

## -parameters
### -param noteViewId
The unique identifier of the note to be resized.

### -param size
The desired dimensions of the note (use raw pixels when constructing).

## -returns
**true** if the note was resized, **false** if it was not resized due to screen restrictions.

## -remarks

## -examples

## -see-also
