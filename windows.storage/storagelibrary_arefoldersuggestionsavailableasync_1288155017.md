---
-api-id: M:Windows.Storage.StorageLibrary.AreFolderSuggestionsAvailableAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> StorageLibrary.AreFolderSuggestionsAvailableAsync()
-->

# Windows.Storage.StorageLibrary.AreFolderSuggestionsAvailableAsync

## -description
Determines if there are any suggested folders to be added to a library.

## -params

## -returns
True if there are recommended folders; False if there are no recommended folders. 

## -remarks

## -see-also

## -examples

```csharp
StorageLibrary picturesLibrary;

private async Task<StorageLibrary> SetupPicturesLibraryAsync()
{
    if (this.picturesLibrary == null)
    {
        this.picturesLibrary = await StorageLibrary.GetLibraryAsync(KnownLibraryId.Pictures);
        this.picturesLibrary.DefinitionChanged += PicturesLibrary_DefinitionChanged;
    }
    return this.picturesLibrary;
}

private async void CheckForFolderSuggestions_Clicked(object sender, RoutedEventArgs e)
{
    var library = await SetupPicturesLibraryAsync();
    if (await library.AreFolderSuggestionsAvailableAsync())
    {
        // There are new folders that could be added to the library.
        // Prompt the user to add one or more of them. Note that
        // the existing RequestAddFolderAsync method returns only one folder.
        // If the user adds multiple folders, only one will be returned.
        // To learn about all added folders, the app can subscribe to the
        // StorageLibrary.DefinitionChanged event 
        await library.RequestAddFolderAsync();
    }
}

private void PicturesLibrary_DefinitionChanged(StorageLibrary sender, object args)
{
    foreach (StorageFolder folder in sender.Folders)
    {
        // Do something with every folder in the library
    }
}
```

