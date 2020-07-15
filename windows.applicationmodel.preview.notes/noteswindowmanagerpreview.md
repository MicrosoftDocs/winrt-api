---
-api-id: T:Windows.ApplicationModel.Preview.Notes.NotesWindowManagerPreview
-api-type: winrt class
---

<!-- Class syntax.
public class NotesWindowManagerPreview : Windows.ApplicationModel.Preview.Notes.INotesWindowManagerPreview, Windows.ApplicationModel.Preview.Notes.INotesWindowManagerPreview2
-->

# Windows.ApplicationModel.Preview.Notes.NotesWindowManagerPreview

## -description
This class owns much of the functionality of the **Preview Notes** application feature (see Remarks).

## -remarks
The **Preview Notes** feature allows a Universal Windows app to utilize the **Windows Ink Workspace** in order to provide a tailored note-taking experience on desktop devices. Apps that are recognized as such will operate with a number of behavioral changes meant to make the note-taking process faster and more convenient. For example, note-taking apps will open without a splash screen, will appear in the "Sticky Notes" section of the **Windows Ink Workspace**, will have their own configurable view-switching mechanism, and can display notes on a locked screen.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | SetFocusToPreviousView |
| 1703 | 15063 | SetThumbnailImageForTaskSwitcherAsync |
| 1703 | 15063 | ShowNoteRelativeTo(Int32,Int32,NotesWindowManagerPreviewShowNoteOptions) |
| 1703 | 15063 | ShowNoteWithPlacement(Int32,IBuffer,NotesWindowManagerPreviewShowNoteOptions) |

## -examples

## -see-also
