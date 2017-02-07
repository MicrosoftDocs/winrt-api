---
-api-id: T:Windows.UI.Text.Core.CoreTextSelectionUpdatingResult
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Text.Core.CoreTextSelectionUpdatingResult : int
-->

# CoreTextSelectionUpdatingResult

## -description
Defines constants that specify the result of handling the [SelectionUpdating](coretexteditcontext_selectionupdating.md) event.

## -enum-fields
### -field Succeeded:0
The selection update operation completed successfully.

### -field Failed:1
The selection update operation was not completed as the text input server expected.


## -remarks
This enumeration is used by the [CoreTextSelectionUpdatingEventArgs.Result](coretextselectionupdatingeventargs_result.md) property. The default is **Succeeded**.

## -examples

## -see-also
[SelectionUpdating](coretexteditcontext_selectionupdating.md), [CoreTextSelectionUpdatingEventArgs.Result](coretextselectionupdatingeventargs_result.md)