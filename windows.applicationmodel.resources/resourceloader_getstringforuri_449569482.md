---
-api-id: M:Windows.ApplicationModel.Resources.ResourceLoader.GetStringForUri(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public string GetStringForUri(Windows.Foundation.Uri uri)
-->

# Windows.ApplicationModel.Resources.ResourceLoader.GetStringForUri

## -description
Returns the most appropriate string value of a resource, specified by a Uniform Resource Identifier (URI) resource identifier, for the default [ResourceContext](../windows.applicationmodel.resources.core/resourcecontext.md) of the currently running app.

Equivalent WinUI method: [Microsoft.ApplicationModel.Resources.ResourceLoader.GetStringForUri](/windows/winui/api/microsoft.applicationmodel.resources.resourceloader.getstringforuri).

## -parameters
### -param uri
A Uniform Resource Identifier (URI) that represents the resource to be retrieved.

## -returns
The most appropriate string value of the specified resource for the default [ResourceContext](../windows.applicationmodel.resources.core/resourcecontext.md).

## -remarks
Uniform Resource Identifier (URI) objects require a scheme to be identified. In this context, the ms-resource scheme must be specified in the Uniform Resource Identifier (URI) passed to the method.

### Errors

This method fails with an exception if the supplied Uniform Resource Identifier (URI) is for some other protocol, if the requested resource is not found, or if the requested resource is not a string.

## -examples

## -see-also
