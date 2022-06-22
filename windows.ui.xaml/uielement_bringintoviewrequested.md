---
-api-id: E:Windows.UI.Xaml.UIElement.BringIntoViewRequested
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler BringIntoViewRequested<UIElement, BringIntoViewRequestedEventArgs>
-->

# Windows.UI.Xaml.UIElement.BringIntoViewRequested

## -description

Occurs when [StartBringIntoView](uielement_startbringintoview_1818344798.md) is called on this element or one of its descendants.



## -remarks

> [!NOTE]
> The framework may also raise the event in response to the element receiving focus via a keyboard or gamepad, or when an assistive technology executes the [IScrollItemProvider](../windows.ui.xaml.automation.provider/iscrollitemprovider.md)'s [ScrollIntoView](../windows.ui.xaml.automation.provider/iscrollitemprovider_scrollintoview_1265805467.md) method on the element's automation peer.

This event enables a control to participate in the process of bringing an element into view.  It indicates to a parent control, such as a [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md), that the element which raised the event should be made visible within the scrollable region. Non-scrolling controls may use the event as a way to alter requests that originate from one of its children by modifying the event data ([BringIntoViewRequestedEventArgs](bringintoviewrequestedeventargs.md)). For example, you may listen to the event on a parent element to enlarge the [TargetRect](bringintoviewrequestedeventargs_targetrect.md) and ensure a minimum amount of padding is included when bringing any of its child elements into view.

In general, the event data ([BringIntoViewRequestedEventArgs](bringintoviewrequestedeventargs.md)) should not be marked handled.  Doing so may interfere with the intended goal when StartBringIntoView was called. Other event data may be modified as the event bubbles up to alter the request. Specifically, a parent scrolling control is expected to modify the event data to account for its contribution, whether it partially or fully satisfies the request. At a minimum, a scroller is expected to set itself as the [TargetElement](bringintoviewrequestedeventargs_targetelement.md) and update the [TargetRect](bringintoviewrequestedeventargs_targetrect.md) to its own coordinate space. For situations where the element is within a scroller that itself is within a scroller each must react to satisfy the requested alignment.

The [OriginalSource](routedeventargs_originalsource.md) should be used to determine the element on which the event was originally raised given that the [TargetElement](bringintoviewrequestedeventargs_targetelement.md) may be modified as the event bubbles.

BringIntoViewRequested is a routed event. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

## -see-also

[BringIntoViewRequestedEventArgs](bringintoviewrequestedeventargs.md), [OnBringIntoViewRequested](uielement_onbringintoviewrequested_385089886.md)

## -examples
