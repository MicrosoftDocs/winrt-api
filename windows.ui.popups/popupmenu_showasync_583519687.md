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
The coordinates (in DIPs), relative to the window, of the user's finger or mouse pointer when the [oncontextmenu](https://msdn.microsoft.com/library/aa704010(v=vs.85).aspx) event fired. The menu is placed above and centered on this point.

> [!NOTE]
> For VB, C#, and C++, this window is the [CoreWindow](../windows.ui.core/corewindow.md) associated with the thread that is calling the context menu.

## -returns
A [IUICommand](iuicommand.md) object that represents the context menu command that was invoked by the user, after the [ShowAsync](popupmenu_showasync_583519687.md) call completes.

If no command is invoked, [ShowAsync](popupmenu_showasync_583519687.md) returns **null**.

## -remarks
You can see complete code examples that demonstrate how to create and customize context menu in the [Context menu sample](http://go.microsoft.com/fwlink/p/?linkid=234891) on the [ sample home page](http://go.microsoft.com/fwlink/p/?linkid=226952).

## -examples
Before you can show a context menu, you must add an event listener for the [oncontextmenu](https://msdn.microsoft.com/library/aa704010(v=vs.85).aspx) event. For example, the [Context menu sample](http://go.microsoft.com/fwlink/p/?linkid=234891) listens for the event on specific HTML elements, and then calls the `scenario1AttachmentHandler` function.



[!code-js[addcontextmenueventlistener_js](../windows.ui.popups/code/ContextMenu/js/js/scenario1.js#Snippetaddcontextmenueventlistener_js)]



[!code-js[addandshowwithhandlers_js](../windows.ui.popups/code/ContextMenu/js/js/scenario1.js#Snippetaddandshowwithhandlers_js)]

Additionally, make sure you check that a command was invoked and process that case as appropriate for your app. If the [UICommand](uicommand.md) that is invoked has a callback function (`onSaveAttachment` in the example), the callback function will be executed. Otherwise, you may need to use [UICommand.Id](uicommand_id.md) to identify and process the invoked command.

## -see-also
[Adding context menus](http://msdn.microsoft.com/library/9778aea7-c959-4b3e-bd79-9659f07095a6), [Context menu sample](http://go.microsoft.com/fwlink/p/?linkid=234891), [Guidelines and checklist for ](http://msdn.microsoft.com/library/23063edd-ed89-4a82-9857-44001fad770b), [IUICommand](iuicommand.md), [oncontextmenu](https://msdn.microsoft.com/library/aa704010(v=vs.85).aspx), [Point](../windows.foundation/point.md), [PopupMenu.Commands](popupmenu_commands.md), [UICommand](uicommand.md)
ng context menus](http://msdn.microsoft.com/library/9778aea7-c959-4b3e-bd79-9659f07095a6), [Context menu sample](http://go.microsoft.com/fwlink/p/?linkid=234891), [Guidelines and checklist for ](http://msdn.microsoft.com/library/23063edd-ed89-4a82-9857-44001fad770b), [IUICommand](iuicommand.md), [oncontextmenu](https://msdn.microsoft.com/library/aa704010(v=vs.85).aspx), [Point](../windows.foundation/point.md), [PopupMenu.Commands](popupmenu_commands.md), [UICommand](uicommand.md)