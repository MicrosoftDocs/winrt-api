---
-api-id: P:Windows.Media.Playback.MediaPlaybackCommandManagerCommandBehavior.EnablingRule
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Playback.MediaCommandEnablingRule EnablingRule { get;  set; }
-->

# Windows.Media.Playback.MediaPlaybackCommandManagerCommandBehavior.EnablingRule

## -description
Gets or sets a value indicating whether a System Media Transport Controls command should always be enabled, should never be enabled, or if the system should automatically determine whether the command is enabled.

## -property-value
A value defining the rule for enabling a System Media Transport Controls command.

## -remarks
Use this property to override the default behavior for a System Media Transport Controls command managed by a [MediaPlaybackCommandManager](mediaplaybackcommandmanager.md). If a [MediaPlayer](mediaplayer.md) has no remaining items to play, the System Media Transport Controls will disable the **Next** button. If your app uses the **Next** button to trigger some other action, such as switching to a different playlist of media items, you can set the **EnablingRule** for the [NextBehavior](mediaplaybackcommandmanager_nextbehavior.md) to [Always](mediacommandenablingrule.md) to ensure that the **Next** button is always enabled. Or, if a **MediaPlayer** has remaining items to play, the System Media Transport Controls will enable the **Next** button by default. If your app requires some user action before playing the next media item, you can set the **EnablingRule** for the [NextBehavior](mediaplaybackcommandmanager_nextbehavior.md) to [Never](mediacommandenablingrule.md) to disable the **Next** button.

## -examples

## -see-also
