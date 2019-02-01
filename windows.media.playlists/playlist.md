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
This API is used to save and load playlist files to and from disk. For information about playing lists of media items, see [Media items, playlists, and tracks](https://msdn.microsoft.com/windows/uwp/audio-video-camera/media-playback-with-mediasource).

## -examples
This example is an excerpt from the [Playlist sample](https://go.microsoft.com/fwlink/p/?linkid=231538). See the sample for the complete solution.

```javascript
// App namespace.
var PlaylistSample = {};
// Create and save a playlist from a set of audio files.
function scenario1Create() {
    var picker = new Windows.Storage.Pickers.FileOpenPicker();
    picker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.musicLibrary;
    picker.fileTypeFilter.replaceAll(["*"]);

    picker.pickMultipleFilesAsync().then(function (items) {
        PlaylistSample.list = new Windows.Media.Playlists.Playlist();

        items.forEach(function (/*@override*/item) { 
            PlaylistSample.list.files.append(item);
        });

        sdkSample.displayStatus("Playlist sample.wpl created. Choose save location.");
    }, function (error) {
        sdkSample.displayError("Error in picking files.");
    });
}

// Save created playlist.
function scenario1Save() {
    var folderpicker = new Windows.Storage.Pickers.FolderPicker();
    folderpicker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.musicLibrary;
    folderpicker.fileTypeFilter.replaceAll(["*"]);

    folderpicker.pickSingleFolderAsync().then(function (folder) {
        PlaylistSample.list.saveAsAsync(folder, "sample", Windows.Storage.NameCollisionOption.replaceExisting,
                                        Windows.Media.Playlists.PlaylistFormat.windowsMedia).then(function (file) {
            sdkSample.displayStatus("Playlist sample.wpl saved to the " + folder.name + " folder.");
        });

    }, function (error) {
        sdkSample.displayError("Error in picking folder");
    });
}

// Pick playlist and display its contents.
function scenario2Display() {
    var picker = new Windows.Storage.Pickers.FileOpenPicker();
    picker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.musicLibrary;
    picker.fileTypeFilter.replaceAll([".wpl", ".zpl", ".m3u"]);

    picker.pickSingleFileAsync().then(function (/*@override*/item) {
        Windows.Media.Playlists.Playlist.loadAsync(item).then(function (playlist) {
            // Print the name of the playlist.
            var output = "<p>Playlist content</p>";
            var outputdiv = id("scenario2Output");
            outputdiv.innerHTML = "";
            var promises = {};
            var promiseIndex = 0;
            var musicProperties;

            // Request music properties for each file in the playlist.
            playlist.files.forEach(function (file) {
                promises[promiseIndex] = file.properties.getMusicPropertiesAsync();
                promiseIndex++;
            });

            // Print the music properties for each file. Due to the asynchronous
            // nature of the call to retrieve music properties, the data may appear
            // in an order different than the one specified in the original playlist.
            // To guarantee the ordering we use Promise.join with an associative array
            // passed as a parameter, containing an index for each individual promise.
            WinJS.Promise.join(promises).then(function (results) {
                for (var resultIndex = 0; resultIndex < promiseIndex; resultIndex++) {
                    musicProperties = results[resultIndex];
                    output = output + "<p>Title: " + musicProperties.title + "<br/>";
                    output = output + "Album: " + musicProperties.album + "<br/>";
                    output = output + "Artist: " + musicProperties.artist + "</p>";
                    outputdiv.innerHTML = output;
                }
            });
        });

    }, function (error) {
        sdkSample.displayError("Error in picking file.");
    });
}
```



## -see-also
[Playlist sample](https://go.microsoft.com/fwlink/p/?linkid=231538), [Playlists sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=624039)
