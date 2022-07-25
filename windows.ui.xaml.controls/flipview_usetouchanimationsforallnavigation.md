---
-api-id: P:Windows.UI.Xaml.Controls.FlipView.UseTouchAnimationsForAllNavigation
-api-type: winrt property
---

<!-- Property syntax
public bool UseTouchAnimationsForAllNavigation { get;  set; }
-->

# Windows.UI.Xaml.Controls.FlipView.UseTouchAnimationsForAllNavigation

## -description
Gets or sets a value that indicates whether transition animations are always used whether the navigation is touch-based, button-based or programmatic.



## -xaml-syntax
```xaml
<FlipView UseTouchAnimationsForAllNavigation="bool" />
```


## -property-value
**true** if transition animations are always used; **false** if transition animations are used only for touch navigation. The default is **true**.

## -remarks
The XAML [FlipView](flipview.md) control supports three modes of navigation; touch-based, button-based and programmatic. When a user navigates by touch, the [FlipView](flipview.md) items scroll smoothly into view. When you set this property to **true**, the same navigation animation occurs whether the navigation is touch-based, button-based and programmatic. If UseTouchAnimationsForAllNavigation is **false** and the user navigates by mouse, keyboard, or programmatically, the animation doesn't occur and items just pop into view.

<!--Windows Blue bug 467555-->
> **Windows 8**
> In Windows 8, the [FlipView](flipview.md) navigation animation occurs only when the user navigates by touch. If you recompile an app built for Windows 8 for Windows 8.1 and need to keep the Windows 8 behavior, set this property to **false**. For example, if you check the [HorizontalOffset](scrollviewer_horizontaloffset.md) property value of [FlipView](flipview.md)'s internal [ScrollViewer](scrollviewer.md) while the selection is changing, the value is not fixed until the animation is complete. If your app has a dependency on this value, you can set this property to **false**.

## -examples

## -see-also
