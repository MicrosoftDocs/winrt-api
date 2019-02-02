---
-api-id: T:Windows.UI.Xaml.Automation.Provider.IVirtualizedItemProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IVirtualizedItemProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.IVirtualizedItemProvider

## -description
Exposes a method to support the virtualized item control pattern. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) call and [PatternInterface.VirtualizedItem](../windows.ui.xaml.automation.peers/patterninterface.md).

## -remarks
Controls that contain a large number of child items can use virtualization to efficiently manage the items. With virtualization, the control maintains full information in memory for only a subset of items at any given time. Typically, the subset includes only those items that are currently visible to the user. Full information about the remaining virtualized items is kept in storage and is loaded into memory, or realized, as the control needs it, for example, as new items become visible to the user. For more info on this pattern, see [VirtualizedItem Control Pattern](https://msdn.microsoft.com/library/7a95e92f-7ccb-4c9b-8986-1d2de7038e47).

[IVirtualizedItemProvider](ivirtualizeditemprovider.md) is implemented by the Windows Runtime automation peer base class [ItemAutomationPeer](../windows.ui.xaml.automation.peers/itemautomationpeer.md).

The [IVirtualizedItemProvider](ivirtualizeditemprovider.md) pattern doesn't have a pattern property identifier class, the only API to implement is a method.

## -examples

## -see-also
[IVirtualizedItemProvider (COM interface)](https://msdn.microsoft.com/library/39baaa54-b836-497c-b401-a865202626e7), [VirtualizedItem Control Pattern](https://msdn.microsoft.com/library/7a95e92f-7ccb-4c9b-8986-1d2de7038e47), [Custom automation peers](https://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4)
