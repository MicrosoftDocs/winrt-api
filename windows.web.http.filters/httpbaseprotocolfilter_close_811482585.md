---
-api-id: M:Windows.Web.Http.Filters.HttpBaseProtocolFilter.Close
-api-type: winrt method
---

<!-- Method syntax
public void Close()
-->

# Windows.Web.Http.Filters.HttpBaseProtocolFilter.Close

## -description
Closes the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) instance and releases allocated resources.

## -remarks
The Close method releases allocated resources used by the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) instance. The Close method can be used to manage the lifetime of system resources (the network socket used by the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md), for example) that are used by a Windows Runtime object.

In the .NET Framework 4.5, this method is projected as the [Dispose](/uwp/api/windows.web.http.filters.httpbaseprotocolfilter.dispose) method. In Visual C++ component extensions (C++/CX), this method is projected as part of the destructor (delete operator).

Apps written in JavaScript, C#, or VB.NET use garbage collection to release resources. So the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) object and associated resources doesn't get released until the garbage collection pass runs. The Close method allows an app to release these resources early rather than waiting for the object to be released by garbage collection.

Apps written in C++ or CX don't have a Close method since these apps can destroy the object deterministically. In C++ and CX, objects are released when they fall out of program scope or as part of the destructor (delete operator) for the object.

## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md)
