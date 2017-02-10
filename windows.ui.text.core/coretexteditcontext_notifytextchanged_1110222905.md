---
-api-id: M:Windows.UI.Text.Core.CoreTextEditContext.NotifyTextChanged(Windows.UI.Text.Core.CoreTextRange,System.Int32,Windows.UI.Text.Core.CoreTextRange)
-api-type: winrt method
---

<!-- Method syntax
public void NotifyTextChanged(Windows.UI.Text.Core.CoreTextRange modifiedRange, System.Int32 newLength, Windows.UI.Text.Core.CoreTextRange newSelection)
-->

# Windows.UI.Text.Core.CoreTextEditContext.NotifyTextChanged

## -description
Notifies the text input server about any change that the text input control needs to make to the text. This is important in order to keep the internal state of the control and the internal state of the server synchronized. Since a change to the text is also likely to affect the selection range, the method takes the selection range as a parameter.

## -parameters
### -param modifiedRange
The range of text to replace, in terms of the state the text buffer is in prior to this text change.

### -param newLength
The length of the text that should replace *modifiedRange*.

### -param newSelection
The range of selection in effect after the text change.

## -remarks

## -examples

## -see-also
