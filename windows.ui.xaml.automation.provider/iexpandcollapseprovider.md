---
-api-id: T:Windows.UI.Xaml.Automation.Provider.IExpandCollapseProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IExpandCollapseProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.IExpandCollapseProvider

## -description
Exposes methods and properties to support access by a Microsoft UI Automation client to controls that visually expand to display content and that collapse to hide content. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) call and [PatternInterface.ExpandCollapse](../windows.ui.xaml.automation.peers/patterninterface.md).

## -remarks
This pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [ExpandCollapse Control Pattern](https://msdn.microsoft.com/library/0ffc26c3-8696-44f9-b463-902a69e06d21).

[IExpandCollapseProvider](iexpandcollapseprovider.md) is implemented by the existing Windows Runtime automation peer for [ComboBox](../windows.ui.xaml.controls/combobox.md) ([ComboBoxAutomationPeer](../windows.ui.xaml.automation.peers/comboboxautomationpeer.md)).

Use [ExpandCollapsePatternIdentifiers](../windows.ui.xaml.automation/expandcollapsepatternidentifiers.md) if you want to reference the [IExpandCollapseProvider](iexpandcollapseprovider.md) pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md).

## -examples

## -see-also
[ExpandCollapsePatternIdentifiers](../windows.ui.xaml.automation/expandcollapsepatternidentifiers.md), [IExpandCollapseProvider (COM interface)](https://msdn.microsoft.com/library/59d91498-54f8-40df-8224-52ff8e45f6c3), [Custom automation peers](https://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [ExpandCollapse Control Pattern](https://msdn.microsoft.com/library/0ffc26c3-8696-44f9-b463-902a69e06d21)
