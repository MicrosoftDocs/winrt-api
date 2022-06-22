---
-api-id: P:Windows.UI.Xaml.Controls.MenuFlyout.MenuFlyoutPresenterStyle
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Style MenuFlyoutPresenterStyle { get;  set; }
-->

# Windows.UI.Xaml.Controls.MenuFlyout.MenuFlyoutPresenterStyle

## -description
Gets or sets the style that is used when rendering the [MenuFlyout](menuflyout.md).



## -xaml-syntax
```xaml
<MenuFlyout MenuFlyoutPresenterStyle="resourceReferenceToStyle"/>
- or -
<MenuFlyout>
  <MenuFlyout.FlyoutPresenterStyle>
    <Style TargetType="FlyoutPresenter">
      oneOrMoreSetters
    </Style>
  </MenuFlyout.FlyoutPresenterStyle>
</MenuFlyout>
```


## -xaml-values
<dl><dt>resourceReferenceToStyle</dt><dd>resourceReferenceToStyleA {StaticResource} markup extension reference to an existing Style from a XAML resource dictionary.</dd>
<dt>oneOrMoreSetters</dt><dd>oneOrMoreSettersOne or more Setter elements with Property attributes that target the dependency properties of a FlyoutPresenter.</dd>
</dl>
## -property-value
The style that is used when rendering the [MenuFlyout](menuflyout.md).

## -remarks
The [TargetType](../windows.ui.xaml/style_targettype.md) value to use for the [Style](../windows.ui.xaml/style.md) must be [MenuFlyoutPresenter](menuflyoutpresenter.md) (not **MenuFlyout**).

You can't style a [MenuFlyout](menuflyout.md) directly. Instead, you apply a style to the [MenuFlyoutPresenter](menuflyoutpresenter.md) that provides the visuals for the flyout. You can also style [MenuFlyoutItem](menuflyoutitem.md) and [ToggleMenuFlyoutItem](togglemenuflyoutitem.md) (they are controls) and you can use implicit styles to do so. Or, you can set UI-related properties on the [MenuFlyoutItem](menuflyoutitem.md) and [ToggleMenuFlyoutItem](togglemenuflyoutitem.md) items directly.

## -examples

## -see-also
[MenuFlyoutPresenter](menuflyoutpresenter.md)
