---
-api-id: M:Windows.UI.Xaml.Media.XamlCompositionBrushBase.OnDisconnected
-api-type: winrt method
---

<!-- Method syntax.
virtual protected void XamlCompositionBrushBase.OnDisconnected()
-->

# Windows.UI.Xaml.Media.XamlCompositionBrushBase.OnDisconnected

## -description
Invoked when the brush is no longer being used to paint any elements. 

When implemented in a derived class, you can safely dispose of the compostion brush and other composition resources.

[OnConnected](xamlcompositionbrushbase_onconnected_591765711.md) will be called again if the brush is later used to paint any elements after being disconnected.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Media.XamlCompositionBrushBase.OnDisconnected](/windows/winui/api/microsoft.ui.xaml.media.xamlcompositionbrushbase.ondisconnected) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

## -see-also

## -examples

