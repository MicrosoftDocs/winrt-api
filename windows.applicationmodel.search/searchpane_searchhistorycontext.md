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
> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md) for Windows Store app using C++, C#, or Visual Basic, [WinJS.UI.SearchBox](http://msdn.microsoft.com/library/58f5cea3-a19b-48a8-abcc-17f38d8fa886) for Windows app using JavaScript) and the [SearchPane](searchpane.md). Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

The search history context string is used as a secondary key for storing search history. (The primary key is the AppId.
<!--TODO: Might be useful to add a link here to a topic that defines the AppId.-->
) An app can use the search history context string to store different search histories based on the context of the application.

If you don't set this property, Windows assumes that all searches in your app occur in the same context. If you update this property while the search pane is open with suggestions showing, the changes won't take effect until the user enters the next character.

## -examples

## -see-also
[SearchPane class](searchpane.md), [SearchPane.SearchHistoryEnabled property](searchpane_searchhistoryenabled.md)