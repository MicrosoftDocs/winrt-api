---
-api-id: M:Windows.Storage.StorageLibrary.AreFolderSuggestionsAvailableAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> StorageLibrary.AreFolderSuggestionsAvailableAsync()
-->

# Windows.Storage.StorageLibrary.AreFolderSuggestionsAvailableAsync

## -description
Determines if there are suggestions for adding existing folders with content to the StorageLibrary.

## -returns
**True** if there are folder suggestions; **False** otherwise

## -remarks
If this feature is not supported on your version of Windows, the method will return **false**.

## -see-also

## -examples
This example demonstrates how to determine whether there are any suggested folders with content that can be added to your Pictures library.

```csharp
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
        // Prompt the user to add one or more of them. 
        
        // Note that the RequestAddFolderAsync method returns only one folder.
        // If the user adds multiple folders, only one will be returned.
        // In this example, to keep track of all the added folders, the app can subscribe to the
        // StorageLibrary.DefinitionChanged event by awaiting library.RequestAddFolderAsync();

        // Launch the folder suggestion dialog
        var folder = await library.RequestAddFolderAsync(); 
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

> [!NOTE]
> Don't forget to include the **picturesLibrary** capability in your app's package manifest. For more information on Capabilities in the manifest, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations).