---
-api-id: T:Windows.UI.Xaml.Automation.Provider.IWindowProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IWindowProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.IWindowProvider

## -description
Exposes methods and properties to support access by a Microsoft UI Automation client to controls that provide fundamental window-based functionality within a traditional graphical user interface (GUI). Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) call and [PatternInterface.Window](../windows.ui.xaml.automation.peers/patterninterface.md).



## -remarks
For more info on what this pattern is for, see [Window Control Pattern](/windows/desktop/WinAuto/uiauto-implementingwindow).

IWindowProvider isn't implemented by any existing Windows Runtime automation peers. The interface exists so that custom control authors can support the automation pattern in a custom control, and implement their automation support using the same Windows Runtime managed or C++ API as they use to define control logic or other automation support.

Use [WindowPatternIdentifiers](../windows.ui.xaml.automation/windowpatternidentifiers.md) if you want to reference the IWindowProvider pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md).

## -examples

## -see-also
[WindowPatternIdentifiers](../windows.ui.xaml.automation/windowpatternidentifiers.md), [IWindowProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-iwindowprovider), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Window Control Pattern](/windows/desktop/WinAuto/uiauto-implementingwindow)
