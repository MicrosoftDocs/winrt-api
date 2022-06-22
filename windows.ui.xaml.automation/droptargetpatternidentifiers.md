---
-api-id: T:Windows.UI.Xaml.Automation.DropTargetPatternIdentifiers
-api-type: winrt class
---

<!-- Class syntax.
public class DropTargetPatternIdentifiers : Windows.UI.Xaml.Automation.IDropTargetPatternIdentifiers
-->

# Windows.UI.Xaml.Automation.DropTargetPatternIdentifiers

## -description
Contains values used as identifiers by [IDropTargetProvider](../windows.ui.xaml.automation.provider/idroptargetprovider.md).



## -remarks
Classes such as DropTargetPatternIdentifiers are the identifiers for the Windows Runtime implementation of a common provider pattern for Microsoft UI Automation. You might use these identifiers if you are implementing a Windows Runtime custom automation peer that reports support for [IDropTargetProvider](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-idroptargetprovider) in its [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) implementation. These identifiers are needed for the [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md) calls that you make from control code that references your own peer, or for [FindItemByProperty](../windows.ui.xaml.automation.provider/iitemcontainerprovider_finditembyproperty_1997743353.md) in an items container peer.

This same pattern is usually exposed to clients in a different way, depending on which technology they use to implement the client and examine the Microsoft UI Automation tree. [IDropTargetProvider](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-idroptargetprovider) is also presented as a Component Object Model (COM) interface.

## -examples

## -see-also
[IDropTargetProvider](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-idroptargetprovider), [Control patterns and interfaces](/windows/uwp/accessibility/control-patterns-and-interfaces), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
