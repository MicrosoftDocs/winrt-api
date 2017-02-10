---
-api-id: P:Windows.Media.Playback.MediaPlaybackCommandManagerNextReceivedEventArgs.Handled
-api-type: winrt property
---

<!-- Property syntax
public bool Handled { get;  set; }
-->

# Windows.Media.Playback.MediaPlaybackCommandManagerNextReceivedEventArgs.Handled

## -description
Gets or sets a value indicating whether the [NextReceived](mediaplaybackcommandmanager_nextreceived.md) event has been handled.

## -property-value
True if the event has been handled; otherwise, false.

## -remarks
If you mark the event as handled by setting this property to true, the System Media Transport Controls will not take any action for the **Next** command that initiated the event. If this property is false, the system will perform the default action based on the current [NextBehavior](mediaplaybackcommandmanager_nextbehavior.md) setting.

## -examples

## -see-also
