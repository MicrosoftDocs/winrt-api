---
-api-id: T:Windows.UI.Text.SelectionOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Text.SelectionOptions : uint
-->

# SelectionOptions

## -description
Describes the options that apply to a selection.



## -enum-fields
### -field StartActive:1
The start position of the selection is the active end; that is, the end that is changed by pressing Shift+Right Arrow and Shift+Left Arrow.

### -field AtEndOfLine:2
For a degenerate selection (insertion point), the character position at the beginning of a line is the same as the character position at the end of the preceding line. As such, the character position is ambiguous. If this flag is 1, display the caret at the end of the preceding line; otherwise, display it at the beginning of the line.

### -field Overtype:4
Insert/overtype mode is set to overtype.

### -field Active:8
The selection is active; that is, the text control has the input focus.

### -field Replace:16
Typing and pasting replaces the selection.


## -remarks
Each option is binary, so if a particular option is not set, the text selection has the opposite option. For example, if the Overtype option is not set, the text selection is set to insert mode.

## -examples

## -see-also
[ITextSelection.Options](itextselection_options.md)
