---
-api-id: E:Windows.UI.Xaml.Controls.RichEditBox.TextCompositionChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler TextCompositionChanged<Windows.UI.Xaml.Controls.RichEditBox,  Windows.UI.Xaml.Controls.TextCompositionChangedEventArgs>
-->

# Windows.UI.Xaml.Controls.RichEditBox.TextCompositionChanged

## -description
Occurs when text being composed through an Input Method Editor (IME) changes.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.RichEditBox.TextCompositionChanged](/windows/winui/api/microsoft.ui.xaml.controls.richeditbox.textcompositionchanged) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<RichEditBox TextCompositionChanged="eventhandler"/>
```

## -remarks
For event data, see [TextCompositionChangedEventArgs](textcompositionchangedeventargs.md).

This event occurs only when text is composed through an [Input Method Editor (IME)](/previous-versions/windows/apps/hh967427(v=win.10)). Text composition events occur in the following order:
+ [TextCompositionStarted](richeditbox_textcompositionstarted.md)
+ [TextChanging](richeditbox_textchanging.md)
+ [TextChanged](richeditbox_textchanged.md)
+ TextCompositionChanged
+ [TextCompositionEnded](richeditbox_textcompositionended.md)


After the [TextCompositionStarted](richeditbox_textcompositionstarted.md) event, the [TextChanging](richeditbox_textchanging.md) &gt; [TextChanged](richeditbox_textchanged.md) &gt; TextCompositionChanged event cycle can occur multiple times before the [TextCompositionEnded](richeditbox_textcompositionended.md) event occurs.



## -examples

## -see-also
[TextCompositionChangedEventArgs](textcompositionchangedeventargs.md), [Input Method Editor (IME)](/previous-versions/windows/apps/hh967427(v=win.10))
