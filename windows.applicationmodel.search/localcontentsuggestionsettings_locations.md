---
-api-id: P:Windows.ApplicationModel.Search.LocalContentSuggestionSettings.Locations
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.Storage.StorageFolder> Locations { get; }
-->

# Windows.ApplicationModel.Search.LocalContentSuggestionSettings.Locations

## -description

A list of the [StorageFolder](../windows.storage/storagefolder.md) objects that contain files that are used to provide suggestions. If the list is empty, suggestions are provided from files in all of the local libraries for which the app declared capabilities.

## -property-value

The list of [StorageFolder](../windows.storage/storagefolder.md) locations that contain files that are used to provide suggestions. By default, this list is empty and suggestions are provided from the local files in all of the libraries for which the app declared capabilities.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

If you add a location to the list, make sure you add all of the locations that contain files that you want used to provide local suggestions. If a location in this list is not valid, no suggestions are provided from that location. The remaining (valid) locations in this list are then used to provide suggestions.

Suggestions are provided based on local, indexed files in a listed [StorageFolder](../windows.storage/storagefolder.md).

If local suggestions are disabled, this property has no effect. Set the [LocalContentSuggestionSettings.Enabled](localcontentsuggestionsettings_enabled.md) property to `true` to display local suggestions in the search pane.

You can use this list to provide suggestions from libraries or folders for which your app hasn't declared capabilities, like folders that were accessed using the file picker. Learn more about capabilities in [App capability declarations](/windows/uwp/packaging/app-capability-declarations).

## -examples

## -see-also

[App capability declarations](/windows/uwp/packaging/app-capability-declarations), [Search contract sample (Windows 8)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [LocalContentSuggestionSettings class](localcontentsuggestionsettings.md), [LocalContentSuggestionSettings.Enabled property](localcontentsuggestionsettings_enabled.md), [SearchPane.SetLocalContentSuggestionSettings method](searchpane_setlocalcontentsuggestionsettings_156524340.md), [Windows.Storage.KnownFolders class](../windows.storage/knownfolders.md), [Windows.Storage.StorageFolder class](../windows.storage/storagefolder.md)
