using UnityEngine;
using UnityEngine.Events;

namespace ReachBeyond.ScriptSupport.Triggers {
	public class TriggerOnStart : MonoBehaviour {

		public UnityEvent action = new UnityEvent();

		private void Start() {
			action.Invoke();
		}
	}
}
