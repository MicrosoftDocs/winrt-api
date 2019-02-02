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
The [Search contract sample](https://go.microsoft.com/fwlink/p/?linkid=234892) demonstrates how to register a [resultsuggestionchosen](searchpane_resultsuggestionchosen.md) event handler.

> [!NOTE]
> You can get information about the event from the [searchPaneResultSuggestionChosenEventArgs](searchpaneresultsuggestionchoseneventargs.md) object that is passed to your [resultsuggestionchosen](searchpane_resultsuggestionchosen.md) event handler.



[!code-csharp[all_suggestionchosen_register](../windows.applicationmodel.search/code/SearchContract/CS/Scenario6.xaml.cs#Snippetall_suggestionchosen_register)]

[!code-js[all_suggestionchosen_register](../windows.applicationmodel.search/code/SearchContract/js/js/scenario6.js#Snippetall_suggestionchosen_register)]

## -see-also
[Search contract sample](https://go.microsoft.com/fwlink/p/?linkid=234892), [SearchPane class](searchpane.md), [SearchPane.ResultSuggestionChosen event](searchpane_resultsuggestionchosen.md), [SearchSuggestionCollection.AppendResultSuggestion method](searchsuggestioncollection_appendresultsuggestion_603544202.md)
ection_appendresultsuggestion.md)
