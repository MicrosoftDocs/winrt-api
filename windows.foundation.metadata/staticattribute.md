---
-api-id: T:Windows.Foundation.Metadata.StaticAttribute
-api-type: winrt class
---

<!-- Class syntax.
public class StaticAttribute : System.Attribute
-->

# Windows.Foundation.Metadata.StaticAttribute

## -description
Indicates an interface that contains only static methods.

## -remarks
The StaticAttribute specifies an interface with methods that language projections supply as static methods of the class. A runtime class may specify zero or more static attributes.

A runtime class may have an [ActivatableAttribute](activatableattribute.md) to indicate that instances of the class can be constructed. Also, a runtime class may have instance interfaces, which indicate the instance methods that language projections supply on each object instance.

## -examples

## -see-also
[Attribute](/dotnet/api/system.attribute?view=dotnet-uwp-10.0&preserve-view=true), [ActivatableAttribute](activatableattribute.md)
