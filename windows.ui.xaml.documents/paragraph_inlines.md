---
-api-id: P:Windows.UI.Xaml.Documents.Paragraph.Inlines
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Documents.InlineCollection Inlines { get; }
-->

# Windows.UI.Xaml.Documents.Paragraph.Inlines

## -description
Gets an [InlineCollection](inlinecollection.md) containing the top-level [Inline](inline.md) elements that include the contents of the [Paragraph](paragraph.md).

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Documents.Paragraph.Inlines](/windows/winui/api/microsoft.ui.xaml.documents.paragraph.inlines) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<Paragraph .../>
-or-
<Paragraph ...>
  oneOrMoreInlines
</Paragraph>
-or-
<Paragraph ...>
  mixedContent
</Paragraph>
```


## -xaml-values
<dl><dt>oneOrMoreInlines</dt><dd>oneOrMoreInlinesOne or more elements that derive from the Inline type.</dd>
<dt>mixedContent</dt><dd>mixedContentA mixture of inner text and elements that derive from the Inline type.</dd>
</dl>
## -property-value
An [InlineCollection](inlinecollection.md) containing the [Inline](inline.md) elements that include the contents of the [Paragraph](paragraph.md).

## -remarks

## -examples

## -see-also
