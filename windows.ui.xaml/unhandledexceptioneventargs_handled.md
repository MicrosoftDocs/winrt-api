---
-api-id: P:Windows.UI.Xaml.UnhandledExceptionEventArgs.Handled
-api-type: winrt property
---

<!-- Property syntax
public bool Handled { get;  set; }
-->

# Windows.UI.Xaml.UnhandledExceptionEventArgs.Handled

## -description
Gets or sets a value that indicates whether the exception is handled.

## -property-value
**true** to mark the exception as handled, which indicates that the event system should not process it further; otherwise, **false**.

## -remarks
Do not routinely set this value to **true**, that is not always safe and may not guarantee that the app wouldn't terminate anyways. For more info, see [Exception handling for    in C# or Visual Basic](http://msdn.microsoft.com/library/825c5d4f-5ce0-ee93-fd1e-aca1372b1670) and Remarks in [UnhandledException](application_unhandledexception.md).

## -examples

## -see-also
[UnhandledException](application_unhandledexception.md), [Exception handling for    in C# or Visual Basic](http://msdn.microsoft.com/library/825c5d4f-5ce0-ee93-fd1e-aca1372b1670), [Exceptions (C++/CX)](https://docs.microsoft.com/cpp/cppcx/exceptions-c-cx)