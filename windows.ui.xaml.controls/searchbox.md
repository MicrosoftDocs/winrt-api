---
-api-id: T:Windows.UI.Xaml.Controls.SearchBox
-api-type: winrt class
---

<!-- Class syntax.
public class SearchBox : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.ISearchBox
-->

# Windows.UI.Xaml.Controls.SearchBox

## -description
Represents a control that can be used to enter search query text. (Not recommended for Universal Windows Platform (UWP) app. See [AutoSuggestBox](autosuggestbox.md).)

> **Windows 10**
> Although [SearchBox](searchbox_searchbox.md) is implemented in the Universal device family, it is not fully functional on mobile devices. Use [AutoSuggestBox](autosuggestbox.md) for your universal search experience. See [SearchBox deprecated in favor of AutoSuggestBox](http://msdn.microsoft.com/library/78b86762-7359-474f-b1e3-c2d7cf9aa907).

## -xaml-syntax
```xaml
<SearchBox .../>
```


## -remarks
### Windows 10

> [!IMPORTANT]
> Although [SearchBox](searchbox_searchbox.md) is implemented in the Universal device family, it is not fully functional on mobile devices. Use [AutoSuggestBox](autosuggestbox.md) for your universal search experience. See [SearchBox deprecated in favor of AutoSuggestBox](http://msdn.microsoft.com/library/78b86762-7359-474f-b1e3-c2d7cf9aa907).

### Windows 8.x

To support keyboard interaction and make your app's search experience consistent with the Start screen, set the [FocusOnKeyboardInput](searchbox_focusonkeyboardinput.md) property to **true**. For more info, see [Guidelines and checklist for search](http://msdn.microsoft.com/library/c328faa3-f6ae-4970-8372-b413f1290c39).

At a minimum each [SearchBox](searchbox.md) control should always have a [QuerySubmitted](searchbox_querysubmitted.md) handler. This handler passes the user's query text to a search results page that the handler opens. Open this page by calling [Frame.Navigate](frame_navigate.md). For more info on how to write a basic [QuerySubmitted](searchbox_querysubmitted.md) handler and create a search results page as part of your app, see [Enabling users to search for information in your ](http://msdn.microsoft.com/library/9fa49c2a-5237-4432-aa93-0829bdc9dfe0).

In addition to the basic results and search experience, a [SearchBox](searchbox.md) also supports search suggestions, programmatically setting the starting search text, and search history. The search suggestion feature is supported by API in the [Windows.ApplicationModel.Search](../windows.applicationmodel.search/windows_applicationmodel_search.md) namespace. For example code that shows how to use these features, see [SearchBox control sample](http://go.microsoft.com/fwlink/p/?LinkId=317444).

> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](searchbox.md) for Windows Store app using C++, C#, or Visual Basic, [WinJS.UI.SearchBox](http://msdn.microsoft.com/library/58f5cea3-a19b-48a8-abcc-17f38d8fa886) for Windows app using JavaScript) and the [SearchPane](../windows.applicationmodel.search/searchpane.md). Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox'"

## -examples
Here's a basic XAML definition for a [SearchBox](searchbox.md), and an implementation of the [QuerySubmitted](searchbox_querysubmitted.md) handler. It calls [Frame.Navigate](frame_navigate.md) to load a search query result page (not shown) that's named `SearchResultsPage1`. The **this**/**Me** reference in the handlers is the containing page instance, as is typical for on-page input event handling code. You can see similar code as part of [Quickstart: Adding search to an app](http://msdn.microsoft.com/library/9fa49c2a-5237-4432-aa93-0829bdc9dfe0).

```xaml
<SearchBox x:Name="mySearchBox" 
    FocusOnKeyboardInput="True"
    QuerySubmitted="mySearchBox_QuerySubmitted"
    Height="35"/>
```

```csharp
private void mySearchBox_QuerySubmitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
{
    this.Frame.Navigate(typeof(SearchResultsPage1), args.QueryText);
}

```

```vbnet
Private Sub mySearchBox_QuerySubmitted(sender As SearchBox, args As SearchBoxQuerySubmittedEventArgs)
    Me.Frame.Navigate(GetType(SearchResultsPage1), args.QueryText)
End Sub
```



## -see-also
[Quickstart: Adding search to an app](http://msdn.microsoft.com/library/9fa49c2a-5237-4432-aa93-0829bdc9dfe0), [Control](control.md), [SearchBoxQuerySubmittedEventArgs](searchboxquerysubmittedeventargs.md), [SearchBox control sample](http://go.microsoft.com/fwlink/p/?LinkId=317444), [Enabling users to search for information in your ](http://msdn.microsoft.com/library/9fa49c2a-5237-4432-aa93-0829bdc9dfe0)