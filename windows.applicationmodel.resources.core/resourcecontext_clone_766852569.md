---
-api-id: M:Windows.ApplicationModel.Resources.Core.ResourceContext.Clone
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Resources.Core.ResourceContext Clone()
-->

# Windows.ApplicationModel.Resources.Core.ResourceContext.Clone

## -description
Creates a clone of this [ResourceContext](resourcecontext.md), with identical qualifiers.

## -returns
A new, cloned [ResourceContext](resourcecontext.md).

## -remarks
By default, a cloned context has the same qualifier values as the default context from which it was derived. If a qualifier value in the default context changes, the changes are reflected in the cloned context as well. However, if a qualifier value is programmatically overridden on the cloned context, the linkage to the default context for that qualifier is removed— changes to that qualifier value in the cloned context do not affect the default context, and vice versa. This linkage can be restored using the [Reset](/uwp/api/windows.applicationmodel.resources.core.resourcecontext.reset) method.

## -examples

```csharp
// Use a cloned context so that qualifier values set
// in this scenario don't impact behavior in other scenarios that
// use a default context for the view (crossover effects between
// the scenarios will not be expected).
var context = ResourceContext.GetForCurrentView().Clone();
```

## -see-also
