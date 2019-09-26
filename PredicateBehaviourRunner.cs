using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using ReachBeyond.VariableObjects;
using ReachBeyond.EventObjects;

namespace ReachBeyond.ScriptSupport {
	public class PredicateBehaviourRunner : MonoBehaviour {

		private enum Mode {
			AllPass, AnyPass, AnyFail, AllFail
		}
		[SerializeField] private Mode checkMode = Mode.AllPass;

		public PredicateBehaviourConstReference[] predicates;
		public EventObjectInvoker onSuccess;
		public EventObjectInvoker onFail;

		public void MakeCheck() {

			bool success = false;
			PredicateBehaviour[] pbArray = ReferenceExtensions.ConstValues(predicates);

			switch(checkMode) {
				case Mode.AllPass:
					success = pbArray.AllPass();
					break;
				case Mode.AnyPass:
					success = pbArray.AnyPass();
					break;
				case Mode.AnyFail:
					success = pbArray.AnyFail();
					break;
				case Mode.AllFail:
					success = pbArray.AllFail();
					break;
			}

			if(success) {
				onSuccess.Invoke();
			}
			else {
				onFail.Invoke();
			}
		}

	}
}
