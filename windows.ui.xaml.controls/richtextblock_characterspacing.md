---
-api-id: P:Windows.UI.Xaml.Controls.RichTextBlock.CharacterSpacing
-api-type: winrt property
---

<!-- Property syntax
public int CharacterSpacing { get;  set; }
-->

# Windows.UI.Xaml.Controls.RichTextBlock.CharacterSpacing

## -description
Gets or sets the uniform spacing between characters, in units of 1/1000 of an em.



## -xaml-syntax
```xaml
<RichTextBlock CharacterSpacing="int"/>
```


## -property-value
The uniform spacing between characters, in units of 1/1000 of an em. The default is 0. Positive values increase tracking and loosen character spacing. Negative values decrease tracking and tighten the character spacing.

## -remarks
*Tracking* is the typographic term for an amount of space added or removed between all pairs of characters in a portion of text. This feature can be accessed through the CharacterSpacing property on [TextBlock](textblock.md) and [RichTextBlock](richtextblock.md). CharacterSpacing is measured in 1/1000 of an "em". One "em" is equivalent to the current font size of the control. For example, an additional 14 pixels will be inserted between each character in a text control with `FontSize="14"` and `CharacterSpacing="1000"`.

## -examples
To see an example, see scenario 1, "Tracking (character spacing)", of the [XAML text display sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20text%20display%20sample).

## -see-also
[XAML text display sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20text%20display%20sample)
