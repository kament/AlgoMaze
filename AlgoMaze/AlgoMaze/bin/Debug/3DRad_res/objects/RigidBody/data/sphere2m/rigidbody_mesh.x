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
240;
0.500000;0.850650;0.162460;,
 -0.000000;0.999999;0.000000;,
 0.309017;0.850650;-0.425325;,
 -0.000000;-0.999999;0.000000;,
 -0.500000;-0.850650;-0.162460;,
 -0.309017;-0.850650;0.425325;,
 0.850650;0.447213;0.276393;,
 0.500000;0.850650;0.162460;,
 0.809017;0.525731;-0.262865;,
 -0.809017;-0.525731;0.262865;,
 -0.500000;-0.850650;-0.162460;,
 -0.850650;-0.447213;-0.276393;,
 0.809017;0.525731;-0.262865;,
 0.309017;0.850650;-0.425325;,
 0.525731;0.447213;-0.723606;,
 -0.309017;-0.850650;0.425325;,
 -0.809017;-0.525731;0.262865;,
 -0.525731;-0.447213;0.723606;,
 0.809017;0.525731;-0.262865;,
 0.500000;0.850650;0.162460;,
 0.309017;0.850650;-0.425325;,
 -0.309017;-0.850650;0.425325;,
 -0.500000;-0.850650;-0.162460;,
 -0.809017;-0.525731;0.262865;,
 0.850650;0.447213;0.276393;,
 0.809017;0.525731;-0.262865;,
 0.999999;-0.000000;0.000000;,
 -0.809017;-0.525731;0.262865;,
 -0.850650;-0.447213;-0.276393;,
 -0.999999;-0.000000;0.000000;,
 0.809017;0.525731;-0.262865;,
 0.525731;0.447213;-0.723606;,
 0.809017;-0.000000;-0.587785;,
 -0.525731;-0.447213;0.723606;,
 -0.809017;-0.525731;0.262865;,
 -0.809017;-0.000000;0.587785;,
 0.999999;-0.000000;0.000000;,
 0.809017;-0.000000;-0.587785;,
 0.850650;-0.447213;-0.276393;,
 -0.809017;-0.000000;0.587785;,
 -0.999999;-0.000000;0.000000;,
 -0.850650;0.447213;0.276393;,
 0.999999;-0.000000;0.000000;,
 0.809017;0.525731;-0.262865;,
 0.809017;-0.000000;-0.587785;,
 -0.809017;-0.000000;0.587785;,
 -0.809017;-0.525731;0.262865;,
 -0.999999;-0.000000;0.000000;,
 -0.809017;-0.000000;-0.587785;,
 -0.500000;-0.525731;-0.688191;,
 -0.309017;-0.000000;-0.951056;,
 0.500000;0.525731;0.688191;,
 0.809017;-0.000000;0.587785;,
 0.309017;-0.000000;0.951056;,
 -0.525731;0.447213;-0.723606;,
 -0.809017;-0.000000;-0.587785;,
 -0.309017;-0.000000;-0.951056;,
 0.809017;-0.000000;0.587785;,
 0.525731;-0.447213;0.723606;,
 0.309017;-0.000000;0.951056;,
 -0.850650;-0.447213;-0.276393;,
 -0.500000;-0.525731;-0.688191;,
 -0.809017;-0.000000;-0.587785;,
 0.500000;0.525731;0.688191;,
 0.850650;0.447213;0.276393;,
 0.809017;-0.000000;0.587785;,
 -0.309017;-0.000000;-0.951056;,
 -0.500000;-0.525731;-0.688191;,
 -0.000000;-0.447213;-0.894427;,
 0.500000;0.525731;0.688191;,
 0.309017;-0.000000;0.951056;,
 -0.000000;0.447213;0.894427;,
 -0.000000;-0.850650;-0.525731;,
 -0.500000;-0.525731;-0.688191;,
 -0.500000;-0.850650;-0.162460;,
 0.500000;0.525731;0.688191;,
 -0.000000;0.850650;0.525731;,
 0.500000;0.850650;0.162460;,
 -0.500000;-0.525731;-0.688191;,
 -0.850650;-0.447213;-0.276393;,
 -0.500000;-0.850650;-0.162460;,
 0.850650;0.447213;0.276393;,
 0.500000;0.525731;0.688191;,
 0.500000;0.850650;0.162460;,
 -0.000000;-0.447213;-0.894427;,
 -0.500000;-0.525731;-0.688191;,
 -0.000000;-0.850650;-0.525731;,
 -0.000000;0.850650;0.525731;,
 0.500000;0.525731;0.688191;,
 -0.000000;0.447213;0.894427;,
 -0.000000;-0.850650;-0.525731;,
 -0.500000;-0.850650;-0.162460;,
 -0.000000;-0.999999;0.000000;,
 0.500000;0.850650;0.162460;,
 -0.000000;0.850650;0.525731;,
 -0.000000;0.999999;0.000000;,
 0.309017;-0.000000;-0.951056;,
 0.500000;-0.525731;-0.688191;,
 0.809017;-0.000000;-0.587785;,
 -0.500000;0.525731;0.688191;,
 -0.309017;-0.000000;0.951056;,
 -0.809017;-0.000000;0.587785;,
 0.525731;0.447213;-0.723606;,
 0.309017;-0.000000;-0.951056;,
 0.809017;-0.000000;-0.587785;,
 -0.309017;-0.000000;0.951056;,
 -0.525731;-0.447213;0.723606;,
 -0.809017;-0.000000;0.587785;,
 0.309017;-0.000000;-0.951056;,
 -0.000000;-0.447213;-0.894427;,
 0.500000;-0.525731;-0.688191;,
 -0.500000;0.525731;0.688191;,
 -0.000000;0.447213;0.894427;,
 -0.309017;-0.000000;0.951056;,
 0.850650;-0.447213;-0.276393;,
 0.809017;-0.000000;-0.587785;,
 0.500000;-0.525731;-0.688191;,
 -0.500000;0.525731;0.688191;,
 -0.809017;-0.000000;0.587785;,
 -0.850650;0.447213;0.276393;,
 0.500000;-0.850650;-0.162460;,
 0.500000;-0.525731;-0.688191;,
 -0.000000;-0.850650;-0.525731;,
 -0.000000;0.850650;0.525731;,
 -0.500000;0.525731;0.688191;,
 -0.500000;0.850650;0.162460;,
 -0.000000;-0.447213;-0.894427;,
 -0.000000;-0.850650;-0.525731;,
 0.500000;-0.525731;-0.688191;,
 -0.000000;0.850650;0.525731;,
 -0.000000;0.447213;0.894427;,
 -0.500000;0.525731;0.688191;,
 0.850650;-0.447213;-0.276393;,
 0.500000;-0.525731;-0.688191;,
 0.500000;-0.850650;-0.162460;,
 -0.500000;0.525731;0.688191;,
 -0.850650;0.447213;0.276393;,
 -0.500000;0.850650;0.162460;,
 0.500000;-0.850650;-0.162460;,
 -0.000000;-0.850650;-0.525731;,
 -0.000000;-0.999999;0.000000;,
 -0.000000;0.850650;0.525731;,
 -0.500000;0.850650;0.162460;,
 -0.000000;0.999999;0.000000;,
 0.809017;-0.000000;0.587785;,
 0.999999;-0.000000;0.000000;,
 0.809017;-0.525731;0.262865;,
 -0.999999;-0.000000;0.000000;,
 -0.809017;-0.000000;-0.587785;,
 -0.809017;0.525731;-0.262865;,
 0.809017;-0.000000;0.587785;,
 0.850650;0.447213;0.276393;,
 0.999999;-0.000000;0.000000;,
 -0.999999;-0.000000;0.000000;,
 -0.850650;-0.447213;-0.276393;,
 -0.809017;-0.000000;-0.587785;,
 0.809017;-0.525731;0.262865;,
 0.999999;-0.000000;0.000000;,
 0.850650;-0.447213;-0.276393;,
 -0.850650;0.447213;0.276393;,
 -0.999999;-0.000000;0.000000;,
 -0.809017;0.525731;-0.262865;,
 0.525731;-0.447213;0.723606;,
 0.809017;-0.000000;0.587785;,
 0.809017;-0.525731;0.262865;,
 -0.809017;0.525731;-0.262865;,
 -0.809017;-0.000000;-0.587785;,
 -0.525731;0.447213;-0.723606;,
 0.809017;-0.525731;0.262865;,
 0.500000;-0.850650;-0.162460;,
 0.309017;-0.850650;0.425325;,
 -0.309017;0.850650;-0.425325;,
 -0.500000;0.850650;0.162460;,
 -0.809017;0.525731;-0.262865;,
 0.809017;-0.525731;0.262865;,
 0.850650;-0.447213;-0.276393;,
 0.500000;-0.850650;-0.162460;,
 -0.850650;0.447213;0.276393;,
 -0.809017;0.525731;-0.262865;,
 -0.500000;0.850650;0.162460;,
 0.809017;-0.525731;0.262865;,
 0.309017;-0.850650;0.425325;,
 0.525731;-0.447213;0.723606;,
 -0.309017;0.850650;-0.425325;,
 -0.809017;0.525731;-0.262865;,
 -0.525731;0.447213;-0.723606;,
 0.500000;-0.850650;-0.162460;,
 -0.000000;-0.999999;0.000000;,
 0.309017;-0.850650;0.425325;,
 -0.000000;0.999999;0.000000;,
 -0.500000;0.850650;0.162460;,
 -0.309017;0.850650;-0.425325;,
 0.309017;-0.000000;0.951056;,
 0.000000;-0.525731;0.850650;,
 -0.309017;-0.000000;0.951056;,
 -0.000000;0.525731;-0.850650;,
 -0.309017;-0.000000;-0.951056;,
 0.309017;-0.000000;-0.951056;,
 -0.000000;0.447213;0.894427;,
 0.309017;-0.000000;0.951056;,
 -0.309017;-0.000000;0.951056;,
 -0.309017;-0.000000;-0.951056;,
 -0.000000;-0.447213;-0.894427;,
 0.309017;-0.000000;-0.951056;,
 0.309017;-0.000000;0.951056;,
 0.525731;-0.447213;0.723606;,
 0.000000;-0.525731;0.850650;,
 -0.000000;0.525731;-0.850650;,
 -0.525731;0.447213;-0.723606;,
 -0.309017;-0.000000;-0.951056;,
 -0.309017;-0.000000;0.951056;,
 0.000000;-0.525731;0.850650;,
 -0.525731;-0.447213;0.723606;,
 -0.000000;0.525731;-0.850650;,
 0.309017;-0.000000;-0.951056;,
 0.525731;0.447213;-0.723606;,
 0.309017;-0.850650;0.425325;,
 -0.309017;-0.850650;0.425325;,
 0.000000;-0.525731;0.850650;,
 0.309017;0.850650;-0.425325;,
 -0.309017;0.850650;-0.425325;,
 -0.000000;0.525731;-0.850650;,
 0.525731;-0.447213;0.723606;,
 0.309017;-0.850650;0.425325;,
 0.000000;-0.525731;0.850650;,
 -0.309017;0.850650;-0.425325;,
 -0.525731;0.447213;-0.723606;,
 -0.000000;0.525731;-0.850650;,
 -0.525731;-0.447213;0.723606;,
 0.000000;-0.525731;0.850650;,
 -0.309017;-0.850650;0.425325;,
 0.309017;0.850650;-0.425325;,
 -0.000000;0.525731;-0.850650;,
 0.525731;0.447213;-0.723606;,
 0.309017;-0.850650;0.425325;,
 -0.000000;-0.999999;0.000000;,
 -0.309017;-0.850650;0.425325;,
 0.309017;0.850650;-0.425325;,
 -0.000000;0.999999;0.000000;,
 -0.309017;0.850650;-0.425325;;
