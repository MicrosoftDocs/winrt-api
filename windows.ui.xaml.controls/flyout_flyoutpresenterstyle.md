---
-api-id: P:Windows.UI.Xaml.Controls.Flyout.FlyoutPresenterStyle
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Style FlyoutPresenterStyle { get;  set; }
-->

# Windows.UI.Xaml.Controls.Flyout.FlyoutPresenterStyle

## -description
Gets or sets the [Style](../windows.ui.xaml/style.md) applied to the [Flyout](flyout.md) content.



## -xaml-syntax
```xaml
<Flyout FlyoutPresenterStyle={StaticResource styleResourceKey}/>
- or -
<Flyout>
  <Flyout.FlyoutPresenterStyle>
    <Style TargetType="FlyoutPresenter">
      oneOrMoreSetters
    </Style>
  </Flyout.FlyoutPresenterStyle>
</Flyout>
```


## -xaml-values
<dl><dt>styleResourceKey</dt><dd>styleResourceKeyThe key that identifies the style being requested. The key refers to an existing resource in a ResourceDictionary.</dd>
<dt>oneOrMoreSetters</dt><dd>oneOrMoreSettersOne or more Setter elements with Property attributes that target the dependency properties of a FlyoutPresenter.</dd>
</dl>
## -property-value
The applied [Style](../windows.ui.xaml/style.md) for the [Flyout](flyout.md) content, if present; otherwise, **null**. The default is **null**.

## -remarks
The [Style](../windows.ui.xaml/style.md) element you use for a FlyoutPresenterStyle value must specify `TargetType="FlyoutPresenter"`.

A [Flyout](flyout.md) itself isn't a control or even a [UIElement](../windows.ui.xaml/uielement.md), and thus doesn't have any properties to apply a [Style](../windows.ui.xaml/style.md) to. Instead, you can style the properties of the internal [FlyoutPresenter](flyoutpresenter.md) that is presenting the [Content](flyout_content.md) of a [Flyout](flyout.md). The properties that can be styled are the dependency properties of the base [ContentControl](contentcontrol.md) class or [Control](control.md) class, such as [FontSize](control_fontsize.md) or [Padding](control_padding.md), or base element properties such as [FrameworkElement.Margin](../windows.ui.xaml/frameworkelement_margin.md) that the [FlyoutPresenter](flyoutpresenter.md) class inherits. You also can use the properties that are available on whichever element you're setting as [Flyout.Content](flyout_content.md), and set values of those properties directly rather than styling the [FlyoutPresenter](flyoutpresenter.md).

## -examples

## -see-also
[Content](flyout_content.md), [FlyoutPresenter](flyoutpresenter.md), [Styling controls](/windows/uwp/controls-and-patterns/styling-controls)
