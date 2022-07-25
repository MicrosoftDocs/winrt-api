---
-api-id: T:Windows.UI.Xaml.Automation.Peers.RadioButtonAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class RadioButtonAutomationPeer : Windows.UI.Xaml.Automation.Peers.ToggleButtonAutomationPeer, Windows.UI.Xaml.Automation.Peers.IRadioButtonAutomationPeer, Windows.UI.Xaml.Automation.Provider.ISelectionItemProvider
-->

# Windows.UI.Xaml.Automation.Peers.RadioButtonAutomationPeer

## -description
Exposes [RadioButton](../windows.ui.xaml.controls/radiobutton.md) types to Microsoft UI Automation.



## -remarks
The Windows Runtime  [RadioButton](../windows.ui.xaml.controls/radiobutton.md) class creates a new RadioButtonAutomationPeer as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from RadioButtonAutomationPeer if you are deriving a custom class from [RadioButton](../windows.ui.xaml.controls/radiobutton.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **RadioButtonAutomationPeer**

RadioButtonAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) reports that the peer provides pattern support for [PatternInterface.SelectionItem](patterninterface.md) ([ISelectionItemProvider](../windows.ui.xaml.automation.provider/iselectionitemprovider.md)). Also, the [ToggleButtonAutomationPeer](togglebuttonautomationpeer.md) peer base reports support for [PatternInterface.Toggle](patterninterface.md) ([IToggleProvider](../windows.ui.xaml.automation.provider/itoggleprovider.md)).
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "RadioButton".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.RadioButton](automationcontroltype.md).
+ [IsControlElement](automationpeer_iscontrolelement_1004644794.md) returns **true**.
<!--not sure how this gets set cannot see in the partial cpp-->
This peer has the base classes [ButtonBaseAutomationPeer](buttonbaseautomationpeer.md) and [ToggleButtonAutomationPeer](togglebuttonautomationpeer.md) and inherits behavior other than the overrides indicated above. Notably, [GetName](automationpeer_getname_1386609741.md) returns a string value based on examining the current **Content**. For more info, see [ButtonBaseAutomationPeer](buttonbaseautomationpeer.md).

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[RadioButton](../windows.ui.xaml.controls/radiobutton.md), [ToggleButtonAutomationPeer](togglebuttonautomationpeer.md), [IToggleProvider](../windows.ui.xaml.automation.provider/itoggleprovider.md), [ISelectionItemProvider](../windows.ui.xaml.automation.provider/iselectionitemprovider.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
