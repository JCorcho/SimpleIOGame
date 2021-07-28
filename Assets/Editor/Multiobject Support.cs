using System.Collections;
using UnityEditor;

[CustomEditor(typeof(ServerLoad))]
[CanEditMultipleObjects]
public class MultiobjectSupport : Editor {

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
    }
}
