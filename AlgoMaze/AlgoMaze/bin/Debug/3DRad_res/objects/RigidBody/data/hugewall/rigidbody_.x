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
36;
6.339997;0.000000;1.169999;,
0.000000;0.000000;0.000000;,
0.000000;0.000000;1.169999;,
27.919985;0.000000;0.000000;,
10.629994;0.000000;1.169999;,
27.919985;0.000000;1.169999;,
10.629994;0.000000;1.179999;,
6.339997;0.000000;1.169999;,
6.339997;0.000000;1.179999;,
10.629994;0.000000;1.169999;,
8.846751;6.059997;0.000000;,
0.000000;6.059997;1.169999;,
0.000000;6.059997;0.000000;,
27.919985;6.059997;1.169999;,
9.156751;6.059997;0.000000;,
27.919985;6.059997;0.000000;,
0.000000;6.059997;1.169999;,
0.000000;0.000000;0.000000;,
0.000000;6.059997;0.000000;,
0.000000;0.000000;1.169999;,
0.000000;6.059997;1.169999;,
6.339997;0.000000;1.169999;,
0.000000;0.000000;1.169999;,
10.629994;0.000000;1.169999;,
27.919985;0.000000;1.169999;,
27.919985;6.059997;1.169999;,
27.919985;6.059997;0.000000;,
9.156751;6.059997;0.000000;,
27.919985;0.000000;0.000000;,
0.000000;6.059997;0.000000;,
0.000000;0.000000;0.000000;,
8.846751;6.059997;0.000000;,
27.919985;0.000000;1.169999;,
27.919985;6.059997;0.000000;,
27.919985;0.000000;0.000000;,
27.919985;6.059997;1.169999;;
22;
3;2,1,0,
3;3,0,1,
3;4,0,3,
3;5,4,3,
3;8,7,6,
3;9,6,7,
3;12,11,10,
3;13,10,11,
3;14,10,13,
3;15,14,13,
3;18,17,16,
3;19,16,17,
3;22,21,20,
3;23,20,21,
3;24,20,23,
3;25,20,24,
3;28,27,26,
3;30,29,28,
3;27,28,29,
3;31,27,29,
3;34,33,32,
3;35,32,33;;
MeshNormals {
36;
0.000000;-1.000000;0.000000;
0.000000;-1.000000;0.000000;
0.000000;-1.000000;0.000000;
0.000000;-1.000000;0.000000;
0.000000;-1.000000;0.000000;
0.000000;-1.000000;0.000000;
0.000000;-1.000000;0.000000;
0.000000;-1.000000;0.000000;
0.000000;-1.000000;0.000000;
0.000000;-1.000000;0.000000;
0.000000;1.000000;0.000000;
0.000000;1.000000;0.000000;
0.000000;1.000000;0.000000;
0.000000;1.000000;0.000000;
0.000000;1.000000;0.000000;
0.000000;1.000000;0.000000;
-1.000000;0.000000;0.000000;
-1.000000;0.000000;0.000000;
-1.000000;0.000000;0.000000;
-1.000000;0.000000;0.000000;
-0.000000;-0.000000;1.000000;
-0.000000;-0.000000;1.000000;
-0.000000;-0.000000;1.000000;
-0.000000;-0.000000;1.000000;
-0.000000;-0.000000;1.000000;
-0.000000;-0.000000;1.000000;
0.000000;0.000000;-1.000000;
0.000000;0.000000;-1.000000;
0.000000;0.000000;-1.000000;
0.000000;0.000000;-1.000000;
0.000000;0.000000;-1.000000;
0.000000;0.000000;-1.000000;
1.000000;0.000000;0.000000;
1.000000;0.000000;0.000000;
1.000000;0.000000;0.000000;
1.000000;0.000000;0.000000;;
22;
3;2,1,0;
3;3,0,1;
3;4,0,3;
3;5,4,3;
3;8,7,6;
3;9,6,7;
3;12,11,10;
3;13,10,11;
3;14,10,13;
3;15,14,13;
3;18,17,16;
3;19,16,17;
3;22,21,20;
3;23,20,21;
3;24,20,23;
3;25,20,24;
3;28,27,26;
3;30,29,28;
3;27,28,29;
3;31,27,29;
3;34,33,32;
3;35,32,33;;
}
MeshTextureCoords {
36;
-248.606299,-46.062992;
1.000000,-0.000000;
1.000000,-46.062992;
-1098.212598,-0.000000;
-417.503937,-46.062992;
-1098.212598,-46.062992;
-417.503937,-46.456693;
-248.606299,-46.062992;
-248.606299,-46.456693;
-417.503937,-46.062992;
349.297472,-0.000000;
1.000000,-46.062992;
1.000000,-0.000000;
1100.212598,-46.062992;
361.502196,-0.000000;
1100.212598,-0.000000;
-45.062992,-238.582677;
1.000000,-0.000000;
1.000000,-238.582677;
-45.062992,-0.000000;
1.000000,-238.582677;
-248.606299,-0.000000;
1.000000,-0.000000;
-417.503937,-0.000000;
-1098.212598,-0.000000;
-1098.212598,-238.582677;
1100.212598,-238.582677;
361.502196,-238.582677;
1100.212598,-0.000000;
1.000000,-238.582677;
1.000000,-0.000000;
349.297472,-238.582677;
47.062992,0.000000;
1.000000,-238.582677;
1.000000,0.000000;
47.062992,-238.582677;;
}
MeshMaterialList {
5;
22;
0,
0,
0,
0,
0,
0,
1,
1,
1,
1,
2,
2,
3,
3,
3,
3,
3,
3,
3,
3,
4,
4;
Material {
1.000000;1.000000;1.000000;1.000000;;
50.000000;
0.000000;0.000000;0.000000;;
0.000000;0.000000;0.000000;;
}
Material {
1.000000;0.847059;0.396078;1.000000;;
50.000000;
0.000000;0.000000;0.000000;;
0.000000;0.000000;0.000000;;
}
Material {
0.556863;0.556863;0.556863;1.000000;;
50.000000;
0.000000;0.000000;0.000000;;
0.000000;0.000000;0.000000;;
}
Material {
0.478431;0.800000;0.156863;1.000000;;
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
