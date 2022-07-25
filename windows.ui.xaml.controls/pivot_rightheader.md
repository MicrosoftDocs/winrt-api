---
-api-id: P:Windows.UI.Xaml.Controls.Pivot.RightHeader
-api-type: winrt property
---

<!-- Property syntax
public object RightHeader { get;  set; }
-->

# Windows.UI.Xaml.Controls.Pivot.RightHeader

## -description
Gets or sets the content for the header on the control's right side.



## -xaml-syntax
```xaml
<Pivot RightHeader="headerString"/>
- or -
<Pivot>
  <Pivot.RightHeader>headerObject</Pivot.RightHeader>
</Pivot>

```


## -xaml-values
<dl><dt>headerString</dt><dd>headerStringA text string that serves as header content.</dd>
<dt>headerObject</dt><dd>headerObjectA single object element that serves as header content. Use discretion when using objects as header content; not all objects are suitable for use within the limited presentation surface that appears for headers.</dd>
</dl>
## -property-value
The content of the header on the control's right side. The default is **null**.

## -remarks
You can set a data template for the RightHeader value by using the [RightHeaderTemplate](pivot_rightheadertemplate.md) property.

## -examples

## -see-also
[LeftHeader](pivot_leftheader.md), [RightHeaderTemplate](pivot_rightheadertemplate.md)
