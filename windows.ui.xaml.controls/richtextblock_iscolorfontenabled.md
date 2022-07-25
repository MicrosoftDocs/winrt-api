---
-api-id: P:Windows.UI.Xaml.Controls.RichTextBlock.IsColorFontEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsColorFontEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.RichTextBlock.IsColorFontEnabled

## -description
Gets or sets a value that determines whether font glyphs that contain color layers, such as Segoe UI Emoji, are rendered in color.



## -xaml-syntax
```xaml
<RichEditBlock IsColorFontEnabled="bool" />
```


## -property-value
**true** if color glyphs show in color; otherwise, **false**. The default is **true**.

## -remarks
Windows 8.1 introduces the ability for fonts to include multiple colored layers for each glyph. For example, the Segoe UI Emoji font defines color versions of the Emoticon and other Emoji characters. By default, the IsColorFontEnabled property is **true** and fonts with these additional layers are rendered in color.


<!--The following remark is relevant for Windows 8 > 8.1 migration. See Windows Blue bug 452226.-->
In Windows 8, Extensible Application Markup Language (XAML) text controls don't render multi-color fonts in color. When an app that was compiled for Windows 8 is recompiled for Windows 8.1, color rendering of multi-color fonts is enabled by default. Some glyphs in multi-color fonts have different layout metrics when rendered in color. This could cause different layout in apps when they are recompiled for Windows 8.1. To retain the Windows 8 behavior when your app is recompiled for Windows 8.1, set IsColorFontEnabled to **false**.

## -examples

## -see-also
