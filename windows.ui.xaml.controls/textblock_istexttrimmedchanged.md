---
-api-id: E:Windows.UI.Xaml.Controls.TextBlock.IsTextTrimmedChanged
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler IsTextTrimmedChanged<TextBlock, IsTextTrimmedChangedEventArgs>
-->

# Windows.UI.Xaml.Controls.TextBlock.IsTextTrimmedChanged

## -description

Occurs when the [IsTextTrimmed](textblock_istexttrimmed.md) property value has changed.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.TextBlock.IsTextTrimmedChanged](/windows/winui/api/microsoft.ui.xaml.controls.textblock.istexttrimmedchanged) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<TextBlock IsTextTrimmedChanged="eventhandler"/>
```

## -remarks

If the [TextTrimming](textblock_texttrimming.md) property is set to None (default), no trim indicator is drawn and the [IsTextTrimmedChanged](textblock_istexttrimmedchanged.md) event does not fire.

## -see-also

## -examples
