---
-api-id: M:Windows.UI.Text.ITextSelection.TypeText(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void TypeText(System.String value)
-->

# Windows.UI.Text.ITextSelection.TypeText

## -description
Enters text into the selection as if someone typed it.

Equivalent WinUI method: [Microsoft.UI.Text.ITextSelection.TypeText](/windows/winui/api/microsoft.ui.text.itextselection.typetext).

## -parameters
### -param value
The text string to type into this selection.

## -remarks
This method is similar to the underlying [ITextDocument.SetText](itextdocument_settext_522499431.md) method, but is sensitive to the Insert or Overtype key state and UI settings like AutoCorrect and smart quotes.

## -examples

## -see-also
