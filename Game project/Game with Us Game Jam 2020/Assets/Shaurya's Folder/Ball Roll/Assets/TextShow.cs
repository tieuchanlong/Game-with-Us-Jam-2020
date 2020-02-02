
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]
public class TextShow : MonoBehaviour
{

	[Space(10)]
	[Header("Toggle for the gui on off")]
	public bool GuiOn = false;


	[Space(10)]
	[Header("The text to Display on Trigger")]
	public string Text = "Turn Back";

	[Tooltip("This is the window Box's size. It will be mid screen. Add or reduce the X and Y to move the box in Pixels. ")]
	public Rect BoxSize = new Rect(0, 0, 200, 100);


	[Space(10)]
	public GUISkin customSkin;

	void OnTriggerEnter()
	{
		GuiOn = true;
	}


	void OnTriggerExit()
	{
		GuiOn = false;
	}

	void OnGUI()
	{

		if (customSkin != null)
		{
			GUI.skin = customSkin;
		}

		if (GuiOn == true)
		{

			GUI.BeginGroup(new Rect((Screen.width - BoxSize.width) / 2, (Screen.height - BoxSize.height) / 2, BoxSize.width, BoxSize.height));
			GUI.Label(BoxSize, Text);
			GUI.EndGroup();

		}


	}

}