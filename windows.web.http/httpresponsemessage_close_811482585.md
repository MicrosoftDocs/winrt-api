---
-api-id: M:Windows.Web.Http.HttpResponseMessage.Close
-api-type: winrt method
---

<!-- Method syntax
public void Close()
-->

# Windows.Web.Http.HttpResponseMessage.Close

## -description
Closes the [HttpResponseMessage](httpresponsemessage.md) instance and releases allocated resources.

## -remarks
The [Close](httpresponsemessage_close.md) method releases allocated resources used by the [HttpResponseMessage](httpresponsemessage.md) instance. The [Close](httpresponsemessage_close.md) method can manage the lifetime of system resources (memory for the [HttpResponseMessage](httpresponsemessage.md), for example) used by a Windows Runtime object.

In the .NET Framework 4.5, this method projects as the [Dispose](httpresponsemessage_dispose.md) method. In Visual C++ component extensions (C++/CX), this method projects as the destructor (delete operator).

Apps written in JavaScript, C#, or VB.NET use garbage collection to release resources. So the [HttpResponseMessage](httpresponsemessage.md) object and associated resources doesn't get released until the garbage collection pass runs. The [Close](httpresponsemessage_close.md) method allows an app to release these resources early rather than waiting for the object to be released by garbage collection.

Apps written in C++ or CX don't have a [Close](httpresponsemessage_close.md) method since these apps can destroy the object. In C++ and CX, objects are released when they fall out of program scope or as part of the destructor (delete operator) for the object.

## -examples

## -see-also
