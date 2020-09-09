---
-api-id: P:Windows.UI.Popups.MessageDialog.Title
-api-type: winrt property
---

<!-- Property syntax
public string Title { get;  set; }
-->

# Windows.UI.Popups.MessageDialog.Title

## -description
Gets or sets the title to display on the dialog, if any.

## -property-value
The title to display on the dialog; or, an empty string if no title is set.

## -remarks
Use the title as a concise main instruction to convey the objective of the dialog.

Long titles do not wrap and will be truncated.

If you use the dialog to deliver a simple message, error, or question, omit the title. Rely on the [content](messagedialog_content.md) to deliver that core information.

On the desktop device family the title is displayed both in the title bar of the popup dialog window, and in the body of the dialog. On the mobile device family, the title is shown only in the body of the dialog.

## -examples

## -see-also
[MessageDialog.Content](messagedialog_content.md), [Quickstart: Designing a message dialog](/previous-versions/windows/apps/hh738364(v=win.10))
