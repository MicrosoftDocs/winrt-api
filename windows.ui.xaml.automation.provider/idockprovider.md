---
-api-id: T:Windows.UI.Xaml.Automation.Provider.IDockProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IDockProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.IDockProvider

## -description
Exposes methods and properties to support access by a Microsoft UI Automation client to controls that expose their dock properties in a docking container. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) call and [PatternInterface.Dock](../windows.ui.xaml.automation.peers/patterninterface.md).



## -remarks
A docking container is a control that allows you to arrange child elements horizontally and vertically, relative to each other. For more info on what this pattern is for, see [Dock Control Pattern](/windows/desktop/WinAuto/uiauto-implementingdock).

IDockProvider isn't implemented by any existing Windows Runtime automation peers. The interface exists so that custom control authors can support the automation pattern in a custom control, and implement their automation support using the same Windows Runtime managed or C++ API as they use to define control logic or other automation support.

Use [DockPatternIdentifiers](../windows.ui.xaml.automation/dockpatternidentifiers.md) if you want to reference the IDockProvider pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md).

## -examples

## -see-also
[DockPatternIdentifiers](../windows.ui.xaml.automation/dockpatternidentifiers.md), [IDockProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-idockprovider), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Dock Control Pattern](/windows/desktop/WinAuto/uiauto-implementingdock)
