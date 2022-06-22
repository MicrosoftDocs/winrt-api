---
-api-id: T:Windows.UI.Xaml.Automation.AnnotationType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Automation.AnnotationType : int
-->

# AnnotationType

## -description
Provides a set of constants that identify types of annotations in a document, as used by the [ISpreadsheetItemProvider](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-ispreadsheetitemprovider)  Microsoft UI Automation interface.



## -enum-fields
### -field Unknown:60000
The annotation type is unknown.

### -field SpellingError:60001
A spelling error, often denoted by a red squiggly line.

### -field GrammarError:60002
A grammatical error, often denoted by a green squiggly line.

### -field Comment:60003
A comment. Comments can take different forms depending on the application.

### -field FormulaError:60004
An error in a formula. Formula errors typically include red text and exclamation marks.

### -field TrackChanges:60005
A change that was made to the document.

### -field Header:60006
The header for a page in a document.

### -field Footer:60007
The footer for a page in a document.

### -field Highlighted:60008
Highlighted content, typically denoted by a contrasting background color.

### -field Endnote:60009
Endnote content.

### -field Footnote:60010
Footnote content.

### -field InsertionChange:60011
An insertion change.

### -field DeletionChange:60012
A deletion change.

### -field MoveChange:60013
A move change.

### -field FormatChange:60014
A format change.

### -field UnsyncedChange:60015
An unsynced change.

### -field EditingLockedChange:60016
An editing locked change.

### -field ExternalChange:60017
An external change.

### -field ConflictingChange:60018
A conflicting change.

### -field Author:60019
Author info.

### -field AdvancedProofingIssue:60020
An advanced proofing issue.

### -field DataValidationError:60021
A data validation error.

### -field CircularReferenceError:60022
A circular reference error.


## -remarks
This enumeration is used as an input value to the [GetAnnotationTypes](../windows.ui.xaml.automation.provider/ispreadsheetitemprovider_getannotationtypes_911639376.md) method.

The values in AnnotationType parallel the values in the [Annotation Type Identifiers](/windows/desktop/WinAuto/uiauto-annotation-type-identifiers) constants.

<!--The descriptions in this topic are adapted or taken directly from http://msdn.microsoft.com/library/windows/desktop/hh448743(v=vs.85).aspx-->

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | AdvancedProofingIssue |
| 1607 | 14393 | Author |
| 1607 | 14393 | CircularReferenceError |
| 1607 | 14393 | ConflictingChange |
| 1607 | 14393 | DataValidationError |
| 1607 | 14393 | DeletionChange |
| 1607 | 14393 | EditingLockedChange |
| 1607 | 14393 | ExternalChange |
| 1607 | 14393 | FormatChange |
| 1607 | 14393 | InsertionChange |
| 1607 | 14393 | MoveChange |
| 1607 | 14393 | UnsyncedChange |

## -examples

## -see-also
[GetAnnotationTypes](../windows.ui.xaml.automation.provider/ispreadsheetitemprovider_getannotationtypes_911639376.md)
