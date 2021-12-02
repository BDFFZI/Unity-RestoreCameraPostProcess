Shader "Unlit/MakeMask"
{

	//遮罩物体
	SubShader
	{
		Tags
		{
			"RenderType"="Mask"
		}
		UsePass "Unlit/MakeMaskPass/Mask"
	}

	//不透明的非遮罩物体
	SubShader
	{
		Tags
		{
			"RenderType"="Opaque"
		}
		UsePass "Unlit/MakeMaskPass/NoMask"
	}

	//透明的非遮罩物体
	SubShader
	{
		Tags
		{
			"RenderType"="Transparent"
		}
		UsePass "Unlit/MakeMaskPass/NoMask"
	}
}