---
-api-id: P:Windows.UI.Accessibility.ScreenReaderPositionChangedEventArgs.IsReadingText
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool IsReadingText { get; }
-->

# Windows.UI.Accessibility.ScreenReaderPositionChangedEventArgs.IsReadingText

## -description

Gets whether a screen reader is currently reading a block of text.

## -property-value

True if the screen reader is reading text; otherwise, false.

This property is true when reading text and embedded objects continuously from the beginning, or current location, in a document, webpage, or app.

When navigating by a single character or word in a text-based element this property is false.

## -remarks

This property is useful in situations where you need to handle the frequent and predictable movement of the screen reader focus. For example, Magnifier smooths the movement of the magnified region by setting its location in anticipation of the movement of the Narrator focus.

Reading with Narrator is initiated through specific key combinations, such as **Caps lock + M**. While reading text, the need for the user to press other keys and key combinations to navigate through different objects in a document, webpage, or app is eliminated. For a comprehensive list of key combinations that initiate text reading with Narrator, see [Reading text](https://support.microsoft.com/help/22799/windows-10-narrator-reading-text).

## -see-also

## -examples

