---
-api-id: M:Windows.ApplicationModel.Package.StageContentGroupsAsync(Windows.Foundation.Collections.IIterable{System.String},System.Boolean)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<PackageContentGroup>> Package.StageContentGroupsAsync(IIterable<String> names, Boolean moveToHeadOfQueue)
-->

# Windows.ApplicationModel.Package.StageContentGroupsAsync

## -description
Put the packages in the specified content groups into the staging queue; optionally placing the content groups at the head of the queue.

## -params

## -param names
The names of the content groups to stage.

## -param moveToHeadOfQueue
**True** to move the content group to the head of the staging queue; **false** otherwise.

## -returns
A list of [PackageContentGroup](packagecontentgroup.md) objects for each content group specified by the _names_  parameter.

## -remarks

## -see-also

## -examples
