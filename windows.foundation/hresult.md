---
-api-id: T:Windows.Foundation.HResult
-api-type: winrt struct
---

<!-- Structure syntax.
public struct HResult 
-->

# HResult

## -description
Represents a Windows Runtime error.

> **.NET**
> When programming with .NET, this type is hidden, and exceptions appear as [System.Exception](https://msdn.microsoft.com/library/system.exception.aspx) or specific derived exception types. See Remarks.

## -struct-fields

### -field Value
An integer that describes an error.
    

## -remarks
When programming with .NET, this class is hidden. All exceptions that are visible to .NET programming are instead reported as an instance of the [System.Exception](https://msdn.microsoft.com/library/system.exception.aspx) class, or a specific derivative exception (a standard exception) where the exception type encapsulates a more detailed meaning or scenario for the exception. This is true for first-chance exceptions you encounter while developing, run-time exceptions, and any exceptions that you can handle at the app level using the [UnhandledException](../windows.ui.xaml/application_unhandledexception.md) technique.

For more info on how to handle exceptions using C# or Visual Basic, see [Exception handling for  in C# or Visual Basic](https://msdn.microsoft.com/library/825c5d4f-5ce0-ee93-fd1e-aca1372b1670).

For more info on how to handle exceptions using Visual C++ component extensions (C++/CX), see [Exceptions (C++/CX)](https://msdn.microsoft.com/library/6cbdc1f1-e4d7-4707-a670-86365146432f).

For more info on how to handle errors in JavaScript, see [JavaScript Run-time Errors](https://msdn.microsoft.com/library/c111469d-8f31-4bde-9d46-16d58775db7d).


<!--The JS topic is just a lookup table but that is better than nothing?-->
The Windows Runtime  **HResult** is based on the [Windows Error codes model](https://msdn.microsoft.com/library/1bc92ddf-b79e-413c-bbaa-99a5281a6c90). The **Value** field combines all the parts of a conventional **HRESULT** as a single integer (preceding bits, facility, error code). The Windows Runtime does have its own facility, but also uses (and can throw) error codes defined by other facilities.

## -examples

## -see-also
[Exception handling in C# or Visual Basic](https://msdn.microsoft.com/library/825c5d4f-5ce0-ee93-fd1e-aca1372b1670)  
[Exceptions (C++/CX)](https://msdn.microsoft.com/library/6cbdc1f1-e4d7-4707-a670-86365146432f)  
[JavaScript Run-time Errors](https://msdn.microsoft.com/library/c111469d-8f31-4bde-9d46-16d58775db7d)  
[Application.UnhandledException](../windows.ui.xaml/application_unhandledexception.md)  
[Debug apps in Visual Studio](https://msdn.microsoft.com/library/48a85bcf-290b-4390-9993-f6f9dd73ad03)
