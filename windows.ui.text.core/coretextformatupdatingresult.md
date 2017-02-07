---
-api-id: T:Windows.UI.Text.Core.CoreTextFormatUpdatingResult
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Text.Core.CoreTextFormatUpdatingResult : int
-->

# CoreTextFormatUpdatingResult

## -description
Defines constants that specify the result of handling the [FormatUpdating](coretexteditcontext_formatupdating.md) event.

## -enum-fields
### -field Succeeded:0
The format update operation completed successfully.

### -field Failed:1
The format update operation was not completed as the text input server expected.


## -remarks
This enumeration is used by the [CoreTextFormatUpdatingEventArgs.Result](coretextformatupdatingeventargs_result.md) property. The default is **Succeeded**.

## -examples

## -see-also
[FormatUpdating](coretexteditcontext_formatupdating.md), [CoreTextFormatUpdatingEventArgs.Result](coretextformatupdatingeventargs_result.md)