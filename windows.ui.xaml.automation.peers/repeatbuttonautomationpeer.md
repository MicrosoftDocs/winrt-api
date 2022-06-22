---
-api-id: T:Windows.UI.Xaml.Automation.Peers.RepeatButtonAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class RepeatButtonAutomationPeer : Windows.UI.Xaml.Automation.Peers.ButtonBaseAutomationPeer, Windows.UI.Xaml.Automation.Peers.IRepeatButtonAutomationPeer, Windows.UI.Xaml.Automation.Provider.IInvokeProvider
-->

# Windows.UI.Xaml.Automation.Peers.RepeatButtonAutomationPeer

## -description
Exposes [RepeatButton](../windows.ui.xaml.controls.primitives/repeatbutton.md) types to Microsoft UI Automation.


## -remarks
The Windows Runtime  [RepeatButton](../windows.ui.xaml.controls.primitives/repeatbutton.md) class creates a new RepeatButtonAutomationPeer as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. [RepeatButton](../windows.ui.xaml.controls.primitives/repeatbutton.md) is sealed, so the normal scenario of deriving from the [RepeatButton](../windows.ui.xaml.controls.primitives/repeatbutton.md) class and its existing peer isn't applicable to RepeatButtonAutomationPeer.

### Default peer implementation and overrides in **RepeatButtonAutomationPeer**

RepeatButtonAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) reports that the peer provides pattern support for [PatternInterface.Invoke](patterninterface.md) ([IInvokeProvider](../windows.ui.xaml.automation.provider/iinvokeprovider.md)).
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "RepeatButton".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Button](automationcontroltype.md).
+ [IsControlElement](automationpeer_iscontrolelement_1004644794.md) returns **true**.
<!--not sure how this gets set cannot see in the partial cpp-->
This peer has the immediate base class [ButtonBaseAutomationPeer](buttonbaseautomationpeer.md) and inherits its behavior other than the overrides indicated above. Notably, [GetName](automationpeer_getname_1386609741.md) returns a string value based on examining the current **Content**. For more info, see [ButtonBaseAutomationPeer](buttonbaseautomationpeer.md).

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[RepeatButton](../windows.ui.xaml.controls.primitives/repeatbutton.md), [ButtonBaseAutomationPeer](buttonbaseautomationpeer.md), [IInvokeProvider](../windows.ui.xaml.automation.provider/iinvokeprovider.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
