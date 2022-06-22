---
-api-id: P:Windows.UI.Xaml.Controls.Hub.Header
-api-type: winrt property
---

<!-- Property syntax
public object Header { get;  set; }
-->

# Windows.UI.Xaml.Controls.Hub.Header

## -description
Gets or sets the content for the hub header.



## -xaml-syntax
```xaml
<Hub Header="headerString"/>
- or -
<Hub>
  <Hub.Header>
    headerObject
  </Hub.Header>
</Hub>

```


## -xaml-values
<dl><dt>headerString</dt><dd>headerStringA text string that serves as header content.</dd>
<dt>headerObject</dt><dd>headerObjectAn single object element that serves as header content. Use discretion when using objects as header content; not all objects are suitable for use within the limited presentation surface that appears for headers.</dd>
</dl>
## -property-value
The content of the hub header. The default is **null**.

## -remarks
Add a header to let users know the context of your [Hub](hub.md). This is often the name of your app. It's important to remember that although you can use arbitrary content in the header, the height of the header affects the amount of vertical space available for your hub section content. The header remains fixed in its position and doesn't scroll with the hub sections.

You can use a data template for the header by setting the [HeaderTemplate](hub_headertemplate.md) property.

## -examples

## -see-also
[HeaderTemplate](hub_headertemplate.md)