80;
3;2,1,0,
 3;5,4,3,
 3;8,7,6,
 3;11,10,9,
 3;14,13,12,
 3;17,16,15,
 3;20,19,18,
 3;23,22,21,
 3;26,25,24,
 3;29,28,27,
 3;32,31,30,
 3;35,34,33,
 3;38,37,36,
 3;41,40,39,
 3;44,43,42,
 3;47,46,45,
 3;50,49,48,
 3;53,52,51,
 3;56,55,54,
 3;59,58,57,
 3;62,61,60,
 3;65,64,63,
 3;68,67,66,
 3;71,70,69,
 3;74,73,72,
 3;77,76,75,
 3;80,79,78,
 3;83,82,81,
 3;86,85,84,
 3;89,88,87,
 3;92,91,90,
 3;95,94,93,
 3;98,97,96,
 3;101,100,99,
 3;104,103,102,
 3;107,106,105,
 3;110,109,108,
 3;113,112,111,
 3;116,115,114,
 3;119,118,117,
 3;122,121,120,
 3;125,124,123,
 3;128,127,126,
 3;131,130,129,
 3;134,133,132,
 3;137,136,135,
 3;140,139,138,
 3;143,142,141,
 3;146,145,144,
 3;149,148,147,
 3;152,151,150,
 3;155,154,153,
 3;158,157,156,
 3;161,160,159,
 3;164,163,162,
 3;167,166,165,
 3;170,169,168,
 3;173,172,171,
 3;176,175,174,
 3;179,178,177,
 3;182,181,180,
 3;185,184,183,
 3;188,187,186,
 3;191,190,189,
 3;194,193,192,
 3;197,196,195,
 3;200,199,198,
 3;203,202,201,
 3;206,205,204,
 3;209,208,207,
 3;212,211,210,
 3;215,214,213,
 3;218,217,216,
 3;221,220,219,
 3;224,223,222,
 3;227,226,225,
 3;230,229,228,
 3;233,232,231,
 3;236,235,234,
 3;239,238,237;;
