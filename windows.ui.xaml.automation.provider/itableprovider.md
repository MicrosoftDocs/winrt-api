---
-api-id: T:Windows.UI.Xaml.Automation.Provider.ITableProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ITableProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.ITableProvider

## -description
Exposes methods and properties to support access by a Microsoft UI Automation client to controls that act as containers for a collection of child elements. The children of this element must implement [ITableItemProvider](itableitemprovider.md) and be organized in a two-dimensional logical coordinate system that can be traversed (a Microsoft UI Automation client can move to adjacent controls, which are headers or cells of the table) by using the keyboard.



## -remarks
This pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [Table Control Pattern](/windows/desktop/WinAuto/uiauto-implementingtable).

ITableProvider isn't implemented by any existing Windows Runtime automation peers. The interface exists so that custom control authors can support the automation pattern in a custom control, and implement their automation support using the same Windows Runtime managed or C++ API as they use to define control logic or other automation support.

Use [TablePatternIdentifiers](../windows.ui.xaml.automation/tablepatternidentifiers.md) if you want to reference the ITableProvider pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md).

## -examples

## -see-also
[IGridProvider](igridprovider.md), [ITableItemProvider](itableitemprovider.md), [ITableProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-itableprovider), [Table Control Pattern](/windows/desktop/WinAuto/uiauto-implementingtable), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
