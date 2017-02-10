---
-api-id: P:Windows.ApplicationModel.Search.Core.SearchSuggestion.Tag
-api-type: winrt property
---

<!-- Property syntax
public string Tag { get; }
-->

# Windows.ApplicationModel.Search.Core.SearchSuggestion.Tag

## -description
Gets the value that was passed to the *tag* parameter of the [AppendResultSuggestion](../windows.applicationmodel.search/searchsuggestioncollection_appendresultsuggestion.md) method.

## -property-value
The tag, or **null** if the search suggestion is not a **Result**.

## -remarks
The [Tag](searchsuggestion_tag.md) property is an opaque value that the app uses to identify the result suggestions that it has added when the user selects a suggestion in the UI.

## -examples

## -see-also
[SearchBox](../windows.ui.xaml.controls/searchbox.md)