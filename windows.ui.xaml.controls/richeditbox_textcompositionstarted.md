---
-api-id: E:Windows.UI.Xaml.Controls.RichEditBox.TextCompositionStarted
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler TextCompositionStarted<Windows.UI.Xaml.Controls.RichEditBox,  Windows.UI.Xaml.Controls.TextCompositionStartedEventArgs>
-->

# Windows.UI.Xaml.Controls.RichEditBox.TextCompositionStarted

## -description
Occurs when a user starts composing text through an Input Method Editor (IME).

## -xaml-syntax

```xaml
<RichEditBox TextCompositionStarted="eventhandler"/>
```

## -remarks
For event data, see [TextCompositionStartedEventArgs](textcompositionstartedeventargs.md).

This event occurs only when text is composed through an [Input Method Editor (IME)](http://msdn.microsoft.com/library/5fcc73e6-f499-47e6-8e81-0014ca4d241c). Text composition events occur in the following order:
+ [TextCompositionStarted](richeditbox_textcompositionstarted.md)
+ [TextChanging](richeditbox_textchanging.md)
+ [TextChanged](richeditbox_textchanged.md)
+ [TextCompositionChanged](richeditbox_textcompositionchanged.md)
+ [TextCompositionEnded](richeditbox_textcompositionended.md)


After the [TextCompositionStarted](richeditbox_textcompositionstarted.md) event, the [TextChanging](richeditbox_textchanging.md) &gt; [TextChanged](richeditbox_textchanged.md) &gt; [TextCompositionChanged](richeditbox_textcompositionchanged.md) event cycle can occur multiple times before the [TextCompositionEnded](richeditbox_textcompositionended.md) event occurs.



## -examples

## -see-also
[TextCompositionStartedEventArgs](textcompositionstartedeventargs.md), [Input Method Editor (IME)](http://msdn.microsoft.com/library/5fcc73e6-f499-47e6-8e81-0014ca4d241c)