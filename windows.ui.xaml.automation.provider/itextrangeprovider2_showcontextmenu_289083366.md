---
-api-id: M:Windows.UI.Xaml.Automation.Provider.ITextRangeProvider2.ShowContextMenu
-api-type: winrt method
---

<!-- Method syntax
public void ShowContextMenu()
-->

# Windows.UI.Xaml.Automation.Provider.ITextRangeProvider2.ShowContextMenu

## -description
Shows the available context menu for the owner element.



## -remarks
From the client perspective, [ShowContextMenu](../windows.ui.xaml.automation.peers/automationpeer_showcontextmenu_289083366.md) isn't intended for general cases where an app defines the UI and also defines a discrete UI element that is presented as a menu, flyout, or other UI metaphor as a result of handling an app input event. Such context menus are already controllable for automation and should appear in expected locations in a Microsoft UI Automation tree once that context is entered. [ShowContextMenu](../windows.ui.xaml.automation.peers/automationpeer_showcontextmenu_289083366.md) is specifically intended for cases where text entry into a text control results in that control displaying UI elements that aren't specified by the app's XAML or code, which come from the control's internal logic or templated states. These context menus typically present the UI for a service operation that the text control supports and that the user is expected to interact with before they can exit that context. Some example control scenarios are input method editors handling text at the input level and presenting completion choices, or auto-complete and spell-checking for text input in a [TextBox](../windows.ui.xaml.controls/textbox.md) or similar control.

## -examples

## -see-also
[AutomationPeer.ShowContextMenu](../windows.ui.xaml.automation.peers/automationpeer_showcontextmenu_289083366.md)
