---
-api-id: M:Windows.Networking.HostName.Compare(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public int Compare(System.String value1, System.String value2)
-->

# Windows.Networking.HostName.Compare

## -description
Compares two strings to determine if they represent the same hostname.

## -parameters
### -param value1
A hostname or IP address.

### -param value2
A hostname or IP address.

## -returns
The return value indicates the lexicographic relation of *value1* to *value2*. If the two parameters represent the same canonical hostname, then zero is returned. If *value1* is less than *value2*, the return value is less than zero. If *value1* is greater than *value2*, the return vale is greater than zero.

## -remarks
The Compare method is used to compare two strings to determine if the strings represent the same hostname. This method compares canonical names created from the *value1* and *value2* parameters to determine the value to return.

## -examples

## -see-also
[Windows.Networking](windows_networking.md)
