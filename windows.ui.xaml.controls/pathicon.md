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
> You can set the **Foreground** property on the [AppBarButton](appbarbutton.md) or on the [PathIcon](pathicon.md). If you set the [Foreground](control_foreground.md) on the [AppBarButton](appbarbutton.md), it's applied only to the default visual state. It's not applied to the other visual states defined in the [AppBarButton](appbarbutton.md) template, like `MouseOver`. If you set the [Foreground](iconelement_foreground.md) on the [PathIcon](pathicon.md), the color is applied to all visual states.

## -examples
This example shows an [AppBarButton](appbarbutton.md) with a [PathIcon](pathicon.md).

```xaml
<!-- App bar button with path icon. -->
<AppBarButton Label="PathIcon" Click="AppBarButton_Click">
    <AppBarButton.Icon>
        <PathIcon Data="F1 M 16,12 20,2L 20,16 1,16" HorizontalAlignment="Center"/>
    </AppBarButton.Icon>
</AppBarButton>
```



## -see-also
[IconElement](iconelement.md), [AppBarButton](appbarbutton.md), [Path](../windows.ui.xaml.shapes/path.md), [Move and draw commands syntax](https://docs.microsoft.com/windows/uwp/xaml-platform/move-draw-commands-syntax), [Icons for UWP apps](https://docs.microsoft.com/windows/uwp/style/icons) 
