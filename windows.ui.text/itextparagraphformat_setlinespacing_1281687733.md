---
-api-id: M:Windows.UI.Text.ITextParagraphFormat.SetLineSpacing(Windows.UI.Text.LineSpacingRule,System.Single)
-api-type: winrt method
---

<!-- Method syntax
public void SetLineSpacing(Windows.UI.Text.LineSpacingRule rule, System.Single spacing)
-->

# Windows.UI.Text.ITextParagraphFormat.SetLineSpacing

## -description
Sets the paragraph line-spacing rule and the amount of line spacing for a paragraph.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Text.ITextParagraphFormat.SetLineSpacing](/windows/winui/api/microsoft.ui.text.itextparagraphformat.setlinespacing) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param rule
The new line-spacing rule.

### -param spacing
The new line spacing amount. If the line-spacing *rule* interprets the *spacing* value as a linear dimension, *spacing* is given in floating-point points.

## -remarks
Because the line-spacing rule and line spacing work together, they must be set together.

## -examples

## -see-also
[ITextParagraphFormat.LineSpacing](itextparagraphformat_linespacing.md), [ITextParagraphFormat.LineSpacingRule](itextparagraphformat_linespacingrule.md)
