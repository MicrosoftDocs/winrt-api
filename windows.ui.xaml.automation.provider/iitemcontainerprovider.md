---
-api-id: T:Windows.UI.Xaml.Automation.Provider.IItemContainerProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IItemContainerProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.IItemContainerProvider

## -description
Exposes a Microsoft UI Automation method to enable applications to find an element in a container, such as a virtualized list. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) call and [PatternInterface.ItemContainer](../windows.ui.xaml.automation.peers/patterninterface.md).

## -remarks
Controls that contain a large number of child items can use virtualization to efficiently manage the items. With virtualization, the control maintains full information in memory for only a subset of items at any given time. Typically, the subset includes only those items that are currently visible to the user. Full information about the remaining virtualized items is kept in storage and is loaded into memory, or realized, as the control needs it, for example, as new items become visible to the user. A related pattern is [IVirtualizedItemProvider](ivirtualizeditemprovider.md). For more info on what this pattern is for, see [ItemContainer Control Pattern](https://msdn.microsoft.com/library/6f3dd94e-3563-4a13-9db9-5928a02bab77).

[IItemContainerProvider](iitemcontainerprovider.md) is implemented by the existing Windows Runtime automation peers for various list controls or views, controls that share the base class [ItemsControl](../windows.ui.xaml.controls/itemscontrol.md). Each of these peers inherits from [ItemsControlAutomationPeer](../windows.ui.xaml.automation.peers/itemscontrolautomationpeer.md), and [ItemsControlAutomationPeer](../windows.ui.xaml.automation.peers/itemscontrolautomationpeer.md) provides the common [FindItemByProperty](../windows.ui.xaml.automation.peers/itemscontrolautomationpeer_finditembyproperty_1997743353.md) implementation.

The [IItemContainerProvider](iitemcontainerprovider.md) pattern doesn't have a pattern property identifier class, the only API to implement is [FindItemByProperty](iitemcontainerprovider_finditembyproperty_1997743353.md), a method.

## -examples

## -see-also
[IVirtualizedItemProvider](ivirtualizeditemprovider.md), [IItemContainerProvider (COM interface)](https://msdn.microsoft.com/library/403436f5-7540-455b-965e-e2e3b64ef7e0), [Custom automation peers](https://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [ItemContainer Control Pattern](https://msdn.microsoft.com/library/6f3dd94e-3563-4a13-9db9-5928a02bab77)
