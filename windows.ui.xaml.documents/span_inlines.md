---
-api-id: P:Windows.UI.Xaml.Documents.Span.Inlines
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Documents.InlineCollection Inlines { get;  set; }
-->

# Windows.UI.Xaml.Documents.Span.Inlines

## -description
Gets an [InlineCollection](inlinecollection.md) containing the top-level inline elements that include the contents of [Span](span.md).



## -xaml-syntax
```xaml
<Span ...>
  oneOrMoreInlines
</Span>
-or-
<Span ...>
  mixedContent
</Span>
```


## -xaml-values
<dl><dt>oneOrMoreInlines</dt><dd>oneOrMoreInlinesOne or more elements that derive from the Inline type.</dd>
<dt>mixedContent</dt><dd>mixedContentA mixture of inner text and elements that derive from the Inline type.</dd>
</dl>
## -property-value
An [InlineCollection](inlinecollection.md) containing the inline elements that include the contents of the [Span](span.md). This property has no default value.

## -remarks
[Hyperlink](hyperlink.md) has restrictions on the content that can exist in its Inlines colllection. Specifically, a [Hyperlink](hyperlink.md) only permits [Run](run.md) and other [Span](span.md) types that aren't another [Hyperlink](hyperlink.md). [InlineUIContainer](inlineuicontainer.md) can't be in the Inlines colllection of a [Hyperlink](hyperlink.md). Attempting to add restricted content throws an invalid args exception or XAML parse exception.

## -examples

## -see-also
