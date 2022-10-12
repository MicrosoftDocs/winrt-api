---
-api-id: P:Windows.UI.Xaml.Controls.PathIconSource.Data
-api-type: winrt property
---

<!-- Property syntax.
public Geometry Data { get;  set; }
-->

# Windows.UI.Xaml.Controls.PathIconSource.Data

## -description

Gets or sets a [Geometry](../windows.ui.xaml.media/geometry.md) that specifies the shape to be drawn. In XAML. this can also be set using a string that describes [Move and draw commands syntax](/windows/uwp/xaml-platform/move-draw-commands-syntax).

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.PathIconSource.Data](/windows/winui/api/microsoft.ui.xaml.controls.pathiconsource.data) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<PathIconSource>
  <PathIconSource.Data>
    singleGeometry
  </PathIconSource.Data>
</PathIconSource>
- or -
<PathIconSource Data="moveAndDrawCommands"/>
```

## -xaml-values

<dl><dt>singleGeometry</dt><dd>singleGeometryA single object element that derives from Geometry. This can be one of the following: One of the simple geometries EllipseGeometry, LineGeometry, or RectangleGeometry.A single GeometryGroup, which supports other geometries as child elements. A PathGeometry, which supports child object elements that establish a path geometry object model of figures and segments. See the "XAML Values" section of PathGeometry.</dd>
<dt>moveAndDrawCommands</dt><dd>moveAndDrawCommandsThis is a complex syntax that cannot be adequately summarized here. See Move and draw commands syntax.</dd>
</dl>

## -property-value

A description of the shape to be drawn.

## -remarks

## -see-also

## -examples

