xof 0303txt 0032

// Generated by 3D Rad Exporter plugin for Google SketchUp - http://www.3drad.com

template Header {
<3D82AB43-62DA-11cf-AB39-0020AF71E433>
WORD major;
WORD minor;
DWORD flags;
}
template Vector {
<3D82AB5E-62DA-11cf-AB39-0020AF71E433>
FLOAT x;
FLOAT y;
FLOAT z;
}
template Coords2d {
<F6F23F44-7686-11cf-8F52-0040333594A3>
FLOAT u;
FLOAT v;
}
template Matrix4x4 {
<F6F23F45-7686-11cf-8F52-0040333594A3>
array FLOAT matrix[16];
}
template ColorRGBA {
<35FF44E0-6C7C-11cf-8F52-0040333594A3>
FLOAT red;
FLOAT green;
FLOAT blue;
FLOAT alpha;
}
template ColorRGB {
<D3E16E81-7835-11cf-8F52-0040333594A3>
FLOAT red;
FLOAT green;
FLOAT blue;
}
template IndexedColor {
<1630B820-7842-11cf-8F52-0040333594A3>
DWORD index;
ColorRGBA indexColor;
}
template Boolean {
<4885AE61-78E8-11cf-8F52-0040333594A3>
WORD truefalse;
}
template Boolean2d {
<4885AE63-78E8-11cf-8F52-0040333594A3>
Boolean u;
Boolean v;
}
template MaterialWrap {
<4885AE60-78E8-11cf-8F52-0040333594A3>
Boolean u;
Boolean v;
}
template TextureFilename {
<A42790E1-7810-11cf-8F52-0040333594A3>
STRING filename;
}
template Material {
<3D82AB4D-62DA-11cf-AB39-0020AF71E433>
ColorRGBA faceColor;
FLOAT power;
ColorRGB specularColor;
ColorRGB emissiveColor;
[...]
}
template MeshFace {
<3D82AB5F-62DA-11cf-AB39-0020AF71E433>
DWORD nFaceVertexIndices;
array DWORD faceVertexIndices[nFaceVertexIndices];
}
template MeshFaceWraps {
<4885AE62-78E8-11cf-8F52-0040333594A3>
DWORD nFaceWrapValues;
Boolean2d faceWrapValues;
}
template MeshTextureCoords {
<F6F23F40-7686-11cf-8F52-0040333594A3>
DWORD nTextureCoords;
array Coords2d textureCoords[nTextureCoords];
}
template MeshMaterialList {
<F6F23F42-7686-11cf-8F52-0040333594A3>
DWORD nMaterials;
DWORD nFaceIndexes;
array DWORD faceIndexes[nFaceIndexes];
[Material]
}
template MeshNormals {
<F6F23F43-7686-11cf-8F52-0040333594A3>
DWORD nNormals;
array Vector normals[nNormals];
DWORD nFaceNormals;
array MeshFace faceNormals[nFaceNormals];
}
template MeshVertexColors {
<1630B821-7842-11cf-8F52-0040333594A3>
DWORD nVertexColors;
array IndexedColor vertexColors[nVertexColors];
}
template Mesh {
<3D82AB44-62DA-11cf-AB39-0020AF71E433>
DWORD nVertices;
array Vector vertices[nVertices];
DWORD nFaces;
array MeshFace faces[nFaces];
[...]
}
template FrameTransformMatrix {
<F6F23F41-7686-11cf-8F52-0040333594A3>
Matrix4x4 frameMatrix;
}
template Frame {
<3D82AB46-62DA-11cf-AB39-0020AF71E433>
[...]
}
template XSkinMeshHeader {
<3cf169ce-ff7c-44ab-93c0-f78f62d172e2>
WORD nMaxSkinWeightsPerVertex;
WORD nMaxSkinWeightsPerFace;
WORD nBones;
}
template VertexDuplicationIndices {
<b8d65549-d7c9-4995-89cf-53a9a8b031e3>
DWORD nIndices;
DWORD nOriginalVertices;
array DWORD indices[nIndices];
}
template SkinWeights {
<6f0d123b-bad2-4167-a0d0-80224f25fabb>
STRING transformNodeName;
DWORD nWeights;
array DWORD vertexIndices[nWeights];
array FLOAT weights[nWeights];
Matrix4x4 matrixOffset;
}
Frame RAD_SCENE_ROOT {
FrameTransformMatrix {
1.000000,0.000000,0.000000,0.000000,0.000000,1.000000,0.000000,0.000000,0.000000,0.000000,1.000000,0.000000,0.000000,0.000000,0.000000,1.000000;;
}
Frame RAD_FRAME {
FrameTransformMatrix {
1.000000,0.000000,0.000000,0.000000,0.000000,1.000000,0.000000,0.000000,0.000000,0.000000,1.000000,0.000000,0.000000,0.000000,0.000000,1.000000;;
}
Mesh RAD_MESH {
24;
11.469994;0.000000;1.119999;,
0.000000;0.000000;0.000000;,
0.000000;0.000000;1.119999;,
11.469994;0.000000;0.000000;,
11.469994;7.999996;0.000000;,
0.000000;7.999996;1.119999;,
0.000000;7.999996;0.000000;,
11.469994;7.999996;1.119999;,
0.000000;7.999996;1.119999;,
0.000000;0.000000;0.000000;,
0.000000;7.999996;0.000000;,
0.000000;0.000000;1.119999;,
0.000000;7.999996;1.119999;,
11.469994;0.000000;1.119999;,
0.000000;0.000000;1.119999;,
11.469994;7.999996;1.119999;,
11.469994;0.000000;1.119999;,
11.469994;7.999996;0.000000;,
11.469994;0.000000;0.000000;,
11.469994;7.999996;1.119999;,
11.469994;7.999996;0.000000;,
0.000000;0.000000;0.000000;,
11.469994;0.000000;0.000000;,
0.000000;7.999996;0.000000;;
12;
3;2,1,0,
3;3,0,1,
3;6,5,4,
3;7,4,5,
3;10,9,8,
3;11,8,9,
3;14,13,12,
3;15,12,13,
3;18,17,16,
3;19,16,17,
3;22,21,20,
3;23,20,21;;
MeshNormals {
24;
0.000000;-1.000000;0.000000;
0.000000;-1.000000;0.000000;
0.000000;-1.000000;0.000000;
0.000000;-1.000000;0.000000;
0.000000;1.000000;0.000000;
0.000000;1.000000;0.000000;
0.000000;1.000000;0.000000;
0.000000;1.000000;0.000000;
-1.000000;0.000000;0.000000;
-1.000000;0.000000;0.000000;
-1.000000;0.000000;0.000000;
-1.000000;0.000000;0.000000;
-0.000000;0.000000;1.000000;
-0.000000;0.000000;1.000000;
-0.000000;0.000000;1.000000;
-0.000000;0.000000;1.000000;
1.000000;0.000000;0.000000;
1.000000;0.000000;0.000000;
1.000000;0.000000;0.000000;
1.000000;0.000000;0.000000;
-0.000000;-0.000000;-1.000000;
-0.000000;-0.000000;-1.000000;
-0.000000;-0.000000;-1.000000;
-0.000000;-0.000000;-1.000000;;
12;
3;2,1,0;
3;3,0,1;
3;6,5,4;
3;7,4,5;
3;10,9,8;
3;11,8,9;
3;14,13,12;
3;15,12,13;
3;18,17,16;
3;19,16,17;
3;22,21,20;
3;23,20,21;;
}
MeshTextureCoords {
24;
-450.574803,-44.094488;
1.000000,-0.000000;
1.000000,-44.094488;
-450.574803,-0.000000;
452.574803,-0.000000;
1.000000,-44.094488;
1.000000,-0.000000;
452.574803,-44.094488;
-43.094488,-314.960630;
1.000000,-0.000000;
1.000000,-314.960630;
-43.094488,-0.000000;
1.000000,-314.960630;
-450.574803,-0.000000;
1.000000,-0.000000;
-450.574803,-314.960630;
45.094488,-0.000000;
1.000000,-314.960630;
1.000000,-0.000000;
45.094488,-314.960630;
452.574803,-314.960630;
1.000000,-0.000000;
452.574803,-0.000000;
1.000000,-314.960630;;
}
MeshMaterialList {
2;
12;
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1;
Material {
1.000000;1.000000;1.000000;1.000000;;
50.000000;
0.000000;0.000000;0.000000;;
0.000000;0.000000;0.000000;;
}
Material {
0.000000;0.000000;0.800000;1.000000;;
50.000000;
0.000000;0.000000;0.000000;;
0.000000;0.000000;0.000000;;
}
}
}
}
}
