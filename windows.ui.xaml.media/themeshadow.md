---
-api-id: T:Windows.UI.Xaml.Media.ThemeShadow
-api-type: winrt class
ms.custom: 19H1
---

<!-- Class syntax.
public class ThemeShadow : Shadow, Shadow
-->

# Windows.UI.Xaml.Media.ThemeShadow

## -description

A ThemeShadow is a preconfigured shadow effect that can be applied to any XAML element to draw shadows appropriately based on x, y, z coordinates. ThemeShadow also automatically adjusts for other environmental specifications:

- Adapts to changes in lighting, user theme, app environment, and shell.
- Shadows elements automatically based on their elevation.
- Keeps elements in sync as they move and change elevation.
- Keeps shadows consistent throughout and across applications.


## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Z-depth and shadow](/windows/uwp/design/layout/depth-shadow).

A ThemeShadow can be applied to any XAML element to draw shadows based on the relative x, y, and z coordinates between a conceptual caster UIElement and one or more receiver UIElements which have the caster's shadow rendered onto them. 

ThemeShadow supports only rectangular shadows. For custom shadow effects, you can use a [DropShadow](../windows.ui.composition/dropshadow.md).

### ThemeShadows in Popups

ThemeShadow automatically casts shadows when applied to any XAML element in a [Popup](../windows.ui.xaml.controls.primitives/popup.md). It will cast shadows on the app background content behind it and any other open Popups below it.

To use ThemeShadow with Popups, use the [UIElement.Shadow](../windows.ui.xaml/uielement_shadow.md) property to apply a ThemeShadow to a XAML element. Then, elevate the element from other elements behind it, for example by using the z component of the [UIElement.Translation](../windows.ui.xaml/uielement_translation.md) property.
For most Popup UI, the recommended default elevation relative to the app background content is 32 effective pixels.

### ThemeShadow in other elements

To cast a shadow from a XAML element that isn't in a [Popup](../windows.ui.xaml.controls.primitives/popup.md), you must explicitly specify the other elements that can receive the shadow in the [ThemeShadow.Receivers](themeshadow_receivers.md) collection. Receivers cannot be an ancestor of the caster in the visual tree.

### Performance best practices for ThemeShadow

1. Limit the number of custom receiver elements to the minimum necessary.

2. If multiple receiver elements are at the same elevation then try to combine them by targeting a single parent element instead.

3. If multiple elements will cast the same type of shadow onto the same receiver elements then add the shadow as a shared resource and reuse it.

## -see-also

[Z-depth and shadow](/windows/uwp/design/layout/depth-shadow), [UIElement.Shadow](../windows.ui.xaml/uielement_shadow.md)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Z-depth and shadow](/windows/uwp/design/layout/depth-shadow).
>
> Many common controls automatically cast shadows using ThemeShadow. 
>
> If you have the **WinUI 2 Gallery** app installed and meet the minimum Windows 10 version requirements above, [click here to open the app and see ThemeShadow in action on common controls](winui2gallery:/).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)


