---
-api-id: P:Windows.UI.Xaml.Controls.IconSource.Foreground
-api-type: winrt property
---

<!-- Property syntax.
public Brush Foreground { get;  set; }
-->

# Windows.UI.Xaml.Controls.IconSource.Foreground

## -description

Gets or sets a brush that describes the foreground color.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.IconSource.Foreground](/windows/winui/api/microsoft.ui.xaml.controls.iconsource.foreground) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<iconSource Foreground="{StaticResource resourceName}"/>
```

```xaml
<iconSource Foreground="colorString"/>
```

## -xaml-values

<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
</dl>

## -property-value

The brush that paints the foreground of the control. The default is **null**, (a null brush) which is evaluated as [Transparent](../windows.ui/colors_transparent.md) for rendering. However, this value is typically set by a default system resource at runtime, which is tied to the active theme and other settings.

## -remarks

## -see-also

## -examples

