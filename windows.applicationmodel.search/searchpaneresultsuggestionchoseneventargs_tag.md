---
-api-id: P:Windows.ApplicationModel.Search.SearchPaneResultSuggestionChosenEventArgs.Tag
-api-type: winrt property
---

<!-- Property syntax
public string Tag { get; }
-->

# Windows.ApplicationModel.Search.SearchPaneResultSuggestionChosenEventArgs.Tag

## -description

Gets the tag for the suggested result that the user selected.

## -property-value

The app-defined tag for the selected search result.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

The value of this tag is set by the app when it appends the suggested result to a [searchSuggestionCollection](searchsuggestioncollection.md).

You can use this property to display the view for the result the user selected.

## -examples

## -see-also

[SearchPane class](searchpane.md), [SearchPane.ResultSuggestionChosen event](searchpane_resultsuggestionchosen.md), [SearchPaneResultSuggestionChosenEventArgs class](searchpaneresultsuggestionchoseneventargs.md), [SearchSuggestionCollection class](searchsuggestioncollection.md), [SearchSuggestionCollection.AppendResultSuggestion method](searchsuggestioncollection_appendresultsuggestion_603544202.md)