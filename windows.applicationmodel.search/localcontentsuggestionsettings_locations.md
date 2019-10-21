---
-api-id: P:Windows.ApplicationModel.Search.LocalContentSuggestionSettings.Locations
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.Storage.StorageFolder> Locations { get; }
-->

# Windows.ApplicationModel.Search.LocalContentSuggestionSettings.Locations

## -description
A list of the [storageFolder](../windows.storage/storagefolder.md) objects that contain files that are used to provide suggestions. If the list is empty, suggestions are provided from files in all of the local libraries for which the app declared capabilities.

## -property-value
The list of [storageFolder](../windows.storage/storagefolder.md) locations that contain files that are used to provide suggestions. By default, this list is empty and suggestions are provided from the local files in all of the libraries for which the app declared capabilities.



## -remarks
If you add a location to the list, make sure you add all of the locations that contain files that you want used to provide local suggestions. If a location in this list is not valid, no suggestions are provided from that location. The remaining (valid) locations in this list are then used to provide suggestions.

Suggestions are provided based on local, indexed files in a listed [storageFolder](../windows.storage/storagefolder.md).

If local suggestions are disabled, this property has no effect. Set the [localContentSuggestionSettings.enabled](localcontentsuggestionsettings_enabled.md) property to true to display local suggestions in the search pane.

You can use this list to provide suggestions from libraries or folders for which your app hasn't declared capabilities, like folders that were accessed using the file picker. Learn more about capabilities in [Access to user resources using the Windows Runtime](https://docs.microsoft.com/previous-versions/windows/apps/hh464936(v=win.10)).

## -examples
The [Search contract sample](https://go.microsoft.com/fwlink/p/?linkid=234892) demonstrates how to append a location to the list:



[!code-js[lssettings_appendloc_js](../windows.applicationmodel.search/code/SearchContract/js/js/scenario4.js#Snippetlssettings_appendloc_js)]
> If there is only one [storageFolder](../windows.storage/storagefolder.md) in the locations list, like the Music library in the example, the local files in that location only are used to provide suggestions in the search pane.

## -see-also
[Access to user resources using the Windows Runtime](https://docs.microsoft.com/previous-versions/windows/apps/hh464936(v=win.10)), [Quickstart: Adding search](https://docs.microsoft.com/previous-versions/windows/apps/hh465238(v=win.10)), [Search contract sample](https://go.microsoft.com/fwlink/p/?linkid=234892), [Object class](https://docs.microsoft.com/dotnet/api/system.object?redirectedfrom=MSDN), [LocalContentSuggestionSettings class](localcontentsuggestionsettings.md), [LocalContentSuggestionSettings.Enabled property](localcontentsuggestionsettings_enabled.md), [SearchPane.SetLocalContentSuggestionSettings method](searchpane_setlocalcontentsuggestionsettings_156524340.md), [Windows.Storage.KnownFolders class](../windows.storage/knownfolders.md), [Windows.Storage.StorageFolder class](../windows.storage/storagefolder.md)
