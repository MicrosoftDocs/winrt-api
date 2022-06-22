---
-api-id: T:Windows.UI.Xaml.Automation.Peers.ScrollViewerAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ScrollViewerAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IScrollViewerAutomationPeer, Windows.UI.Xaml.Automation.Provider.IScrollProvider
-->

# Windows.UI.Xaml.Automation.Peers.ScrollViewerAutomationPeer

## -description
Exposes [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) types to Microsoft UI Automation.



## -remarks
The Windows Runtime  [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) class creates a new ScrollViewerAutomationPeer as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) is sealed, so the normal scenario of deriving from the [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) class and its existing peer isn't applicable to ScrollViewerAutomationPeer.

### Default peer implementation and overrides in **ScrollViewerAutomationPeer**

ScrollViewerAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) reports that the peer provides pattern support for [PatternInterface.Scroll](patterninterface.md) ([IScrollProvider](../windows.ui.xaml.automation.provider/iscrollprovider.md)).
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "ScrolViewer".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Pane](automationcontroltype.md).
+ [IsControlElement](automationpeer_iscontrolelement_1004644794.md) returns a value based on the template parent. If there is a template parent then it returns **true**, otherwise the value is **false**. The scenario here is that a templated control may have forwarded to this peer for scrolling support, but normally a [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) by itself isn't a full-fledged control.
This peer fires several automation events on behalf of its owner in response to changes in scrolling or properties that report scrolling info.

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md), [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [IScrollProvider](../windows.ui.xaml.automation.provider/iscrollprovider.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
