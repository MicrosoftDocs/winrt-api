---
-api-id: M:Windows.UI.Xaml.UIElement.OnCreateAutomationPeer
-api-type: winrt method
---

<!-- Method syntax
virtual protected Windows.UI.Xaml.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
-->

# Windows.UI.Xaml.UIElement.OnCreateAutomationPeer

## -description
When implemented in a derived class, returns class-specific [AutomationPeer](../windows.ui.xaml.automation.peers/automationpeer.md) implementations for the Microsoft UI Automation infrastructure.

## -returns
The class-specific [AutomationPeer](../windows.ui.xaml.automation.peers/automationpeer.md) subclass to return.

## -remarks
For more info on the purpose of an automation peer and why you might need to define a class-specific [AutomationPeer](../windows.ui.xaml.automation.peers/automationpeer.md) class, see [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4).

You should override this method in a custom class where you want to supply a custom automation peer for Microsoft UI Automation, rather than the default peer that is referenced by the default [OnCreateAutomationPeer](uielement_oncreateautomationpeer.md) implementation. How you define a custom peer for your custom control depends on your control's accessibility requirements , its UI contract, and its behavior. For more info on why you might want to define a new peer, see [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4). To see a sample that implements [OnCreateAutomationPeer](uielement_oncreateautomationpeer.md) and defines the custom peer that [OnCreateAutomationPeer](uielement_oncreateautomationpeer.md) returns, see [XAML accessibility sample](http://go.microsoft.com/fwlink/p/?linkid=238570) (the peer implementation is part of Scenario 3 in that sample).

We recommend that the [OnCreateAutomationPeer](uielement_oncreateautomationpeer.md) implementation should do nothing more than initialize a new instance of your custom automation peer, passing the calling control as owner, and return that instance. Do not attempt additional logic in this method. In particular, any logic that could potentially lead to destruction of the [AutomationPeer](../windows.ui.xaml.automation.peers/automationpeer.md) within the same call may result in unexpected runtime behavior.

## -examples
The entirety of a [OnCreateAutomationPeer](uielement_oncreateautomationpeer.md) implementation should consist of constructing the custom automation peer class and returning it.

```csharp
        protected override AutomationPeer OnCreateAutomationPeer() 
        { 
            return new MediaContainerAP(this, mediaElement); 
        }
```

```vbnet
        Protected Overrides Function OnCreateAutomationPeer() As AutomationPeer
            Return New MediaContainerAP(Me, mediaElement)
        End Function

```

```cpp
        protected:
            virtual AutomationPeer^ OnCreateAutomationPeer() override
            {
                return ref new MediaContainerAP(this, mediaElement);
            }
        };

```



## -see-also
[AutomationPeer](../windows.ui.xaml.automation.peers/automationpeer.md), [XAML accessibility sample](http://go.microsoft.com/fwlink/p/?linkid=238570), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [Accessibility](http://msdn.microsoft.com/library/c89d79c2-b830-493d-b020-f3ff8eb5ffdd)