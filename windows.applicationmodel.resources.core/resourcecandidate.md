---
-api-id: T:Windows.ApplicationModel.Resources.Core.ResourceCandidate
-api-type: winrt class
ms.custom: 19H1
---

<!-- Class syntax.
public class ResourceCandidate : Windows.ApplicationModel.Resources.Core.IResourceCandidate, Windows.ApplicationModel.Resources.Core.IResourceCandidate2
-->

# Windows.ApplicationModel.Resources.Core.ResourceCandidate

## -description
 Represents a single possible value for a given [NamedResource](namedresource.md), the qualifiers associated with that resource, and how well those qualifiers match the context against which it was resolved. 

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | Kind |

## -examples
This example is based on scenario 13 of the [Application resources and localization sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ApplicationResources). See the sample for the more complete solution.

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
