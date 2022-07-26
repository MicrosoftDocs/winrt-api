---
-api-id: T:Windows.UI.Xaml.Automation.Peers.ProgressBarAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ProgressBarAutomationPeer : Windows.UI.Xaml.Automation.Peers.RangeBaseAutomationPeer, Windows.UI.Xaml.Automation.Peers.IProgressBarAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.ProgressBarAutomationPeer

## -description
Exposes [ProgressBar](../windows.ui.xaml.controls/progressbar.md) types to Microsoft UI Automation.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Automation.Peers.ProgressBarAutomationPeer](/windows/winui/api/microsoft.ui.xaml.automation.peers.progressbarautomationpeer) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
The Windows Runtime  [ProgressBar](../windows.ui.xaml.controls/progressbar.md) class creates a new ProgressBarAutomationPeer as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from ProgressBarAutomationPeer if you are deriving a custom class from [ProgressBar](../windows.ui.xaml.controls/progressbar.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **ProgressBarAutomationPeer**

ProgressBarAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) defers to base peers. A [ProgressBar](../windows.ui.xaml.controls/progressbar.md) can be indeterminate ([IsIndeterminate](../windows.ui.xaml.controls/progressbar_isindeterminate.md) is **true**). If this is true of the owner control, [GetPattern](automationpeer_getpattern_2046576749.md) won't return a pattern for [IRangeValueProvider](../windows.ui.xaml.automation.provider/irangevalueprovider.md) even though the base [RangeBaseAutomationPeer](rangebaseautomationpeer.md) normally would.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "ProgressBar".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.ProgressBar](automationcontroltype.md).
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[ProgressBar](../windows.ui.xaml.controls/progressbar.md), [RangeBaseAutomationPeer](rangebaseautomationpeer.md), [IRangeValueProvider](../windows.ui.xaml.automation.provider/irangevalueprovider.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
