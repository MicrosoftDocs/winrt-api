---
-api-id: T:Windows.ApplicationModel.Search.SearchPaneQuerySubmittedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class SearchPaneQuerySubmittedEventArgs : Windows.ApplicationModel.Search.ISearchPaneQuerySubmittedEventArgs, Windows.ApplicationModel.Search.ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails
-->

# Windows.ApplicationModel.Search.SearchPaneQuerySubmittedEventArgs

## -description
Provides data for a [querysubmitted](searchpane_querysubmitted.md) event that is associated with a [searchPane](searchpane.md) instance.

## -remarks
This object is passed to an app's [querysubmitted](searchpane_querysubmitted.md) event handler.

## -examples
The [Search contract sample](http://go.microsoft.com/fwlink/p/?linkid=234892) demonstrates how to register a [querysubmitted](searchpane_querysubmitted.md) event handler.

> [!NOTE]
> You can access information about the event from the [searchPaneQuerySubmittedEventArgs](searchpanequerysubmittedeventargs.md) object that is passed to your [querysubmitted](searchpane_querysubmitted.md) event handler.



[!code-csharp[all_searchpane_querysubmitted_register](../windows.applicationmodel.search/code/SearchContract/CS/App.xaml.cs#Snippetall_searchpane_querysubmitted_register)]

[!code-js[all_searchpane_querysubmitted_register](../windows.applicationmodel.search/code/SearchContract/js/js/default.js#Snippetall_searchpane_querysubmitted_register)]

## -see-also
[SearchPane.QuerySubmitted event](searchpane_querysubmitted.md), [SearchPaneQuerySubmittedEventArgs class](searchpanequerysubmittedeventargs.md)
chpanequerysubmittedeventargs.md)
