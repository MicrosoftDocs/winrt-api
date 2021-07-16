---
-api-id: M:Windows.Web.Http.HttpStringContent.Close
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax
public void Close()
-->

# Windows.Web.Http.HttpStringContent.Close

## -description
Closes the [HttpStringContent](httpstringcontent.md) instance and releases allocated resources.

## -remarks
The Close method releases allocated resources used by the [HttpStringContent](httpstringcontent.md) instance. The Close method can manage the lifetime of system resources (memory for the [HttpStringContent](httpstringcontent.md), for example) used by a Windows Runtime object.

In the .NET Framework 4.5, this method projects as the [Dispose](/uwp/api/windows.web.http.httpstringcontent.dispose) method. In Visual C++ component extensions (C++/CX), this method projects as the destructor (delete operator).

Apps written in JavaScript, C#, or VB.NET use garbage collection to release resources. So the [HttpStringContent](httpstringcontent.md) object and associated resources don't get released until the garbage collection pass runs. The Close method allows an app to release these resources early rather than waiting for the object to be released by garbage collection.

Apps written in C++ or CX don't have a Close method since these apps can destroy the object. In C++ and CX, objects are released when they fall out of program scope or as part of the destructor (delete operator) for the object.

## -examples

## -see-also
