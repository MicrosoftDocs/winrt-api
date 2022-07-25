---
-api-id: P:Windows.UI.Xaml.Controls.WrapGrid.Orientation
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.Orientation Orientation { get;  set; }
-->

# Windows.UI.Xaml.Controls.WrapGrid.Orientation

## -description
Gets or sets the direction in which child elements are arranged.



## -xaml-syntax
```xaml
WrapGrid Orientation="orientationMemberName" />
```


## -property-value
A value of the enumeration. The default is **Vertical**.

## -remarks
The Orientation property specifies whether the grid adds its items in rows or columns before wrapping.

When the value is **Vertical**, the grid adds items in columns from top to bottom, then wraps from left to right, like this:<table>
   <tr><td>Item 1</td><td>Item 4</td><td>Item 7</td></tr>
   <tr><td>Item 2</td><td>Item 5</td><td>Item 8</td></tr>
   <tr><td>Item 3</td><td>Item 6</td><td>Item 9</td></tr>
</table>

When the value is **Horizontal**, the grid adds items in rows from left to right, then wraps from top to bottom, like this:<table>
   <tr><td>Item 1</td><td>Item 2</td><td>Item 3</td></tr>
   <tr><td>Item 4</td><td>Item 5</td><td>Item 6</td></tr>
   <tr><td>Item 7</td><td>Item 8</td><td>Item 9</td></tr>
</table>

## -examples

## -see-also
