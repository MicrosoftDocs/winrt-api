---
-api-id: M:Windows.UI.Xaml.Controls.Canvas.GetZIndex(Windows.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax
public int GetZIndex(Windows.UI.Xaml.UIElement element)
-->

# Windows.UI.Xaml.Controls.Canvas.GetZIndex

## -description
Gets the value of the [Canvas.ZIndex](canvas_zindex.md) XAML attached property for the target element.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.Canvas.GetZIndex](/windows/winui/api/microsoft.ui.xaml.controls.canvas.getzindex) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param element
The object from which the property value is read.

## -returns
The [Canvas.ZIndex](canvas_zindex.md) XAML attached property value of the requested object. 
<!--The maximum allowed value for <xref rid="w_ui_xaml_ctrl.canvas_zindex" targtype="property_winrt">ZIndex</xref> is Int16.MaxValue – 1 = 32766.
      -->

## -remarks
This method is a utility method for the property system, and isn't used in most app scenarios. In most cases you set the [Canvas.ZIndex](canvas_zindex.md) XAML attached property in XAML and won't need this method. For more info, see the [Canvas.ZIndex](canvas_zindex.md) attached property.

## -examples

## -see-also

Canvas.ZIndex](canvas_zindex.md), [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview)
