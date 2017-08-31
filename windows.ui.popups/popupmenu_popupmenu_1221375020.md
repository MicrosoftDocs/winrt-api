---
-api-id: M:Windows.UI.Popups.PopupMenu.#ctor
-api-type: winrt method
---

<!-- Method syntax
public PopupMenu()
-->

# Windows.UI.Popups.PopupMenu.PopupMenu

## -description
Creates a new instance of the [PopupMenu](popupmenu.md) class.

## -remarks
You can see complete code examples that demonstrate how to create and customize context menu in the [Context menu sample](http://go.microsoft.com/fwlink/p/?linkid=234891) on the [ sample home page](http://go.microsoft.com/fwlink/p/?linkid=226952).

## -examples
To customize the context menu, call [preventDefault](https://msdn.microsoft.com/en-us/library/ff975967(v=vs.85).aspx) on the [oncontextmenu](XREF:TODO:wwa.oncontextmenu_Event) event (`e` in the example) to suppress the default context menu, and then create a new, empty context menu menu as shown in the [Context menu sample](http://go.microsoft.com/fwlink/p/?linkid=234891).



[!code-js[contextmenu_preventdefault](../windows.ui.popups/code/ContextMenu/js/js/scenario2.js#Snippetcontextmenu_preventdefault)]

[!code-js[newcontextmenu_js](../windows.ui.popups/code/ContextMenu/js/js/scenario1.js#Snippetnewcontextmenu_js)]

## -see-also
[Adding context menus](http://msdn.microsoft.com/library/9778aea7-c959-4b3e-bd79-9659f07095a6), [Context menu sample](http://go.microsoft.com/fwlink/p/?linkid=234891), [Guidelines and checklist for ](http://msdn.microsoft.com/library/23063edd-ed89-4a82-9857-44001fad770b), [UICommand](uicommand.md), [UICommandSeparator](uicommandseparator.md)
