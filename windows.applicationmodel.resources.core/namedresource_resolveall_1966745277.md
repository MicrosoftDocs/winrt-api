---
-api-id: M:Windows.ApplicationModel.Resources.Core.NamedResource.ResolveAll
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Resources.Core.ResourceCandidate> ResolveAll()
-->

# Windows.ApplicationModel.Resources.Core.NamedResource.ResolveAll

## -description

Resolves this [NamedResource](namedresource.md) object against the default context and returns a list of all possible candidates in preference order.

> [!NOTE]
> ResolveAll may be altered or unavailable for releases after Windows 8.1. Instead, use [ResolveAll(ResourceContext)](namedresource_resolveall_1183893306.md).

## -returns
A list of [ResourceCandidate](resourcecandidate.md) objects, in order of preference. The object in first position in the list is the most appropriate candidate for the corresponding context, and the object in last position is the least appropriate.

## -remarks

## -examples

## -see-also
[ResolveAll(ResourceContext)](namedresource_resolveall_1183893306.md)