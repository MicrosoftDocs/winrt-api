---
-api-id: M:Windows.UI.Xaml.Controls.SearchBox.SetLocalContentSuggestionSettings(Windows.ApplicationModel.Search.LocalContentSuggestionSettings)
-api-type: winrt method
---

<!-- Method syntax
public void SetLocalContentSuggestionSettings(Windows.ApplicationModel.Search.LocalContentSuggestionSettings settings)
-->

# Windows.UI.Xaml.Controls.SearchBox.SetLocalContentSuggestionSettings

## -description
Specifies whether suggestions based on local files are automatically displayed in the search box suggestions, and defines the criteria that Windows uses to locate and filter these suggestions.

## -parameters
### -param settings
The new settings for local content suggestions.

## -remarks
When local content suggestions are enabled, Windows provides search suggestions from the user's local files as the user enters query text. For example, a picture application can configure local content suggestions so that search suggestions come only from a particular kind of image file that is stored in the user's picture library.

To search a local library, the appropriate capability must be declared in the app manifest. For more info, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations).

## -examples
Here, suggestions are restricted to one kind of file, music files, using an AQS string. Two of the most common AQS filters restrict based on file kind, like "kind:music" in the example; and based on file name extension, like "ext:.mp3".

```csharp
public MainPage()
{
    this.InitializeComponent();

    // Let Windows provide suggestions from local files.
    var settings = new Windows.ApplicationModel.Search.LocalContentSuggestionSettings();
    settings.Enabled = true;
    // Access to the music library requires that the Music Library capability
    // be declared in the app manifest .
    settings.Locations.Add(Windows.Storage.KnownFolders.MusicLibrary);
    settings.AqsFilter = "kind:Music";
    MySearchBox.SetLocalContentSuggestionSettings(settings);
}

```



## -see-also
