---
-api-id: E:Windows.UI.Xaml.Controls.RichEditBox.TextChanging
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler TextChanging<Windows.UI.Xaml.Controls.RichEditBox,  Windows.UI.Xaml.Controls.RichEditBoxTextChangingEventArgs>
-->

# Windows.UI.Xaml.Controls.RichEditBox.TextChanging

## -description
Occurs synchronously when the text in the edit box starts to change, but before it is rendered.



## -xaml-syntax
```xaml
<RichEditBox TextChanging="eventhandler"/>
```


## -remarks
For event data, see [RichEditBoxTextChangingEventArgs](richeditboxtextchangingeventargs.md).

The TextChanging event occurs synchronously before the new text is rendered. In contrast, the [TextChanged](richeditbox_textchanged.md) event is asynchronous and occurs after the new text is rendered.

When the TextChanging event occurs, the [Document](richeditbox_document.md) property already reflects the new value (but it's not rendered in the UI). You typically handle this event to update the text value and selection before the text is rendered. This prevents the text flickering that can happen when text is rendered, updated, and re-rendered rapidly.

> [!NOTE]
> This is a synchronous event that can occur at times when changes to the XAML visual tree are not allowed, such as during layout. Therefore, you should limit code within the TextChanging event handler primarily to inspecting and updating the [Document](richeditbox_document.md) property. Attempting to perform other actions, such as showing a popup or adding/removing elements from the visual tree, might cause potentially fatal errors that can lead to a crash. We recommend that you perform these other changes either in a [TextChanged](richeditbox_textchanged.md) event handler, or run them as a separate asynchronous operation.

## -examples

## -see-also
[RichEditBoxTextChangingEventArgs](richeditboxtextchangingeventargs.md)
