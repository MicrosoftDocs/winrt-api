---
-api-id: T:Windows.UI.Composition.Compositor
-api-type: winrt class
---

<!-- Class syntax.
public class Compositor : Windows.Foundation.IClosable, Windows.UI.Composition.ICompositor, Windows.UI.Composition.ICompositor2, Windows.UI.Composition.ICompositor3, Windows.UI.Composition.ICompositor4
-->

# Windows.UI.Composition.Compositor

## -description

Manages the session between an application and the system compositor process.

The Compositor class creates an instance of the Compositor for the application that can be used as a factory for a variety of types in the Windows.UI.Composition namespace spanning the visual layer, effects system and animation system. The Compositor class also manages the lifetime of objects created from the factory.

## -remarks

The Compositor implicitly synchronizes changes made to associated visuals to ensure they get applied in a transactional manner.

See the [Composition UI Overview](http://go.microsoft.com/fwlink/p/?LinkID=699334) and [Composition Visual Tree Overview](http://go.microsoft.com/fwlink/p/?LinkID=699335) for more information.

New instances of Compositor must be created on a thread that has a CoreDispatcher.

## -examples

## -see-also

[Composition UI Overview](http://go.microsoft.com/fwlink/p/?LinkID=699334), [Composition Visual Tree Overview](http://go.microsoft.com/fwlink/p/?LinkID=699335), [IClosable](../windows.foundation/iclosable.md), [Composition visual without framework sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620483), [Version adaptive code sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/VersionAdaptiveCode)