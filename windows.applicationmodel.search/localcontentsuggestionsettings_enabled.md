---
-api-id: P:Windows.ApplicationModel.Search.LocalContentSuggestionSettings.Enabled
-api-type: winrt property
---

<!-- Property syntax
public bool Enabled { get;  set; }
-->

# Windows.ApplicationModel.Search.LocalContentSuggestionSettings.Enabled

## -description

Indicates whether suggestions based on local files are displayed in the search pane.

## -property-value

`true` if suggestions from local files are displayed; otherwise, `false`. The default is `false`.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

## -examples

## -see-also

[Search contract sample (Windows 8)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [LocalContentSuggestionSettings class](localcontentsuggestionsettings.md), [SearchPane.SetLocalContentSuggestionSettings method](searchpane_setlocalcontentsuggestionsettings_156524340.md)
