---
-api-id: E:Windows.ApplicationModel.Preview.Notes.NotesWindowManagerPreview.NoteVisibilityChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler NoteVisibilityChanged<Windows.ApplicationModel.Preview.Notes.NotesWindowManagerPreview,  Windows.ApplicationModel.Preview.Notes.NoteVisibilityChangedPreviewEventArgs>
-->

# Windows.ApplicationModel.Preview.Notes.NotesWindowManagerPreview.NoteVisibilityChanged

## -description
Indicates that a note's visibility state has changed.

> [!NOTE]
> When this event is raised, its handler must determine whether the given view was hidden or shown (according to the [isVisible](notevisibilitychangedprevieweventargs_isvisible.md) property in [NoteVisibilityChangedPreviewEventArgs](notevisibilitychangedprevieweventargs.md) class). If hidden, the note's [CoreWindow](../windows.ui.core/corewindow.md) object must be closed (with the [Close](../windows.ui.core/corewindow_close_811482585.md) method) within the event handler.

## -remarks

## -examples

## -see-also
