---
-api-id: T:Windows.UI.Xaml.Automation.Provider.IScrollProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IScrollProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.IScrollProvider

## -description
Exposes methods and properties to support access by a Microsoft UI Automation client to a control that acts as a scrollable container for a collection of child objects. The children of this element must implement [IScrollItemProvider](iscrollitemprovider.md). Implement [IScrollProvider](iscrollprovider.md) in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) call and [PatternInterface.Scroll](../windows.ui.xaml.automation.peers/patterninterface.md).

## -remarks
This pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [Scroll Control Pattern](https://msdn.microsoft.com/library/baf8012a-52d5-4465-b26d-aa3d7f550b54).

[IScrollProvider](iscrollprovider.md) is implemented by the existing Windows Runtime class [ScrollViewerAutomationPeer](../windows.ui.xaml.automation.peers/scrollviewerautomationpeer.md), which is the peer for the [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) component part used in many other list controls.

Also, [IScrollProvider](iscrollprovider.md) is reported as a supported pattern by [ItemsControlAutomationPeer](../windows.ui.xaml.automation.peers/itemscontrolautomationpeer.md), but only if a [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) exists in the owner's template and is active. The [ScrollViewerAutomationPeer](../windows.ui.xaml.automation.peers/scrollviewerautomationpeer.md) for this [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) provides the pattern implementation, [ItemsControlAutomationPeer](../windows.ui.xaml.automation.peers/itemscontrolautomationpeer.md) is only forwarding it.

Use [ScrollPatternIdentifiers](../windows.ui.xaml.automation/scrollpatternidentifiers.md) if you want to reference the [IScrollProvider](iscrollprovider.md) pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md).

## -examples

## -see-also
[IScrollItemProvider](iscrollitemprovider.md), [IScrollProvider (COM interface)](https://msdn.microsoft.com/library/55e1b899-aa9f-45eb-9cfa-d645ea659988), [ScrollViewerAutomationPeer](../windows.ui.xaml.automation.peers/scrollviewerautomationpeer.md), [Custom automation peers](https://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [Scroll Control Pattern](https://msdn.microsoft.com/library/baf8012a-52d5-4465-b26d-aa3d7f550b54)
