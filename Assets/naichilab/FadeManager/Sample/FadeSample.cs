using UnityEngine;
using System.Collections;

public class FadeSample : MonoBehaviour
{

	public void FadeScene ()
	{
		FadeManager.Instance.LoadScene ("blackoutScene", 2.0f);
	}
}
