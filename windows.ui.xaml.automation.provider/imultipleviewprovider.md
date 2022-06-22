---
-api-id: T:Windows.UI.Xaml.Automation.Provider.IMultipleViewProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IMultipleViewProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.IMultipleViewProvider

## -description
Exposes methods and properties to support Microsoft UI Automation client access to controls that provide, and are able to switch between, multiple representations of the same set of information or child controls. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) call and [PatternInterface.MultipleView](../windows.ui.xaml.automation.peers/patterninterface.md).



## -remarks
This pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [MultipleView Control Pattern](/windows/desktop/WinAuto/uiauto-implementingmultipleview).

IMultipleViewProvider isn't implemented by any existing Windows Runtime automation peers. Notably, IMultipleViewProvider doesn't exist for [SemanticZoom](../windows.ui.xaml.controls/semanticzoom.md). The interface exists so that custom control authors can support the automation pattern in a custom control, and implement their automation support using the same Windows Runtime managed or C++ API as they use to define control logic or other automation support.

Use [MultipleViewPatternIdentifiers](../windows.ui.xaml.automation/multipleviewpatternidentifiers.md) if you want to reference the [IGridProvider](igridprovider.md) pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](../windows.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_715050195.md).

## -examples

## -see-also
[MultipleViewPatternIdentifiers](../windows.ui.xaml.automation/multipleviewpatternidentifiers.md), [IMultipleViewProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-imultipleviewprovider), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [MultipleView Control Pattern](/windows/desktop/WinAuto/uiauto-implementingmultipleview)
