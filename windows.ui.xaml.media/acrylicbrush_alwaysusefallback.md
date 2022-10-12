---
-api-id: P:Windows.UI.Xaml.Media.AcrylicBrush.AlwaysUseFallback
-api-type: winrt property
---

<!-- Property syntax.
public bool AlwaysUseFallback { get;  set; }
-->

# Windows.UI.Xaml.Media.AcrylicBrush.AlwaysUseFallback

## -description

Gets or sets a value that specifies whether the brush is forced to the solid fallback color.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Media.AcrylicBrush.AlwaysUseFallback](/windows/winui/api/microsoft.ui.xaml.media.acrylicbrush.alwaysusefallback) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

**true** to always replace the acrylic material with the solid fallback color. Otherwise, **false**. The default is **false**.

## -remarks

By default, the acrylic material is replaced with a solid color when one of the fallback conditions is met (such as entering battery saver mode). You can set this property to **true** to always replace the acrylic material with a solid color. Setting this property will synchronously trigger a transition animation between the normal look and fallback color.

## -see-also

## -examples

