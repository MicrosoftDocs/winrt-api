---
-api-id: P:Windows.UI.Text.ITextRange.EndPosition
-api-type: winrt property
---

<!-- Property syntax
public int EndPosition { get;  set; }
-->

# Windows.UI.Text.ITextRange.EndPosition

## -description
Gets or sets the end character position of the text range.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Text.ITextRange.EndPosition](/windows/winui/api/microsoft.ui.text.itextrange.endposition) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
The end character position.

## -remarks
A text range object remains valid when the text is edited, but a character position is volatile. That is, a character position becomes invalid when text is inserted or deleted before the character position. Be careful when using character positions, especially if you store them for a significant length of time.

## -examples

## -see-also
