---
-api-id: T:Windows.UI.Xaml.Automation.Peers.RichEditBoxAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class RichEditBoxAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IRichEditBoxAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.RichEditBoxAutomationPeer

## -description
Exposes [RichEditBox](../windows.ui.xaml.controls/richeditbox.md) types to Microsoft UI Automation.


## -remarks
The Windows Runtime  [RichEditBox](../windows.ui.xaml.controls/richeditbox.md) class creates a new RichEditBoxAutomationPeer as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from RichEditBoxAutomationPeer if you are deriving a custom class from [RichEditBox](../windows.ui.xaml.controls/richeditbox.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **RichEditBoxAutomationPeer**

RichEditBoxAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) reports pattern support for [TextPattern](/windows/desktop/api/uiautomationclient/nn-uiautomationclient-iuiautomationtextpattern), but see "TextPattern support" in this topic for more info.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "RichEditBox".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Edit](automationcontroltype.md).
+ [IsControlElement](automationpeer_iscontrolelement_1004644794.md) returns **true**.
<!--not sure how this gets set cannot see in the partial cpp-->
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

### TextPattern support

 RichEditBoxAutomationPeer supports the **TextPattern**  Microsoft UI Automation pattern. The support for this pattern is implemented as native code by the peer, so you won't see public API for the RichEditBoxAutomationPeer peer class that exposes the pattern implementation for extension. And you won't see [ITextRangeProvider](../windows.ui.xaml.automation.provider/itextrangeprovider.md) and the similar managed interfaces in the RichEditBoxAutomationPeer inheritance. But Microsoft UI Automation clients can use the **TextPattern** pattern implemented by this peer and call its native API surface.


<!--<p  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">specifics of the <xref targtype="iface" rid="winauto.uiauto_IUIAutomationTextPattern">TextPattern</xref> implementation .... not documented</p>-->

## -examples

## -see-also
[RichEditBox](../windows.ui.xaml.controls/richeditbox.md), [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
