---
-api-id: P:Windows.Media.Playback.MediaBreak.CanStart
-api-type: winrt property
---

<!-- Property syntax
public bool CanStart { get;  set; }
-->

# Windows.Media.Playback.MediaBreak.CanStart

## -description
Gets or sets a value indicating whether the [MediaBreak](mediabreak.md) can be played.

## -property-value
True if the [MediaBreak](mediabreak.md) can be played; otherwise false.

## -remarks
You can set **CanStart** to false in the handler for the [BreakEnded](mediabreakmanager_breakended.md) event to make sure that a break that has already played isn't played again.

## -examples

## -see-also
