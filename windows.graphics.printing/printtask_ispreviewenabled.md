---
-api-id: P:Windows.Graphics.Printing.PrintTask.IsPreviewEnabled
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public bool IsPreviewEnabled { get;  set; }
-->

# Windows.Graphics.Printing.PrintTask.IsPreviewEnabled

## -description
Gets or sets a value that indicates whether the [PrintTask](printtask.md) will show a print preview.

## -property-value
True, if print preview is enabled.

## -remarks
In some situations, displaying the print preview will take too much time and disrupt the user experience of a Universal Windows app. For this reason, the developer may wish to disable the print preview feature in favor of a smoother control flow.

By default, **isPreviewEnabled** is **true**. Windows Store app that are meant to print in the background must set **isPreviewEnabled** to **false**.

## -examples

## -see-also
