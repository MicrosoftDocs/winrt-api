---
-api-id: T:Windows.UI.Xaml.Automation.Provider.IInvokeProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IInvokeProvider : 
-->

# Windows.UI.Xaml.Automation.Provider.IInvokeProvider

## -description
Exposes a method to support Microsoft UI Automation access to controls that initiate or perform a single, unambiguous action and do not maintain state when activated. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](../windows.ui.xaml.automation.peers/automationpeer_getpattern_2046576749.md) call and [PatternInterface.Invoke](../windows.ui.xaml.automation.peers/patterninterface.md).



## -remarks
An example of a control that meets the guidelines of IInvokeProvider is [Button](../windows.ui.xaml.controls/button.md). Controls that do maintain state, such as check boxes and radio buttons, must instead implement [IToggleProvider](itoggleprovider.md) and [ISelectionProvider](iselectionprovider.md) respectively. Controls implement IInvokeProvider if the same behavior is not exposed through another control pattern provider. For more info on what this pattern is for, see [Invoke Control Pattern](/windows/desktop/WinAuto/uiauto-implementinginvoke).

IInvokeProvider is implemented by the existing Windows Runtime automation peers for [Button](../windows.ui.xaml.controls/button.md) ([ButtonAutomationPeer](../windows.ui.xaml.automation.peers/buttonautomationpeer.md)), [RepeatButton](../windows.ui.xaml.controls.primitives/repeatbutton.md) ([RepeatButtonAutomationPeer](../windows.ui.xaml.automation.peers/repeatbuttonautomationpeer.md)) and [HyperlinkButton](../windows.ui.xaml.controls/hyperlinkbutton.md) ([HyperlinkButtonAutomationPeer](../windows.ui.xaml.automation.peers/hyperlinkbuttonautomationpeer.md)).

If you implement IInvokeProvider for a list/list items scenario and a control that uses [ListViewBase](../windows.ui.xaml.controls/listviewbase.md), implement IInvokeProvider for the list and not for individual items.

The IInvokeProvider pattern doesn't have a pattern property identifier class, the only API to implement is [Invoke](iinvokeprovider_invoke_1893356988.md), a method.

## -examples

## -see-also
[IInvokeProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-iinvokeprovider), [Button](../windows.ui.xaml.controls/button.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Invoke Control Pattern](/windows/desktop/WinAuto/uiauto-implementinginvoke)
