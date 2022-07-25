---
-api-id: P:Windows.UI.Text.ITextParagraphFormat.ListLevelIndex
-api-type: winrt property
---

<!-- Property syntax
public int ListLevelIndex { get;  set; }
-->

# Windows.UI.Text.ITextParagraphFormat.ListLevelIndex

## -description
Gets or sets the list level index used with paragraphs.



## -property-value
The list level index. It can be a value of 0 or higher, as described in the following table. <table>
   <tr><th>Value</th><th>Meaning</th></tr>
   <tr><td>0</td><td>No list.</td></tr>
   <tr><td>1</td><td>First-level (outermost) list.</td></tr>
   <tr><td>2</td><td>Second-level (nested) list. This is nested under a level 1 list item.</td></tr>
   <tr><td>3</td><td>Third-level (nested) list. This is nested under a level 2 list item.</td></tr>
   <tr><td>And so on</td><td>Nesting continues similarly.</td></tr>
</table>

 Up to three levels are common in HTML documents.

## -remarks
Setting the list level index doesn't automatically change a list's indentation and other paragraph properties.

## -examples

## -see-also
