---
-api-id: T:Windows.UI.Xaml.Controls.FlyoutPresenter
-api-type: winrt class
---

<!-- Class syntax.
public class FlyoutPresenter : Windows.UI.Xaml.Controls.ContentControl, Windows.UI.Xaml.Controls.IFlyoutPresenter
-->

# Windows.UI.Xaml.Controls.FlyoutPresenter

## -description
Displays the content of a [Flyout](flyout.md).

## -xaml-syntax
```xaml

See Remarks

```


## -remarks
You don't typically declare object elements for [FlyoutPresenter](flyoutpresenter.md) in XAML. There are no properties that a [FlyoutPresenter](flyoutpresenter.md) can set in XAML syntax and there's no reason to declare a [FlyoutPresenter](flyoutpresenter.md) as a resource.

The main purpose of the [FlyoutPresenter](flyoutpresenter.md) class is to be the default internal presenter for the [Content](flyout_content.md) value of a [Flyout](flyout.md). The [Content](flyout_content.md) property can be any [UIElement](../windows.ui.xaml/uielement.md). The [FlyoutPresenter](flyoutpresenter.md) can apply presentation that can modify presentation info declared on the element used as [Content](flyout_content.md). You extend presentation behavior of the [FlyoutPresenter](flyoutpresenter.md) by setting a value for the [FlyoutPresenterStyle](flyout_flyoutpresenterstyle.md) property of the [Flyout](flyout.md). The [Style](../windows.ui.xaml/style.md) you declare that fills the [FlyoutPresenterStyle](flyout_flyoutpresenterstyle.md) property must specify `TargetType="FlyoutPresenter"`. The properties that can be styled are the dependency properties of the base [ContentControl](contentcontrol.md) class or [Control](control.md) class, such as [FontSize](control_fontsize.md) or [Padding](control_padding.md), or base element properties such as [FrameworkElement.Margin](../windows.ui.xaml/frameworkelement_margin.md) that the [FlyoutPresenter](flyoutpresenter.md) class inherits.

[FlyoutPresenter](flyoutpresenter.md) exists as a class and has a default constructor basically to satisfy XAML infrastructure support, when it's specified as the [TargetType](../windows.ui.xaml/style_targettype.md) of the [Style](../windows.ui.xaml/style.md) used for a [FlyoutPresenterStyle](flyout_flyoutpresenterstyle.md) value.

## -examples

## -see-also
[ContentControl](contentcontrol.md), [Flyout](flyout.md), [FlyoutPresenter styles and templates](http://msdn.microsoft.com/library/eefbb325-9c9b-4c52-936a-c009377da75d)