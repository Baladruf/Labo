using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using System;

[Serializable]
[PostProcess(typeof(PostProcessBlackHoleRenderer), PostProcessEvent.AfterStack, "Custom/BlackHole")]
public sealed class PostProcessBlackHole : PostProcessEffectSettings
{
	//[Range(0f, 1f), Tooltip("Grayscale effect intensity.")]
	//public FloatParameter blend = new FloatParameter { value = 0.5f };

	//public ParameterOverride<Camera> cam = new ParameterOverride<Camera> { value = new Camera() };
	//public ParameterOverride<Transform> blackhole = new ParameterOverride<Transform> { value = new GameObject().transform };

	public FloatParameter ratio = new FloatParameter { value = 0.5f };
	public FloatParameter radius = new FloatParameter { value = 0.5f };
	public FloatParameter dist = new FloatParameter { value = 0.5f };
	public Vector2Parameter pos = new Vector2Parameter();
	//[SerializeField] float ratio;
	//[SerializeField] float radius;

	//private Camera cam;

	//private Vector3 wtsp;
	//private Vector2 pos;
}

public sealed class PostProcessBlackHoleRenderer : PostProcessEffectRenderer<PostProcessBlackHole>
{
	public override void Render(PostProcessRenderContext context)
	{
		var sheet = context.propertySheets.Get(Shader.Find("Custom/BlackHole"));


		sheet.properties.SetVector("_Position", settings.pos);
		sheet.properties.SetFloat("_Ratio", settings.ratio);
		sheet.properties.SetFloat("_Rad", settings.radius);
		sheet.properties.SetFloat("_Distance", settings.dist);
		// Install all the required parameters for the shader
		//m_shader.SetVector("_Position", pos);
		//m_shader.SetFloat("_Ratio", ratio);
		//m_shader.SetFloat("_Rad", radius);
		//m_shader.SetFloat("_Distance", Vector3.Distance(blackHoles.position, transform.position));
		//// And is applied to the resulting image.
		//Graphics.Blit(source, destination, m_shader);


		context.command.BlitFullscreenTriangle(context.source, context.destination, sheet, 0);
	}
}
