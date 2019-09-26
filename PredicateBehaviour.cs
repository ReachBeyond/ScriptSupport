using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace ReachBeyond.ScriptSupport {
	public abstract class PredicateBehaviour : MonoBehaviour {

		/// <summary>
		/// This will attempt whatever the given behaviour's action
		/// is. It will return true if successful. (Or if the condition is
		/// met). This varies between behaviours.
		/// </summary>
		/// <returns></returns>
		public abstract bool TryAction();

	}

	public static class PredicateBehaviourCollectionExtensions {
		public static bool AllPass(this IEnumerable<PredicateBehaviour> source) {
			return source.All(TryAction);
		}

		public static bool AnyPass(this IEnumerable<PredicateBehaviour> source) {
			return source.Any(TryAction);
		}

		public static bool AllFail(this IEnumerable<PredicateBehaviour> source) {
			return !source.AnyPass();
		}

		public static bool AnyFail(this IEnumerable<PredicateBehaviour> source) {
			return !source.AllPass();
		}

		/// <summary>
		/// This is a shortcut method to make it easier to call the Linq
		/// extension methods.
		/// </summary>
		/// <param name="pb">The behaviour to run TryAction on.</param>
		/// <returns>Same as pb's local TryAction method.</returns>
		private static bool TryAction(PredicateBehaviour pb) {
			return pb.TryAction();
		}
	}
}
