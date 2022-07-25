---
-api-id: T:Windows.UI.Xaml.Media.Media3D.Matrix3D
-api-type: winrt struct
---

<!-- Structure syntax.
public struct Matrix3D 
-->

# Matrix3D

## -description
Represents a 4 × 4 matrix that is used for transformations in a 3-D space. Used as a value for [Matrix3DProjection.ProjectionMatrix](../windows.ui.xaml.media/matrix3dprojection_projectionmatrix.md).


## -xaml-syntax
```xaml
<Matrix3DProjection ProjectionMatrix="m11, m12, m13, m14, 
  m21, m22, m23, m24, m31, m32, m33, m34, offsetX, offsetY, offsetZ, m44" />
- or -
<!--xmlns:m3d="using:Windows.UI.Xaml.Media.Media3D"-->
<m3d:Matrix3D>
m11, m12, m13, m14, m21, m22, m23, m24, m31, m32, m33, m34, offsetX, offsetY, offsetZ, m44
</m3d:Matrix3D>
```



## -struct-fields

### -field M11
The value of the first row and first column of this Matrix3D.
    

### -field M12
The value of the first row and second column of this Matrix3D.
    

### -field M13
The value of the first row and third column of this Matrix3D.
    

### -field M14
The value of the first row and fourth column of this Matrix3D.
    

### -field M21
The value of the second row and first column of this Matrix3D.
    

### -field M22
The value of the second row and second column of this Matrix3D.
    

### -field M23
The value of the second row and third column of this Matrix3D.
    

### -field M24
The value of the second row and fourth column of this Matrix3D.
    

### -field M31
The value of the third row and first column of this Matrix3D.
    

### -field M32
The value of the third row and second column of this Matrix3D.
    

### -field M33
The value of the third row and third column of this Matrix3D.
    

### -field M34
The value of the third row and fourth column of this Matrix3D.
    

### -field OffsetX
The value of the fourth row and first column of this Matrix3D.
    

### -field OffsetY
The value of the fourth row and second column of this Matrix3D.
    

### -field OffsetZ
The value of the fourth row and third column of this Matrix3D.
    

### -field M44
The value of the fourth row and fourth column of this Matrix3D.
    

## -remarks
You can use the [Matrix3DProjection](../windows.ui.xaml.media/matrix3dprojection.md) and Matrix3D types for more complex semi–3-D scenarios than are possible with the [PlaneProjection](../windows.ui.xaml.media/planeprojection.md) type. [Matrix3DProjection](../windows.ui.xaml.media/matrix3dprojection.md) provides a complete 3-D transform matrix to apply to any [UIElement](../windows.ui.xaml/uielement.md) (you use this as a value for the [UIElement.Projection](../windows.ui.xaml/uielement_projection.md) property). The matrix lets you apply arbitrary model transform matrices and perspective matrices to visual elements.

Matrix3D has this row-vector syntax:<table>
   <tr><td>M11</td><td>M12</td><td>M13</td><td>M14</td></tr>
   <tr><td>M21</td><td>M22</td><td>M23</td><td>M24</td></tr>
   <tr><td>M31</td><td>M32</td><td>M33</td><td>M34</td></tr>
   <tr><td>OffsetX</td><td>OffsetY</td><td>OffsetZ</td><td>M44</td></tr>
</table>

Because the fourth column is accessible, Matrix3D can represent both affine and non-affine transforms.

### XAML syntax for **Matrix3D**

