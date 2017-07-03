---
-api-id: P:Windows.System.AppMemoryReport.ExpectedTotalCommitLimit
-api-type: winrt property
---

<!-- Property syntax.
public ulong ExpectedTotalCommitLimit { get; }
-->

# Windows.System.AppMemoryReport.ExpectedTotalCommitLimit

## -description
Gets the expected commit limit for the current app.

## -property-value
The expected commit limit in bytes.

## -remarks
When an app launches on Xbox, it is initially given a small commit limit (the sum of the app’s available usage of private plus shared commit memory) which may grow as the system frees memory. This property returns the expected upper limit.

When an app launches on a non-Xbox system, the commit limit the app gets at launch remains the same and this property will return the same value as [Windows.System.AppMemoryReport.TotalCommitLimit](appmemoryreport_totalcommitlimit.md).

## -see-also


## -examples
