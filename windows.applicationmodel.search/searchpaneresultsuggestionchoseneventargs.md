---
-api-id: T:Windows.ApplicationModel.Search.SearchPaneResultSuggestionChosenEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class SearchPaneResultSuggestionChosenEventArgs : Windows.ApplicationModel.Search.ISearchPaneResultSuggestionChosenEventArgs
-->

# Windows.ApplicationModel.Search.SearchPaneResultSuggestionChosenEventArgs

## -description
Provides data for a [resultsuggestionchosen](searchpane_resultsuggestionchosen.md) event that is associated with a [searchPane](searchpane.md) object.

## -remarks
This object is passed to an app's [resultsuggestionchosen](searchpane_resultsuggestionchosen.md) event handler.

## -examples
The [Search contract sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample) demonstrates how to register a [resultsuggestionchosen](searchpane_resultsuggestionchosen.md) event handler.

> [!NOTE]
> You can get information about the event from the searchPaneResultSuggestionChosenEventArgs object that is passed to your [resultsuggestionchosen](searchpane_resultsuggestionchosen.md) event handler.



[!code-csharp[all_suggestionchosen_register](../windows.applicationmodel.search/code/SearchContract/CS/Scenario6.xaml.cs#Snippetall_suggestionchosen_register)]

[!code-js[all_suggestionchosen_register](../windows.applicationmodel.search/code/SearchContract/js/js/scenario6.js#Snippetall_suggestionchosen_register)]

## -see-also
[Search contract sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [SearchPane class](searchpane.md), [SearchPane.ResultSuggestionChosen event](searchpane_resultsuggestionchosen.md), [SearchSuggestionCollection.AppendResultSuggestion method](searchsuggestioncollection_appendresultsuggestion_603544202.md)
