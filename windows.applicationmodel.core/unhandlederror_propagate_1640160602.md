---
-api-id: M:Windows.ApplicationModel.Core.UnhandledError.Propagate
-api-type: winrt method
---

<!-- Method syntax
public void Propagate()
-->

# Windows.ApplicationModel.Core.UnhandledError.Propagate

## -description
Wraps the underlying error info in a language specific exception, and throws the error.

## -remarks
In addition to throwing the language-specific wrapped error, calling this method marks the error as handled (sets [Handled](unhandlederror_handled.md) to **true**). However, if an error is returned from a delegate, the handled state is set to **false**.

## -examples

## -see-also
