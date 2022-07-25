---
-api-id: T:Windows.UI.Xaml.Automation.Provider.ISelectionItemProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ISelectionItemProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.ISelectionItemProvider

## -description
Exposes methods and properties to support access by a Microsoft UI Automation client to individual, selectable child controls of containers that implement [ISelectionProvider](iselectionprovider.md). Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) call and [PatternInterface.SelectionItem](../windows.ui.xaml.automation.peers/patterninterface.md).



## -remarks
This pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [SelectionItem Control Pattern](/windows/desktop/WinAuto/uiauto-implementingselectionitem). However, you don't need to follow the guidance regarding [IRawElementProviderFragmentRoot](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-irawelementproviderfragmentroot), that is specific to COM provider implementations and the interface doesn't exist in the Windows Runtime automation provider API.

ISelectionItemProvider is implemented by these existing Windows Runtime classes:
+ [RadioButtonAutomationPeer](../windows.ui.xaml.automation.peers/radiobuttonautomationpeer.md)
+ [SelectorItemAutomationPeer](../windows.ui.xaml.automation.peers/selectoritemautomationpeer.md)


Use [SelectionItemPatternIdentifiers](../windows.ui.xaml.automation/selectionitempatternidentifiers.md) if you want to reference the ISelectionItemProvider pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md).

## -examples

## -see-also
[SelectionItemPatternIdentifiers](../windows.ui.xaml.automation/selectionitempatternidentifiers.md), [ISelectionItemProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-iselectionitemprovider), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [SelectionItem Control Pattern](/windows/desktop/WinAuto/uiauto-implementingselectionitem)
