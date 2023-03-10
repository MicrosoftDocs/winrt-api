---
-api-id: P:Windows.ApplicationModel.Search.SearchPane.PlaceholderText
-api-type: winrt property
---

<!-- Property syntax
public string PlaceholderText { get;  set; }
-->

# Windows.ApplicationModel.Search.SearchPane.PlaceholderText

## -description

The placeholder text in the search box when the user hasn't entered any characters.

## -property-value

The placeholder text to display in the search box.

## -remarks

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md)/[WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10))) and the SearchPane. Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

You can use the placeholder text to give the user an indication about what he or she can search for.

If the placeholder text is too long to fit in the search box, the system truncates the text without raising an exception.

## -examples

## -see-also

[SearchPane class](searchpane.md)