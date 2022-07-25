---
-api-id: M:Windows.UI.Xaml.Media.XamlLight.OnDisconnected(Windows.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax.
virtual protected void XamlLight.OnDisconnected(UIElement oldElement)
-->

# Windows.UI.Xaml.Media.XamlLight.OnDisconnected


## -description

This method is automatically called when the XamlLight is no longer in use anywhere on the screen.

This provides an opportunity to safely dispose of resources such as the CompositionLight when they aren't currently required.

[OnConnected](xamllight_onconnected_832156073.md) will be called again if the XamlLight is later used to light any UIElements or Brushes after being disconnected.



## -parameters

### -param oldElement

The [UIElement](/uwp/api/Windows.UI.Xaml.UIElement) that the light is attached to.

## -remarks

## -see-also

## -examples

