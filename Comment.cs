using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReachBeyond.ScriptSupport {
	public class Comment : MonoBehaviour {
		[TextArea(minLines: 1, maxLines: 30)]
		[Tooltip("This is a private field meant for humans' eyes only.")]
		[SerializeField] private string comments;
	}
}
