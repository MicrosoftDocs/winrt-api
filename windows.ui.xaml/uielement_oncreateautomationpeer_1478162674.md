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
For more info on the purpose of an automation peer and why you might need to define a class-specific [AutomationPeer](../windows.ui.xaml.automation.peers/automationpeer.md) class, see [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

You should override this method in a custom class where you want to supply a custom automation peer for Microsoft UI Automation, rather than the default peer that is referenced by the default OnCreateAutomationPeer implementation. How you define a custom peer for your custom control depends on your control's accessibility requirements , its UI contract, and its behavior. For more info on why you might want to define a new peer, see [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers). 

> [!NOTE]
>
> **This sample is not maintained and might not compile.**
>
> See [XAML accessibility sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20accessibility%20sample) for an implementation of OnCreateAutomationPeer that defines the custom peer returned by OnCreateAutomationPeer (the peer implementation is part of Scenario 3 in this sample). 

We recommend that the OnCreateAutomationPeer implementation should do nothing more than initialize a new instance of your custom automation peer, passing the calling control as owner, and return that instance. Do not attempt additional logic in this method. In particular, any logic that could potentially lead to destruction of the [AutomationPeer](../windows.ui.xaml.automation.peers/automationpeer.md) within the same call may result in unexpected runtime behavior.

## -examples
The entirety of an OnCreateAutomationPeer implementation should consist of constructing the custom automation peer class and returning it.

```csharp
protected override AutomationPeer OnCreateAutomationPeer() 
{
    return new MediaContainerAP(this, mediaElement); 
}
```

```cppwinrt
#include "MediaContainerAP.h"
...
public:
    MyNamespace::MediaContainerAP OnCreateAutomationPeer()
    {
        return winrt::make<MyNamespace::implementation::MediaContainerAP>(*this, mediaElement());
    }
```

```cppcx
protected:
    virtual AutomationPeer^ OnCreateAutomationPeer() override
    {
        return ref new MediaContainerAP(this, mediaElement);
    }
};
```

```vb
Protected Overrides Function OnCreateAutomationPeer() As AutomationPeer
    Return New MediaContainerAP(Me, mediaElement)
End Function
```

## -see-also
[AutomationPeer](../windows.ui.xaml.automation.peers/automationpeer.md), [Code samples for resolving common programmatic accessibility issues in Windows desktop apps](/accessibility-tools-docs/), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)
