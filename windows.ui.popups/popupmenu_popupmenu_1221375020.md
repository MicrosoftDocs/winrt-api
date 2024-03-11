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

In a desktop app, before using an instance of this class in a way that displays UI, you'll need to associate the object with its owner's window handle. For more info, and code examples, see [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects#winui-3-with-c).

## -remarks
You can see complete code examples that demonstrate how to create and customize context menus in the [Context menu sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample).

## -examples
To customize the context menu, call [preventDefault](/previous-versions/windows/internet-explorer/ie-developer/platform-apis/ff975967(v=vs.85)) on the [oncontextmenu](XREF:TODO:wwa.oncontextmenu_Event) event (`e` in the example) to suppress the default context menu, and then create a new, empty context menu as shown in the [Context menu sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample).



[!code-js[contextmenu_preventdefault](../windows.ui.popups/code/ContextMenu/js/js/scenario2.js#Snippetcontextmenu_preventdefault)]

[!code-js[newcontextmenu_js](../windows.ui.popups/code/ContextMenu/js/js/scenario1.js#Snippetnewcontextmenu_js)]

## -see-also
[Adding context menus](/previous-versions/windows/apps/hh465300(v=win.10)), [Context menu sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample), [Guidelines and checklist for ](/windows/uwp/design/controls-and-patterns/index), [UICommand](uicommand.md), [UICommandSeparator](uicommandseparator.md)