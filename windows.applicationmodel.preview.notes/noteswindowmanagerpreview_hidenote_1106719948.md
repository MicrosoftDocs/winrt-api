---
-api-id: M:Windows.ApplicationModel.Preview.Notes.NotesWindowManagerPreview.HideNote(System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void HideNote(System.Int32 noteViewId)
-->

# Windows.ApplicationModel.Preview.Notes.NotesWindowManagerPreview.HideNote

## -description
Sets a note's view to invisible and moves the focus to the next visible note view (window) or to the Windows Ink Workspace (see Remarks). The views are selected in a cyclic, system-determined order.

> [!NOTE]
> Even though the note disappears from the screen, its [CoreWindow](../windows.ui.core/corewindow.md) object remains until the [NoteVisibilityChanged](noteswindowmanagerpreview_notevisibilitychanged.md) event is raised and the handling method closes the note's window by calling the [Close](../windows.ui.core/corewindow_close_811482585.md) method.

## -parameters
### -param noteViewId
The unique identifier of the note to be hidden.

## -remarks
When the notes app is loaded from the Windows Ink Workspace, this method will switch focus to the Windows Ink Workspace if it is next in the order.

## -examples

## -see-also
