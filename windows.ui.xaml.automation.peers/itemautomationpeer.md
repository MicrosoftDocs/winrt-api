---
-api-id: T:Windows.UI.Xaml.Automation.Peers.ItemAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ItemAutomationPeer : Windows.UI.Xaml.Automation.Peers.AutomationPeer, Windows.UI.Xaml.Automation.Peers.IItemAutomationPeer, Windows.UI.Xaml.Automation.Provider.IVirtualizedItemProvider
-->

# Windows.UI.Xaml.Automation.Peers.ItemAutomationPeer

## -description
Exposes a data item in an [Items](../windows.ui.xaml.controls/itemscontrol_items.md) collection to Microsoft UI Automation.

## -remarks
 [ItemAutomationPeer](itemautomationpeer.md) is generated from items control logic and [ItemsControlAutomationPeer](itemscontrolautomationpeer.md), not an associated control class.

In addition to the typical peer implementation API, [ItemAutomationPeer](itemautomationpeer.md) has an [ItemsControlAutomationPeer](itemautomationpeer_itemscontrolautomationpeer.md) property to reference its container peer. The container peer potentially supplies the logic for [AutomationPeer](automationpeer.md) methods as called against the [ItemAutomationPeer](itemautomationpeer.md). There is also an [Item](itemautomationpeer_item.md) property that is similar in purpose to the **Owner** property on other peers (it provides the reference to the object that this peer provides the automation exposure for). Both these values must be set in the [ItemAutomationPeer](itemautomationpeer_itemautomationpeer.md) constructor.

[ItemAutomationPeer](itemautomationpeer.md) implements the [Realize](itemautomationpeer_realize.md) method in order to support the [IVirtualizedItemProvider](../windows.ui.xaml.automation.provider/ivirtualizeditemprovider.md) control pattern. Clients can call their framework's equivalent pattern access to [Realize](itemautomationpeer_realize.md) to get a non-virtualized result. This generates more information about the item in an automation tree view.

### Default peer implementation and overrides in **ItemAutomationPeer**

[ItemAutomationPeer](itemautomationpeer.md) has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern.md) reports that the peer supports [PatternInterface.VirtualizedItem](patterninterface.md) ([IVirtualizedItemProvider](../windows.ui.xaml.automation.provider/ivirtualizeditemprovider.md)). Also, there is "GetContainerPeer" logic that reports information about the item container's supported patterns.
+ [GetClassName](automationpeer_getclassname.md) uses "GetContainerPeer" logic to get class name information. If there is no container peer, calling [GetClassName](automationpeer_getclassname.md) throws [ElementNotAvailableException](https://msdn.microsoft.com/library/system.windows.automation.elementnotavailableexception).
+ [GetName](automationpeer_getname.md) uses "GetContainerPeer" logic but if no container peer exists it will use a basic `ToString()` logic to try and generate a default automation name from the item content.
+ [GetAutomationControlType](automationpeer_getautomationcontroltype.md) uses "GetContainerPeer" logic to get control type information. If there is no container peer, returns [AutomationControlType.ListItem](automationcontroltype.md).
+  "GetContainerPeer" logic is used to forward most of the other [AutomationPeer](automationpeer.md) methods from the container peer implementations if possible. For example, [IsControlElement](automationpeer_iscontrolelement.md) might check the container peer first. Some of these [AutomationPeer](automationpeer.md) methods will throw [ElementNotAvailableException](https://msdn.microsoft.com/library/system.windows.automation.elementnotavailableexception) if there is no container peer available.
This is one of the only peer classes in the Windows Runtime support for Microsoft UI Automation that does not use [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) as a base class.

### **ItemAutomationPeer** derived classes

[ItemAutomationPeer](itemautomationpeer.md) is the parent class for [SelectorItemAutomationPeer](selectoritemautomationpeer.md).

## -examples

## -see-also
[AutomationPeer](automationpeer.md), [IVirtualizedItemProvider](../windows.ui.xaml.automation.provider/ivirtualizeditemprovider.md)