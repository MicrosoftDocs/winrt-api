---
-api-id: T:Windows.ApplicationModel.Resources.Core.ResourceMap
-api-type: winrt class
---

<!-- Class syntax.
public class ResourceMap : Windows.ApplicationModel.Resources.Core.IResourceMap, Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, Windows.ApplicationModel.Resources.Core.NamedResource>>, Windows.Foundation.Collections.IMapView<System.String, Windows.ApplicationModel.Resources.Core.NamedResource>
-->

# Windows.ApplicationModel.Resources.Core.ResourceMap

## -description

A collection of related resources, typically either for a particular app package, or a resource file for a particular package.

## -remarks

### Resource identifier syntax

Many methods of this class use resource identifiers as parameters. The resource identifier is treated as a Uniform Resource Identifier (URI) fragment, subject to Uniform Resource Identifier (URI) semantics. For example, GetValue("Caption%20") is treated as GetValue("Caption ").

Do not use "?" or "#" in resource identifiers, because they terminate the resource path evaluation. For example, "MyResource?3" is treated as "MyResource".

## -examples

This example is based on scenario 8 of the [Application resources and localization sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ApplicationResources). See the sample for the complete solution.

```csharp
private void ShowText()
{
    ResourceContext defaultContextForCurrentView = ResourceContext.GetForCurrentView();
    ResourceMap stringResourcesResourceMap = ResourceManager.Current.MainResourceMap.GetSubtree("Resources");
    Scenario8MessageTextBlock.Text = stringResourcesResourceMap.GetValue("string1", defaultContextForCurrentView).ValueAsString;
}
```

```cpp
void Scenario8::ShowText()
{
    ResourceContext^ defaultContextForCurrentView = ResourceContext::GetForCurrentView();
    auto resourceStringMap = ResourceManager::Current->MainResourceMap->GetSubtree("Resources");
    Scenario8MessageTextBlock->Text = resourceStringMap->GetValue("string1", defaultContextForCurrentView)->ValueAsString;
}
```

## -see-also

[Application resources and localization sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ApplicationResources)
