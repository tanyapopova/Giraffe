Shader "LightDev/Toon/Toon Transparent"
{
  Properties
  {
    [Main(colorSettings, , 3)]
    _ColorShadingGroup("Color And Texture", float) = 1
    [Sub(colorSettings)]
    _Color ("Color", Color) = (1,1,1,1)
    [Sub(colorSettings)]
    _ShadowColor ("Shadow Color", Color) = (0,0,0,1)
    [Sub(colorSettings)]
    _MainTex ("Main Texture", 2D) = "white" {}

    [Main(shadingSettings, , 3)]
    _ShadingSettingsGroup("Shading Settings", float) = 1
    [Sub(shadingSettings)]
    _SelfShadingSize ("Self Shading Size", Range(0,1)) = 0.175
    [Sub(shadingSettings)]
    _ShadowEdgeSize ("Shadow Edge Size", Range(0,1)) = 0.334

    [Main(rim)]
    _RimEnabled ("Rim", float) = 0
    [Sub(rim)]
    _RimColor("Rim Color", Color) = (1, 1, 1, 1)
    [Sub(rim)]
    _RimSize("Rim Size", Range(0, 1)) = 0.5
    [Sub(rim)]
    _RimEdgeSmoothness("Rim Edge Smoothness", Range(0, 1)) = 0

    [Main(specular)]
    _SpecularEnabled ("Specular", float) = 0
    [Sub(specular)]
    _SpecularColor("Specular Color", Color) = (1, 1, 1, 1)
    [Sub(specular)]
    _SpecularSize("Specular Size", Range(0, 1)) = 0.5
    [Sub(specular)]
    _SpecularEdgeSmoothness("Rim Edge Smoothness", Range(0, 1)) = 0

    [Main(transparentGradient)]
    _TransparentGradientEnabled ("World Space Transparent Gradient", float) = 0
    [Sub(transparentGradient)]
    _TransparentGradientTop("Top point", float) = 10
    [Sub(transparentGradient)]
    _TransparentGradientBottom("Bottom point", float) = 0

    [Main(localTransparentGradient)]
    _LocalTransparentGradientEnabled ("Local Space Transparent Gradient", float) = 0
    [Sub(localTransparentGradient)]
    _LocalTransparentGradientTop("Top point", float) = 10
    [Sub(localTransparentGradient)]
    _LocalTransparentGradientBottom("Bottom point", float) = 0
  }

  SubShader
  {
    Tags {"Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent"}
    Blend SrcAlpha OneMinusSrcAlpha

    CGPROGRAM

    #include "ToonLightDevLightning.cginc"
    #pragma surface surf LightDevCustom keepalpha vertex:vert
    #pragma target 3.0

    #pragma shader_feature_local _SPECULARENABLED_ON
    #pragma shader_feature_local _TRANSPARENTGRADIENTENABLED_ON
    #pragma shader_feature_local _LOCALTRANSPARENTGRADIENTENABLED_ON
    #pragma shader_feature_local _RIMENABLED_ON

    ENDCG
  }

  Fallback "Diffuse"
  CustomEditor "JTRP.ShaderDrawer.LWGUI"
}
