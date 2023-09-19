﻿using System;
using System.Runtime.InteropServices;

// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming

namespace Prism.MojoShader;

/* Shader Parse Interface */

internal enum MOJOSHADER_symbolClass {
    MOJOSHADER_SYMCLASS_SCALAR = 0,
    MOJOSHADER_SYMCLASS_VECTOR,
    MOJOSHADER_SYMCLASS_MATRIX_ROWS,
    MOJOSHADER_SYMCLASS_MATRIX_COLUMNS,
    MOJOSHADER_SYMCLASS_OBJECT,
    MOJOSHADER_SYMCLASS_STRUCT,
    MOJOSHADER_SYMCLASS_TOTAL,
}

internal enum MOJOSHADER_symbolType {
    MOJOSHADER_SYMTYPE_VOID = 0,
    MOJOSHADER_SYMTYPE_BOOL,
    MOJOSHADER_SYMTYPE_INT,
    MOJOSHADER_SYMTYPE_FLOAT,
    MOJOSHADER_SYMTYPE_STRING,
    MOJOSHADER_SYMTYPE_TEXTURE,
    MOJOSHADER_SYMTYPE_TEXTURE1D,
    MOJOSHADER_SYMTYPE_TEXTURE2D,
    MOJOSHADER_SYMTYPE_TEXTURE3D,
    MOJOSHADER_SYMTYPE_TEXTURECUBE,
    MOJOSHADER_SYMTYPE_SAMPLER,
    MOJOSHADER_SYMTYPE_SAMPLER1D,
    MOJOSHADER_SYMTYPE_SAMPLER2D,
    MOJOSHADER_SYMTYPE_SAMPLER3D,
    MOJOSHADER_SYMTYPE_SAMPLERCUBE,
    MOJOSHADER_SYMTYPE_PIXELSHADER,
    MOJOSHADER_SYMTYPE_VERTEXSHADER,
    MOJOSHADER_SYMTYPE_PIXELFRAGMENT,
    MOJOSHADER_SYMTYPE_VERTEXFRAGMENT,
    MOJOSHADER_SYMTYPE_UNSUPPORTED,
    MOJOSHADER_SYMTYPE_TOTAL,
}

[StructLayout(LayoutKind.Sequential)]
internal struct MOJOSHADER_symbolTypeInfo {
    public MOJOSHADER_symbolClass parameter_class;
    public MOJOSHADER_symbolType parameter_type;
    public uint rows;
    public uint columns;
    public uint elements;
    public uint member_count;
    public IntPtr members; // MOJOSHADER_symbolStructMember*
}

[StructLayout(LayoutKind.Sequential)]
internal struct MOJOSHADER_symbolStructMember {
    public IntPtr name; //const char*
    public MOJOSHADER_symbolTypeInfo info;
}

/* MOJOSHADER_effectState types... */

