---
-api-id: P:Windows.UI.Xaml.Documents.Hyperlink.XYFocusRightNavigationStrategy
-api-type: winrt property
---

<!-- Property syntax.
public XYFocusNavigationStrategy XYFocusRightNavigationStrategy { get;  set; }
-->

# Windows.UI.Xaml.Documents.Hyperlink.XYFocusRightNavigationStrategy

## -description
Gets or sets a value that specifies the strategy used to determine the target element of a right navigation.

Equivalent WinUI property: [Microsoft.UI.Xaml.Documents.Hyperlink.XYFocusRightNavigationStrategy](/windows/winui/api/microsoft.ui.xaml.documents.hyperlink.xyfocusrightnavigationstrategy).

## -xaml-syntax
```xaml
<Hyperlink XYFocusRightNavigationStrategy="xyFocusNavigationStrategyMemberName"/>
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

