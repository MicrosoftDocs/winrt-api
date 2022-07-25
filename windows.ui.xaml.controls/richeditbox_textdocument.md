---
-api-id: P:Windows.UI.Xaml.Controls.RichEditBox.TextDocument
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public RichEditTextDocument TextDocument { get; }
-->

# Windows.UI.Xaml.Controls.RichEditBox.TextDocument

## -description

Gets an object that enables access to the text object model for the text contained in a [RichEditBox](richeditbox.md).



## -property-value

An object that enables access to the text object model.

## -remarks

The TextDocument property is equivalent to the [Document](richeditbox_document.md) property except for the type. The Document property is of type [ITextDocument](/windows.ui.text/itextdocument.md), and can be type cast to RichEditTextDocument. The TextDocument property, on the other hand, is already typed as RichEditTextDocument, so no type cast is necessary.


## -see-also

## -examples