Matrix3D values can be declared in XAML, but the syntax is limited, and different than what you might expect based on how other Windows Runtime structures (like [Thickness](../windows.ui.xaml/thickness.md)) support values for XAML UI:+ The most typical usage for Matrix3D-type properties is to rely on the initialization string behavior that's built-in to the Matrix3D type, and set any value that uses a Matrix3D value as an attribute. You specify a string in the "initialization text" format for constructing a Matrix3D value: 16 separate **Double** values each separated by comma or space. You can see this format used in the XAML in "Examples" below.
+ There's only one existing property that uses a Matrix3D value: [Matrix3DProjection.ProjectionMatrix](../windows.ui.xaml.media/matrix3dprojection_projectionmatrix.md). So that's what's shown as the primary XAML syntax here.
+ The secondary XAML syntax shown has an actual Matrix3D object element. But note that it has a XAML namespace prefix. The [Windows.UI.Xaml.Media.Media3D](windows_ui_xaml_media_media3d.md) namespace was not included in the set of code namespaces that the Windows Runtime XAML parser uses for the default XAML namespace. In order to use the Matrix3D as an element in XAML, you have to include an **xmlns** declaration in your XAML that references [Windows.UI.Xaml.Media.Media3D](windows_ui_xaml_media_media3d.md) by a ** using:** statement. Then qualify the Matrix3D with the **xmlns** prefix you mapped for the types in [Windows.UI.Xaml.Media.Media3D](windows_ui_xaml_media_media3d.md).
+ Even once you do this mapping, the Matrix3D object element can't have attribute values for setting the 16 properties, it's not enabled by the XAML parser (other XAML structures have special-case handling for properties-as-attribute syntax; Matrix3D happens to not have this). You still have to use the initialization text that sets the 16 values as consecutive atoms of a string. In this case the string is contained as the "inner text" / content of the Matrix3D object element.
+ As you can see the object element syntax isn't any easier to read or use than the inline attribute syntax for [Matrix3DProjection.ProjectionMatrix](../windows.ui.xaml.media/matrix3dprojection_projectionmatrix.md), so the verbose Matrix3D object element syntax isn't common.


### Projection and members of Matrix3D

If you are using a Microsoft .NET language (C# or Microsoft Visual Basic), or in Visual C++ component extensions (C++/CX), then Matrix3D has non-data members available, and its data members are exposed as read-write properties, not fields.

If you are programming with C++ using the Windows Runtime Template Library (WRL), then only the data member fields exist as members of Matrix3D, and you cannot use the utility methods or properties listed in the members table. WRL code can access similar utility methods that exist on the [Matrix3DHelper](matrix3dhelper.md) class.

You can't set properties of Matrix3D in XAML with individual XAML attributes. You have to initialize a Matrix3D object element using an initialization string that specifies all 16 values, or use attribute syntax for [Matrix3DProjection.ProjectionMatrix](../windows.ui.xaml.media/matrix3dprojection_projectionmatrix.md) that uses this same string format.

## -examples
This example uses a simple Matrix3D matrix to transform the image in the X and Y directions when you click the image.



[!code-xaml[Matrix3DProjectionSimple](../windows.ui.xaml.media/code/Matrix3DProjectionSimple/csharp/MainPage.xaml#SnippetMatrix3DProjectionSimple)]

[!code-csharp[Matrix3DProjectionSimple_code](../windows.ui.xaml.media/code/Matrix3DProjectionSimple/csharp/MainPage.xaml.cs#SnippetMatrix3DProjectionSimple_code)]



[!code-xaml[Matrix3DProjectionXAML](../windows.ui.xaml.media/code/Matrix3DProjectionXAML/csharp/MainPage.xaml#SnippetMatrix3DProjectionXAML)]



[!code-xaml[Matrix3DProjectionSample](../windows.ui.xaml.media/code/Matrix3DProjectionSample/csharp/MainPage.xaml#SnippetMatrix3DProjectionSample)]

[!code-csharp[Matrix3DProjectionSample_code](../windows.ui.xaml.media/code/Matrix3DProjectionSample/csharp/MainPage.xaml.cs#SnippetMatrix3DProjectionSample_code)]

## -see-also
[Matrix3DHelper](matrix3dhelper.md), [Matrix3DProjection](../windows.ui.xaml.media/matrix3dprojection.md), [UIElement.Projection](../windows.ui.xaml/uielement_projection.md), [3-D perspective effects for XAML UI](/windows/uwp/graphics/3-d-perspective-effects)
projection.md), [UIElement.Projection](../windows.ui.xaml/uielement_projection.md), [3-D perspective effects for XAML UI](/windows/uwp/graphics/3-d-perspective-effects)
