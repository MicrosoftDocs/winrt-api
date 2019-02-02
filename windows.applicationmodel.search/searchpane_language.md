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
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md) for UWP app using C++, C#, or Visual Basic, [WinJS.UI.SearchBox](https://msdn.microsoft.com/library/58f5cea3-a19b-48a8-abcc-17f38d8fa886) for Windows app using JavaScript) and the [SearchPane](searchpane.md). Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

## -examples

## -see-also
[Quickstart: Adding search](https://msdn.microsoft.com/library/d412c562-22d2-41c4-9f27-27503b89b9e9), [Search contract sample](https://go.microsoft.com/fwlink/p/?linkid=234892), [Object class](https://msdn.microsoft.com/library/system.object.aspx), [SearchPane class](searchpane.md)
