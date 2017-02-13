---
-api-id: P:Windows.System.Diagnostics.ProcessMemoryUsageReport.WorkingSetSizeInBytes
-api-type: winrt property
---

<!-- Property syntax
public ulong WorkingSetSizeInBytes { get; }
-->

# Windows.System.Diagnostics.ProcessMemoryUsageReport.WorkingSetSizeInBytes

## -description
Gets the amount of physical memory allocated for the associated process.

## -property-value
The amount of physical memory, in bytes, allocated for the associated process.

## -remarks
The value returned by this property represents the current size of working set memory used by the process. The working set of a process is the set of memory pages currently visible to the process in physical RAM memory. These pages are resident and available for an application to use without triggering a page fault.

The working set includes both shared and private data. The shared data includes the pages that contain all the instructions that the process executes, including instructions in the process modules and the system libraries.

## -examples

## -see-also
[PageFaultCount](processmemoryusagereport_pagefaultcount.md)