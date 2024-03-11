---
-api-id: M:Windows.UI.Popups.PopupMenu.ShowForSelectionAsync(Windows.Foundation.Rect,Windows.UI.Popups.Placement)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.UI.Popups.IUICommand> ShowForSelectionAsync(Windows.Foundation.Rect selection, Windows.UI.Popups.Placement preferredPlacement)
-->

# Windows.UI.Popups.PopupMenu.ShowForSelectionAsync

## -description
Shows the context menu in the preferred placement relative to the specified selection.

## -parameters
### -param selection
The coordinates (in DIPs) of the selected rectangle, relative to the window.

> [!NOTE]
> For VB, C#, and C++, this window is the [CoreWindow](../windows.ui.core/corewindow.md) associated with the thread that is calling the context menu.

### -param preferredPlacement
The preferred placement of the context menu relative to the selection rectangle.

The context menu is positioned in the *preferredPlacement* if the menu fits in the window and does not cover the selection. If the context menu does not fit in the preferred placement, another placement that does not cover the selection is used. If the context menu does not fit anywhere else, a placement that partially or wholly covers the selection is used.

## -returns
A [IUICommand](iuicommand.md) object that represents the context menu command invoked by the user, after the [ShowForSelectionAsync](popupmenu_showforselectionasync_574993385.md) call completes.

If no command is invoked, [ShowForSelectionAsync](popupmenu_showforselectionasync_574993385.md) returns **null**.

## -remarks
You can see complete code examples that demonstrate how to create and customize context menus in the [Context menu sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample).

## -examples
Before you can show a context menu, you must add an event listener for the [oncontextmenu](/previous-versions/windows/internet-explorer/ie-developer/platform-apis/aa704010(v=vs.85)) event. For example, the [Context menu sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample) listens for the event on specific HTML elements, and then calls the `scenario1AttachmentHandler` function.



[!code-js[addcontextmenueventlistener_js](../windows.ui.popups/code/ContextMenu/js/js/scenario1.js#Snippetaddcontextmenueventlistener_js)]



[!code-js[selectionrect_js](../windows.ui.popups/code/ContextMenu/js/js/scenario2.js#Snippetselectionrect_js)]

## -see-also
[Adding context menus](/previous-versions/windows/apps/hh465300(v=win.10)), [Context menu sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample), [Guidelines and checklist for ](/windows/uwp/design/controls-and-patterns/index), [IUICommand](iuicommand.md), [oncontextmenu](/previous-versions/windows/internet-explorer/ie-developer/platform-apis/aa704010(v=vs.85)), [Rect](../windows.foundation/rect.md), [ShowForSelectionAsync(Rect)](popupmenu_showforselectionasync_574993385.md), [UICommand](uicommand.md)