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
> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md) for Windows Store app using C++, C#, or Visual Basic, [WinJS.UI.SearchBox](http://msdn.microsoft.com/library/58f5cea3-a19b-48a8-abcc-17f38d8fa886) for Windows app using JavaScript) and the [SearchPane](searchpane.md). Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

You can use the placeholder text to give the user an indication about what he or she can search for.

If the placeholder text is too long to fit in the search box, the system truncates the text without raising an exception.

## -examples

## -see-also
[SearchPane class](searchpane.md)