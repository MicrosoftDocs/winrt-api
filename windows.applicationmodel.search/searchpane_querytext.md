---
-api-id: P:Windows.ApplicationModel.Search.SearchPane.QueryText
-api-type: winrt property
---

<!-- Property syntax
public string QueryText { get; }
-->

# Windows.ApplicationModel.Search.SearchPane.QueryText

## -description

The current text in the search box of the search pane.

## -property-value

The current query text. If the search pane was not used, this is an empty string.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) and the SearchPane. Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

You can get the query text at any time, even if the search pane isn't open.

## -examples

## -see-also

[SearchPane class](searchpane.md)