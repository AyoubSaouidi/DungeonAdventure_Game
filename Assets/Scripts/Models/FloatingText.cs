using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FloatingText
{
    public string text;
    public int fontSize;
    public FontStyle fontStyle;
    public Color color;
    public Vector2 motion;
	public float duration;

	public FloatingText(string text, int fontSize, FontStyle fontStyle, Color color, Vector2 motion, float duration)
	{
		this.text = text;
		this.fontSize = fontSize;
		this.fontStyle = fontStyle;
		this.color = color;
		this.motion = motion;
		this.duration = duration;
	}
}
