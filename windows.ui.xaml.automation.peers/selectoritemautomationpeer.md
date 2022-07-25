---
-api-id: T:Windows.UI.Xaml.Automation.Peers.SelectorItemAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class SelectorItemAutomationPeer : Windows.UI.Xaml.Automation.Peers.ItemAutomationPeer, Windows.UI.Xaml.Automation.Peers.ISelectorItemAutomationPeer, Windows.UI.Xaml.Automation.Provider.ISelectionItemProvider
-->

# Windows.UI.Xaml.Automation.Peers.SelectorItemAutomationPeer

## -description
Exposes the items in a [Selector](../windows.ui.xaml.controls.primitives/selector.md) to Microsoft UI Automation.



## -remarks
The Windows Runtime  SelectorItemAutomationPeer is created by selected item logic in [SelectorAutomationPeer](selectorautomationpeer.md), not by invoking a [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition on [SelectorItem](../windows.ui.xaml.controls.primitives/selectoritem.md). Derive an automation peer from SelectorItemAutomationPeer if you are also creating a peer based on [SelectorAutomationPeer](selectorautomationpeer.md) and want to change the selected-item automation info.

### Default peer implementation and overrides in **SelectorItemAutomationPeer**

SelectorItemAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) reports that the peer provides pattern support for [PatternInterface.SelectionItem](patterninterface.md) ([ISelectionItemProvider](../windows.ui.xaml.automation.provider/iselectionitemprovider.md)). The base [ItemAutomationPeer](itemautomationpeer.md) reports support for .
+ [GetClassName](automationpeer_getclassname_614238974.md) and [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) don't have implementations. It's expected that you will implement these. A typical [GetAutomationControlTypeCore](automationpeer_getautomationcontroltypecore_1718556232.md) implementation would return [AutomationControlType.ListItem](automationcontroltype.md) or [AutomationControlType.DataItem](automationcontroltype.md).
The peer handles selection pattern logic so that a number of existing derived peers like [ListBoxItemAutomationPeer](listboxitemautomationpeer.md) can inherit automation support that parallels the base [Selector](../windows.ui.xaml.controls.primitives/selector.md) behavior.

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).[SelectorItem](../windows.ui.xaml.controls.primitives/selectoritem.md)

### **SelectorItemAutomationPeer** derived classes

SelectorItemAutomationPeer is the parent class for these classes:
+ [ComboBoxItemDataAutomationPeer](comboboxitemdataautomationpeer.md)
+ [FlipViewItemDataAutomationPeer](flipviewitemdataautomationpeer.md)
+ [GridViewItemDataAutomationPeer](gridviewitemdataautomationpeer.md)
+ [ListBoxItemDataAutomationPeer](listboxitemdataautomationpeer.md)
+ [ListViewItemDataAutomationPeer](listviewitemdataautomationpeer.md)


## -examples

## -see-also
[SelectorItem](../windows.ui.xaml.controls.primitives/selectoritem.md), [ItemAutomationPeer](itemautomationpeer.md), [ISelectionItemProvider](../windows.ui.xaml.automation.provider/iselectionitemprovider.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
