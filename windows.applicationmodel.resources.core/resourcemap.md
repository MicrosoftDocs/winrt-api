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

### Collection member lists

For JavaScript, ResourceMap supports using an index to access items.

## -examples
This example is based on scenario 13 of the [Application resources and localization sample](https://go.microsoft.com/fwlink/p/?linkid=227301). See the sample for the more complete solution.

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
[Application resources and localization sample](https://go.microsoft.com/fwlink/p/?linkid=227301)
