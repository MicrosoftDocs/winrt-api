---
-api-id: M:Windows.ApplicationModel.Search.SearchPane.SetLocalContentSuggestionSettings(Windows.ApplicationModel.Search.LocalContentSuggestionSettings)
-api-type: winrt method
---

<!-- Method syntax
public void SetLocalContentSuggestionSettings(Windows.ApplicationModel.Search.LocalContentSuggestionSettings settings)
-->

# Windows.ApplicationModel.Search.SearchPane.SetLocalContentSuggestionSettings

## -description

Specifies whether suggestions based on local files are automatically displayed in the search pane, and defines the criteria that Windows uses to locate and filter these suggestions.

## -parameters

### -param settings

The new settings for local content suggestions.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) and the SearchPane. Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

When local content suggestions are enabled, Windows will provide search suggestions from the user's local files as the user enters query text. For example, a picture application can configure local content suggestions so that search suggestions come only from a particular kind of image file that is stored in the user's picture library.

## -examples

## -see-also

[Quickstart: Adding search](/previous-versions/windows/apps/hh465238(v=win.10)), [Search contract sample (Windows 8)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [LocalContentSuggestionSettings class](localcontentsuggestionsettings.md), [SearchPane class](searchpane.md)
