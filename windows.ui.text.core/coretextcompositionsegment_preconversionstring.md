---
-api-id: P:Windows.UI.Text.Core.CoreTextCompositionSegment.PreconversionString
-api-type: winrt property
---

<!-- Property syntax
public string PreconversionString { get; }
-->

# Windows.UI.Text.Core.CoreTextCompositionSegment.PreconversionString

## -description
Gets a string that represents the state of the user input after IME-processing but before final conversion.

## -property-value
A string that represents the pre-conversion string.

## -remarks
The original string is the text input by the user, for example a romanized string. The IME might process that string into Hiragana, for example, and the result is the pre-conversion string— also known as the reading string. After this, the user might convert part of the Hiragana into Kanji, and the result is the post-conversion string that you would see in the text input control when composition is completed. The pre-conversion string is sometimes phonetic, but not always. For example with some Chinese IMEs it can be the strokes used or, in math, the shortcut used to describe the desired notation. See [CoreTextCompositionSegment](coretextcompositionsegment.md) for an illustration.

## -examples

## -see-also
