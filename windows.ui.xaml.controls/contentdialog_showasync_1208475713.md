---
-api-id: M:Windows.UI.Xaml.Controls.ContentDialog.ShowAsync(Windows.UI.Xaml.Controls.ContentDialogPlacement)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<ContentDialogResult> ContentDialog.ShowAsync(ContentDialogPlacement placement)
-->

# Windows.UI.Xaml.Controls.ContentDialog.ShowAsync

## -description

Begins an asynchronous operation to show the dialog with the specified placement.



## -parameters

### -param placement

A value that specifies whether the dialog is placed in the PopupRoot or in its parent's visual tree.

## -returns

An asynchronous operation showing the dialog. When complete, returns a [ContentDialogResult](contentdialogresult.md).

## -remarks

When you call this method with the **ContentDialogPlacement.Popup** parameter value, the dialog is rooted in the PopupRoot element of the XAML Window. This is the default behavior, and is equivilent to calling the [ShowAsync](contentdialog_showasync_1714076542.md) method with no parameters.

When you call this method with the **ContentDialogPlacement.InPlace** parameter value:

- If the dialog has a parent element, the dialog is rooted in the parent's visual tree. It's shown inline along with the parent’s other child elements, and participates in the parent container’s layout.
- If the dialog has no parent, the dialog falls back to the default behavior and is shown in the PopupRoot.

## -see-also

## -examples

