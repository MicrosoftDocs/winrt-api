---
-api-id: P:Windows.UI.Xaml.Controls.DatePicker.Header
-api-type: winrt property
---

<!-- Property syntax
public object Header { get;  set; }
-->

# Windows.UI.Xaml.Controls.DatePicker.Header

## -description
Gets or sets the content for the control's header.

## -xaml-syntax
```xaml
<DatePicker Header="headerString"/>

```

```xaml
<DatePicker>
  <DatePicker.Header>headerObject</DatePicker.Header>
</DatePicker>

```


## -xaml-values
<dl><dt>headerString</dt><dd>headerStringA text string that serves as header content.</dd>
<dt>headerObject</dt><dd>headerObjectAn single object element that serves as header content. Use discretion when using objects as header content; not all objects are suitable for use within the limited presentation surface that appears for headers.</dd>
</dl>
## -property-value
The content of the control's header. The default is **null**.

## -remarks
You can set a data template for the [Header](datepicker_header.md) value by using the [HeaderTemplate](datepicker_headertemplate.md) property.

## -examples

## -see-also
[HeaderTemplate](datepicker_headertemplate.md), [Quickstart: Adding a DatePicker](http://msdn.microsoft.com/library/feae870d-e423-457b-9d0a-3929247952a9)