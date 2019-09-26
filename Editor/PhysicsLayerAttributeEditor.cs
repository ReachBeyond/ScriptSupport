// Comes from MoruganKodi: http://answers.unity.com/answers/1371058/view.html

using UnityEditor;
using UnityEngine;

namespace ReachBeyond.ScriptSupport {

	[CustomPropertyDrawer(typeof(PhysicsLayerAttribute))]
	class LayerAttributeEditor : PropertyDrawer {

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
			// One line of  oxygen free code.
			property.intValue = EditorGUI.LayerField(position, label, property.intValue);
		}
	}
}