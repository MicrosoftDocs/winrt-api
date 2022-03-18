---
-api-id: M:Windows.UI.Xaml.Controls.HandwritingView.TryOpen
-api-type: winrt method
---

<!-- Method syntax.
public bool HandwritingView.TryOpen()
-->

# Windows.UI.Xaml.Controls.HandwritingView.TryOpen

## -description

Attempts to open the handwriting view panel.

## -returns

**true** if the handwriting view panel opened; otherwise, **false**.

## -remarks

There are cases where the handwriting view does not open, such as when the current language is not supported.

The **Opened** event is raised if the handwriting view opens successfully.

## -see-also

[Text input with the handwriting view](/windows/uwp/design/controls-and-patterns/text-handwriting-view)

## -examples

