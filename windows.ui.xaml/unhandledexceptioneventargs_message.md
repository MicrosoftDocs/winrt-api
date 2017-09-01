---
-api-id: P:Windows.UI.Xaml.UnhandledExceptionEventArgs.Message
-api-type: winrt property
---

<!-- Property syntax
public string Message { get; }
-->

# Windows.UI.Xaml.UnhandledExceptionEventArgs.Message

## -description
Gets the message string as passed by the originating unhandled exception.

## -property-value
The message string, which may be useful for debugging.

## -remarks
The message is coming from info that's propagated by the original system or runtime app error. The message is not guaranteed to be an exact match to the original error message (as seen in native stacks or output windows). For more info on error propagation and exception handling techniques, see [Exception handling for    in C# or Visual Basic](http://msdn.microsoft.com/library/825c5d4f-5ce0-ee93-fd1e-aca1372b1670) and Remarks in [UnhandledException](application_unhandledexception.md).

## -examples

## -see-also
[UnhandledException](application_unhandledexception.md), [Exception handling for    in C# or Visual Basic](http://msdn.microsoft.com/library/825c5d4f-5ce0-ee93-fd1e-aca1372b1670), [Exceptions (C++/CX)](https://docs.microsoft.com/en-us/cpp/cppcx/exceptions-c-cx)