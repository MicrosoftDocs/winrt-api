---
-api-id: T:Windows.UI.Xaml.Automation.Peers.ProgressRingAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ProgressRingAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IProgressRingAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.ProgressRingAutomationPeer

## -description
Exposes [ProgressRing](../windows.ui.xaml.controls/progressring.md) types to Microsoft UI Automation.

## -remarks
The Windows Runtime  [ProgressRing](../windows.ui.xaml.controls/progressring.md) class creates a new [ProgressRingAutomationPeer](progressringautomationpeer.md) as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. [ProgressRing](../windows.ui.xaml.controls/progressring.md) is sealed, so the normal scenario of deriving from the [PasswordBox](../windows.ui.xaml.controls/passwordbox.md) class and its existing peer isn't applicable to [ProgressRingAutomationPeer](progressringautomationpeer.md).

### Default peer implementation and overrides in **ProgressRingAutomationPeer**

[ProgressRingAutomationPeer](progressringautomationpeer.md) has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) defers to base peers, which report no patterns.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "ProgressRing".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.ProgressBar](automationcontroltype.md).
+ [GetName](automationpeer_getname_1386609741.md) has an implementation that reports a localized string for "Busy" whenever the [ProgressRing](../windows.ui.xaml.controls/progressring.md) owner reports [IsActive](../windows.ui.xaml.controls/progressring_isactive.md) as **true**.
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4).

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [ProgressRing](../windows.ui.xaml.controls/progressring.md), [ProgressBar](../windows.ui.xaml.controls/progressbar.md), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4)