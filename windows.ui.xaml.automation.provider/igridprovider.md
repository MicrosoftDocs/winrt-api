---
-api-id: T:Windows.UI.Xaml.Automation.Provider.IGridProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IGridProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.IGridProvider

## -description
Exposes methods and properties to support access by a Microsoft UI Automation client to controls that act as containers for a collection of child elements. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) call and [PatternInterface.Grid](../windows.ui.xaml.automation.peers/patterninterface.md).

## -remarks
This pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [Grid Control Pattern](http://msdn.microsoft.com/library/c50fb6f7-884a-4147-a6b2-c59d787fc04b).

[IGridProvider](igridprovider.md) isn't implemented by any existing Windows Runtime automation peers. Notably, [IGridProvider](igridprovider.md) doesn't exist for the [Grid](../windows.ui.xaml.controls/grid.md) layout container, or for [GridView](../windows.ui.xaml.controls/gridview.md). The interface exists so that custom control authors can support the automation pattern in a custom control, and implement their automation support using the same Windows Runtime managed or C++ API as they use to define control logic or other automation support.

Use [GridPatternIdentifiers](../windows.ui.xaml.automation/gridpatternidentifiers.md) if you want to reference the [IGridProvider](igridprovider.md) pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md).

## -examples

## -see-also
[GridPatternIdentifiers](../windows.ui.xaml.automation/gridpatternidentifiers.md), [IGridProvider (COM interface)](http://msdn.microsoft.com/library/37e2cc95-d765-4c2c-ae8a-5a072a43ad5a), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [Grid Control Pattern](http://msdn.microsoft.com/library/c50fb6f7-884a-4147-a6b2-c59d787fc04b)