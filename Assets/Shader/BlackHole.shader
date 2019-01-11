Shader "Custom/BlackHole"
{
	HLSLINCLUDE

#include "Packages/com.unity.postprocessing/PostProcessing/Shaders/StdLib.hlsl"

	TEXTURE2D_SAMPLER2D(_MainTex, sampler_MainTex);
	float _Blend;

	uniform float2 _Position;
	uniform float _Rad;
	uniform float _Ratio;
	uniform float _Distance;

	float4 Frag(VaryingsDefault i) : SV_Target
	{
			//float2 uv = i.texcoord;
			//uv.x += sin(_Time.y + uv.y * 20) * 0.1;// *0.5 + 0.5;
			//float4 color = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, uv/*i.texcoord*/);
			////float luminance = dot(color.rgb, float3(0.2126729, 0.7151522, 0.0721750));
			////color.rgb = lerp(color.rgb, luminance.xxx, _Blend.xxx);
			//return color;


			float2 offset = i.texcoord - _Position; // We shift our pixel to the desired position
			float2 ratio = { _Ratio, 1 }; // determines the aspect ratio
			float rad = length(offset / ratio); // the distance from the conventional "center" of the screen.
			float deformation = 1 / pow(rad*pow(_Distance, 0.5), 2)*_Rad * 2;

			offset = offset * (1 - deformation);

			offset += _Position;

			half4 res = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, offset);
			if (rad * _Distance < _Rad) {
				res = float4(0, 0, 0, 1);
			}
			//if (rad*_Distance<pow(2*_Rad/_Distance,0.5)*_Distance) {res.g+=0.2;} // verification of compliance with the Einstein radius
			//if (rad*_Distance<_Rad){res.r=0;res.g=0;res.b=0;} // check radius BH
			return res;

	}

		ENDHLSL

		SubShader
	{
		Cull Off ZWrite Off ZTest Always

			Pass
		{
			HLSLPROGRAM

				#pragma vertex VertDefault
				#pragma fragment Frag

			ENDHLSL
		}
	}
}