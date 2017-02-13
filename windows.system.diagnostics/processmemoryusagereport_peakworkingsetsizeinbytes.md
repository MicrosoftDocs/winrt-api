---
-api-id: P:Windows.System.Diagnostics.ProcessMemoryUsageReport.PeakWorkingSetSizeInBytes
-api-type: winrt property
---

<!-- Property syntax
public ulong PeakWorkingSetSizeInBytes { get; }
-->

# Windows.System.Diagnostics.ProcessMemoryUsageReport.PeakWorkingSetSizeInBytes

## -description
Gets the maximum amount of physical memory used by the associated process.

## -property-value
The maximum amount of physical memory, in bytes, allocated for the associated process since it was started.

## -remarks
The value returned by this property represents the maximum size of working set memory used by the process since it started. The working set of a process is the set of memory pages currently visible to the process in physical RAM memory. These pages are resident and available for an application to use without triggering a page fault.

The working set includes both shared and private data. The shared data includes the pages that contain all the instructions that the process executes, including instructions from the process modules and the system libraries.

## -examples

## -see-also
