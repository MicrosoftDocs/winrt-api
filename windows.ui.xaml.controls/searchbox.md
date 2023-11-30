---
-api-id: T:Windows.UI.Xaml.Controls.SearchBox
-api-type: winrt class
---

<!-- Class syntax.
public class SearchBox : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.ISearchBox
-->

# Windows.UI.Xaml.Controls.SearchBox

## -description

Represents a control that can be used to enter search query text. (Not recommended for Universal Windows Platform (UWP) apps. See [AutoSuggestBox](autosuggestbox.md).)

## -xaml-syntax

```xaml
<SearchBox .../>
```

## -remarks

Use [AutoSuggestBox](autosuggestbox.md) for search.

### Notes for previous versions

#### Windows 10 or later

> [!IMPORTANT]
> Although [SearchBox](searchbox_searchbox_1221375020.md) is implemented in the Universal device family, it is not fully functional on mobile devices. Use [AutoSuggestBox](autosuggestbox.md) for your universal search experience. See [SearchBox deprecated in favor of AutoSuggestBox](/windows/uwp/porting/w8x-to-uwp-porting-xaml-and-ui#searchbox-deprecated-in-favor-of-autosuggestbox).

#### Windows 8.x

To support keyboard interaction and make your app's search experience consistent with the Start screen, set the [FocusOnKeyboardInput](searchbox_focusonkeyboardinput.md) property to **true**. For more info, see [Guidelines and checklist for search](/windows/uwp/controls-and-patterns/search).

At a minimum each SearchBox control should always have a [QuerySubmitted](searchbox_querysubmitted.md) handler. This handler passes the user's query text to a search results page that the handler opens. Open this page by calling [Frame.Navigate](frame_navigate_1426351961.md). For more info on how to write a basic [QuerySubmitted](searchbox_querysubmitted.md) handler and create a search results page as part of your app, see [Enabling users to search for information in your ](/previous-versions/windows/apps/hh868180(v=win.10)).

In addition to the basic results and search experience, a SearchBox also supports search suggestions, programmatically setting the starting search text, and search history. The search suggestion feature is supported by API in the [Windows.ApplicationModel.Search](../windows.applicationmodel.search/windows_applicationmodel_search.md) namespace. For example code that shows how to use these features, see [SearchBox control sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/SearchBox%20control%20sample).

> [!NOTE]
> An app can't use both the search box and the [SearchPane](../windows.applicationmodel.search/searchpane.md). Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox'"

## -examples
Here's a basic XAML definition for a SearchBox, and an implementation of the [QuerySubmitted](searchbox_querysubmitted.md) handler. It calls [Frame.Navigate](frame_navigate_1426351961.md) to load a search query result page (not shown) that's named `SearchResultsPage1`. The **this**/**Me** reference in the handlers is the containing page instance, as is typical for on-page input event handling code. You can see similar code as part of [Quickstart: Adding search to an app](/previous-versions/windows/apps/hh868180(v=win.10)).

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

```vb
Private Sub mySearchBox_QuerySubmitted(sender As SearchBox, args As SearchBoxQuerySubmittedEventArgs)
    Me.Frame.Navigate(GetType(SearchResultsPage1), args.QueryText)
End Sub
```



## -see-also
[Quickstart: Adding search to an app](/previous-versions/windows/apps/hh868180(v=win.10)), [Control](control.md), [SearchBoxQuerySubmittedEventArgs](searchboxquerysubmittedeventargs.md), [SearchBox control sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/SearchBox%20control%20sample), [Enabling users to search for information in your ](/previous-versions/windows/apps/hh868180(v=win.10))
