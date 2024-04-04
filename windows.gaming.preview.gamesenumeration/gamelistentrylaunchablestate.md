---
-api-id: T:Windows.Gaming.Preview.GamesEnumeration.GameListEntryLaunchableState
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum GameListEntryLaunchableState : int 
-->

# Windows.Gaming.Preview.GamesEnumeration.GameListEntryLaunchableState

## -description
Provides the context in which the [GameListEntry](gamelistentry.md) launch parameters were specified.

## -enum-fields

### -field NotLaunchable:0

[GameListEntry](gamelistentry.md) is not launchable. [GameListEntry](gamelistentry.md) doesn’t have a full path to the binary.

### -field ByUserProvidedPath:2

A user has provided the launch path. The caller may want to allow an edit button incase it was entered incorrectly.

### -field ByTile:3

The user is not allowed to override the launch path. This will cause the SetLauncherExectuableFileAsync to return an error.

### -field ByLastRunningFullPath:1

The system has determined the running path based on the path of the last time the game was run. The caller may want to confirm running location with the user.

## -remarks
This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -see-also

## -examples

## -capabilities
gameList
