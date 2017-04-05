---
-api-id: T:Windows.ApplicationModel.PackageContentGroupState
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum PackageContentGroupState : int {
	Queued = 1
	NotStaged = 0
	Staged = 3
	Staging = 2
}
-->

# Windows.ApplicationModel.PackageContentGroupState

## -description
Describes the staging state of the package content group.

## -enum-fields

## -field Staging:2
The package group is currently being staged.

## -field Staged:3
The package group has been staged.

## -field NotStaged:0
The package group has not been staged and is not in the staging queue.

## -field Queued:1
The package has not been staged but is in the queue of packages to be staged.

## -remarks

## -see-also

## -examples