internal enum MOJOSHADER_renderStateType {
    MOJOSHADER_RS_ZENABLE,
    MOJOSHADER_RS_FILLMODE,
    MOJOSHADER_RS_SHADEMODE,
    MOJOSHADER_RS_ZWRITEENABLE,
    MOJOSHADER_RS_ALPHATESTENABLE,
    MOJOSHADER_RS_LASTPIXEL,
    MOJOSHADER_RS_SRCBLEND,
    MOJOSHADER_RS_DESTBLEND,
    MOJOSHADER_RS_CULLMODE,
    MOJOSHADER_RS_ZFUNC,
    MOJOSHADER_RS_ALPHAREF,
    MOJOSHADER_RS_ALPHAFUNC,
    MOJOSHADER_RS_DITHERENABLE,
    MOJOSHADER_RS_ALPHABLENDENABLE,
    MOJOSHADER_RS_FOGENABLE,
    MOJOSHADER_RS_SPECULARENABLE,
    MOJOSHADER_RS_FOGCOLOR,
    MOJOSHADER_RS_FOGTABLEMODE,
    MOJOSHADER_RS_FOGSTART,
    MOJOSHADER_RS_FOGEND,
    MOJOSHADER_RS_FOGDENSITY,
    MOJOSHADER_RS_RANGEFOGENABLE,
    MOJOSHADER_RS_STENCILENABLE,
    MOJOSHADER_RS_STENCILFAIL,
    MOJOSHADER_RS_STENCILZFAIL,
    MOJOSHADER_RS_STENCILPASS,
    MOJOSHADER_RS_STENCILFUNC,
    MOJOSHADER_RS_STENCILREF,
    MOJOSHADER_RS_STENCILMASK,
    MOJOSHADER_RS_STENCILWRITEMASK,
    MOJOSHADER_RS_TEXTUREFACTOR,
    MOJOSHADER_RS_WRAP0,
    MOJOSHADER_RS_WRAP1,
    MOJOSHADER_RS_WRAP2,
    MOJOSHADER_RS_WRAP3,
    MOJOSHADER_RS_WRAP4,
    MOJOSHADER_RS_WRAP5,
    MOJOSHADER_RS_WRAP6,
    MOJOSHADER_RS_WRAP7,
    MOJOSHADER_RS_WRAP8,
    MOJOSHADER_RS_WRAP9,
    MOJOSHADER_RS_WRAP10,
    MOJOSHADER_RS_WRAP11,
    MOJOSHADER_RS_WRAP12,
    MOJOSHADER_RS_WRAP13,
    MOJOSHADER_RS_WRAP14,
    MOJOSHADER_RS_WRAP15,
    MOJOSHADER_RS_CLIPPING,
    MOJOSHADER_RS_LIGHTING,
    MOJOSHADER_RS_AMBIENT,
    MOJOSHADER_RS_FOGVERTEXMODE,
    MOJOSHADER_RS_COLORVERTEX,
    MOJOSHADER_RS_LOCALVIEWER,
    MOJOSHADER_RS_NORMALIZENORMALS,
    MOJOSHADER_RS_DIFFUSEMATERIALSOURCE,
    MOJOSHADER_RS_SPECULARMATERIALSOURCE,
    MOJOSHADER_RS_AMBIENTMATERIALSOURCE,
    MOJOSHADER_RS_EMISSIVEMATERIALSOURCE,
    MOJOSHADER_RS_VERTEXBLEND,
    MOJOSHADER_RS_CLIPPLANEENABLE,
    MOJOSHADER_RS_POINTSIZE,
    MOJOSHADER_RS_POINTSIZE_MIN,
    MOJOSHADER_RS_POINTSPRITEENABLE,
    MOJOSHADER_RS_POINTSCALEENABLE,
    MOJOSHADER_RS_POINTSCALE_A,
    MOJOSHADER_RS_POINTSCALE_B,
    MOJOSHADER_RS_POINTSCALE_C,
    MOJOSHADER_RS_MULTISAMPLEANTIALIAS,
    MOJOSHADER_RS_MULTISAMPLEMASK,
    MOJOSHADER_RS_PATCHEDGESTYLE,
    MOJOSHADER_RS_DEBUGMONITORTOKEN,
    MOJOSHADER_RS_POINTSIZE_MAX,
    MOJOSHADER_RS_INDEXEDVERTEXBLENDENABLE,
    MOJOSHADER_RS_COLORWRITEENABLE,
    MOJOSHADER_RS_TWEENFACTOR,
    MOJOSHADER_RS_BLENDOP,
    MOJOSHADER_RS_POSITIONDEGREE,
    MOJOSHADER_RS_NORMALDEGREE,
    MOJOSHADER_RS_SCISSORTESTENABLE,
    MOJOSHADER_RS_SLOPESCALEDEPTHBIAS,
    MOJOSHADER_RS_ANTIALIASEDLINEENABLE,
    MOJOSHADER_RS_MINTESSELLATIONLEVEL,
    MOJOSHADER_RS_MAXTESSELLATIONLEVEL,
    MOJOSHADER_RS_ADAPTIVETESS_X,
    MOJOSHADER_RS_ADAPTIVETESS_Y,
    MOJOSHADER_RS_ADAPTIVETESS_Z,
    MOJOSHADER_RS_ADAPTIVETESS_W,
    MOJOSHADER_RS_ENABLEADAPTIVETESSELLATION,
    MOJOSHADER_RS_TWOSIDEDSTENCILMODE,
    MOJOSHADER_RS_CCW_STENCILFAIL,
    MOJOSHADER_RS_CCW_STENCILZFAIL,
    MOJOSHADER_RS_CCW_STENCILPASS,
    MOJOSHADER_RS_CCW_STENCILFUNC,
    MOJOSHADER_RS_COLORWRITEENABLE1,
    MOJOSHADER_RS_COLORWRITEENABLE2,
    MOJOSHADER_RS_COLORWRITEENABLE3,
    MOJOSHADER_RS_BLENDFACTOR,
    MOJOSHADER_RS_SRGBWRITEENABLE,
    MOJOSHADER_RS_DEPTHBIAS,
    MOJOSHADER_RS_SEPARATEALPHABLENDENABLE,
    MOJOSHADER_RS_SRCBLENDALPHA,
    MOJOSHADER_RS_DESTBLENDALPHA,
    MOJOSHADER_RS_BLENDOPALPHA,
    MOJOSHADER_RS_VERTEXSHADER = 146,
    MOJOSHADER_RS_PIXELSHADER = 147,
}

