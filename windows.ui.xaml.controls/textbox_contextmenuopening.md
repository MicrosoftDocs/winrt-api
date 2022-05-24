---
-api-id: E:Windows.UI.Xaml.Controls.TextBox.ContextMenuOpening
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Controls.ContextMenuOpeningEventHandler ContextMenuOpening
-->

# Windows.UI.Xaml.Controls.TextBox.ContextMenuOpening

## -description

Occurs when the system processes an interaction that displays a context menu.


## -xaml-syntax

```xaml
<TextBox ContextMenuOpening="eventhandler" />
```

## -remarks

To override or add commands to the context menu, you can handle the ContextMenuOpening event and replace the default menu with a custom menu. For an example of this, see the **Customizing RichEditBox's CommandBarFlyout - adding 'Share'** example in the <a href="winui2gallery:/item/RichEditBox">WinUI 2 Gallery</a>. For design info, see [Guidelines for context menus](/windows/uwp/design/controls-and-patterns/menus).

## -examples

## -see-also

[ContextMenuOpeningEventHandler](contextmenuopeningeventhandler.md), [Guidelines for context menus](/windows/uwp/design/controls-and-patterns/index), [ContextMenu sample](https://github.com/microsoft/Windows-universal-samples/tree/master/archived/ContextMenu)
