---
-api-id: M:Windows.UI.Popups.PopupMenu.ShowAsync(Windows.Foundation.Point)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.UI.Popups.IUICommand> ShowAsync(Windows.Foundation.Point invocationPoint)
-->

# Windows.UI.Popups.PopupMenu.ShowAsync

## -description
Shows the context menu at the specified client coordinates.

## -parameters
### -param invocationPoint
The coordinates (in DIPs), relative to the window, of the user's finger or mouse pointer when the [oncontextmenu](/previous-versions/windows/internet-explorer/ie-developer/platform-apis/aa704010(v=vs.85)) event fired. The menu is placed above and centered on this point.

> [!NOTE]
> For VB, C#, and C++, this window is the [CoreWindow](../windows.ui.core/corewindow.md) associated with the thread that is calling the context menu.

## -returns
A [IUICommand](iuicommand.md) object that represents the context menu command that was invoked by the user, after the ShowAsync call completes.

If no command is invoked, ShowAsync returns **null**.

## -remarks
You can see complete code examples that demonstrate how to create and customize context menus in the [Context menu sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample).

## -examples
Before you can show a context menu, you must add an event listener for the [oncontextmenu](/previous-versions/windows/internet-explorer/ie-developer/platform-apis/aa704010(v=vs.85)) event. For example, the [Context menu sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample) listens for the event on specific HTML elements, and then calls the `scenario1AttachmentHandler` function.



[!code-js[addcontextmenueventlistener_js](../windows.ui.popups/code/ContextMenu/js/js/scenario1.js#Snippetaddcontextmenueventlistener_js)]



[!code-js[addandshowwithhandlers_js](../windows.ui.popups/code/ContextMenu/js/js/scenario1.js#Snippetaddandshowwithhandlers_js)]

Additionally, make sure you check that a command was invoked and process that case as appropriate for your app. If the [UICommand](uicommand.md) that is invoked has a callback function (`onSaveAttachment` in the example), the callback function will be executed. Otherwise, you may need to use [UICommand.Id](uicommand_id.md) to identify and process the invoked command.

## -see-also
[Adding context menus](/previous-versions/windows/apps/hh465300(v=win.10)), [Context menu sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample), [Guidelines and checklist for ](/windows/uwp/design/controls-and-patterns/index), [IUICommand](iuicommand.md), [oncontextmenu](/previous-versions/windows/internet-explorer/ie-developer/platform-apis/aa704010(v=vs.85)), [Point](../windows.foundation/point.md), [PopupMenu.Commands](popupmenu_commands.md), [UICommand](uicommand.md)