---
-api-id: M:Windows.UI.Xaml.Resources.CustomXamlResourceLoader.GetResource(System.String,System.String,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
virtual protected object GetResource(System.String resourceId, System.String objectType, System.String propertyName, System.String propertyType)
-->

# Windows.UI.Xaml.Resources.CustomXamlResourceLoader.GetResource

## -description
When overridden in a derived class, specifies the logic of resource lookup for this [CustomXamlResourceLoader](customxamlresourceloader.md). Given a resource ID and some type information about the expected result, returns the requested resource.



## -parameters
### -param resourceId
The string-form key of the resource to get.

### -param objectType
The expected type of the resource.

### -param propertyName
The name of the property that serves as the key in the custom resource lookup logic.

### -param propertyType
The type of the property that serves as the key, with type represented as a string.

## -returns
The retrieved resource.

## -remarks
This method will be called by the Windows Runtime XAML parser whenever it encounters a [{CustomResource} markup extension](/windows/uwp/xaml-platform/customresource-markup-extension) usage in markup. The *resourceId* comes from the default *key* markup extension argument to [{CustomResource} markup extension](/windows/uwp/xaml-platform/customresource-markup-extension), and the other input parameters come from context, such as which property the usage is applied to.

## -examples

## -see-also
