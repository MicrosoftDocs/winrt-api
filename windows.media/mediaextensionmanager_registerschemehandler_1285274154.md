---
-api-id: M:Windows.Media.MediaExtensionManager.RegisterSchemeHandler(System.String,System.String,Windows.Foundation.Collections.IPropertySet)
-api-type: winrt method
---

<!-- Method syntax
public void RegisterSchemeHandler(System.String activatableClassId, System.String scheme, Windows.Foundation.Collections.IPropertySet configuration)
-->

# Windows.Media.MediaExtensionManager.RegisterSchemeHandler

## -description
Registers a scheme handler for the specified URL scheme with an optional configuration parameter.

## -parameters
### -param activatableClassId
The class identifier of the activatable runtime class of the scheme handler. The runtime class must implement the [IMediaExtension](imediaextension.md) interface.

### -param scheme
The URL scheme that will be recognized to invoke the scheme handler. For example, "myscheme://".

### -param configuration
An optional parameter that contains configuration properties for the scheme handler.

## -remarks

## -examples

## -see-also
[RegisterSchemeHandler(String, String)](mediaextensionmanager_registerschemehandler_1279508154.md)