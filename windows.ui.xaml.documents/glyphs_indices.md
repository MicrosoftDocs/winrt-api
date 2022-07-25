---
-api-id: P:Windows.UI.Xaml.Documents.Glyphs.Indices
-api-type: winrt property
---

<!-- Property syntax
public string Indices { get;  set; }
-->

# Windows.UI.Xaml.Documents.Glyphs.Indices

## -description

Gets or sets a collection of glyph specifications that represents the Glyphs object.



## -xaml-syntax

```xaml
<Glyphs Indices="string"/>
```

## -property-value

A collection of glyph specifications that represents the Glyphs object.
A string that defines the position of a glyph in the font as well as other glyph specifics in a string mini-language. The default is an empty string.

## -remarks

A sequence of glyphs forms a single cluster. The specification of the first glyph in the cluster is preceded by a specification of how many glyphs and how many code points combine to form the cluster. The Indices property collects in one string the following properties:

- Glyph indices
- Glyph advance widths
- Combining glyph attachment vectors
- Cluster mapping from code points to glyphs
- Glyph flags

Each glyph specification has the following form.

`[GlyphIndex][,[Advance][,[uOffset][,[vOffset][,[Flags]]]]]`

## -examples

## -see-also
