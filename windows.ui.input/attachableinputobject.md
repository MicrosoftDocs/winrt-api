---
-api-id: T:Windows.UI.Input.AttachableInputObject
-api-type: winrt class
ms.custom: 19H1
---

<!-- Class syntax.
public class AttachableInputObject : IClosable
-->

# Windows.UI.Input.AttachableInputObject

## -description

Base class for an [InputActivationListener](inputactivationlistener.md) object associated with a window, view, or other visual element.

## -remarks

This class does not have a constructor, or any properties, methods, and events.

This class derives from [Windows.Foundation.IClosable](../windows.foundation/iclosable.md), which has a [Close](../windows.foundation/iclosable_close_811482585.md) method that is invoked internally upon the object's destruction, releasing the object's resources and rendering it invalid.

Do not invoke the [Close](../windows.foundation/iclosable_close_811482585.md) method directly, just destroy the object according to the language being used.

## -see-also

[IClosable](../windows.foundation/iclosable.md)

## -examples
