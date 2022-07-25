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



## -remarks

## -see-also

## -examples

