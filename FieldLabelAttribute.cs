using UnityEngine;

[System.AttributeUsage(System.AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
public class FieldLabelAttribute : PropertyAttribute
{
    public readonly string text;

    public FieldLabelAttribute(string text)
    {
        this.text = text;
    }
}
