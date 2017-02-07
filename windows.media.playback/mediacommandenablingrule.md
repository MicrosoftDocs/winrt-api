---
-api-id: T:Windows.Media.Playback.MediaCommandEnablingRule
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Playback.MediaCommandEnablingRule : int
-->

# MediaCommandEnablingRule

## -description
Specifies a rule for enabling a System Media Transport Controls command.

## -enum-fields
### -field Auto:0
The system dynamically determines whether the command is enabled.

### -field Always:1
The command is always enabled.

### -field Never:2
The command is never enabled.


## -remarks
Set the [EnablingRule](mediaplaybackcommandmanagercommandbehavior_enablingrule.md) property of a [MediaPlaybackCommandManagerCommandBehavior](mediaplaybackcommandmanagercommandbehavior.md) object to specify the enabling rule for a System Media Transport Controls command that is managed by a [MediaPlaybackCommandManager](mediaplaybackcommandmanager.md).

## -examples

## -see-also