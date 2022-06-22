---
-api-id: T:Windows.UI.Xaml.Automation.Peers.ButtonBaseAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ButtonBaseAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IButtonBaseAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.ButtonBaseAutomationPeer

## -description
Represents a base class for exposing classes derived from [ButtonBase](../windows.ui.xaml.controls.primitives/buttonbase.md) to Microsoft UI Automation.


## -remarks
 ButtonBaseAutomationPeer has a protected constructor, so you won't be able to use it directly for an [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from ButtonBaseAutomationPeer if you are deriving a custom class from [ButtonBase](../windows.ui.xaml.controls.primitives/buttonbase.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer. Note that [ButtonBase](../windows.ui.xaml.controls.primitives/buttonbase.md) already has derived classes, each of which also has a derived peer, so make sure that you really want to derive from this base class rather than use one of the existing XAML-enabled derived button classes.

### Default peer implementation and overrides in **ButtonBaseAutomationPeer**

[ButtonAutomationPeer](buttonautomationpeer.md) has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetName](automationpeer_getname_1386609741.md) returns a string value based on examining the current **Content**. This is implemented so that consumers of the control don't always need to provide an [AutomationProperties.Name](/uwp/api/windows.ui.xaml.automation.automationproperties.name) value in app code, and can use a generated-from-content value for the automation **Name** directly from the UI definition. For more info on how this works, see [Basic accessibility information](/windows/uwp/accessibility/basic-accessibility-information).
+ Other normally required values such as [GetClassName](automationpeer_getclassname_614238974.md) and [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) should be implemented on the derived peer classes.
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

There is no "ControlAutomationPeer" class. [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) serves as implementation for all basic [Control](../windows.ui.xaml.controls/control.md) class scenarios that involve Microsoft UI Automation. This includes behavior that does not necessarily appear as a public API exposure, such as the practical implementations of many of the **Core** methods from [AutomationPeer](automationpeer.md).

[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) includes extensive base implementation of peer behavior that other peers can use to report information that comes from owner classes at the [UIElement](../windows.ui.xaml/uielement.md) and [FrameworkElement](../windows.ui.xaml/frameworkelement.md) level. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).
<!--Maybe eventually also put this info in the Core methods, because it is overriders that most want to know the specifics of each such behavior whereas general consumers might want big picture or the semi client perspective you get from the non Core descs-->

In addition to the **Core** overrides, [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) has two static utility methods that are useful for getting a peer handle from within control code, or for generating items peers from an item container peer for Microsoft UI Automation support. These are:
+ [CreatePeerForElement](frameworkelementautomationpeer_createpeerforelement_1260151463.md)
+ [FromElement](frameworkelementautomationpeer_fromelement_1666357111.md)


If you have a need to define a custom automation peer and can't identify a more derived peer class that pairs up with the control or base class you are deriving the owner class from, you should base your peer on [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md). Even if the owner class isn't necessarily a [FrameworkElement](../windows.ui.xaml/frameworkelement.md), you can't practically derive peers from [AutomationPeer](automationpeer.md) directly because [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) has many overrides that provide the expected behavior for layout, automation and UI interactions. You do need to derive your owner class from [UIElement](../windows.ui.xaml/uielement.md) at least, otherwise there is no way to create the peer on automation tree load with [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md).

### **ButtonBaseAutomationPeer** derived classes

ButtonBaseAutomationPeer is the parent class for several immediately derived classes that implement peer support for Windows Runtime controls. Here is the list of classes that directly derive from ButtonBaseAutomationPeer:

+ [ButtonAutomationPeer](buttonautomationpeer.md)
+ [HyperlinkButtonAutomationPeer](hyperlinkbuttonautomationpeer.md)
+ [RepeatButtonAutomationPeer](repeatbuttonautomationpeer.md)
+ [ToggleButtonAutomationPeer](togglebuttonautomationpeer.md)


## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [ButtonAutomationPeer](buttonautomationpeer.md), [Button](../windows.ui.xaml.controls/button.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
