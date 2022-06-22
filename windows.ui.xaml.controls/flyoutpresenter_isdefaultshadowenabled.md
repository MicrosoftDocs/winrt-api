---
-api-id: P:Windows.UI.Xaml.Controls.FlyoutPresenter.IsDefaultShadowEnabled
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public bool IsDefaultShadowEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.FlyoutPresenter.IsDefaultShadowEnabled

## -description

Gets or sets a value that indicates whether the default shadow effect is shown.



## -property-value

**true** if the default shadow effect is shown; otherwise, **false**. The default is **true**.

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Z-depth and shadow](/windows/uwp/design/layout/depth-shadow).

Many common controls automatically cast shadows using a [ThemeShadow](../windows.ui.xaml.media/themeshadow.md). 

If the default shadow doesn't look correct on your Flyout's content then you can disable it by setting this property to `false`.

## -see-also

## -examples

