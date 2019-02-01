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
A docking container is a control that allows you to arrange child elements horizontally and vertically, relative to each other. For more info on what this pattern is for, see [Dock Control Pattern](https://msdn.microsoft.com/library/a6ea269b-632e-48ce-ac3b-edd7cc34d986).

[IDockProvider](idockprovider.md) isn't implemented by any existing Windows Runtime automation peers. The interface exists so that custom control authors can support the automation pattern in a custom control, and implement their automation support using the same Windows Runtime managed or C++ API as they use to define control logic or other automation support.

Use [DockPatternIdentifiers](../windows.ui.xaml.automation/dockpatternidentifiers.md) if you want to reference the [IDockProvider](idockprovider.md) pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md).

## -examples

## -see-also
[DockPatternIdentifiers](../windows.ui.xaml.automation/dockpatternidentifiers.md), [IDockProvider (COM interface)](https://msdn.microsoft.com/library/106ca4b4-1304-4942-88a4-79a3895b552f), [Custom automation peers](https://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [Dock Control Pattern](https://msdn.microsoft.com/library/a6ea269b-632e-48ce-ac3b-edd7cc34d986)
