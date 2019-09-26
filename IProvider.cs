using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReachBeyond {
	public interface IProvider<T> {

		T Provide();

	}
}
