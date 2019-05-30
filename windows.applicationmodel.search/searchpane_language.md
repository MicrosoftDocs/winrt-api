---
-api-id: P:Windows.ApplicationModel.Search.SearchPane.Language
-api-type: winrt property
---

<!-- Property syntax
public string Language { get; }
-->

# Windows.ApplicationModel.Search.SearchPane.Language

## -description
The Internet Engineering Task Force (IETF) language tag (BCP 47 standard) that identifies the language currently associated with the user's text input device.

## -property-value
The Internet Engineering Task Force (IETF) BCP 47 standard language tag.

## -remarks
> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md) for UWP app using C++, C#, or Visual Basic, [WinJS.UI.SearchBox](https://docs.microsoft.com/previous-versions/windows/apps/dn301949(v=win.10)) for Windows app using JavaScript) and the [SearchPane](searchpane.md). Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

## -examples

## -see-also
[Quickstart: Adding search](https://docs.microsoft.com/previous-versions/windows/apps/hh465238(v=win.10)), [Search contract sample](https://go.microsoft.com/fwlink/p/?linkid=234892), [Object class](https://docs.microsoft.com/dotnet/api/system.object?redirectedfrom=MSDN), [SearchPane class](searchpane.md)
