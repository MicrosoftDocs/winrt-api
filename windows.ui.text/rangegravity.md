---
-api-id: T:Windows.UI.Text.RangeGravity
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Text.RangeGravity : int
-->

# RangeGravity

## -description
Specifies the gravity for a text range.

Equivalent **WinUI 2 API for UWP**: [RangeGravity](/windows/winui/api/microsoft.ui.text.rangegravity) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -enum-fields
### -field UIBehavior:0
Use selection user interface rules.

### -field Backward:1
Use the formatting of the previous text run when on a boundary between runs.

### -field Forward:2
Use the formatting of the following text run when on a boundary between runs.

### -field Inward:3
The start of the text range has forward gravity, and the end has backward gravity.

### -field Outward:4
The start of the text range has backward gravity, and the end has forward gravity.


## -remarks
The gravity of a text range determines which text run’s formatting is used by the [ITextCharacterFormat](itextcharacterformat.md) and [ITextParagraphFormat](itextparagraphformat.md) interfaces when the range is an insertion point between two runs.

## -examples

## -see-also
[ITextRange.Gravity](itextrange_gravity.md)
