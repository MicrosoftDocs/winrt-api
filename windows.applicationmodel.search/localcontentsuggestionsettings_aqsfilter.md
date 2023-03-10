---
-api-id: P:Windows.ApplicationModel.Search.LocalContentSuggestionSettings.AqsFilter
-api-type: winrt property
---

<!-- Property syntax
public string AqsFilter { get;  set; }
-->

# Windows.ApplicationModel.Search.LocalContentSuggestionSettings.AqsFilter

## -description

An Advanced Query Syntax (AQS) string that limits the types and kinds of files that are used to provide suggestions. If no Advanced Query Syntax (AQS) string is specified, suggestions are provided from all local files in locations specified by the [Locations](localcontentsuggestionsettings_locations.md) property.

## -property-value

The Advanced Query Syntax (AQS) string that is used to refine which local, indexed files are used to provide suggestions. By default, this string is empty.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

If local suggestions are disabled, this property has no effect. Set [LocalContentSuggestionSettings.Enabled](localcontentsuggestionsettings_enabled.md) property to `true` to display local suggestions in the search pane.

Use an AQS filter to help keep local suggestions relevant. For example, if your app is a video player, you may want to limit suggestions to videos or a specific file type.

## -examples

## -see-also

[Search contract sample (Windows 8)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [LocalContentSuggestionSettings class](localcontentsuggestionsettings.md), [SearchPane.SetLocalContentSuggestionSettings method](searchpane_setlocalcontentsuggestionsettings_156524340.md)
