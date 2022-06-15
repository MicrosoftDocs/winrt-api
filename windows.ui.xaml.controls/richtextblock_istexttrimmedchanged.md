---
-api-id: E:Windows.UI.Xaml.Controls.RichTextBlock.IsTextTrimmedChanged
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler IsTextTrimmedChanged<RichTextBlock, IsTextTrimmedChangedEventArgs>
-->

# Windows.UI.Xaml.Controls.RichTextBlock.IsTextTrimmedChanged

## -description

Occurs when the [IsTextTrimmed](richtextblock_istexttrimmed.md) property value has changed.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.RichTextBlock.IsTextTrimmedChanged](/windows/winui/api/microsoft.ui.xaml.controls.richtextblock.istexttrimmedchanged) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<RichTextBlock IsTextTrimmedChanged="eventhandler"/>
```

## -remarks

If the [TextTrimming](richtextblock_texttrimming.md) property is set to None (default), no trim indicator is drawn and the [IsTextTrimmedChanged](richtextblock_istexttrimmedchanged.md) event does not fire.

## -see-also

## -examples

