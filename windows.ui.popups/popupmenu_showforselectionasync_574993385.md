---
-api-id: M:Windows.UI.Popups.PopupMenu.ShowForSelectionAsync(Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.UI.Popups.IUICommand> ShowForSelectionAsync(Windows.Foundation.Rect selection)
-->

# Windows.UI.Popups.PopupMenu.ShowForSelectionAsync

## -description
Shows the context menu above the specified selection.

## -parameters
### -param selection
The coordinates (in DIPs) of the selected rectangle, relative to the window. The context menu is placed directly above and centered on this rectangle such that selection is not covered.

> [!NOTE]
> For VB, C#, and C++, this window is the [CoreWindow](../windows.ui.core/corewindow.md) associated with the thread that is calling the context menu.

## -returns
A [IUICommand](iuicommand.md) object that represents the context menu command invoked by the user, after the ShowForSelectionAsync call completes.

If no command is invoked, ShowForSelectionAsync returns **null**.

## -remarks
You can see complete code examples that demonstrate how to create and customize context menus in the [Context menu sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample).

## -examples
Before you can show a context menu, you must add an event listener for the [oncontextmenu](/previous-versions/windows/internet-explorer/ie-developer/platform-apis/aa704010(v=vs.85)) event. For example, the [Context menu sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample) listens for the event on specific HTML elements, and then calls the `scenario1AttachmentHandler` function.



[!code-js[addcontextmenueventlistener_js](../windows.ui.popups/code/ContextMenu/js/js/scenario1.js#Snippetaddcontextmenueventlistener_js)]



[!code-js[showforselection_commandshaveids_js](../windows.ui.popups/code/ContextMenu/js/js/scenario2.js#Snippetshowforselection_commandshaveids_js)]

Additionally, the [Context menu sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample) uses two helper functions (`getSelectionRect` and `getclientCoordinates`) to set the coordinates for the selection rectangle.



[!code-js[selectionrect_js](../windows.ui.popups/code/ContextMenu/js/js/scenario2.js#Snippetselectionrect_js)]


## -see-also
[Adding context menus](/previous-versions/windows/apps/hh465300(v=win.10)), [Context menu sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample), [Guidelines and checklist for ](/windows/uwp/design/controls-and-patterns/index), [IUICommand](iuicommand.md), [oncontextmenu](/previous-versions/windows/internet-explorer/ie-developer/platform-apis/aa704010(v=vs.85)), [Rect](../windows.foundation/rect.md), [ShowForSelectionAsync(Rect, Placement)](popupmenu_showforselectionasync_655080999.md), [UICommand](uicommand.md)