---
-api-id: M:Windows.UI.Text.ITextDocument.CanPaste
-api-type: winrt method
---

<!-- Method syntax
public bool CanPaste()
-->

# Windows.UI.Text.ITextDocument.CanPaste

## -description
Determines whether the Clipboard has content that can be pasted into the document.

## -returns
True if the Clipboard has content that can be pasted into the document; otherwise false.

## -remarks
Pasting is allowed unless the control is read-only or the selection is protected and the client refuses permission to paste.

## -examples

## -see-also
[ITextDocument.CanCopy](itextdocument_cancopy_171689037.md), [ITextDocument.CanRedo](itextdocument_canredo_328904111.md), [ITextDocument.CanUndo](itextdocument_canundo_730574244.md)