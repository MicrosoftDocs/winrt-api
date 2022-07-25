---
-api-id: T:Windows.UI.Xaml.Media.Matrix
-api-type: winrt struct
---

<!-- Structure syntax.
public struct Matrix 
-->

# Matrix

## -description
Represents a 3 × 3 affine transformation matrix used for transformations in two-dimensional space.


## -xaml-syntax
```xaml
<Matrix .../>
- or -
<object property="m11,m12,m21,m22,offsetX,offsetY"/>
- or -
<object property="m11 m12 m21 m22 offsetX offsetY"/>
-or-
<object property="Identity"/>
```


## -xaml-values
<dl><dt>m11</dt><dd>m11The numeric value in the first row and first column of this Matrix.</dd>
<dt>m12</dt><dd>m12The numeric value in the first row and second column.</dd>
<dt>m21</dt><dd>m21The numeric value in the second row and first column.</dd>
<dt>m22</dt><dd>m22The numeric value in the second row and second column.</dd>
<dt>offsetX</dt><dd>offsetXThe numeric value in the third row and first column.</dd>
<dt>offsetY</dt><dd>offsetYThe numeric value in the third row and second column.</dd>
<dt>Identity</dt><dd>IdentityThe literal Identity value.</dd>
</dl>

## -struct-fields

### -field M11
The value of the first row and first column of this Matrix structure.
    

### -field M12
The value of the first row and second column of this Matrix structure.
    

### -field M21
The value of the second row and first column of this Matrix structure.
    

### -field M22
The value of the second row and second column of this Matrix structure.
    

### -field OffsetX
Gets or sets the value of the third row and first column of this Matrix structure.
    

### -field OffsetY
Gets or sets the value of the third row and second column of this Matrix structure.
    

## -remarks
A 3×3 matrix is used for transformations in a two-dimensional x-y plane. Affine transformation matrices can be multiplied to form any number of linear transformations, such as rotation and skew (shear), followed by translation. An affine transformation matrix has its final column equal to (0, 0, 1), so only the members in the first two columns need to be specified. Note that vectors are expressed as row-vectors, not column vectors.

A Matrix is stored using row-major order and has the following structure:

<table>
   <tr><td>M11</td><td>M12</td><td>0</td></tr>
   <tr><td>M21</td><td>M22</td><td>0</td></tr>
   <tr><td>OffsetX</td><td>OffsetY</td><td>1</td></tr>
</table>

The members in the last row, **OffsetX** and **OffsetY**, represent translation values.

In methods and properties, the transformation matrix is usually specified as a vector with only six members, as follows: (**M11**, **M12**, **M21**, **M22**, **OffsetX**, **OffsetY**)

Although you can use a Matrix structure directly to translate individual points, or with a [MatrixTransform](matrixtransform.md) to transform objects, the Windows Runtime also provides a set of classes that can transform objects without working directly with matrices:
+ [RotateTransform](rotatetransform.md)
+ [ScaleTransform](scaletransform.md)
+ [SkewTransform](skewtransform.md)
+ [TranslateTransform](translatetransform.md)


Properties of a Matrix can be animated (as one or more [DoubleAnimation](../windows.ui.xaml.media.animation/doubleanimation.md) animations or [DoubleAnimationUsingKeyFrames](../windows.ui.xaml.media.animation/doubleanimationusingkeyframes.md)).

Matrix is the property value for the [MatrixTransform.Matrix](matrixtransform_matrix.md) property. Related types can be used for transformation matrices in three-dimensional space and then used for a projection. See [Matrix3D](../windows.ui.xaml.media.media3d/matrix3d.md) and [Matrix3DProjection](matrix3dprojection.md).

### Language projections and members of Matrix

If you are using a Microsoft .NET language (C# or Microsoft Visual Basic), or in Visual C++ component extensions (C++/CX) then Matrix has non-data members available, and its data members are exposed as read-write properties, not fields.

If you are programming with C++ using the Windows Runtime Template Library (WRL), then only the data member fields exist as members of Matrix, and you cannot use the utility methods or properties listed in the members table. WRL code can access similar utility methods that exist on the [MatrixHelper](matrixhelper.md) class.

## -examples
This example XAML defines a Matrix that provides data for a [MatrixTransform](matrixtransform.md) applied to a rectangular shape. In this case, the matrix combines an offset ([OffsetX](/uwp/api/windows.ui.xaml.media.matrix.offsetx) and [OffsetY](/uwp/api/windows.ui.xaml.media.matrix.offsety)) and a skew ([M12](/uwp/api/windows.ui.xaml.media.matrix.m12)). Note that this same effect could have been produced by combining a [TranslateTransform](translatetransform.md) and a [SkewTransform](skewtransform.md). Whether to use a single Matrix or combinations of discrete transforms is a matter of coding style; the results are identical.

[!code-xaml[matrixtransform](../windows.ui.xaml/code/transforms/csharp/Matrix_Transform.xaml#Snippetmatrixtransform)]

## -see-also
