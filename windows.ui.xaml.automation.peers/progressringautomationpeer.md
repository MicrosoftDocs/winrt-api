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

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Automation.Peers.ProgressRingAutomationPeer](/windows/winui/api/microsoft.ui.xaml.automation.peers.progressringautomationpeer) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
The Windows Runtime  [ProgressRing](../windows.ui.xaml.controls/progressring.md) class creates a new ProgressRingAutomationPeer as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. [ProgressRing](../windows.ui.xaml.controls/progressring.md) is sealed, so the normal scenario of deriving from the [PasswordBox](../windows.ui.xaml.controls/passwordbox.md) class and its existing peer isn't applicable to ProgressRingAutomationPeer.

### Default peer implementation and overrides in **ProgressRingAutomationPeer**

ProgressRingAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) defers to base peers, which report no patterns.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "ProgressRing".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.ProgressBar](automationcontroltype.md).
+ [GetName](automationpeer_getname_1386609741.md) has an implementation that reports a localized string for "Busy" whenever the [ProgressRing](../windows.ui.xaml.controls/progressring.md) owner reports [IsActive](../windows.ui.xaml.controls/progressring_isactive.md) as **true**.
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [ProgressRing](../windows.ui.xaml.controls/progressring.md), [ProgressBar](../windows.ui.xaml.controls/progressbar.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
