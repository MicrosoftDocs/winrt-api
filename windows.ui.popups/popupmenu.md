---
-api-id: T:Windows.UI.Popups.PopupMenu
-api-type: winrt class
---

<!-- Class syntax.
public class PopupMenu : Windows.UI.Popups.IPopupMenu
-->

# Windows.UI.Popups.PopupMenu

## -description
Represents a context menu.

## -remarks
context menu can show a maximum of six commands. This limit helps to ensure that the context menu remains uncluttered, usable, and directly relevant to users.

You can see complete code examples that demonstrate how to create and customize context menu in the [Context menu sample](https://go.microsoft.com/fwlink/p/?linkid=234891) on the [ sample home page](https://go.microsoft.com/fwlink/p/?linkid=226952).

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](https://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](https://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples
Provide users with a context menu by adding an event listener for the `"contextmenu"` event. For example, the [Context menu sample](https://go.microsoft.com/fwlink/p/?linkid=234891) listens for the event on specific HTML elements, and then calls the `scenario1AttachmentHandler` function.



[!code-js[addcontextmenueventlistener_js](../windows.ui.popups/code/ContextMenu/js/js/scenario1.js#Snippetaddcontextmenueventlistener_js)]

To customize the context menu, call [preventDefault](https://docs.microsoft.com/previous-versions/windows/internet-explorer/ie-developer/platform-apis/ff975967(v=vs.85)) on the event to suppress the default, and then create a new, empty context menu as shown in the [Context menu sample](https://go.microsoft.com/fwlink/p/?linkid=234891).



[!code-js[contextmenu_preventdefault](../windows.ui.popups/code/ContextMenu/js/js/scenario2.js#Snippetcontextmenu_preventdefault)]

[!code-js[newcontextmenu_js](../windows.ui.popups/code/ContextMenu/js/js/scenario1.js#Snippetnewcontextmenu_js)]

## -see-also
[Adding context menus](https://docs.microsoft.com/previous-versions/windows/apps/hh465300(v=win.10)), [Context menu sample](https://go.microsoft.com/fwlink/p/?linkid=234891), [Guidelines and checklist for ](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/index), [PopupMenu.Commands](popupmenu_commands.md), [UICommand](uicommand.md), [UICommandSeparator](uicommandseparator.md), [Context menu sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620525), [UICommand](uicommand.md), [UICommandSeparator](uicommandseparator.md), [Context menu sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620525)
