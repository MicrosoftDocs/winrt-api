---
-api-id: M:Windows.ApplicationModel.Core.IFrameworkView.Load(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void Load(System.String entryPoint)
-->

# Windows.ApplicationModel.Core.IFrameworkView.Load

## -description
Loads or activates any external resources used by the app view before [Run](coreapplication_run_1480028297.md) is called.

## -parameters
### -param entryPoint
The name of the entry point method for the activated type.

## -remarks
If you are implementing a DirectX view provider, in this method you create DirectX-specific resources for your view, like the render target surface and the attached swap chain. If you are activating an out-of-process Windows Runtime type, the app object supplies the name of the entry point method for that type.

## -examples

## -see-also
