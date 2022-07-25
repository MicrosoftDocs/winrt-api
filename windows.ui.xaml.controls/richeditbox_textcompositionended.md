---
-api-id: E:Windows.UI.Xaml.Controls.RichEditBox.TextCompositionEnded
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler TextCompositionEnded<Windows.UI.Xaml.Controls.RichEditBox,  Windows.UI.Xaml.Controls.TextCompositionEndedEventArgs>
-->

# Windows.UI.Xaml.Controls.RichEditBox.TextCompositionEnded

## -description
Occurs when a user stops composing text through an Input Method Editor (IME).



## -xaml-syntax

```xaml
<RichEditBox TextCompositionEnded="eventhandler"/>
```

## -remarks
For event data, see [TextCompositionEndedEventArgs](textcompositionendedeventargs.md).

This event occurs only when text is composed through an [Input Method Editor (IME)](/previous-versions/windows/apps/hh967427(v=win.10)). Text composition events occur in the following order:
+ [TextCompositionStarted](richeditbox_textcompositionstarted.md)
+ [TextChanging](richeditbox_textchanging.md)
+ [TextChanged](richeditbox_textchanged.md)
+ [TextCompositionChanged](richeditbox_textcompositionchanged.md)
+ TextCompositionEnded


After the [TextCompositionStarted](richeditbox_textcompositionstarted.md) event, the [TextChanging](richeditbox_textchanging.md) &gt; [TextChanged](richeditbox_textchanged.md) &gt; [TextCompositionChanged](richeditbox_textcompositionchanged.md) event cycle can occur multiple times before the TextCompositionEnded event occurs.



## -examples

## -see-also
[TextCompositionEndedEventArgs](textcompositionendedeventargs.md), [Input Method Editor (IME)](/previous-versions/windows/apps/hh967427(v=win.10))
