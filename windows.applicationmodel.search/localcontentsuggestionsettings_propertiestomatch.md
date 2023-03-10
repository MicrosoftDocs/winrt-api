---
-api-id: P:Windows.ApplicationModel.Search.LocalContentSuggestionSettings.PropertiesToMatch
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<string> PropertiesToMatch { get; }
-->

# Windows.ApplicationModel.Search.LocalContentSuggestionSettings.PropertiesToMatch

## -description

A list of the file properties whose values are used to provide suggestions from local files. If the list is empty, all of the file properties that are available for suggestions are used.

## -property-value

The list of the file properties that are used to provide suggestions from local files. By default, this list is empty and all of the file properties that are available for suggestions are used.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

If local suggestions are disabled, this property has no effect.

Adding properties to this list limits local suggestions to the values of the specified properties for local, indexed files. For example, if you want to limit suggestions to musical artists, you would append the "System.Music.AlbumArtist" (Album artists) or the "System.Music.Artist" (Contributing artists) property to the PropertiesToMatch list.

Adding properties to this list limits local suggestions to local, indexed files that have the listed properties.

## -examples

## -see-also

[App capability declarations](/windows/uwp/packaging/app-capability-declarations), [Search contract sample (Windows 8)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [Object class](/dotnet/api/system.object?view=dotnet-uwp-10.0&preserve-view=true), [LocalContentSuggestionSettings class](localcontentsuggestionsettings.md), [LocalContentSuggestionSettings.Enabled](localcontentsuggestionsettings_enabled.md), [SearchPane.SetLocalContentSuggestionSettings](searchpane_setlocalcontentsuggestionsettings_156524340.md)
