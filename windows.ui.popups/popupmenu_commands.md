---
-api-id: P:Windows.UI.Popups.PopupMenu.Commands
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.UI.Popups.IUICommand> Commands { get; }
-->

# Windows.UI.Popups.PopupMenu.Commands

## -description
Gets the commands for the context menu.

## -property-value
The commands for the context menu.

## -remarks
You can see complete code examples that demonstrate how to create and customize context menus in the [Context menu sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample).

## -examples
Add your commands to the context menu after you create a new [PopupMenu](popupmenu.md). Create a [UICommand](uicommand.md) object for each command and append the commands to the context menu.

The [Context menu sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample) creates and appends a new [UICommand](uicommand.md) that specifies a handler function, which runs if the command is invoked.



[!code-js[addcommandwithhandler_js](../windows.ui.popups/code/ContextMenu/js/js/scenario1.js#Snippetaddcommandwithhandler_js)]

The [Context menu sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample) also creates and appends a new [UICommand](uicommand.md) that specifies a command identifier, which can be used to determine the command that has been invoked.



[!code-js[addcommandwithid_js](../windows.ui.popups/code/ContextMenu/js/js/scenario2.js#Snippetaddcommandwithid_js)]

The [Context menu sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample) places a separator between its `"Copy"` and `"Highlight"` commands like this.



[!code-js[addcommandswithidsandseparator_js](../windows.ui.popups/code/ContextMenu/js/js/scenario2.js#Snippetaddcommandswithidsandseparator_js)]

## -see-also
[Adding context menus](/previous-versions/windows/apps/hh465300(v=win.10)), [Context menu sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Context%20menu%20sample), [Guidelines and checklist for ](/windows/uwp/design/controls-and-patterns/index), [IUICommand](iuicommand.md), [IVector(IUICommand)](../windows.foundation.collections/ivector_1.md), [PopupMenu.PopupMenu](popupmenu_popupmenu_1221375020.md), [UICommand](uicommand.md), [UICommandInvokedHandler](uicommandinvokedhandler.md), [UICommandSeparator](uicommandseparator.md)