internal enum MOJOSHADER_zBufferType {
    MOJOSHADER_ZB_FALSE,
    MOJOSHADER_ZB_TRUE,
    MOJOSHADER_ZB_USEW,
}

internal enum MOJOSHADER_fillMode {
    MOJOSHADER_FILL_POINT     = 1,
    MOJOSHADER_FILL_WIREFRAME = 2,
    MOJOSHADER_FILL_SOLID     = 3,
}

internal enum MOJOSHADER_blendMode {
    MOJOSHADER_BLEND_ZERO            = 1,
    MOJOSHADER_BLEND_ONE             = 2,
    MOJOSHADER_BLEND_SRCCOLOR        = 3,
    MOJOSHADER_BLEND_INVSRCCOLOR     = 4,
    MOJOSHADER_BLEND_SRCALPHA        = 5,
    MOJOSHADER_BLEND_INVSRCALPHA     = 6,
    MOJOSHADER_BLEND_DESTALPHA       = 7,
    MOJOSHADER_BLEND_INVDESTALPHA    = 8,
    MOJOSHADER_BLEND_DESTCOLOR       = 9,
    MOJOSHADER_BLEND_INVDESTCOLOR    = 10,
    MOJOSHADER_BLEND_SRCALPHASAT     = 11,
    MOJOSHADER_BLEND_BOTHSRCALPHA    = 12,
    MOJOSHADER_BLEND_BOTHINVSRCALPHA = 13,
    MOJOSHADER_BLEND_BLENDFACTOR     = 14,
    MOJOSHADER_BLEND_INVBLENDFACTOR  = 15,
    MOJOSHADER_BLEND_SRCCOLOR2       = 16,
    MOJOSHADER_BLEND_INVSRCCOLOR2    = 17,
}

internal enum MOJOSHADER_cullMode {
    MOJOSHADER_CULL_NONE = 1,
    MOJOSHADER_CULL_CW   = 2,
    MOJOSHADER_CULL_CCW  = 3,
}

internal enum MOJOSHADER_compareFunc {
    MOJOSHADER_CMP_NEVER        = 1,
    MOJOSHADER_CMP_LESS         = 2,
    MOJOSHADER_CMP_EQUAL        = 3,
    MOJOSHADER_CMP_LESSEQUAL    = 4,
    MOJOSHADER_CMP_GREATER      = 5,
    MOJOSHADER_CMP_NOTEQUAL     = 6,
    MOJOSHADER_CMP_GREATEREQUAL = 7,
    MOJOSHADER_CMP_ALWAYS       = 8,
}

internal enum MOJOSHADER_stencilOp {
    MOJOSHADER_STENCILOP_KEEP    = 1,
    MOJOSHADER_STENCILOP_ZERO    = 2,
    MOJOSHADER_STENCILOP_REPLACE = 3,
    MOJOSHADER_STENCILOP_INCRSAT = 4,
    MOJOSHADER_STENCILOP_DECRSAT = 5,
    MOJOSHADER_STENCILOP_INVERT  = 6,
    MOJOSHADER_STENCILOP_INCR    = 7,
    MOJOSHADER_STENCILOP_DECR    = 8,
}

internal enum MOJOSHADER_blendOp {
    MOJOSHADER_BLENDOP_ADD         = 1,
    MOJOSHADER_BLENDOP_SUBTRACT    = 2,
    MOJOSHADER_BLENDOP_REVSUBTRACT = 3,
    MOJOSHADER_BLENDOP_MIN         = 4,
    MOJOSHADER_BLENDOP_MAX         = 5,
}

/* MOJOSHADER_effectSamplerState types... */

