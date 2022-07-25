---
-api-id: M:Windows.UI.Text.ITextParagraphFormat.AddTab(System.Single,Windows.UI.Text.TabAlignment,Windows.UI.Text.TabLeader)
-api-type: winrt method
---

<!-- Method syntax
public void AddTab(System.Single position, Windows.UI.Text.TabAlignment align, Windows.UI.Text.TabLeader leader)
-->

# Windows.UI.Text.ITextParagraphFormat.AddTab

## -description
Adds a new tab at the specified position.



## -parameters
### -param position
The position of the new tab, in floating-point points relative to the left side of the page for left-to-right paragraphs, or the right side of the page for right-to-left paragraphs. A maximum of 63 tabs are allowed. Tabs beyond the page are ignored. Negative tabs are not valid.

### -param align
The alignment option for the tab position.

### -param leader
The character used to fill the space taken by a tab character.

## -remarks

## -examples

## -see-also
[ITextDocument.DefaultTabStop](itextdocument_defaulttabstop.md), [ITextParagraphFormat.ClearAllTabs](itextparagraphformat_clearalltabs_28978480.md), [ITextParagraphFormat.DeleteTab](itextparagraphformat_deletetab_937922036.md), [ITextParagraphFormat.GetTab](itextparagraphformat_gettab_939731864.md), [ITextParagraphFormat.TabCount](itextparagraphformat_tabcount.md)
