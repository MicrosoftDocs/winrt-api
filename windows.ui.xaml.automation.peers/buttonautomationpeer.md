---
-api-id: T:Windows.UI.Xaml.Automation.Peers.ButtonAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ButtonAutomationPeer : Windows.UI.Xaml.Automation.Peers.ButtonBaseAutomationPeer, Windows.UI.Xaml.Automation.Peers.IButtonAutomationPeer, Windows.UI.Xaml.Automation.Provider.IInvokeProvider
-->

# Windows.UI.Xaml.Automation.Peers.ButtonAutomationPeer

## -description
Exposes [Button](../windows.ui.xaml.controls/button.md) types to Microsoft UI Automation.


## -remarks
The Windows Runtime  [Button](../windows.ui.xaml.controls/button.md) class creates a new ButtonAutomationPeer as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from ButtonAutomationPeer if you are deriving a custom class from [Button](../windows.ui.xaml.controls/button.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **ButtonAutomationPeer**

ButtonAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) reports that the peer provides pattern support for [PatternInterface.Invoke](patterninterface.md) ([IInvokeProvider](../windows.ui.xaml.automation.provider/iinvokeprovider.md) ).
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "Button".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Button](automationcontroltype.md).
+ [IsControlElement](automationpeer_iscontrolelement_1004644794.md) returns **true**.
<!--not sure how this gets set cannot see in the partial cpp-->
This peer has the immediate base class [ButtonBaseAutomationPeer](buttonbaseautomationpeer.md) and inherits its behavior other than the overrides indicated above. Notably, [GetName](automationpeer_getname_1386609741.md) returns a string value based on examining the current **Content**. For more info, see [ButtonBaseAutomationPeer](buttonbaseautomationpeer.md).

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

### **ButtonAutomationPeer** derived classes

ButtonAutomationPeer is the parent class for [AppBarButtonAutomationPeer](appbarbuttonautomationpeer.md).

## -examples

## -see-also
[ButtonBaseAutomationPeer](buttonbaseautomationpeer.md), [IInvokeProvider](../windows.ui.xaml.automation.provider/iinvokeprovider.md), [Button](../windows.ui.xaml.controls/button.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
