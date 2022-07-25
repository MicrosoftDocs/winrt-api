---
-api-id: T:Windows.UI.Xaml.Automation.Peers.ListViewAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ListViewAutomationPeer : Windows.UI.Xaml.Automation.Peers.ListViewBaseAutomationPeer, Windows.UI.Xaml.Automation.Peers.IListViewAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.ListViewAutomationPeer

## -description
Exposes [ListView](../windows.ui.xaml.controls/listview.md) types to Microsoft UI Automation.



## -remarks
The Windows Runtime  [ListView](../windows.ui.xaml.controls/listview.md) class creates a new ListViewAutomationPeer as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from ListViewAutomationPeer if you are deriving a custom class from [ListView](../windows.ui.xaml.controls/listview.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **ListViewAutomationPeer**

ListViewAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) reports that the peer provides pattern support for these patterns:
  + [PatternInterface.Selection](patterninterface.md) ([ISelectionProvider](../windows.ui.xaml.automation.provider/iselectionprovider.md))
  + [PatternInterface.ItemContainer](patterninterface.md) ([IItemContainerProvider](../windows.ui.xaml.automation.provider/iitemcontainerprovider.md))
  + [PatternInterface.DropTarget](patterninterface.md) ([IDropTargetProvider](../windows.ui.xaml.automation.provider/idroptargetprovider.md) )
  + This is the accumulated pattern support from each of the peer base classes.

+ [GetClassName](automationpeer_getclassname_614238974.md) returns "ListView".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.List](automationcontroltype.md).
+ [GetChildren](automationpeer_getchildren_555647254.md) has an implementation from [ListViewBaseAutomationPeer](listviewbaseautomationpeer.md) that returns the item peers.
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

The API that supports the control patterns is all on [ListViewBaseAutomationPeer](listviewbaseautomationpeer.md), [SelectorAutomationPeer](selectorautomationpeer.md) or [ItemsControlAutomationPeer](itemscontrolautomationpeer.md).

## -examples

## -see-also
[ListView](../windows.ui.xaml.controls/listview.md), [ListViewBaseAutomationPeer](listviewbaseautomationpeer.md), [ItemsControlAutomationPeer](itemscontrolautomationpeer.md), [SelectorAutomationPeer](selectorautomationpeer.md), [IItemContainerProvider](../windows.ui.xaml.automation.provider/iitemcontainerprovider.md), [ISelectionProvider](../windows.ui.xaml.automation.provider/iselectionprovider.md), [IDropTargetProvider](../windows.ui.xaml.automation.provider/idroptargetprovider.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
