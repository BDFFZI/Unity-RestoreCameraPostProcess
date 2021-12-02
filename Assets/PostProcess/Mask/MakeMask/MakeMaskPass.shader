Shader "Unlit/MakeMaskPass"
{
	SubShader
	{
		//遮罩标记为红色
		Pass
		{
			Name "Mask"
			Color(1, 0, 0, 1)
		}

		//非遮罩为绿色
		Pass
		{
			Name "NoMask"
			Color(0, 1, 0, 1)
		}
	}
}