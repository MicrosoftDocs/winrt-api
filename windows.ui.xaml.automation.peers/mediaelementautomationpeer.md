---
-api-id: T:Windows.UI.Xaml.Automation.Peers.MediaElementAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class MediaElementAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IMediaElementAutomationPeer
-->

# Windows.UI.Xaml.Automation.Peers.MediaElementAutomationPeer

## -description
Exposes [MediaElement](../windows.ui.xaml.controls/mediaelement.md) types to Microsoft UI Automation.


## -remarks
The Windows Runtime  [MediaElement](../windows.ui.xaml.controls/mediaelement.md) class creates a new MediaElementAutomationPeer as its [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from MediaElementAutomationPeer if you are deriving a custom class from [MediaElement](../windows.ui.xaml.controls/mediaelement.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **MediaElementAutomationPeer**

MediaElementAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_2046576749.md) reports no pattern support.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "MediaElement".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Custom](automationcontroltype.md).
+ [GetChildren](automationpeer_getchildren_555647254.md) has a behavior that only works if [isFullWindow](../windows.ui.xaml.controls/mediaelement_isfullwindow.md) on the owner is **true**. In this case it can return peers for child elements such as the transport controls.
No patterns and a "Custom" control type don't provide much of an accessibility experience. This is by design for the basic [MediaElement](../windows.ui.xaml.controls/mediaelement.md), because it really isn't a control. It's not focusable or invokable, and it doesn't have any kind of control surface such as elements that can be referenced to provide more automation information unless [AreTransportControlsEnabled](../windows.ui.xaml.controls/mediaelement_aretransportcontrolsenabled.md) is **true**. Without transport controls, it's just a display surface for the media that takes up space in layout. Many apps would composite a [MediaElement](../windows.ui.xaml.controls/mediaelement.md) either within a control template or within an app definition where the [MediaElement](../windows.ui.xaml.controls/mediaelement.md) is included in a container along with a custom transport control surface. For example, you would typically have **Play****Pause** and **Stop** buttons that hook up to the matching [MediaElement](../windows.ui.xaml.controls/mediaelement.md) methods that enable the user to control the actions of the media source. It's the control elements such as the buttons that need to have accessibility/automation support, so that the user can identify their actions and invoke them. Make sure that any control elements for a [MediaElement](../windows.ui.xaml.controls/mediaelement.md) report an automation **Name**, are focusable, and support at least one mode of invoking their action without using a pointer action.

Making the media content itself accessible requires planning, and is related to accessibility scenarios where Microsoft UI Automation isn't directly involved. For more info, see [Making media content accessible](/previous-versions/windows/apps/hh868162(v=win.10)).

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[MediaElement](../windows.ui.xaml.controls/mediaelement.md), [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Making media content accessible](/previous-versions/windows/apps/hh868162(v=win.10))
