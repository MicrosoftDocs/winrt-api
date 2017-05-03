---
-api-id: T:Windows.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ItemsControlAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IItemsControlAutomationPeer, Windows.UI.Xaml.Automation.Peers.IItemsControlAutomationPeer2, Windows.UI.Xaml.Automation.Peers.IItemsControlAutomationPeerOverrides2, Windows.UI.Xaml.Automation.Provider.IItemContainerProvider
-->

# Windows.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer

## -description
Exposes [ItemsControl](../windows.ui.xaml.controls/itemscontrol.md) types to Microsoft UI Automation.

## -remarks
The Windows Runtime  [ItemsControl](../windows.ui.xaml.controls/itemscontrol.md) class creates a new [ItemsControlAutomationPeer](itemscontrolautomationpeer.md) as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from [ItemsControlAutomationPeer](itemscontrolautomationpeer.md) if you are deriving a custom class from [ItemsControl](../windows.ui.xaml.controls/itemscontrol.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer. Make sure though that there aren't any existing derived classes from [ItemsControl](../windows.ui.xaml.controls/itemscontrol.md) that might better suit your scenario. For example, [Selector](../windows.ui.xaml.controls.primitives/selector.md), [FlipView](../windows.ui.xaml.controls/flipview.md), [GridView](../windows.ui.xaml.controls/gridview.md), [ComboBox](../windows.ui.xaml.controls/combobox.md), [ListViewBase](../windows.ui.xaml.controls/listviewbase.md) and [ListBox](../windows.ui.xaml.controls/listbox.md) are all a type of [ItemsControl](../windows.ui.xaml.controls/itemscontrol.md). Each of these already has a dedicated automation peer.

### Default peer implementation and overrides in **ItemsControlAutomationPeer**

[ItemsControlAutomationPeer](itemscontrolautomationpeer.md) has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern.md) reports that the peer provides pattern support for [PatternInterface.ItemContainer](patterninterface.md) ([IItemContainerProvider](../windows.ui.xaml.automation.provider/iitemcontainerprovider.md)). Also, there's logic that looks for scrolling behavior in the owner. If there's scrolling available and a peer can be forwarded to provide the control pattern, the peer can support [PatternInterface.Scroll](patterninterface.md) ([IScrollProvider](../windows.ui.xaml.automation.provider/iscrollprovider.md)).
+ There is no [GetClassName](automationpeer_getclassname.md) and [GetAutomationControlType](automationpeer_getautomationcontroltype.md) is **Custom**. These values are expected to come from derived peers.
+ [GetChildren](automationpeer_getchildren.md) has an extensive implementation that returns the item peers and is used by all the derived peers.
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4).

> For Windows Phone Store app, [ItemsControlAutomationPeer](itemscontrolautomationpeer.md) has methods that support creating item-specific automation peers for data items. See [CreateItemAutomationPeer](itemscontrolautomationpeer_createitemautomationpeer.md) and [OnCreateItemAutomationPeer](itemscontrolautomationpeer_oncreateitemautomationpeer.md).

### **ItemsControlAutomationPeer** derived classes

[ItemsControlAutomationPeer](itemscontrolautomationpeer.md) is the parent class for [SelectorAutomationPeer](selectorautomationpeer.md).

## -examples

## -see-also
[ItemsControl](../windows.ui.xaml.controls/itemscontrol.md), [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [IItemContainerProvider](../windows.ui.xaml.automation.provider/iitemcontainerprovider.md), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4)