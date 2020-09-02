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
True if the search box text was set successfully. Otherwise, false.

## -remarks
> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md) for UWP app using C++, C#, or Visual Basic, [WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10)) for Windows app using JavaScript) and the [SearchPane](searchpane.md). Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

If you have an in-app search box, use this method to maintain consistency between the search pane and your search box. Most apps should reply on the search pane instead of using in-app search UI. To learn more, see [Guidelines and checklist for search](/windows/uwp/controls-and-patterns/search).

## -examples

## -see-also
