---
-api-id: T:Windows.UI.Xaml.Automation.Peers.SelectorAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class SelectorAutomationPeer : Windows.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer, Windows.UI.Xaml.Automation.Peers.ISelectorAutomationPeer, Windows.UI.Xaml.Automation.Provider.ISelectionProvider
-->

# Windows.UI.Xaml.Automation.Peers.SelectorAutomationPeer

## -description
A base class that provides a Microsoft UI Automation peer implementation for types that derive from [Selector](../windows.ui.xaml.controls.primitives/selector.md).



## -remarks
The Windows Runtime  [Selector](../windows.ui.xaml.controls.primitives/selector.md) class creates a new SelectorAutomationPeer as part of internal logic that checks for listeners of certain automation events. [Selector](../windows.ui.xaml.controls.primitives/selector.md) doesn't have an [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) that automatically hooks up the peer on creation, because [Selector](../windows.ui.xaml.controls.primitives/selector.md) is usually a base class.

 [Selector](../windows.ui.xaml.controls.primitives/selector.md) has several derived classes such as [ListBox](../windows.ui.xaml.controls/listbox.md), which have template support and practical implementations of some important functionality. Make sure that you really want to derive from the base class. If you're sure you want to derive from [Selector](../windows.ui.xaml.controls.primitives/selector.md), directly, derive your automation peer from SelectorAutomationPeer and override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **SelectorAutomationPeer**

SelectorAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) reports that the peer provides pattern support for [PatternInterface.Selection](patterninterface.md) ([ISelectionProvider](../windows.ui.xaml.automation.provider/iselectionprovider.md)). The base [ItemsControlAutomationPeer](itemscontrolautomationpeer.md) reports support for [PatternInterface.ItemContainer](patterninterface.md) ([IItemContainerProvider](../windows.ui.xaml.automation.provider/iitemcontainerprovider.md)).
+ [GetClassName](automationpeer_getclassname_614238974.md) is not implemented. Make sure to provide an implementation that returns your class name.
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.List](automationcontroltype.md).
This peer raises selection-related automation events on behalf of its owner class.

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

### **SelectorAutomationPeer** derived classes

SelectorAutomationPeer is the parent class for these classes:
+ [ComboBoxAutomationPeer](comboboxautomationpeer.md)
+ [FlipViewAutomationPeer](flipviewautomationpeer.md)
+ [ListBoxAutomationPeer](listboxautomationpeer.md)
+ [ListViewBaseAutomationPeer](listviewbaseautomationpeer.md)


## -examples

## -see-also
[Selector](../windows.ui.xaml.controls.primitives/selector.md), [ItemsControlAutomationPeer](itemscontrolautomationpeer.md), [IItemContainerProvider](../windows.ui.xaml.automation.provider/iitemcontainerprovider.md), [ISelectionProvider](../windows.ui.xaml.automation.provider/iselectionprovider.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
