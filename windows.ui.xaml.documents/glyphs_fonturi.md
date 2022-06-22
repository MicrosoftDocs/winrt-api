---
-api-id: P:Windows.UI.Xaml.Documents.Glyphs.FontUri
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri FontUri { get;  set; }
-->

# Windows.UI.Xaml.Documents.Glyphs.FontUri

## -description
Gets or sets the location of the font used for rendering the glyphs.



## -xaml-syntax
```xaml
<Glyphs FontUri="uriString"/>
```


## -property-value
An object describing the Uniform Resource Identifier (URI) source of the font. The default is null.

## -remarks

## -examples
This example shows how to reference a font file that's included in the Assets folder of a project. To embed a font file in a project, set its **Build Action** to **Content** in Microsoft Visual Studio.

```csharp
glyph.FontUri = new Uri("ms-appx:///Assets/segoeui.ttf");

```



## -see-also
