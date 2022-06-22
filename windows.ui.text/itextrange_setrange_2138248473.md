---
-api-id: M:Windows.UI.Text.ITextRange.SetRange(System.Int32,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void SetRange(System.Int32 startPosition, System.Int32 endPosition)
-->

# Windows.UI.Text.ITextRange.SetRange

## -description
Sets the endpoints of the text range to the specified values.



## -parameters
### -param startPosition
The character position for the start of the text range. This parameter must be less than *endPosition*.

### -param endPosition
The character position for the end of the text range.

## -remarks
If the text range is a nondegenerate selection, *endPosition* is the active end.

## -examples

## -see-also
