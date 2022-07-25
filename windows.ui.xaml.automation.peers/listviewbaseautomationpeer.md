---
-api-id: T:Windows.UI.Xaml.Automation.Peers.ListViewBaseAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ListViewBaseAutomationPeer : Windows.UI.Xaml.Automation.Peers.SelectorAutomationPeer, Windows.UI.Xaml.Automation.Peers.IListViewBaseAutomationPeer, Windows.UI.Xaml.Automation.Provider.IDropTargetProvider
-->

# Windows.UI.Xaml.Automation.Peers.ListViewBaseAutomationPeer

## -description
A base class that provides a Microsoft UI Automation peer implementation for types that derive from [ListViewBase](../windows.ui.xaml.controls/listviewbase.md).



## -remarks
 [ListViewBase](../windows.ui.xaml.controls/listviewbase.md) isn't used as a control class, because it is the base class for other controls. You could either derive from those other controls or derive from directly, but the latter means that you have to provide a template and a lot more behavior. If you derive from [ListViewBase](../windows.ui.xaml.controls/listviewbase.md), override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns a custom peer that is based on ListViewBaseAutomationPeer.

### Default peer implementation and overrides in **ListViewBaseAutomationPeer**

ListViewBaseAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) reports that the peer provides pattern support for [PatternInterface.DropTarget](patterninterface.md) ([IDropTargetProvider](../windows.ui.xaml.automation.provider/idroptargetprovider.md)). Pattern support for [PatternInterface.Selection](patterninterface.md) ([ISelectionProvider](../windows.ui.xaml.automation.provider/iselectionprovider.md)) and [PatternInterface.ItemContainer](patterninterface.md) ([IItemContainerProvider](../windows.ui.xaml.automation.provider/iitemcontainerprovider.md)) comes from peer base classes [SelectorAutomationPeer](selectorautomationpeer.md) and [ItemsControlAutomationPeer](itemscontrolautomationpeer.md).
+ [GetClassName](automationpeer_getclassname_614238974.md) and [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) don't have implementations. It's expected that you will implement these. A typical [GetAutomationControlTypeCore](automationpeer_getautomationcontroltypecore_1718556232.md) implementation would return [AutomationControlType.List](automationcontroltype.md).
+ [GetChildren](automationpeer_getchildren_555647254.md) has an implementation that returns the item peers. This implementation is used by derived peer classes such as [ListViewAutomationPeer](listviewautomationpeer.md).
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

### **ListViewBaseAutomationPeer** derived classes

ListViewBaseAutomationPeer is the parent class for [GridViewAutomationPeer](gridviewautomationpeer.md) and [ListViewAutomationPeer](listviewautomationpeer.md).

## -examples

## -see-also
[SelectorAutomationPeer](selectorautomationpeer.md), [IItemContainerProvider](../windows.ui.xaml.automation.provider/iitemcontainerprovider.md), [ISelectionProvider](../windows.ui.xaml.automation.provider/iselectionprovider.md), [IDropTargetProvider](../windows.ui.xaml.automation.provider/idroptargetprovider.md)
