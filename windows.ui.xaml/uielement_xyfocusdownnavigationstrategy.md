---
-api-id: P:Windows.UI.Xaml.UIElement.XYFocusDownNavigationStrategy
-api-type: winrt property
---

<!-- Property syntax.
public XYFocusNavigationStrategyMode XYFocusDownNavigationStrategy { get;  set; }
-->

# Windows.UI.Xaml.UIElement.XYFocusDownNavigationStrategy

## -description

Gets or sets a value that specifies the strategy used to determine the target element of a down navigation.



## -xaml-syntax

```xaml
<uiElement XYFocusDownNavigationStrategy="xyFocusNavigationStrategyMemberName"/>
```

## -xaml-values

***xyFocusNavigationStrategyMemberName***

One of the named constants of the [XYFocusNavigationStrategy](../windows.ui.xaml.input/xyfocusnavigationstrategy.md) enumeration.

## -property-value

A value of the enumeration. The default is **Auto**.

## -remarks

When this property is set to **Auto**, the strategy is inherited from the elements ancestors. If all ancestors have a value of **Auto**, the fallback strategy is **Projection**.  

## -see-also

[XYFocusNavigationStrategy](../windows.ui.xaml.input/xyfocusnavigationstrategy.md)

## -examples

