---
-api-id: T:Windows.UI.Xaml.Automation.WindowPatternIdentifiers
-api-type: winrt class
---

<!-- Class syntax.
public class WindowPatternIdentifiers : Windows.UI.Xaml.Automation.IWindowPatternIdentifiers
-->

# Windows.UI.Xaml.Automation.WindowPatternIdentifiers

## -description
Contains values used as identifiers by [IWindowProvider](../windows.ui.xaml.automation.provider/iwindowprovider.md).



## -remarks
Classes such as WindowPatternIdentifiers are the identifiers for the Windows Runtime implementation of a common provider pattern for Microsoft UI Automation. You might use these identifiers if you are implementing a Windows Runtime custom automation peer that reports support for [IWindowProvider](../windows.ui.xaml.automation.provider/iwindowprovider.md) in its [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) implementation. These identifiers are needed for the [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md) calls that you make from control code that references your own peer, or for [FindItemByProperty](../windows.ui.xaml.automation.provider/iitemcontainerprovider_finditembyproperty_1997743353.md) in an items container peer. Using this pattern for controls is fairly uncommon.

This same pattern is usually exposed to clients in a different way, depending on which technology they use to implement the client and examine the Microsoft UI Automation tree. [IWindowProvider](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-iwindowprovider) is also presented as a Component Object Model (COM) interface.

## -examples

## -see-also
[IWindowProvider](../windows.ui.xaml.automation.provider/iwindowprovider.md), [Control patterns and interfaces](/windows/uwp/accessibility/control-patterns-and-interfaces), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