MeshNormals {
240;
0.315094;0.943522;-0.102380;
0.315094;0.943522;-0.102380;
0.315094;0.943522;-0.102380;
-0.315094;-0.943522;0.102380;
-0.315094;-0.943522;0.102380;
-0.315094;-0.943522;0.102380;
0.748783;0.661694;0.038534;
0.748783;0.661694;0.038534;
0.748783;0.661694;0.038534;
-0.748783;-0.661694;-0.038534;
-0.748783;-0.661694;-0.038534;
-0.748783;-0.661694;-0.038534;
0.583129;0.661694;-0.471299;
0.583129;0.661694;-0.471299;
0.583129;0.661694;-0.471299;
-0.583129;-0.661694;0.471299;
-0.583129;-0.661694;0.471299;
-0.583129;-0.661694;0.471299;
0.577350;0.794654;-0.187592;
0.577350;0.794654;-0.187592;
0.577350;0.794654;-0.187592;
-0.577350;-0.794654;0.187592;
-0.577350;-0.794654;0.187592;
-0.577350;-0.794654;0.187592;
0.943522;0.330384;-0.024740;
0.943522;0.330384;-0.024740;
0.943522;0.330384;-0.024740;
-0.943522;-0.330384;0.024740;
-0.943522;-0.330384;0.024740;
-0.943522;-0.330384;0.024740;
0.777868;0.330384;-0.534573;
0.777868;0.330384;-0.534573;
0.777868;0.330384;-0.534573;
-0.777868;-0.330384;0.534573;
-0.777868;-0.330384;0.534573;
-0.777868;-0.330384;0.534573;
0.943522;-0.125624;-0.306569;
0.943522;-0.125624;-0.306569;
0.943522;-0.125624;-0.306569;
-0.943522;0.125624;0.306569;
-0.943522;0.125624;0.306569;
-0.943522;0.125624;0.306569;
0.934172;0.187592;-0.303531;
0.934172;0.187592;-0.303531;
0.934172;0.187592;-0.303531;
-0.934172;-0.187592;0.303531;
-0.934172;-0.187592;0.303531;
-0.934172;-0.187592;0.303531;
-0.577350;-0.187592;-0.794654;
-0.577350;-0.187592;-0.794654;
-0.577350;-0.187592;-0.794654;
0.577350;0.187592;0.794654;
0.577350;0.187592;0.794654;
0.577350;0.187592;0.794654;
-0.583129;0.125624;-0.802608;
-0.583129;0.125624;-0.802608;
-0.583129;0.125624;-0.802608;
0.583129;-0.125624;0.802608;
0.583129;-0.125624;0.802608;
0.583129;-0.125624;0.802608;
-0.748783;-0.330384;-0.574604;
-0.748783;-0.330384;-0.574604;
-0.748783;-0.330384;-0.574604;
0.748783;0.330384;0.574604;
0.748783;0.330384;0.574604;
0.748783;0.330384;0.574604;
-0.315094;-0.330384;-0.889698;
-0.315094;-0.330384;-0.889698;
-0.315094;-0.330384;-0.889698;
0.315094;0.330384;0.889698;
0.315094;0.330384;0.889698;
0.315094;0.330384;0.889698;
-0.356822;-0.794654;-0.491123;
-0.356822;-0.794654;-0.491123;
-0.356822;-0.794654;-0.491123;
0.356822;0.794654;0.491123;
0.356822;0.794654;0.491123;
0.356822;0.794654;0.491123;
-0.628428;-0.661694;-0.408949;
-0.628428;-0.661694;-0.408949;
-0.628428;-0.661694;-0.408949;
0.628428;0.661694;0.408949;
0.628428;0.661694;0.408949;
0.628428;0.661694;0.408949;
-0.194739;-0.661694;-0.724043;
-0.194739;-0.661694;-0.724043;
-0.194739;-0.661694;-0.724043;
0.194739;0.661694;0.724043;
0.194739;0.661694;0.724043;
0.194739;0.661694;0.724043;
-0.194739;-0.943522;-0.268035;
-0.194739;-0.943522;-0.268035;
-0.194739;-0.943522;-0.268035;
0.194739;0.943522;0.268035;
0.194739;0.943522;0.268035;
0.194739;0.943522;0.268035;
0.577350;-0.187592;-0.794654;
0.577350;-0.187592;-0.794654;
0.577350;-0.187592;-0.794654;
-0.577350;0.187592;0.794654;
-0.577350;0.187592;0.794654;
-0.577350;0.187592;0.794654;
0.583129;0.125624;-0.802608;
0.583129;0.125624;-0.802608;
0.583129;0.125624;-0.802608;
-0.583129;-0.125624;0.802608;
-0.583129;-0.125624;0.802608;
-0.583129;-0.125624;0.802608;
0.315094;-0.330384;-0.889698;
0.315094;-0.330384;-0.889698;
0.315094;-0.330384;-0.889698;
-0.315094;0.330384;0.889698;
-0.315094;0.330384;0.889698;
-0.315094;0.330384;0.889698;
0.748783;-0.330384;-0.574604;
0.748783;-0.330384;-0.574604;
0.748783;-0.330384;-0.574604;
-0.748783;0.330384;0.574604;
-0.748783;0.330384;0.574604;
-0.748783;0.330384;0.574604;
0.356822;-0.794654;-0.491123;
0.356822;-0.794654;-0.491123;
0.356822;-0.794654;-0.491123;
-0.356822;0.794654;0.491123;
-0.356822;0.794654;0.491123;
-0.356822;0.794654;0.491123;
0.194739;-0.661694;-0.724043;
0.194739;-0.661694;-0.724043;
0.194739;-0.661694;-0.724043;
-0.194739;0.661694;0.724043;
-0.194739;0.661694;0.724043;
-0.194739;0.661694;0.724043;
0.628428;-0.661694;-0.408949;
0.628428;-0.661694;-0.408949;
0.628428;-0.661694;-0.408949;
-0.628428;0.661694;0.408949;
-0.628428;0.661694;0.408949;
-0.628428;0.661694;0.408949;
0.194739;-0.943522;-0.268035;
0.194739;-0.943522;-0.268035;
0.194739;-0.943522;-0.268035;
-0.194739;0.943522;0.268035;
-0.194739;0.943522;0.268035;
-0.194739;0.943522;0.268035;
0.934172;-0.187592;0.303531;
0.934172;-0.187592;0.303531;
0.934172;-0.187592;0.303531;
-0.934172;0.187592;-0.303531;
-0.934172;0.187592;-0.303531;
-0.934172;0.187592;-0.303531;
0.943522;0.125624;0.306569;
0.943522;0.125624;0.306569;
0.943522;0.125624;0.306569;
-0.943522;-0.125624;-0.306569;
-0.943522;-0.125624;-0.306569;
-0.943522;-0.125624;-0.306569;
0.943522;-0.330384;0.024740;
0.943522;-0.330384;0.024740;
0.943522;-0.330384;0.024740;
-0.943522;0.330384;-0.024740;
-0.943522;0.330384;-0.024740;
-0.943522;0.330384;-0.024740;
0.777868;-0.330384;0.534573;
0.777868;-0.330384;0.534573;
0.777868;-0.330384;0.534573;
-0.777868;0.330384;-0.534573;
-0.777868;0.330384;-0.534573;
-0.777868;0.330384;-0.534573;
0.577350;-0.794654;0.187592;
0.577350;-0.794654;0.187592;
0.577350;-0.794654;0.187592;
-0.577350;0.794654;-0.187592;
-0.577350;0.794654;-0.187592;
-0.577350;0.794654;-0.187592;
0.748783;-0.661694;-0.038534;
0.748783;-0.661694;-0.038534;
0.748783;-0.661694;-0.038534;
-0.748783;0.661694;0.038534;
-0.748783;0.661694;0.038534;
-0.748783;0.661694;0.038534;
0.583129;-0.661694;0.471299;
0.583129;-0.661694;0.471299;
0.583129;-0.661694;0.471299;
-0.583129;0.661694;-0.471299;
-0.583129;0.661694;-0.471299;
-0.583129;0.661694;-0.471299;
0.315094;-0.943522;0.102380;
0.315094;-0.943522;0.102380;
0.315094;-0.943522;0.102380;
-0.315094;0.943522;-0.102380;
-0.315094;0.943522;-0.102380;
-0.315094;0.943522;-0.102380;
0.000000;-0.187592;0.982247;
0.000000;-0.187592;0.982247;
0.000000;-0.187592;0.982247;
-0.000000;0.187592;-0.982247;
-0.000000;0.187592;-0.982247;
-0.000000;0.187592;-0.982247;
0.000000;0.125624;0.992078;
0.000000;0.125624;0.992078;
0.000000;0.125624;0.992078;
-0.000000;-0.125624;-0.992078;
-0.000000;-0.125624;-0.992078;
-0.000000;-0.125624;-0.992078;
0.268035;-0.330384;0.904988;
0.268035;-0.330384;0.904988;
0.268035;-0.330384;0.904988;
-0.268035;0.330384;-0.904988;
-0.268035;0.330384;-0.904988;
-0.268035;0.330384;-0.904988;
-0.268035;-0.330384;0.904988;
-0.268035;-0.330384;0.904988;
-0.268035;-0.330384;0.904988;
0.268035;0.330384;-0.904988;
0.268035;0.330384;-0.904988;
0.268035;0.330384;-0.904988;
0.000000;-0.794654;0.607062;
0.000000;-0.794654;0.607062;
0.000000;-0.794654;0.607062;
-0.000000;0.794654;-0.607062;
-0.000000;0.794654;-0.607062;
-0.000000;0.794654;-0.607062;
0.268035;-0.661694;0.700228;
0.268035;-0.661694;0.700228;
0.268035;-0.661694;0.700228;
-0.268035;0.661694;-0.700228;
-0.268035;0.661694;-0.700228;
-0.268035;0.661694;-0.700228;
-0.268035;-0.661694;0.700228;
-0.268035;-0.661694;0.700228;
-0.268035;-0.661694;0.700228;
0.268035;0.661694;-0.700228;
0.268035;0.661694;-0.700228;
0.268035;0.661694;-0.700228;
0.000000;-0.943522;0.331309;
0.000000;-0.943522;0.331309;
0.000000;-0.943522;0.331309;
-0.000000;0.943522;-0.331309;
-0.000000;0.943522;-0.331309;
-0.000000;0.943522;-0.331309;;
80;
3;2,1,0;
  3;5,4,3;
  3;8,7,6;
  3;11,10,9;
  3;14,13,12;
  3;17,16,15;
  3;20,19,18;
  3;23,22,21;
  3;26,25,24;
  3;29,28,27;
  3;32,31,30;
  3;35,34,33;
  3;38,37,36;
  3;41,40,39;
  3;44,43,42;
  3;47,46,45;
  3;50,49,48;
  3;53,52,51;
  3;56,55,54;
  3;59,58,57;
  3;62,61,60;
  3;65,64,63;
  3;68,67,66;
  3;71,70,69;
  3;74,73,72;
  3;77,76,75;
  3;80,79,78;
  3;83,82,81;
  3;86,85,84;
  3;89,88,87;
  3;92,91,90;
  3;95,94,93;
  3;98,97,96;
  3;101,100,99;
  3;104,103,102;
  3;107,106,105;
  3;110,109,108;
  3;113,112,111;
  3;116,115,114;
  3;119,118,117;
  3;122,121,120;
  3;125,124,123;
  3;128,127,126;
  3;131,130,129;
  3;134,133,132;
  3;137,136,135;
  3;140,139,138;
  3;143,142,141;
  3;146,145,144;
  3;149,148,147;
  3;152,151,150;
  3;155,154,153;
  3;158,157,156;
  3;161,160,159;
  3;164,163,162;
  3;167,166,165;
  3;170,169,168;
  3;173,172,171;
  3;176,175,174;
  3;179,178,177;
  3;182,181,180;
  3;185,184,183;
  3;188,187,186;
  3;191,190,189;
  3;194,193,192;
  3;197,196,195;
  3;200,199,198;
  3;203,202,201;
  3;206,205,204;
  3;209,208,207;
  3;212,211,210;
  3;215,214,213;
  3;218,217,216;
  3;221,220,219;
  3;224,223,222;
  3;227,226,225;
  3;230,229,228;
  3;233,232,231;
  3;236,235,234;
  3;239,238,237;;
}
MeshTextureCoords {
240;
13.166023,4.703756;
  1.000000,-13.043675;
  -11.166023,4.703756;
  1.000000,13.043675;
  13.166023,-4.703756;
  -11.166023,-4.703756;
  10.146040,9.299861;
  6.375907,-11.884320;
  -10.972321,5.176966;
  -10.972321,-5.176966;
  6.375907,11.884320;
  10.146040,-9.299861;
  12.972321,5.176966;
  -4.375907,-11.884320;
  -8.146040,9.299861;
  -4.375907,11.884320;
  12.972321,-5.176966;
  -8.146040,-9.299861;
  1.000000,14.048114;
  13.166023,-7.024057;
  -11.166023,-7.024057;
  -11.166023,7.024057;
  13.166023,7.024057;
  1.000000,-14.048114;
  12.755738,-5.651554;
  -8.510592,-8.926706;
  2.031980,13.002787;
  -8.510592,8.926706;
  12.755738,5.651554;
  2.031980,-13.002787;
  10.510592,-8.926706;
  -10.755738,-5.651554;
  -0.031980,13.002787;
  -10.755738,5.651554;
  10.510592,8.926706;
  -0.031980,-13.002787;
  13.166023,-4.703756;
  -11.166023,-4.703756;
  1.000000,13.043675;
  -11.166023,4.703756;
  13.166023,4.703756;
  1.000000,-13.043675;
  13.166023,7.024057;
  1.000000,-14.048114;
  -11.166023,7.024057;
  -11.166023,-7.024057;
  1.000000,14.048114;
  13.166023,-7.024057;
  -11.166023,-7.024057;
  1.000000,14.048114;
  13.166023,-7.024057;
  1.000000,-14.048114;
  -11.166023,7.024057;
  13.166023,7.024057;
  1.000000,-13.043675;
  -11.166023,4.703756;
  13.166023,4.703756;
  -11.166023,-4.703756;
  1.000000,13.043675;
  13.166023,-4.703756;
  -10.755738,5.651554;
  10.510592,8.926706;
  -0.031980,-13.002787;
  10.510592,-8.926706;
  -10.755738,-5.651554;
  -0.031980,13.002787;
  2.031980,-13.002787;
  -8.510592,8.926706;
  12.755738,5.651554;
  -8.510592,-8.926706;
  2.031980,13.002787;
  12.755738,-5.651554;
  13.166023,7.024057;
  1.000000,-14.048114;
  -11.166023,7.024057;
  1.000000,14.048114;
  13.166023,-7.024057;
  -11.166023,-7.024057;
  12.972321,-5.176966;
  -8.146040,-9.299861;
  -4.375907,11.884320;
  -8.146040,9.299861;
  12.972321,5.176966;
  -4.375907,-11.884320;
  10.146040,-9.299861;
  -10.972321,-5.176966;
  6.375907,11.884320;
  6.375907,-11.884320;
  -10.972321,5.176966;
  10.146040,9.299861;
  13.166023,-4.703756;
  -11.166023,-4.703756;
  1.000000,13.043675;
  -11.166023,4.703756;
  13.166023,4.703756;
  1.000000,-13.043675;
  -11.166023,-7.024057;
  1.000000,14.048114;
  13.166023,-7.024057;
  1.000000,-14.048114;
  -11.166023,7.024057;
  13.166023,7.024057;
  1.000000,-13.043675;
  -11.166023,4.703756;
  13.166023,4.703756;
  -11.166023,-4.703756;
  1.000000,13.043675;
  13.166023,-4.703756;
  -0.031980,-13.002787;
  -10.755738,5.651554;
  10.510592,8.926706;
  10.510592,-8.926706;
  -10.755738,-5.651554;
  -0.031980,13.002787;
  12.755738,5.651554;
  2.031980,-13.002787;
  -8.510592,8.926706;
  -8.510592,-8.926706;
  2.031980,13.002787;
  12.755738,-5.651554;
  13.166023,7.024057;
  1.000000,-14.048114;
  -11.166023,7.024057;
  -11.166023,-7.024057;
  1.000000,14.048114;
  13.166023,-7.024057;
  -8.146040,-9.299861;
  -4.375907,11.884320;
  12.972321,-5.176966;
  -4.375907,-11.884320;
  -8.146040,9.299861;
  12.972321,5.176966;
  10.146040,-9.299861;
  -10.972321,-5.176966;
  6.375907,11.884320;
  -10.972321,5.176966;
  10.146040,9.299861;
  6.375907,-11.884320;
  13.166023,-4.703756;
  -11.166023,-4.703756;
  1.000000,13.043675;
  -11.166023,4.703756;
  13.166023,4.703756;
  1.000000,-13.043675;
  13.166023,-7.024057;
  -11.166023,-7.024057;
  1.000000,14.048114;
  -11.166023,7.024057;
  13.166023,7.024057;
  1.000000,-14.048114;
  13.166023,4.703756;
  1.000000,-13.043675;
  -11.166023,4.703756;
  -11.166023,-4.703756;
  1.000000,13.043675;
  13.166023,-4.703756;
  10.510592,8.926706;
  -0.031980,-13.002787;
  -10.755738,5.651554;
  -10.755738,-5.651554;
  -0.031980,13.002787;
  10.510592,-8.926706;
  12.755738,5.651554;
  2.031980,-13.002787;
  -8.510592,8.926706;
  -8.510592,-8.926706;
  2.031980,13.002787;
  12.755738,-5.651554;
  1.000000,-14.048114;
  -11.166023,7.024057;
  13.166023,7.024057;
  13.166023,-7.024057;
  -11.166023,-7.024057;
  1.000000,14.048114;
  12.972321,-5.176966;
  -8.146040,-9.299861;
  -4.375907,11.884320;
  -8.146040,9.299861;
  12.972321,5.176966;
  -4.375907,-11.884320;
  -10.972321,-5.176966;
  6.375907,11.884320;
  10.146040,-9.299861;
  6.375907,-11.884320;
  -10.972321,5.176966;
  10.146040,9.299861;
  -11.166023,-4.703756;
  1.000000,13.043675;
  13.166023,-4.703756;
  1.000000,-13.043675;
  -11.166023,4.703756;
  13.166023,4.703756;
  -11.166023,-7.024057;
  1.000000,14.048114;
  13.166023,-7.024057;
  1.000000,-14.048114;
  -11.166023,7.024057;
  13.166023,7.024057;
  1.000000,-13.043675;
  -11.166023,4.703756;
  13.166023,4.703756;
  -11.166023,-4.703756;
  1.000000,13.043675;
  13.166023,-4.703756;
  -0.031980,-13.002787;
  -10.755738,5.651554;
  10.510592,8.926706;
  10.510592,-8.926706;
  -10.755738,-5.651554;
  -0.031980,13.002787;
  2.031980,-13.002787;
  -8.510592,8.926706;
  12.755738,5.651554;
  -8.510592,-8.926706;
  2.031980,13.002787;
  12.755738,-5.651554;
  -11.166023,7.024057;
  13.166023,7.024057;
  1.000000,-14.048114;
  13.166023,-7.024057;
  -11.166023,-7.024057;
  1.000000,14.048114;
  -8.146040,-9.299861;
  -4.375907,11.884320;
  12.972321,-5.176966;
  -4.375907,-11.884320;
  -8.146040,9.299861;
  12.972321,5.176966;
  10.146040,-9.299861;
  -10.972321,-5.176966;
  6.375907,11.884320;
  6.375907,-11.884320;
  -10.972321,5.176966;
  10.146040,9.299861;
  -11.166023,-4.703756;
  1.000000,13.043675;
  13.166023,-4.703756;
  13.166023,4.703756;
  1.000000,-13.043675;
  -11.166023,4.703756;;
}
MeshMaterialList {
2;
80;
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
  1,
  1,
  1;
Material {
0.784314;0.784314;0.784314;1.000000;;
50.000000;
0.000000;0.000000;0.000000;;
0.000000;0.000000;0.000000;;
}
Material {
0.886274509803922;0.886274509803922;0.886274509803922;1.0;;
50.000000;
0.000000;0.000000;0.000000;;
0.000000;0.000000;0.000000;;
}
}
}
}
}
