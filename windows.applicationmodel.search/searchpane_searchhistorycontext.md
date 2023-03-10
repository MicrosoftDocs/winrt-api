---
-api-id: P:Windows.ApplicationModel.Search.SearchPane.SearchHistoryContext
-api-type: winrt property
---

<!-- Property syntax
public string SearchHistoryContext { get;  set; }
-->

# Windows.ApplicationModel.Search.SearchPane.SearchHistoryContext

## -description

A string that identifies the context of the search and is used to store the user's search history with the app.

## -property-value

The search history context string.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) and the SearchPane. Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

The search history context string is used as a secondary key for storing search history (the primary key is the AppId). An app can use the search history context string to store different search histories based on the context of the application.

If you don't set this property, Windows assumes that all searches in your app occur in the same context. If you update this property while the search pane is open with suggestions showing, the changes won't take effect until the user enters the next character.

## -examples

## -see-also

[SearchPane class](searchpane.md), [SearchPane.SearchHistoryEnabled property](searchpane_searchhistoryenabled.md)