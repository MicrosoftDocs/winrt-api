---
-api-id: M:Windows.Media.Playlists.Playlist.SaveAsAsync(Windows.Storage.IStorageFolder,System.String,Windows.Storage.NameCollisionOption,Windows.Media.Playlists.PlaylistFormat)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> SaveAsAsync(Windows.Storage.IStorageFolder saveLocation, System.String desiredName, Windows.Storage.NameCollisionOption option, Windows.Media.Playlists.PlaylistFormat playlistFormat)
-->

# Windows.Media.Playlists.Playlist.SaveAsAsync

## -description
Asynchronously saves the playlist to a specified file and folder, in a specified format.

## -parameters
### -param saveLocation
The folder in which to save the playlist.

### -param desiredName
The name of the playlist to save.

### -param option
The action to take if the playlist is saved to an existing file. One of the values of the [NameCollisionOption](../windows.storage/namecollisionoption.md) enumeration.

### -param playlistFormat
The playlist format. One of the values of the [PlaylistFormat](playlistformat.md) enumeration.

## -returns
Represents the asynchronous operation to save the playlist to a specified file and folder.

## -remarks

## -examples

## -see-also
[SaveAsAsync(IStorageFolder, String, NameCollisionOption)](playlist_saveasasync_166599488.md)