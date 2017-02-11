---
-api-id: P:Windows.Storage.FileProperties.MusicProperties.Artist
-api-type: winrt property
---

<!-- Property syntax
public string Artist { get;  set; }
-->

# Windows.Storage.FileProperties.MusicProperties.Artist

## -description
Gets the artists that contributed to the song.

## -property-value
The names of the song's artists.

## -remarks
This is how the value returned by the [Artist](musicproperties_artist.md) property is determined:

1. If the [AlbumArtist](musicproperties_albumartist.md) property of the song contains a value, the value of the [AlbumArtist](musicproperties_albumartist.md) property is returned.
1. If the [AlbumArtist](musicproperties_albumartist.md) property of the song does not contain a value, and the song is marked as part of a compilation, the value "Various Artists" is returned.
1. Otherwise, the first value from the contributing artists list is returned. The contributing artists list is the value of the **System.Music.Artist** file property.
If you want to get the album artist, use [AlbumArtist](musicproperties_albumartist.md) instead.

If you want to get the list of all the contributing artists, query the value of the **System.Music.Artist** file property. The following example shows how to do this.

```csharp
using Windows.Storage;
using Windows.Storage.FileProperties;
...
    StorageFile musicFile = 
        await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///assets/song.mp3"));
    StorageItemContentProperties fileProperties = musicFile.Properties;
    MusicProperties musicFileProperties =
        await fileProperties.GetMusicPropertiesAsync();
    string[] contributingArtistsKey = { "System.Music.Artist" };
    IDictionary<string, object> contributingArtistsProperty =
        await musicFileProperties.RetrievePropertiesAsync(contributingArtistsKey);
    string[] contributingArtists = contributingArtistsProperty["System.Music.Artist"] as string[];
    foreach (string contributingArtist in contributingArtists)
    {
        // Do something with the name of each contributing artist.
    }

```



## -examples

## -see-also
