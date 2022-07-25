---
-api-id: P:Windows.UI.Xaml.Documents.Hyperlink.XYFocusUpNavigationStrategy
-api-type: winrt property
---

<!-- Property syntax.
public XYFocusNavigationStrategy XYFocusUpNavigationStrategy { get;  set; }
-->

# Windows.UI.Xaml.Documents.Hyperlink.XYFocusUpNavigationStrategy

## -description
Gets or sets a value that specifies the strategy used to determine the target element of an up navigation.



## -xaml-syntax
```xaml
<Hyperlink XYFocusUpNavigationStrategy="xyFocusNavigationStrategyMemberName"/>
```

## -xaml-values
<dl><dt>xyFocusNavigationStrategyMemberName</dt><dd>xyFocusNavigationStrategyMemberNameOne of the named constants of the [XYFocusNavigationStrategy](../windows.ui.xaml.input/xyfocusnavigationstrategy.md) enumeration.</dd>
</dl>

## -property-value
A value of the enumeration. The default is **Auto**.

## -remarks
When this property is set to **Auto**, the strategy is inherited from the elements ancestors. If all ancestors have a value of **Auto**, the fallback strategy is **Projection**.  

## -see-also
[XYFocusNavigationStrategy](../windows.ui.xaml.input/xyfocusnavigationstrategy.md)

## -examples

