---
-api-id: E:Windows.UI.Text.Core.CoreTextEditContext.TextUpdating
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler TextUpdating<Windows.UI.Text.Core.CoreTextEditContext,  Windows.UI.Text.Core.CoreTextTextUpdatingEventArgs>
-->

# Windows.UI.Text.Core.CoreTextEditContext.TextUpdating

## -description
Occurs when the text input server needs to modify text inside the text input control. This event could be the result of a key event— such as inserting a single character— or the result of processing done by an input processor, such as auto-correction and prediction.

When handling the event, the text input control must replace a range with the new text provided by the server, and also move the caret to the end of the new text.

## -remarks

## -examples

## -see-also
