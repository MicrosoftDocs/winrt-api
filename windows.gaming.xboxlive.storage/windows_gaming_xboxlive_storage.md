---
-api-id: N:Windows.Gaming.XboxLive.Storage
-api-type: winrt namespace
---

# Windows.Gaming.XboxLive.Storage

## -description

Contains [GameSaveProvider](gamesaveprovider.md) and [GameSaveContainer](gamesavecontainer.md) classes used to create, save, enumerate, and load Xbox Live game saves.

> [!IMPORTANT]
> This API is targeted towards UWP games and apps with Xbox Live Enabled. Calls to these APIs made from sources that are not Xbox Live enabled will not be able to sync data to the cloud.

## -remarks

Universal Windows Platform (UWP) apps running on PCs save local data in a location that is accessible to the local user, and is not inherently protected from user tampering.

You should consider applying your own encryption and validity checks to game save data in order to help prevent users from modifying the game saves outside of the game.

In addition, if your game is a cross-play game that allows game save sharing between Windows 10 and Xbox One, the Xbox One version of the game must perform any appropriate validation and decryption of the data during load time, in case the data was tampered with on a Windows 10 device.

## -examples

## -see-also