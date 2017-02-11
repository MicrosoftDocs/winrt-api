---
-api-id: P:Windows.UI.Text.ITextParagraphFormat.TabCount
-api-type: winrt property
---

<!-- Property syntax
public int TabCount { get; }
-->

# Windows.UI.Text.ITextParagraphFormat.TabCount

## -description
Retrieves the tab count.

## -property-value
The tab count.

## -remarks
The tab count of a new instance can be nonzero; for example, Microsoft Word stories begin with no explicit tabs defined, while rich edit instances start with a single explicit tab. To ensure there are no explicit tabs (that is, to set the tab count to zero), call the [ITextParagraphFormat.ClearAllTabs](itextparagraphformat_clearalltabs.md) method.

## -examples

## -see-also
[ITextDocument.DefaultTabStop](itextdocument_defaulttabstop.md), [ITextParagraphFormat.AddTab](itextparagraphformat_addtab.md), [ITextParagraphFormat.ClearAllTabs](itextparagraphformat_clearalltabs.md), [ITextParagraphFormat.DeleteTab](itextparagraphformat_deletetab.md), [ITextParagraphFormat.GetTab](itextparagraphformat_gettab.md)