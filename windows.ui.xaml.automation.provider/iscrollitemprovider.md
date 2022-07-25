---
-api-id: T:Windows.UI.Xaml.Automation.Provider.IScrollItemProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IScrollItemProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.IScrollItemProvider

## -description
Exposes methods and properties to support access by Microsoft UI Automation client to individual child controls of containers that implement [IScrollProvider](iscrollprovider.md). Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) call and [PatternInterface.ScrollItem](../windows.ui.xaml.automation.peers/patterninterface.md).



## -remarks
This control pattern acts as a communication channel between a child control and its container to ensure that the container can change the currently visible content (or region) within its viewport to display the child control. The pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [ScrollItem Control Pattern](/windows/desktop/WinAuto/uiauto-implementingscrollitem).

IScrollItemProvider is implemented by these existing Windows Runtime classes:
+ [ComboBoxItemDataAutomationPeer](../windows.ui.xaml.automation.peers/comboboxitemdataautomationpeer.md)
+ [FlipViewItemDataAutomationPeer](../windows.ui.xaml.automation.peers/flipviewitemdataautomationpeer.md)
+ [ListBoxItemDataAutomationPeer](../windows.ui.xaml.automation.peers/listboxitemdataautomationpeer.md)
+ internal base class of [ListViewItemDataAutomationPeer](../windows.ui.xaml.automation.peers/listviewitemdataautomationpeer.md) and [GridViewItemDataAutomationPeer](../windows.ui.xaml.automation.peers/gridviewitemdataautomationpeer.md)


The IScrollItemProvider pattern doesn't have a pattern property identifier class, the only API to implement is [ScrollIntoView](iscrollitemprovider_scrollintoview_1265805467.md), a method.

## -examples

## -see-also
[IScrollProvider](iscrollprovider.md), [IScrollItemProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-iscrollitemprovider), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [ScrollItem Control Pattern](/windows/desktop/WinAuto/uiauto-implementingscrollitem)
