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
You can see complete code examples that demonstrate how to create and customize context menu in the [Context menu sample](http://code.msdn.microsoft.com/windowsapps/Context-menu-sample-40840351) on the [ sample home page](https://go.microsoft.com/fwlink/p/?linkid=226952).

To use this object from a desktop app, create the object, and then use [the IInitializeWithWindow::Initialize method](https://docs.microsoft.com/en-us/windows/desktop/api/shobjidl_core/nf-shobjidl_core-iinitializewithwindow-initialize) to associate the object with a window handle.

## -examples
To customize the context menu, call [preventDefault](https://docs.microsoft.com/previous-versions/windows/internet-explorer/ie-developer/platform-apis/ff975967(v=vs.85)) on the [oncontextmenu](XREF:TODO:wwa.oncontextmenu_Event) event (`e` in the example) to suppress the default context menu, and then create a new, empty context menu as shown in the [Context menu sample](http://code.msdn.microsoft.com/windowsapps/Context-menu-sample-40840351).



[!code-js[contextmenu_preventdefault](../windows.ui.popups/code/ContextMenu/js/js/scenario2.js#Snippetcontextmenu_preventdefault)]

[!code-js[newcontextmenu_js](../windows.ui.popups/code/ContextMenu/js/js/scenario1.js#Snippetnewcontextmenu_js)]

## -see-also
[Adding context menus](https://docs.microsoft.com/previous-versions/windows/apps/hh465300(v=win.10)), [Context menu sample](http://code.msdn.microsoft.com/windowsapps/Context-menu-sample-40840351), [Guidelines and checklist for ](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/index), [UICommand](uicommand.md), [UICommandSeparator](uicommandseparator.md)
