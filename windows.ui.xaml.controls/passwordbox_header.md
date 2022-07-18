---
-api-id: P:Windows.UI.Xaml.Controls.PasswordBox.Header
-api-type: winrt property
---

<!-- Property syntax
public object Header { get;  set; }
-->

# Windows.UI.Xaml.Controls.PasswordBox.Header

## -description
Gets or sets the content for the control's header.



## -xaml-syntax
```xaml
<PasswordBox Header="headerString"/>
- or -
<PasswordBox>
  <PasswordBox.Header>headerObject</PasswordBox.Header>
</PasswordBox>

```


## -xaml-values
<dl><dt>headerString</dt><dd>headerStringA text string that serves as header content.</dd>
<dt>headerObject</dt><dd>headerObjectA single object element that serves as header content. Use discretion when using objects as header content; not all objects are suitable for use within the limited presentation surface that appears for headers.</dd>
</dl>
## -property-value
The content of the control's header. The default is **null**.

## -remarks
You can set a data template for the Header value by using the [HeaderTemplate](passwordbox_headertemplate.md) property.

## -examples

## -see-also
[Password](passwordbox_password.md), [HeaderTemplate](passwordbox_headertemplate.md)
