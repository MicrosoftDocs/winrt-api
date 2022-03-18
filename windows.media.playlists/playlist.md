---
-api-id: T:Windows.Media.Playlists.Playlist
-api-type: winrt class
---

<!-- Class syntax.
public class Playlist : Windows.Media.Playlists.IPlaylist
-->

# Windows.Media.Playlists.Playlist

## -description
Provides access to a media playlist.

## -remarks
This API is used to save and load playlist files to and from disk. For information about playing lists of media items, see [Media items, playlists, and tracks](/windows/uwp/audio-video-camera/media-playback-with-mediasource).

## -examples

This example is an excerpt from the [Playlist sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/Playlists). See the sample for the complete solution.

```csharp
// Create and save a playlist from a set of audio files.
async private void PickAudioButton_Click(object sender, RoutedEventArgs e)
{
    FileOpenPicker picker = MainPage.CreateFilePicker(MainPage.audioExtensions);
    IReadOnlyList<StorageFile> files = await picker.PickMultipleFilesAsync();

    if (files.Count > 0)
    {
        Playlist playlist = new Playlist();

        foreach (StorageFile file in files)
        {
            playlist.Files.Add(file);
        }

        StorageFolder folder = KnownFolders.MusicLibrary;
        string name = "Sample";
        NameCollisionOption collisionOption = NameCollisionOption.ReplaceExisting;
        PlaylistFormat format = PlaylistFormat.WindowsMedia;

        try
        {
            StorageFile savedFile = await playlist.SaveAsAsync(folder, name, collisionOption, format);
            this.rootPage.NotifyUser(savedFile.Name + " was created and saved with " + files.Count + " files.", NotifyType.StatusMessage);
        }
        catch (Exception error)
        {
            rootPage.NotifyUser(error.Message, NotifyType.ErrorMessage);
        }
    }
    else
    {
        rootPage.NotifyUser("No files picked.", NotifyType.ErrorMessage);
    }
}

// Pick playlist and display its contents.
async private void PickPlaylistButton_Click(object sender, RoutedEventArgs e)
{
    Playlist playlist = await PickPlaylistAsync();

    if (playlist != null)
    {
        string result = "Songs in playlist: " + playlist.Files.Count.ToString() + "\n";

        foreach (StorageFile file in playlist.Files)
        {
            MusicProperties properties = await file.Properties.GetMusicPropertiesAsync();
            result += "\n";
            result += "File: " + file.Path + "\n";
            result += "Title: " + properties.Title + "\n";
            result += "Album: " + properties.Album + "\n";
            result += "Artist: " + properties.Artist + "\n";
        }

        this.OutputStatus.Text = result;
    }
}

private async Task<Playlist> PickPlaylistAsync()
{
    FileOpenPicker picker = CreateFilePicker(MainPage.playlistExtensions);
    StorageFile file = await picker.PickSingleFileAsync(); 

    if (file == null)
    {
        NotifyUser("No playlist picked.", NotifyType.ErrorMessage);
        return null;
    }

    try
    {
        return await Playlist.LoadAsync(file);
    }
    catch (Exception ex)
    {
        NotifyUser(ex.Message, NotifyType.ErrorMessage);
        return null;
    }
}
```

## -see-also
[Playlist sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/Playlists)
