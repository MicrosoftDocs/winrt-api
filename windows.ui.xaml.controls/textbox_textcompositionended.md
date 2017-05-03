---
-api-id: E:Windows.UI.Xaml.Controls.TextBox.TextCompositionEnded
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler TextCompositionEnded<Windows.UI.Xaml.Controls.TextBox,  Windows.UI.Xaml.Controls.TextCompositionEndedEventArgs>
-->

# Windows.UI.Xaml.Controls.TextBox.TextCompositionEnded

## -description
Occurs when a user stops composing text through an Input Method Editor (IME).

## -remarks
For event data, see [TextCompositionEndedEventArgs](textcompositionendedeventargs.md).

This event occurs only when text is composed through an [Input Method Editor (IME)](http://msdn.microsoft.com/library/5fcc73e6-f499-47e6-8e81-0014ca4d241c). Text composition events occur in the following order:
+ [TextCompositionStarted](textbox_textcompositionstarted.md)
+ [TextChanging](textbox_textchanging.md)
+ [TextChanged](textbox_textchanged.md)
+ [TextCompositionChanged](textbox_textcompositionchanged.md)
+ [TextCompositionEnded](textbox_textcompositionended.md)


After the [TextCompositionStarted](textbox_textcompositionstarted.md) event, the [TextChanging](textbox_textchanging.md) &gt; [TextChanged](textbox_textchanged.md) &gt; [TextCompositionChanged](textbox_textcompositionchanged.md) event cycle can occur multiple times before the [TextCompositionEnded](textbox_textcompositionended.md) event occurs.



## -examples

## -see-also
[TextCompositionEndedEventArgs](textcompositionendedeventargs.md), [Input Method Editor (IME)](http://msdn.microsoft.com/library/5fcc73e6-f499-47e6-8e81-0014ca4d241c)