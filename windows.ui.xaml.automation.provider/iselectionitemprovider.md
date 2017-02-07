---
-api-id: T:Windows.UI.Xaml.Automation.Provider.ISelectionItemProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ISelectionItemProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.ISelectionItemProvider

## -description
Exposes methods and properties to support access by a Microsoft UI Automation client to individual, selectable child controls of containers that implement [ISelectionProvider](iselectionprovider.md). Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern.md) call and [PatternInterface.SelectionItem](../windows.ui.xaml.automation.peers/patterninterface.md).

## -remarks
This pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [SelectionItem Control Pattern](http://msdn.microsoft.com/library/9314547f-7062-42db-b6a7-8a8eaef21d4e). However, you don't need to follow the guidance regarding [IRawElementProviderFragmentRoot](http://msdn.microsoft.com/library/16e51962-915e-40ea-a7a1-6f5a5809ba05), that is specific to COM provider implementations and the interface doesn't exist in the Windows Runtime automation provider API.

[ISelectionItemProvider](iselectionitemprovider.md) is implemented by these existing Windows Runtime classes:
+ [RadioButtonAutomationPeer](../windows.ui.xaml.automation.peers/radiobuttonautomationpeer.md)
+ [SelectorItemAutomationPeer](../windows.ui.xaml.automation.peers/selectoritemautomationpeer.md)


Use [SelectionItemPatternIdentifiers](../windows.ui.xaml.automation/selectionitempatternidentifiers.md) if you want to reference the [ISelectionItemProvider](iselectionitemprovider.md) pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent.md).

## -examples

## -see-also
[SelectionItemPatternIdentifiers](../windows.ui.xaml.automation/selectionitempatternidentifiers.md), [ISelectionItemProvider (COM interface)](http://msdn.microsoft.com/library/464b05e3-06da-44b9-b4a6-c64452fcdb6d), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [SelectionItem Control Pattern](http://msdn.microsoft.com/library/9314547f-7062-42db-b6a7-8a8eaef21d4e)