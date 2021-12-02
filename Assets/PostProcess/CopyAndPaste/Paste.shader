Shader "Hidden/Paste"
{
	Properties
	{
		_MainTex ("MainTex", 2D) = "white" {}
		_Mask ("Mask", 2D) = "white" {}
		_Clipboard ("Clipboard", 2D) = "white" {}
	}
	SubShader
	{
		Cull Off ZWrite Off ZTest Always

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			v2f vert(appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;
				return o;
			}

			sampler2D _MainTex;
			sampler2D _Mask;
			sampler2D _Clipboard;

			fixed4 frag(v2f i) : SV_Target
			{
				if (tex2D(_Mask, i.uv).r > 0)
					return tex2D(_Clipboard, i.uv);
				else
					return tex2D(_MainTex, i.uv);
			}
			ENDCG
		}
	}
}