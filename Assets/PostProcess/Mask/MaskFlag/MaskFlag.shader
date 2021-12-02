Shader "Unlit/MaskFlag"
{
	SubShader
	{
		Tags
		{
			"RenderType"="Mask"
		}
		Pass
		{
			AlphaTest Never 0
		}
	}
}