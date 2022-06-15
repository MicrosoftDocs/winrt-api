---
-api-id: M:Windows.UI.Text.ITextRange.GetClone
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Text.ITextRange GetClone()
-->

# Windows.UI.Text.ITextRange.GetClone

## -description
Creates a new object that is identical to this text range object.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Text.ITextRange.GetClone](/windows/winui/api/microsoft.ui.text.itextrange.getclone) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -returns
The duplicate text range object.

## -remarks
To create an insertion point to traverse a text range, first clone the range and then collapse the duplicate at its starting character position.

## -examples

## -see-also
