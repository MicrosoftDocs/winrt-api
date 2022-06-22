---
-api-id: T:Windows.UI.Xaml.Automation.Peers.AutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class AutomationPeer : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Automation.Peers.IAutomationPeer, Windows.UI.Xaml.Automation.Peers.IAutomationPeer2, Windows.UI.Xaml.Automation.Peers.IAutomationPeer3, Windows.UI.Xaml.Automation.Peers.IAutomationPeer4, Windows.UI.Xaml.Automation.Peers.IAutomationPeer5, Windows.UI.Xaml.Automation.Peers.IAutomationPeer6, Windows.UI.Xaml.Automation.Peers.IAutomationPeerOverrides, Windows.UI.Xaml.Automation.Peers.IAutomationPeerOverrides2, Windows.UI.Xaml.Automation.Peers.IAutomationPeerOverrides3, Windows.UI.Xaml.Automation.Peers.IAutomationPeerOverrides4, Windows.UI.Xaml.Automation.Peers.IAutomationPeerOverrides5, Windows.UI.Xaml.Automation.Peers.IAutomationPeerOverrides6, Windows.UI.Xaml.Automation.Peers.IAutomationPeerProtected
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer

## -description
Provides a base class that exposes the automation peer for an associated owner class to Microsoft UI Automation.



## -remarks
AutomationPeer is the class that provides almost all of the API that eventually forwards the Microsoft UI Automation information for a UWP app using C++, C#, or Visual Basic to a Microsoft UI Automation client. Typical Microsoft UI Automation clients aren't calling AutomationPeer methods directly. These clients are often assistive technology that are using other programming models and operating as services, and are not likely to be calling Windows Runtime methods. But the general Microsoft UI Automation support in the Windows Runtime forwards all this information using the provider side of the Microsoft UI Automation framework. Any clients to Microsoft UI Automation can interact with the representative automation trees of a UWP app using C++, C#, or Visual Basic.

### Firing automation events

The AutomationPeer class is relevant to Windows Runtime control authors because you will have a peer instance available at run time, after the runtime invokes the [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) method. Using this peer, you can fire automation events by calling [RaiseAutomationEvent](automationpeer_raiseautomationevent_2027563412.md) and [RaisePropertyChangedEvent](automationpeer_raisepropertychangedevent_715050195.md). You would do this whenever a related property in the peer's owner (your class) changes, or when firing an event is needed for correct automation support.

The automation support design doesn't retain a handle to your own peer as part of how you implement [OnCreateAutomationPeer](../windows.ui.xaml/uielement_oncreateautomationpeer_1478162674.md), because there aren't any guarantees of when the peer is actually created. Instead, you can check for run-time automation event listeners inside your control class definitions just-in-time, using code like this:
```csharp
if (AutomationPeer.ListenerExists(AutomationEvents.PropertyChanged))
{
    MyAutomationPeer peer = 
        FrameworkElementAutomationPeer.FromElement(myCtrl) as MyAutomationPeer;

    if (peer != null)
    {
        peer.RaisePropertyChangedEvent(
            RangeValuePatternIdentifiers.ValueProperty,
            (double)oldValue,
            (double)newValue);
    }
}

```

```vb
If AutomationPeer.ListenerExists(AutomationEvents.PropertyChanged) Then
    Dim peer As MyAutomationPeer = _
    TryCast(FrameworkElementAutomationPeer.FromElement(myCtrl), MyAutomationPeer)
    If peer IsNot Nothing Then
        peer.RaisePropertyChangedEvent(RangeValuePatternIdentifiers.ValueProperty, CDbl(oldValue), CDbl(newValue))
    End If
End If
```

### **AutomationPeer** derived classes

AutomationPeer is in the hierarchy for all the existing peers for the Windows Runtime controls and related UI classes.

Classes that directly derive from AutomationPeer are:
+ [ItemAutomationPeer](itemautomationpeer.md)
+ [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md)
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md). For a list of the peers that derive from [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) see Remarks section of [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md).

### **Core** methods

The "Core" methods are the standard implementations that perform the default action of an associated Microsoft UI Automation client-callable method. You can override any of the "Core" methods to return alternative values in a custom automation peer. For example, [GetAcceleratorKeyCore](automationpeer_getacceleratorkeycore_1091687272.md) is invoked any time that [GetAcceleratorKey](automationpeer_getacceleratorkey_970307487.md) is called, [GetAccessKeyCore](automationpeer_getaccesskeycore_536668621.md) is invoked any time that [GetAccessKey](automationpeer_getaccesskey_372284052.md) is called, and so on.

The base implementation for AutomationPeer returns null. Peers that represent items may defer the result to their container.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | GetLandmarkType |
| 1511 | 10586 | GetLandmarkTypeCore |
| 1511 | 10586 | GetLocalizedLandmarkType |
| 1511 | 10586 | GetLocalizedLandmarkTypeCore |
| 1607 | 14393 | GetDescribedByCore |
| 1607 | 14393 | GetFlowsFromCore |
| 1607 | 14393 | GetFlowsToCore |
| 1607 | 14393 | GetFullDescription |
| 1607 | 14393 | GetFullDescriptionCore |
| 1607 | 14393 | IsDataValidForForm |
| 1607 | 14393 | IsDataValidForFormCore |
| 1607 | 14393 | IsPeripheral |
| 1607 | 14393 | IsPeripheralCore |
| 1703 | 15063 | GetCulture |
| 1703 | 15063 | GetCultureCore |
| 1709 | 16299 | RaiseNotificationEvent |
| 1803 | 17134 | GetHeadingLevel |
| 1803 | 17134 | GetHeadingLevelCore |
| 1809 | 17763 | IsDialog |
| 1809 | 17763 | IsDialogCore |

## -examples

## -see-also
[DependencyObject](../windows.ui.xaml/dependencyobject.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Code samples for resolving common programmatic accessibility issues in Windows desktop apps](/accessibility-tools-docs/), [Accessibility](/windows/uwp/design/accessibility/accessibility)
