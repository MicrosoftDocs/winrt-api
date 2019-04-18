---
-api-id: M:Windows.Graphics.Holographic.HolographicViewConfiguration.RequestRenderTargetSize(Windows.Foundation.Size)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public Size HolographicViewConfiguration.RequestRenderTargetSize(Size size)
-->

# Windows.Graphics.Holographic.HolographicViewConfiguration.RequestRenderTargetSize

## -description
Requests a new minimum render target size for this HolographicViewConfiguration.

## -parameters
### -param size
A [Size](../windows.foundation/size.md) representing the desired render target size. Must be at least [1, 1].

## -returns
A [Size](../windows.foundation/size.md) representing the render target size that was actually set.

## -remarks

## -see-also
[Size](../windows.foundation/size.md), [HolographicDisplay.TryGetViewConfiguration](holographicdisplay_trygetviewconfiguration_2033828652.md)

## -examples

**Example 1: Request a new minimum render target size**

In this example, the app requests a render target size which is at least 1660 by 1660 pixels by calling RequestRenderTargetSize. Starting with the next HolographicFrame, the corresponding [HolographicCamera](holographiccamera.md) will have a render target which is at least 1660 by 1660.

To satisfy restrictions on buffer dimension - for example, device-specific byte alignment requirements - the new render target size could be greater than the requested size. The app can inspect the result of the call to RequestRenderTargetSize to find out the dimensions that were chosen based on the app's requested minimum render target size.

```cppwinrt
Size newRenderTargetSize{ defaultViewConfiguration.RequestRenderTargetSize({ 1660.f, 1660.f }) };

if (newRenderTargetSize.Width > 1672.f || newRenderTargetSize.Height > 1672.f)
{
    // App-specific code
}
```

Note: The values shown in this example are for demonstrative purposes only, and are not based on any specific app, rendering technique, or other detail.
