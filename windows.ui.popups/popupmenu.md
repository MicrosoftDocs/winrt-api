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

You can see complete code examples that demonstrate how to create and customize context menu in the [Context menu sample](http://go.microsoft.com/fwlink/p/?linkid=234891) on the [ sample home page](http://go.microsoft.com/fwlink/p/?linkid=226952).

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](http://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples
Provide users with a context menu by adding an event listener for the `"contextmenu"` event. For example, the [Context menu sample](http://go.microsoft.com/fwlink/p/?linkid=234891) listens for the event on specific HTML elements, and then calls the `scenario1AttachmentHandler` function.



[!code-js[addcontextmenueventlistener_js](../windows.ui.popups/code/ContextMenu/js/js/scenario1.js#Snippetaddcontextmenueventlistener_js)]

To customize the context menu, call [preventDefault](https://msdn.microsoft.com/en-us/library/ff975967(v=vs.85).aspx) on the event to suppress the default, and then create a new, empty context menu menu as shown in the [Context menu sample](http://go.microsoft.com/fwlink/p/?linkid=234891).



[!code-js[contextmenu_preventdefault](../windows.ui.popups/code/ContextMenu/js/js/scenario2.js#Snippetcontextmenu_preventdefault)]

[!code-js[newcontextmenu_js](../windows.ui.popups/code/ContextMenu/js/js/scenario1.js#Snippetnewcontextmenu_js)]

## -see-also
[Adding context menus](http://msdn.microsoft.com/library/9778aea7-c959-4b3e-bd79-9659f07095a6), [Context menu sample](http://go.microsoft.com/fwlink/p/?linkid=234891), [Guidelines and checklist for ](http://msdn.microsoft.com/library/23063edd-ed89-4a82-9857-44001fad770b), [PopupMenu.Commands](popupmenu_commands.md), [UICommand](uicommand.md), [UICommandSeparator](uicommandseparator.md), [Context menu sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620525)
pMenu.Commands](popupmenu_commands.md), [UICommand](uicommand.md), [UICommandSeparator](uicommandseparator.md), [Context menu sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620525)