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

In a desktop app, before using an instance of this class in a way that displays UI, you'll need to associate the object with its owner's window handle. For more info, and code examples, see [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects#winui-3-with-c).

## -remarks

A context menu can show a maximum of six commands. This limit helps to ensure that the context menu remains uncluttered, usable, and directly relevant to users.

You can see complete code examples that demonstrate how to create and customize context menu in the [Context menu sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620525) and [Context menu sample (Windows 8.1)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample).

For XAML-based desktop applications, we recommend to [use a menu flyout to implement context menus](/windows/apps/design/controls/menus-and-context-menus).
<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](/windows/uwp/threading-async/using-windows-runtime-objects-in-a-multithreaded-environment).

## -examples
Provide users with a context menu by adding an event listener for the `"contextmenu"` event. For example, the [Context menu sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample) listens for the event on specific HTML elements, and then calls the `scenario1AttachmentHandler` function.



[!code-js[addcontextmenueventlistener_js](../windows.ui.popups/code/ContextMenu/js/js/scenario1.js#Snippetaddcontextmenueventlistener_js)]

To customize the context menu, call [preventDefault](/previous-versions/windows/internet-explorer/ie-developer/platform-apis/ff975967(v=vs.85)) on the event to suppress the default, and then create a new, empty context menu as shown in the [Context menu sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample).



[!code-js[contextmenu_preventdefault](../windows.ui.popups/code/ContextMenu/js/js/scenario2.js#Snippetcontextmenu_preventdefault)]

[!code-js[newcontextmenu_js](../windows.ui.popups/code/ContextMenu/js/js/scenario1.js#Snippetnewcontextmenu_js)]


## -see-also

[Adding context menus](/previous-versions/windows/apps/hh465300(v=win.10)), [Context menu sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample), [Context menu sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620525), [Menus and context menus for desktop apps](/windows/apps/design/controls/menus), [PopupMenu.Commands](popupmenu_commands.md), [UICommand](uicommand.md), [UICommandSeparator](uicommandseparator.md), [UICommand](uicommand.md), [UICommandSeparator](uicommandseparator.md), [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects)
