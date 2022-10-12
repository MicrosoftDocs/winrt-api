---
-api-id: T:Windows.UI.ViewManagement.Core.CoreInputViewKind
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum CoreInputViewKind : int 
-->

# Windows.UI.ViewManagement.Core.CoreInputViewKind

## -description

Defines the values for specifying a preferred view for the input pane.

## -enum-fields

### -field Default:0

Show the default input pane view.

Behaves exactly like [TryShow](coreinputview_tryshow_1077566544.md) or [TryShowPrimaryView](coreinputview_tryshowprimaryview_1925215151.md).

### -field Keyboard:1

Show the software keyboard view.

### -field Handwriting:2

Show the handwriting pane view. If it is not available, it will show the software keyboard.

### -field Emoji:3

Show the emoji pane view. If it is not available, it will show the emoji view of the software keyboard.

### -field Symbols:4

Show the emoji pane with symbols view enabled. If it is not available, it will show the emoji view of the software keyboard.

### -field Clipboard:5

Show the clipboard history pane view.

### -field Dictation: 6

Show the dictation pane view.

### -field Clipboard:5

Show the clipboard history pane view.

## -remarks

Primary view refers to either of the [CoreInputViewKind.Keyboard](https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.ui.viewmanagement.core/coreinputviewkind.md#-field-keyboard1) or [CoreInputViewKind.Handwriting](https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.ui.viewmanagement.core/coreinputviewkind.md#-field-handwriting2) views, while CoreInputView can be any of the values from [CoreInputViewKind](coreinputviewkind.md).

Pass this parameter in the [TryShow(CoreInputViewKind)](coreinputview_tryshow_154132369.md) method to specify the preferred input view.

This allows apps to build specific experiences around certain input views, if that view is available.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 2004 | 19041 | Symbols |
| ?? | ?? | Clipboard |

## -see-also

[TryShow(CoreInputViewKind)](coreinputview_tryshow_154132369.md)

## -examples
