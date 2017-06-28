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

A [MenuFlyout](menuflyout.md) control can be used as the value of the [Button.Flyout](button_flyout.md) property. This is usually set in XAML as part of a UI definition of the page. [Button](button.md) is the only control that has a dedicated **Flyout** property. To associate a [MenuFlyout](menuflyout.md) with other controls, use the [FlyoutBase.AttachedFlyout](../windows.ui.xaml.controls.primitives/flyoutbase_attachedflyout.md) attached property. When set as [Button.Flyout](button_flyout.md), the [MenuFlyout](menuflyout.md) displays when the button is tapped or otherwise invoked. When a [MenuFlyout](menuflyout.md) is assigned to other UI elements using [FlyoutBase.AttachedFlyout](../windows.ui.xaml.controls.primitives/flyoutbase_attachedflyout.md), you must call either the [ShowAt](../windows.ui.xaml.controls.primitives/flyoutbase_showat.md) method or the static [ShowAttachedFlyout](../windows.ui.xaml.controls.primitives/flyoutbase_showattachedflyout.md) method to display the flyout.

In addition to the members listed above, there are other members of the base class [FlyoutBase](../windows.ui.xaml.controls.primitives/flyoutbase.md) that are often used in typical [MenuFlyout](menuflyout.md) scenarios:
+ [FlyoutBase.AttachedFlyout](../windows.ui.xaml.controls.primitives/flyoutbase_attachedflyout.md): an attached property that associates a [MenuFlyout](menuflyout.md) with a particular UI element (this can be any [FrameworkElement](../windows.ui.xaml/frameworkelement.md) derived class).
+ [ShowAttachedFlyout](../windows.ui.xaml.controls.primitives/flyoutbase_showattachedflyout.md): a static method that can determine whether a flyout is already associated with a UI element through a [FlyoutBase.AttachedFlyout](../windows.ui.xaml.controls.primitives/flyoutbase_attachedflyout.md) usage. If so, the method calls [ShowAt](../windows.ui.xaml.controls.primitives/flyoutbase_showat.md) internally, using the [FrameworkElement](../windows.ui.xaml/frameworkelement.md) that you specified.

## -examples

## -see-also

[FlyoutBase](../windows.ui.xaml.controls.primitives/flyoutbase.md), [MenuFlyoutPresenter](menuflyoutpresenter.md), [Button.Flyout](button_flyout.md), [FlyoutBase.AttachedFlyout](../windows.ui.xaml.controls.primitives/flyoutbase_attachedflyout.md), [Attached properties overview](http://msdn.microsoft.com/library/098c1de0-d640-48b1-9961-d0adf33266e2), [XAML Flyout and MenuFlyout sample](http://go.microsoft.com/fwlink/p/?LinkID=310074), [Flyout](flyout.md), [Controls list](http://msdn.microsoft.com/library/11172840-a63d-4f48-9db4-7baca06308ee), [Controls by function](http://msdn.microsoft.com/library/8db4347b-91d6-4659-91f2-80ecf7bbb596), [Commanding sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620019)