---
-api-id: T:Windows.UI.Xaml.Automation.Provider.ISelectionProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ISelectionProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.ISelectionProvider

## -description
Exposes methods and properties to support access by a Microsoft UI Automation client to controls that act as containers for a collection of individual, selectable child items. The children of this element must implement [ISelectionItemProvider](iselectionitemprovider.md). Implement ISelectionProvider in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) call and [PatternInterface.SelectionItem](../windows.ui.xaml.automation.peers/patterninterface.md).



## -remarks
This pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [Selection Control Pattern](/windows/desktop/WinAuto/uiauto-implementingselection). However, you don't need to follow the guidance regarding [IRawElementProviderFragmentRoot](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-irawelementproviderfragmentroot), that is specific to COM provider implementations and the interface doesn't exist in the Windows Runtime automation provider API.

ISelectionProvider is implemented by the existing Windows Runtime class [SelectorAutomationPeer](../windows.ui.xaml.automation.peers/selectorautomationpeer.md), which is the base class for [ComboBoxAutomationPeer](../windows.ui.xaml.automation.peers/comboboxautomationpeer.md) and [ListBoxAutomationPeer](../windows.ui.xaml.automation.peers/listboxautomationpeer.md).

Use [SelectionPatternIdentifiers](../windows.ui.xaml.automation/selectionpatternidentifiers.md) if you want to reference the ISelectionProvider pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md).

## -examples

## -see-also
[SelectionPatternIdentifiers](../windows.ui.xaml.automation/selectionpatternidentifiers.md), [Selector](../windows.ui.xaml.controls.primitives/selector.md), [ISelectionProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-iselectionprovider), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Selection Control Pattern](/windows/desktop/WinAuto/uiauto-implementingselection)
