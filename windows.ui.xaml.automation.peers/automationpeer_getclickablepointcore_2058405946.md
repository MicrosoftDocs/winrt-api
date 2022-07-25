---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetClickablePointCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected Windows.Foundation.Point GetClickablePointCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetClickablePointCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetClickablePoint](automationpeer_getclickablepoint_955785073.md) or an equivalent Microsoft UI Automation client API.



## -returns
A point within the clickable area of the element.

## -remarks
The base implementation returns a default [Point](../windows.foundation/point.md) (coordinates 0,0). Peers that represent items defer to the container. [ScrollBarAutomationPeer](scrollbarautomationpeer.md) and [SliderAutomationPeer](sliderautomationpeer.md) both have behavior that can't adequately express one point for the purposes of [GetClickablePoint](automationpeer_getclickablepoint_955785073.md) scenarios, so these return a [Point](../windows.foundation/point.md) where the coordinate values are NaN.

> [!NOTE]
> In C#, you can obtain NaN from [Double.NaN](/dotnet/api/system.double.nan?view=dotnet-uwp-10.0&preserve-view=true).
>
> In C++, you can obtain NaN by using the [`NAN` macro](/cpp/standard-library/cmath) or [`std::numeric_limits<double>::quiet_NaN`](/cpp/standard-library/numeric-limits-class#quiet_nan).
>
> Do not use the `==` operator to test for NaN.
>
> In C#, use [Double.IsNaN()](/dotnet/api/system.double.isnan?view=dotnet-uwp-10.0&preserve-view=true) to test for NaN.
>
> In C++, use [isnan()](/cpp/c-runtime-library/reference/isnan-isnan-isnanf) to test for NaN.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)
