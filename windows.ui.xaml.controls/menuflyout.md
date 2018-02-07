---
-api-id: T:Windows.UI.Xaml.Controls.MenuFlyout
-api-type: winrt class
---

<!-- Class syntax.
public class MenuFlyout : Windows.UI.Xaml.Controls.Primitives.FlyoutBase, Windows.UI.Xaml.Controls.IMenuFlyout, Windows.UI.Xaml.Controls.IMenuFlyout2
-->

# Windows.UI.Xaml.Controls.MenuFlyout

## -description

Represents a flyout that displays a menu of commands.

## -xaml-syntax

```xaml
<MenuFlyout>
  oneOrMoreItems
</MenuFlyout>
```

## -remarks

[MenuFlyout](menuflyout.md) temporarily displays a list of commands or options related to what the user is currently doing.

<img src="images/controls/MenuFlyout.png" alt="Menu flyout control" />

Use a [Flyout](flyout.md) control to display single items and a [MenuFlyout](menuflyout.md) control to show a menu of items. For more info, see [Menus and context menus](https://docs.microsoft.com/windows/uwp/controls-and-patterns/menus).

A [MenuFlyout](menuflyout.md) control can be used as the value of the [Button.Flyout](button_flyout.md) property. This is usually set in XAML as part of a UI definition of the page. [Button](button.md) is the only control that has a dedicated **Flyout** property. When set as [Button.Flyout](button_flyout.md), the [MenuFlyout](menuflyout.md) displays when the button is tapped or otherwise invoked.

To associate a [MenuFlyout](menuflyout.md) with other controls, use the [ContextFlyout](../windows.ui.xaml/uielement_contextflyout.md) property that's available on any UIElement.

## Notes for previous versions

> [!NOTE]
> The ContextFlyout property is not available prior to the Windows 10 Anniversary Update (SDK version 14393). For earlier versions, use the [FlyoutBase.AttachedFlyout](../windows.ui.xaml.controls.primitives/flyoutbase_attachedflyout.md) attached property.

You can use the [FlyoutBase.AttachedFlyout](../windows.ui.xaml.controls.primitives/flyoutbase_attachedflyout.md) attached property to associate a [MenuFlyout](menuflyout.md) with other controls. When a [MenuFlyout](menuflyout.md) is assigned to other UI elements using [FlyoutBase.AttachedFlyout](../windows.ui.xaml.controls.primitives/flyoutbase_attachedflyout.md), you must call either the [ShowAt](../windows.ui.xaml.controls.primitives/flyoutbase_showat.md) method or the static [ShowAttachedFlyout](../windows.ui.xaml.controls.primitives/flyoutbase_showattachedflyout.md) method to display the flyout.

In addition to the members listed above, there are other members of the base class [FlyoutBase](../windows.ui.xaml.controls.primitives/flyoutbase.md) that are often used in typical [MenuFlyout](menuflyout.md) scenarios:

+ [FlyoutBase.AttachedFlyout](../windows.ui.xaml.controls.primitives/flyoutbase_attachedflyout.md): an attached property that associates a [MenuFlyout](menuflyout.md) with a particular UI element (this can be any [FrameworkElement](../windows.ui.xaml/frameworkelement.md) derived class).
+ [ShowAttachedFlyout](../windows.ui.xaml.controls.primitives/flyoutbase_showattachedflyout.md): a static method that can determine whether a flyout is already associated with a UI element through a [FlyoutBase.AttachedFlyout](../windows.ui.xaml.controls.primitives/flyoutbase_attachedflyout.md) usage. If so, the method calls [ShowAt](../windows.ui.xaml.controls.primitives/flyoutbase_showat.md) internally, using the [FrameworkElement](../windows.ui.xaml/frameworkelement.md) that you specified.

## -examples

<table>
<th align="left">XAML Controls Gallery<th>
<tr>
<td><img src="images/xaml-controls-gallery-sm.png" alt="XAML controls gallery"></img></td>
<td>
    <p>If you have the <strong style="font-weight: semi-bold">XAML Controls Gallery</strong> app installed, click here to <a href="xamlcontrolsgallery:/item/MenuFlyout">open the app and see the MenuFlyout in action</a>.</p>
    <ul>
    <li><a href="https://www.microsoft.com/store/productId/9MSVH128X2ZT">Get the XAML Controls Gallery app (Microsoft Store)</a></li>
    <li><a href="https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlUIBasics">Get the source code (GitHub)</a></li>
    </ul>
</td>
</tr>
</table>

This example creates a [MenuFlyout class](https://msdn.microsoft.com/library/windows/apps/dn299030) and uses the [ContextFlyout](https://msdn.microsoft.com/library/windows/apps/windows.ui.xaml.uielement.contextflyout.aspx) property, a property available to most controls, to show the [MenuFlyout class](https://msdn.microsoft.com/library/windows/apps/dn299030) as a context menu.

````xaml
<Rectangle Height="100" Width="100">
  <Rectangle.ContextFlyout>
    <MenuFlyout>
      <MenuFlyoutItem Text="Change color" Click="ChangeColorItem_Click" />
    </MenuFlyout>
  </Rectangle.ContextFlyout>
  <Rectangle.Fill>
    <SolidColorBrush x:Name="rectangleFill" Color="Red" />
  </Rectangle.Fill>
</Rectangle>
````

````csharp
private void ChangeColorItem_Click(object sender, RoutedEventArgs e)
{
    // Change the color from red to blue or blue to red.
    if (rectangleFill.Color == Windows.UI.Colors.Red)
    {
        rectangleFill.Color = Windows.UI.Colors.Blue;
    }
    else
    {
        rectangleFill.Color = Windows.UI.Colors.Red;
    }
}
````

The next example is nearly identical, but instead of using the [ContextFlyout](https://msdn.microsoft.com/library/windows/apps/windows.ui.xaml.uielement.contextflyout.aspx) property to show the [MenuFlyout class](https://msdn.microsoft.com/library/windows/apps/dn299030) as a context menu, the example uses the [FlyoutBase.ShowAttachedFlyout](https://msdn.microsoft.com/library/windows/apps/windows.ui.xaml.controls.primitives.flyoutbase.showattachedflyout) property to show it as a menu.

````xaml
<Rectangle
  Height="100" Width="100"
  Tapped="Rectangle_Tapped">
  <FlyoutBase.AttachedFlyout>
    <MenuFlyout>
      <MenuFlyoutItem Text="Change color" Click="ChangeColorItem_Click" />
    </MenuFlyout>
  </FlyoutBase.AttachedFlyout>
  <Rectangle.Fill>
    <SolidColorBrush x:Name="rectangleFill" Color="Red" />
  </Rectangle.Fill>
</Rectangle>
````

````csharp
private void Rectangle_Tapped(object sender, TappedRoutedEventArgs e)
{
    FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
}

private void ChangeColorItem_Click(object sender, RoutedEventArgs e)
{
    // Change the color from red to blue or blue to red.
    if (rectangleFill.Color == Windows.UI.Colors.Red)
    {
        rectangleFill.Color = Windows.UI.Colors.Blue;
    }
    else
    {
        rectangleFill.Color = Windows.UI.Colors.Red;
    }
}
````

## -see-also
[Menus and context menus overview](https://docs.microsoft.com/en-us/windows/uwp/controls-and-patterns/menus), [MenuFlyoutPresenter](menuflyoutpresenter.md), [FlyoutBase](../windows.ui.xaml.controls.primitives/flyoutbase.md), [Flyout](flyout.md), [Button.Flyout](button_flyout.md), [Attached properties overview](https://docs.microsoft.com/en-us/windows/uwp/xaml-platform/attached-properties-overview), [Context menu sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlContextMenu)
