---
-api-id: T:Windows.ApplicationModel.Resources.Core.ResourceQualifierVectorView
-api-type: winrt class
---

<!-- Class syntax.
public class ResourceQualifierVectorView : Windows.Foundation.Collections.IIterable<Windows.ApplicationModel.Resources.Core.ResourceQualifier>, Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Resources.Core.ResourceQualifier>
-->

# Windows.ApplicationModel.Resources.Core.ResourceQualifierVectorView

## -description
An unchangeable view into a vector of [ResourceQualifier](resourcequalifier.md) objects.

## -remarks
### Collection member lists

For JavaScript, [ResourceQualifierVectorView](resourcequalifiervectorview.md) has the members shown in the member lists. In addition, [ResourceQualifierVectorView](resourcequalifiervectorview.md) supports a **length** property, members of **Array.prototype**, and using an index to access items.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A [ResourceQualifierVectorView](resourcequalifiervectorview.md) is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<ResourceQualifier>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](XREF:TODO:M:System.Collections.Generic.IEnumerable`1.GetEnumerator), cast to [IEnumerable&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.IEnumerable`1) with a [ResourceQualifier](resourcequalifier.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples
This example is based on scenario 13 of the [Application resources and localization sample](http://go.microsoft.com/fwlink/p/?linkid=227301). See the sample for the more complete solution.

```javascript
// Create a ResourceContext.
var resourceContext = new Windows.ApplicationModel.Resources.Core.ResourceContext();

// Set the specific context for lookup of resources.
var qualifierValues = resourceContext.qualifierValues;
qualifierValues["language"] = "en-US";
qualifierValues["contrast"] = "standard";
qualifierValues["scale"] = "140";
qualifierValues["homeregion"] = "021"; // Northern America

// Resources actually reside within Scenario13 Resource Map.
var resourceIds = [
    '/Scenario13/languageOnly',
    '/Scenario13/scaleOnly',
    '/Scenario13/contrastOnly',
    '/Scenario13/homeregionOnly',
    '/Scenario13/multiDimensional',
];

var output = { str: "" };
resourceIds.forEach(function (resourceId) {
    renderNamedResource(resourceId, resourceContext, output);
});

function renderNamedResource(resourceId, resourceContext, output) {
    output.str += "Resource ID " + resourceId + ":\n";
    // Lookup the resource in the mainResourceMap (the one for this package).
    var namedResource = Windows.ApplicationModel.Resources.Core.ResourceManager.current.mainResourceMap.lookup(resourceId);

    // Return a ResourceCandidateVectorView of all possible resources candidates
    // resolved against the context in order of appropriateness.
    var resourceCandidates = namedResource.resolveAll(resourceContext);

    resourceCandidates.forEach(function (candidate, index) {
        renderCandidate(candidate, index, output);
    });
    output.str += "\n";
}

function renderCandidate(candidate, index, output) {
    // Get all the various qualifiers for the candidate (such as language, scale, contrast).
    candidate.qualifiers.forEach(function (qualifier) {
        output.str += "qualifierName: " + qualifier.qualifierName + "\n";
        output.str += "qualifierValue: " + qualifier.qualifierValue + "\n";
        output.str += "isDefault: ";
        output.str += (qualifier.isDefault) ? "true\n" : "false\n";
        output.str += "isMatch: ";
        output.str += (qualifier.isMatch) ? "true\n" : "false\n";
        output.str += "score: " + qualifier.score + "\n";
        output.str += "\n";
    });
}
```



## -see-also
[Application resources and localization sample](http://go.microsoft.com/fwlink/p/?linkid=227301)