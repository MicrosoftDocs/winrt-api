---
-api-id: T:Windows.Foundation.IGetActivationFactory
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IGetActivationFactory : 
-->

# Windows.Foundation.IGetActivationFactory

## -description
Defines the implementation for a type that retrieves activation factories.

## -remarks
For typical apps (those that use C#, Visual Basic, C++/CX or JavaScript for programming language), this interface should be considered as an infrastructure piece that the overall Windows Runtime programming experience uses as an implementation detail. There are no common app development scenarios that rely on implementing or using the [IGetActivationFactory](igetactivationfactory.md) interface directly.

The scenario that [IGetActivationFactory](igetactivationfactory.md) supports is if you are defining Windows Runtime components using WRL, which are packaged as separate executables. In this case, there is no automatic activation as part of the app model, and the component is responsible for the activation of its classes prior to use (through various APIs in the [Windows.ApplicationModel.Core](../windows.applicationmodel.core/windows_applicationmodel_core.md) namespace). For a sample that illustrates how to implement this, see [Creating a  EXE component with C++ sample](http://go.microsoft.com/fwlink/p/?LinkID=258333).

### Notes to implementers

The implementation of a type that supports this interface must have a method called [GetActivationFactory](igetactivationfactory_getactivationfactory.md) that takes an Activation ID (ACID) as a parameter and returns a type that implements [IActivationFactory](http://msdn.microsoft.com/library/c6a2ed6e-9c45-4cf3-a301-72a5daeb4dfc).

## -examples

## -see-also
[CoreApplication::RunWithActivationFactories](../windows.applicationmodel.core/coreapplication_runwithactivationfactories.md)