internal enum MOJOSHADER_samplerStateType {
    MOJOSHADER_SAMP_UNKNOWN0      = 0,
    MOJOSHADER_SAMP_UNKNOWN1      = 1,
    MOJOSHADER_SAMP_UNKNOWN2      = 2,
    MOJOSHADER_SAMP_UNKNOWN3      = 3,
    MOJOSHADER_SAMP_TEXTURE       = 4,
    MOJOSHADER_SAMP_ADDRESSU      = 5,
    MOJOSHADER_SAMP_ADDRESSV      = 6,
    MOJOSHADER_SAMP_ADDRESSW      = 7,
    MOJOSHADER_SAMP_BORDERCOLOR   = 8,
    MOJOSHADER_SAMP_MAGFILTER     = 9,
    MOJOSHADER_SAMP_MINFILTER     = 10,
    MOJOSHADER_SAMP_MIPFILTER     = 11,
    MOJOSHADER_SAMP_MIPMAPLODBIAS = 12,
    MOJOSHADER_SAMP_MAXMIPLEVEL   = 13,
    MOJOSHADER_SAMP_MAXANISOTROPY = 14,
    MOJOSHADER_SAMP_SRGBTEXTURE   = 15,
    MOJOSHADER_SAMP_ELEMENTINDEX  = 16,
    MOJOSHADER_SAMP_DMAPOFFSET    = 17,
}

internal enum MOJOSHADER_textureAddress {
    MOJOSHADER_TADDRESS_WRAP       = 1,
    MOJOSHADER_TADDRESS_MIRROR     = 2,
    MOJOSHADER_TADDRESS_CLAMP      = 3,
    MOJOSHADER_TADDRESS_BORDER     = 4,
    MOJOSHADER_TADDRESS_MIRRORONCE = 5,
}

internal enum MOJOSHADER_textureFilterType {
    MOJOSHADER_TEXTUREFILTER_NONE,
    MOJOSHADER_TEXTUREFILTER_POINT,
    MOJOSHADER_TEXTUREFILTER_LINEAR,
    MOJOSHADER_TEXTUREFILTER_ANISOTROPIC,
    MOJOSHADER_TEXTUREFILTER_PYRAMIDALQUAD,
    MOJOSHADER_TEXTUREFILTER_GAUSSIANQUAD,
    MOJOSHADER_TEXTUREFILTER_CONVOLUTIONMONO,
}

/* Effect value types... */

[StructLayout(LayoutKind.Sequential)]
internal struct MOJOSHADER_effectValue {
    public IntPtr name; // const char*
    public IntPtr semantic; // const char*
    public MOJOSHADER_symbolTypeInfo type;
    public uint value_count;
    public IntPtr values; // You know what, just look at the C header...
}

[StructLayout(LayoutKind.Sequential)]
internal struct MOJOSHADER_effectState {
    public MOJOSHADER_renderStateType type;
    public MOJOSHADER_effectValue value;
}

[StructLayout(LayoutKind.Sequential)]
internal struct MOJOSHADER_effectSamplerState {
    public MOJOSHADER_samplerStateType type;
    public MOJOSHADER_effectValue value;
}

/* typedef MOJOSHADER_effectValue MOJOSHADER_effectAnnotation; */
[StructLayout(LayoutKind.Sequential)]
internal struct MOJOSHADER_effectAnnotation {
    public IntPtr name; // const char*
    public IntPtr semantic; // const char*
    public MOJOSHADER_symbolTypeInfo type;
    public uint value_count;
    public IntPtr values; // You know what, just look at the C header...
}

/* Effect interface structures... */

[StructLayout(LayoutKind.Sequential)]
internal struct MOJOSHADER_effectParam {
    public MOJOSHADER_effectValue value;
    public uint annotation_count;
    public IntPtr annotations; // MOJOSHADER_effectAnnotations*
}

[StructLayout(LayoutKind.Sequential)]
internal struct MOJOSHADER_effectPass {
    public IntPtr name; // const char*
    public uint state_count;
    public IntPtr states; // MOJOSHADER_effectState*
    public uint annotation_count;
    public IntPtr annotations; // MOJOSHADER_effectAnnotations*
}

[StructLayout(LayoutKind.Sequential)]
internal struct MOJOSHADER_effectTechnique {
    public IntPtr name; // const char*
    public uint pass_count;
    public IntPtr passes; // MOJOSHADER_effectPass*
    public uint annotation_count;
    public IntPtr annotations; // MOJOSHADER_effectAnnotations*
}

