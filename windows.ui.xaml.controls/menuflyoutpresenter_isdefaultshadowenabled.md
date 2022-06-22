---
-api-id: P:Windows.UI.Xaml.Controls.MenuFlyoutPresenter.IsDefaultShadowEnabled
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public bool IsDefaultShadowEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.MenuFlyoutPresenter.IsDefaultShadowEnabled

## -description

Gets or sets a value that indicates whether the default shadow effect is shown.



## -property-value

**true** if the default shadow effect is shown; otherwise, **false**. The default is **true**.

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Z-depth and shadow](/windows/uwp/design/layout/depth-shadow).

Many common controls automatically cast shadows using a [ThemeShadow](../windows.ui.xaml.media/themeshadow.md). 

If a default shadow doesn't look correct on your MenuFlyout's content then you can disable it by setting this property to `false`.

## -see-also

## -examples

