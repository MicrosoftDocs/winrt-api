---
-api-id: P:Windows.UI.Xaml.UIElement.XYFocusKeyboardNavigation
-api-type: winrt property
---

<!-- Property syntax.
public XYFocusKeyboardNavigationMode XYFocusKeyboardNavigation { get;  set; }
-->

# Windows.UI.Xaml.UIElement.XYFocusKeyboardNavigation

## -description

Gets or sets a value that enables or disables navigation using the keyboard directional arrows.



## -xaml-syntax

```xaml
<uiElement XYFocusKeyboardNavigation="xyFocusKeyboardNavigationModeMemberName"/>
```

## -xaml-values

***xyFocusKeyboardNavigationModeMemberName***

One of the named constants of the [XYFocusKeyboardNavigationMode](../windows.ui.xaml.input/xyfocuskeyboardnavigationmode.md) enumeration.

## -property-value

A value of the enumeration. The default is **Auto**.

## -remarks

When this property is set to **Auto**, the behavior is inherited from the elements ancestors. If all ancestors have a value of **Auto**, the fallback behavior is **Disabled**.  

## -see-also

[XYFocusKeyboardNavigationMode](../windows.ui.xaml.input/xyfocuskeyboardnavigationmode.md)

## -examples

