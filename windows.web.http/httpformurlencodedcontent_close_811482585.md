---
-api-id: M:Windows.Web.Http.HttpFormUrlEncodedContent.Close
-api-type: winrt method
---

<!-- Method syntax
public void Close()
-->

# Windows.Web.Http.HttpFormUrlEncodedContent.Close

## -description
Closes the [HttpFormUrlEncodedContent](httpformurlencodedcontent.md) instance and releases allocated resources.

## -remarks
The [Close](httpformurlencodedcontent_close_811482585.md) method releases allocated resources used by the [HttpFormUrlEncodedContent](httpformurlencodedcontent.md) instance. The [Close](httpformurlencodedcontent_close_811482585.md) method can manage the lifetime of system resources (memory for the [HttpFormUrlEncodedContent](httpformurlencodedcontent.md), for example) used by a Windows Runtime object.

In the .NET Framework 4.5, this method projects as the [Dispose](httpformurlencodedcontent_dispose.md) method. In Visual C++ component extensions (C++/CX), this method projects as the destructor (delete operator).

Apps written in JavaScript, C#, or VB.NET use garbage collection to release resources. So the [HttpFormUrlEncodedContent](httpformurlencodedcontent.md) object and associated resources doesn't get released until the garbage collection pass runs. The [Close](httpformurlencodedcontent_close_811482585.md) method allows an app to release these resources early rather than waiting for the object to be released by garbage collection.

Apps written in C++ or CX don't have a [Close](httpformurlencodedcontent_close_811482585.md) method since these apps can destroy the object. In C++ and CX, objects are released when they fall out of program scope or as part of the destructor (delete operator) for the object.

## -examples

## -see-also