/* Effect "objects"... */

[StructLayout(LayoutKind.Sequential)]
internal struct MOJOSHADER_effectShader {
    public MOJOSHADER_symbolType type;
    public uint technique;
    public uint pass;
    public uint is_preshader;
    public uint preshader_param_count;
    public IntPtr preshader_params; // unsigned int*
    public uint param_count;
    public IntPtr parameters; // unsigned int*
    public uint sampler_count;
    public IntPtr samplers; // MOJOSHADER_samplerStateRegister*
    public IntPtr shader; // *shader/*preshader union
}

[StructLayout(LayoutKind.Sequential)]
internal struct MOJOSHADER_effectSamplerMap {
    public MOJOSHADER_symbolType type;
    public IntPtr name; // const char*
}

[StructLayout(LayoutKind.Sequential)]
internal struct MOJOSHADER_effectString {
    public MOJOSHADER_symbolType type;
    public IntPtr stringvalue; // const char*
}

[StructLayout(LayoutKind.Sequential)]
internal struct MOJOSHADER_effectTexture {
    public MOJOSHADER_symbolType type;
}

[StructLayout(LayoutKind.Explicit)]
internal struct MOJOSHADER_effectObject {
    [FieldOffset(0)]
    public MOJOSHADER_symbolType type;

    [FieldOffset(0)]
    public MOJOSHADER_effectShader shader;

    [FieldOffset(0)]
    public MOJOSHADER_effectSamplerMap mapping;

    [FieldOffset(0)]
    public MOJOSHADER_effectString stringvalue;

    [FieldOffset(0)]
    public MOJOSHADER_effectTexture texture;
}

/* Effect state change types... */

[StructLayout(LayoutKind.Sequential)]
internal struct MOJOSHADER_samplerStateRegister {
    public IntPtr sampler_name; // const char*
    public uint sampler_register;
    public uint sampler_state_count;
    public IntPtr sampler_states; // const MOJOSHADER_effectSamplerState*
}

// Needed by VideoPlayer...
[StructLayout(LayoutKind.Sequential)]
internal struct MOJOSHADER_effectStateChanges {
    public uint render_state_change_count;
    public IntPtr render_state_changes; // const MOJOSHADER_effectState*
    public uint sampler_state_change_count;
    public IntPtr sampler_state_changes; // const MOJOSHADER_samplerStateRegister*
    public uint vertex_sampler_state_change_count;
    public IntPtr vertex_sampler_state_changes; // const MOJOSHADER_samplerStateRegister*
}

/* Effect parsing interface... this is a partial struct! */

[StructLayout(LayoutKind.Sequential)]
internal struct MOJOSHADER_effect {
    public int error_count;
    public IntPtr errors; // MOJOSHADER_error*
    public int param_count;
    public IntPtr parameters; // MOJOSHADER_effectParam* params, lolC#
    public int technique_count;
    public IntPtr techniques; // MOJOSHADER_effectTechnique*
    public int object_count;
    public IntPtr objects; // MOJOSHADER_effectObject*
    public IntPtr current_technique; // MOJOSHADER_effectTechnique*
    public int current_pass;
    public int restore_shader_state;
    public IntPtr state_changes; // MOJOSHADER_effectStateChanges*
    public IntPtr current_vert_raw; // MOJOSHADER_effectShader*
    public IntPtr current_pixl_raw; // MOJOSHADER_effectShader*
    public IntPtr current_vert; // void*
    public IntPtr current_pixl; // void*
    public IntPtr prev_vertex_shader; // void*
    public IntPtr prev_pixel_shader; // void*
    public MOJOSHADER_effectShaderContext ctx;
}

[StructLayout(LayoutKind.Sequential)]
internal struct MOJOSHADER_effectShaderContext {
    public IntPtr compileShader; // void*
    public IntPtr shaderAddRef; // void*
    public IntPtr deleteShader; // void*
    public IntPtr getParseData; // void*
    public IntPtr bindShaders; // void*
    public IntPtr getBoundShaders; // void*
    public IntPtr mapUniformBufferMemory; // void*
    public IntPtr unmapUniformBufferMemory; // void*
    public IntPtr getError; // void*
    public IntPtr shaderContext; // void*
    public IntPtr m; // void*
    public IntPtr f; // void*
    public IntPtr malloc_data; // void*
}
