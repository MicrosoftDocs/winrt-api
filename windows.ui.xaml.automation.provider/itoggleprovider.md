---
-api-id: T:Windows.UI.Xaml.Automation.Provider.IToggleProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IToggleProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.IToggleProvider

## -description
Exposes methods and properties to support Microsoft UI Automation client access to controls that can cycle through a set of states and maintain a particular state. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern.md) call and [PatternInterface.Toggle](../windows.ui.xaml.automation.peers/patterninterface.md).

## -remarks
Controls that do not maintain state when activated, such as buttons, toolbar buttons, and hyperlinks, must implement [IInvokeProvider](iinvokeprovider.md) instead. The **Toggle** pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [Toggle Control Pattern](http://msdn.microsoft.com/library/9fd1232b-199a-41e6-81b0-667c7e463d09).

[IToggleProvider](itoggleprovider.md) is implemented by these existing Windows Runtime classes:
+ [AppBarAutomationPeer](../windows.ui.xaml.automation.peers/appbarautomationpeer.md)
+ [SemanticZoomAutomationPeer](../windows.ui.xaml.automation.peers/semanticzoomautomationpeer.md)
+ [ToggleSwitchAutomationPeer](../windows.ui.xaml.automation.peers/toggleswitchautomationpeer.md)
+ [ToggleButtonAutomationPeer](../windows.ui.xaml.automation.peers/togglebuttonautomationpeer.md), which is the base class for [RadioButtonAutomationPeer](../windows.ui.xaml.automation.peers/radiobuttonautomationpeer.md) and [CheckBoxAutomationPeer](../windows.ui.xaml.automation.peers/checkboxautomationpeer.md)


Use [TogglePatternIdentifiers](../windows.ui.xaml.automation/togglepatternidentifiers.md) if you want to reference the [IToggleProvider](itoggleprovider.md) pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent.md).

## -examples

## -see-also
[TogglePatternIdentifiers](../windows.ui.xaml.automation/togglepatternidentifiers.md), [IToggleProvider (COM interface)](http://msdn.microsoft.com/library/85da8225-31b8-4b4d-81f4-ad98871b8e31), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [Toggle Control Pattern](http://msdn.microsoft.com/library/9fd1232b-199a-41e6-81b0-667c7e463d09)