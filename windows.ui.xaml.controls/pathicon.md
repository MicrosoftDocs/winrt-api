---
-api-id: T:Windows.UI.Xaml.Controls.PathIcon
-api-type: winrt class
---

<!-- Class syntax.
public class PathIcon : Windows.UI.Xaml.Controls.IconElement, Windows.UI.Xaml.Controls.IPathIcon
-->

# Windows.UI.Xaml.Controls.PathIcon

## -description

Represents an icon that uses a vector path as its content.


## -xaml-syntax

```xaml
<PathIcon .../>
```

## -remarks

> [!NOTE]
> You can set the **Foreground** property on the [AppBarButton](appbarbutton.md) or on the PathIcon. If you set the [Foreground](control_foreground.md) on the [AppBarButton](appbarbutton.md), it's applied only to the default visual state. It's not applied to the other visual states defined in the [AppBarButton](appbarbutton.md) template, like `MouseOver`. If you set the [Foreground](iconelement_foreground.md) on the PathIcon, the color is applied to all visual states.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Command bar](/windows/uwp/controls-and-patterns/app-bars).
>
> If you have the **WinUI 2 Gallery** app installed, click here to [open the app and see the PathIcon in action](winui2gallery:/item/AppBarButton).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)

This example shows an [AppBarButton](appbarbutton.md) with a PathIcon.

```xaml
<!-- App bar button with path icon. -->
<AppBarButton Label="PathIcon" Click="AppBarButton_Click">
    <AppBarButton.Icon>
        <PathIcon Data="F1 M 16,12 20,2L 20,16 1,16" HorizontalAlignment="Center"/>
    </AppBarButton.Icon>
</AppBarButton>
```



## -see-also
[IconElement](iconelement.md), [AppBarButton](appbarbutton.md), [Path](../windows.ui.xaml.shapes/path.md), [Move and draw commands syntax](/windows/uwp/xaml-platform/move-draw-commands-syntax), [Icons for UWP apps](/windows/uwp/style/icons) 
