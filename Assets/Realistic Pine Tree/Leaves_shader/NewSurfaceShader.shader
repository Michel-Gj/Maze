﻿Shader "Custom/Transparent/BackFaceON" {
Properties {
_Color ("Main Color", Color) = (1,1,1,1)
_SpecColor ("Specular Color", Color) = (0.5, 0.5, 0.5, 0)
_Shininess ("Shininess", Range (0.01, 1)) = 0.078125
_MainTex ("Base (RGB) TransGloss (A)", 2D) = "white" {}
_BumpMap ("Normalmap", 2D) = "bump" {}
_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
}

SubShader {
Tags {"Queue"="AlphaTest" "IgnoreProjector"="True" "RenderType"="TransparentCutout"}
LOD 200
Cull Front

CGPROGRAM
#pragma surface surf BlinnPhong alphatest:_Cutoff
#pragma vertex vert
#pragma target 2.0

sampler2D _MainTex;
sampler2D _BumpMap;
half4 _Color;
half _Shininess;

struct Input {
float2 uv_MainTex;
float2 uv_BumpMap;
};

void vert(inout appdata_full v) {
v.normal *= -1;
}

void surf (Input IN, inout SurfaceOutput o) {
fixed4 tex = tex2D(_MainTex, IN.uv_MainTex);
o.Albedo = tex.rgb * _Color.rgb;
o.Gloss = tex.a;
o.Alpha = tex.a * _Color.a;
o.Specular = _Shininess;
o.Normal = UnpackNormal(tex2D(_BumpMap, IN.uv_BumpMap));

}
ENDCG

Cull Back

CGPROGRAM
#pragma surface surf BlinnPhong alphatest:_Cutoff
#pragma target 2.0

sampler2D _MainTex;
sampler2D _BumpMap;
half4 _Color;
half _Shininess;

struct Input {
float2 uv_MainTex;
float2 uv_BumpMap;
};

void surf(Input IN, inout SurfaceOutput o) {
fixed4 tex = tex2D(_MainTex, IN.uv_MainTex);
o.Albedo = tex.rgb * _Color.rgb;
o.Gloss = tex.a;
o.Alpha = tex.a * _Color.a;
o.Specular = _Shininess;
o.Normal = UnpackNormal(tex2D(_BumpMap, IN.uv_BumpMap));

}
ENDCG

}

FallBack "Legacy Shaders/Transparent/Cutout/VertexLit"
}