---
-api-id: T:Windows.Foundation.IMemoryBuffer
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IMemoryBuffer : Windows.Foundation.IClosable
-->

# Windows.Foundation.IMemoryBuffer

## -description
Represents a reference counted memory buffer.

## -remarks
IMemoryBuffer provides an interoperability protocol between the unmanaged, direct memory access of the native platform and the reference-counted, potentially garbage-collected environment hosting managed objects. The managed type system requires deterministic lifetime for all types. This lifetime is sometimes implicit (value types are copied by value) or explicit (reference types are reference counted). However for performance reasons, code occasionally needs to interact with types that don’t naturally fit into either model.

A common example, and the one addressed by the IMemoryBuffer design, is access to a direct pointer to a block of memory where performance constraints require that the memory is not copied. The IMemoryBuffer abstraction encapsulates such a direct memory pointer within a set of reference counted objects that layer explicit acquisition of the raw memory pointer and allow its deterministic release.

## -examples

## -see-also
[IClosable](iclosable.md)
