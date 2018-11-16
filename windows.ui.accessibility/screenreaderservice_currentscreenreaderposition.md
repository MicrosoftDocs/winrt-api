---
-api-id: P:Windows.UI.Accessibility.ScreenReaderService.CurrentScreenReaderPosition
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public ScreenReaderPositionChangedEventArgs CurrentScreenReaderPosition { get; }
-->

# Windows.UI.Accessibility.ScreenReaderService.CurrentScreenReaderPosition

## -description

Gets both the rectangle corresponding to the current position of the screen reader focus indicator (such as the Narrator focus highlight box) and whether the screen reader is in continuous reading mode.

## -property-value

An object that provides:

- The physical screen coordinates of the upper left corner of the screen reader focus indicator, and its height and width, in pixels.
- A boolean that indicates whether the screen reader is in continuous reading mode.

## -remarks

If there is no currently active screen reader, or one cannot be detected, the data returned by this property is not reliable.

## -see-also

[ScreenReaderPositionChangedEventArgs.ScreenPositionInRawPixels](screenreaderpositionchangedeventargs_screenpositioninrawpixels.md)

## -examples

