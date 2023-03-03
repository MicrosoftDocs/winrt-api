---
-api-id: M:Windows.ApplicationModel.Search.SearchPane.TrySetQueryText(System.String)
-api-type: winrt method
---

<!-- Method syntax
public bool TrySetQueryText(System.String query)
-->

# Windows.ApplicationModel.Search.SearchPane.TrySetQueryText

## -description

Attempts to set the text in the search box of the search pane.

## -parameters

### -param query

The query text to show in the search pane's search box.

## -returns

`true` if the search box text was set successfully; otherwise, `false`.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) and the SearchPane. Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

If you have an in-app search box, use this method to maintain consistency between the search pane and your search box. Most apps should reply on the search pane instead of using in-app search UI.

## -examples

## -see-also
