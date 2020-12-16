---
-api-id: T:Windows.Foundation.IClosable
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IClosable : 
-->

# Windows.Foundation.IClosable

## -description
Defines a method to release allocated resources.



> **.NET**
> This interface appears as [System.IDisposable](/dotnet/api/system.idisposable?view=dotnet-uwp-10.0&preserve-view=true).



> **C++/CX**
> This interface appears as [Platform::IDisposable](/cpp/cppcx/platform-idisposable-interface).

## -remarks
This interface is projected to a different interface for all possible languages, so it should be considered as an infrastructure piece that the overall Windows Runtime programming experience uses as an implementation detail. There are no typical app development scenarios that rely on implementing or using the IClosable interface directly, unless you're using WRL. For more info, see [WRL Integration](/cpp/cppcx/wrl-integration-c-cx).

### Notes to implementers

When programming with .NET, this interface is hidden and is replaced by the [System.IDisposable](/dotnet/api/system.idisposable?view=dotnet-uwp-10.0&preserve-view=true) interface.

If you are defining a runtime class in C++/CX and define a destructor, don't implement IClosable. There's already compiler-based behavior that implements a cleanup behavior for you, (as [Platform::IDisposable](/cpp/cppcx/platform-idisposable-interface)) and your explicit implementation will clash with the built-in behavior. For more info, see the "Destructors" section of [Ref classes and structs (C++/CX)](/cpp/cppcx/ref-classes-and-structs-c-cx).

The purpose of this interface (as exposed by the languages) is so that Windows Runtime objects can wrap and dispose of exclusive system or device/hardware resources appropriately, such as file handles and network sockets. You do not implement this interface for Windows Runtime objects that wrap shared system resources, such as memory and shareable devices.

### Notes to callers

The scenario for [Platform::IDisposable](/cpp/cppcx/platform-idisposable-interface)/[System.IDisposable](/dotnet/api/system.idisposable?view=dotnet-uwp-10.0&preserve-view=true) is to support language-specific syntax that isolates references, such as the **using()** syntax in C#, or scoping behavior for reference counting in C++. Actually casting to the interfaces or invoking its methods from any app code in any language is rarely necessary.

## -examples

## -see-also
[System.IDisposable](/dotnet/api/system.idisposable?view=dotnet-uwp-10.0&preserve-view=true)
