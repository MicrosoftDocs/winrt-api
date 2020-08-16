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
The [Search contract sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample) demonstrates how to register a [querysubmitted](searchpane_querysubmitted.md) event handler.

> [!NOTE]
> You can access information about the event from the searchPaneQuerySubmittedEventArgs object that is passed to your [querysubmitted](searchpane_querysubmitted.md) event handler.



[!code-csharp[all_searchpane_querysubmitted_register](../windows.applicationmodel.search/code/SearchContract/CS/App.xaml.cs#Snippetall_searchpane_querysubmitted_register)]

[!code-js[all_searchpane_querysubmitted_register](../windows.applicationmodel.search/code/SearchContract/js/js/default.js#Snippetall_searchpane_querysubmitted_register)]

## -see-also
[SearchPane.QuerySubmitted event](searchpane_querysubmitted.md), [SearchPaneQuerySubmittedEventArgs class
chpanequerysubmittedeventargs.md)
