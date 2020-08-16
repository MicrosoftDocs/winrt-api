---
-api-id: T:Windows.UI.Xaml.Controls.Flyout
-api-type: winrt class
---

<!-- Class syntax.
public class Flyout : Windows.UI.Xaml.Controls.Primitives.FlyoutBase, Windows.UI.Xaml.Controls.IFlyout
-->

# Windows.UI.Xaml.Controls.Flyout

## -description

Represents a control that displays lightweight UI that is either information, or requires user interaction. Unlike a dialog, a Flyout can be light dismissed by clicking or tapping outside of it, pressing the device’s back button, or pressing the ‘Esc’ key.

## -xaml-syntax

```xaml

<Flyout>
    singleUIElement
</Flyout>

```

## -remarks

A Flyout displays a message that requires user interaction.

<img src="images/controls/Flyout.png" alt="Flyout control" />

Use a Flyout control for collecting information, for displaying more info, or for warnings and confirmations. Unlike a dialog, a Flyout does not create a separate window, and does not block other user interaction. To show a menu of items, use a [MenuFlyout](menuflyout.md) instead. For more info, including XAML and code examples, see [Quickstart: Adding a Flyout](https://docs.microsoft.com/previous-versions/windows/apps/dn308515(v=win.10)).

A Flyout control (or [MenuFlyout](menuflyout.md)) is used as the value of the [Button.Flyout](button_flyout.md) property. This is usually set in XAML as part of a UI definition of the page. [Button](button.md) is the only control that has a dedicated **Flyout** property. To associate a Flyout with other controls, use the [FlyoutBase.AttachedFlyout](/uwp/api/windows.ui.xaml.controls.primitives.flyoutbase#xaml-attached-properties) attached property. When set as [Button.Flyout](button_flyout.md), the Flyout displays when the button is tapped or otherwise invoked. When a Flyout is assigned to other UI elements using [FlyoutBase.AttachedFlyout](/uwp/api/windows.ui.xaml.controls.primitives.flyoutbase#xaml-attached-properties), you must call either the [ShowAt](../windows.ui.xaml.controls.primitives/flyoutbase_showat_157739403.md) method or the static [ShowAttachedFlyout](../windows.ui.xaml.controls.primitives/flyoutbase_showattachedflyout_1146189011.md) method to display the flyout.

In addition to the members listed in this reference topic, there are other members of the base class [FlyoutBase](../windows.ui.xaml.controls.primitives/flyoutbase.md) that are often used in typical Flyout scenarios:

+ [FlyoutBase.AttachedFlyout](/uwp/api/windows.ui.xaml.controls.primitives.flyoutbase#xaml-attached-properties): an attached property that associates a Flyout with a particular UI element (this can be any [FrameworkElement](../windows.ui.xaml/frameworkelement.md) derived class).
+ [ShowAttachedFlyout](../windows.ui.xaml.controls.primitives/flyoutbase_showattachedflyout_1146189011.md): a static method that can determine whether a flyout is already associated with a UI element through a [FlyoutBase.AttachedFlyout](/uwp/api/windows.ui.xaml.controls.primitives.flyoutbase#xaml-attached-properties) assignment. If so, the method calls [ShowAt](../windows.ui.xaml.controls.primitives/flyoutbase_showat_157739403.md) internally, using the [FrameworkElement](../windows.ui.xaml/frameworkelement.md) that you specified.

### Accessibility

If you use a Flyout with no focusable content-for example, with only text, as shown here-you should take some additional steps to ensure that your content is accessible. Specifically, you need to ensure that Windows Narrator or other screen readers can read the flyout’s content.

<img src="images/flyout-text.png" alt="Flyout control with text content" />

By default, there are properties set on the [FlyoutPresenter](flyoutpresenter.md) that prevent it from receiving focus. This is the desired behavior when content inside the Flyout can receive focus. However, if the content inside the Flyout can’t receive focus, you should update to the [FlyoutPresenterStyle](flyout_flyoutpresenterstyle.md) to let the [FlyoutPresenter](flyoutpresenter.md) receive focus instead. To do this, set [IsTabStop](control_istabstop.md) to **true** and [TabNavigation](control_tabnavigation.md) to **Cycle** on the flyout presenter style.

This example shows how to let the [FlyoutPresenter](flyoutpresenter.md) receive focus so that the content is accessible.

```xaml
<Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">
    <Button VerticalAlignment="Center" HorizontalAlignment="Center"
            Content="Open flyout">
        <Button.Flyout>
            <Flyout>
                <Flyout.FlyoutPresenterStyle>
                    <Style TargetType="FlyoutPresenter">
                        <Setter Property="ScrollViewer.HorizontalScrollMode" Value="Disabled"/>
                        <Setter Property="ScrollViewer.HorizontalScrollBarVisibility" Value="Disabled"/>
                        <Setter Property="IsTabStop" Value="True"/>
                        <Setter Property="TabNavigation" Value="Cycle"/>
                    </Style>
                </Flyout.FlyoutPresenterStyle>
                <TextBlock TextWrapping="Wrap" Text="This is some text in a flyout."/>
            </Flyout>
        </Button.Flyout>
    </Button>
</Grid>

```

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Flyouts](/windows/uwp/design/controls-and-patterns/dialogs-and-flyouts/flyouts).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the Flyout in action](xamlcontrolsgallery:/item/Flyout).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

## -see-also

[FlyoutBase](../windows.ui.xaml.controls.primitives/flyoutbase.md), [FlyoutPresenter](flyoutpresenter.md), [Button.Flyout](button_flyout.md), [MenuFlyout](menuflyout.md), [Dialogs v. flyouts](https://docs.microsoft.com/windows/uwp/controls-and-patterns/dialogs), [Attached properties overview](https://docs.microsoft.com/windows/uwp/xaml-platform/attached-properties-overview), [Commanding sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlCommanding), [XAML Flyout and MenuFlyout sample (Windows 8)](https://go.microsoft.com/fwlink/p/?LinkID=310074)
