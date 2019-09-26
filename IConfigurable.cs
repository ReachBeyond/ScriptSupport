using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO Move this to ReachBeyond.ScriptSupport
namespace ReachBeyond {

	/// <summary>
	/// Implementors can be configured when created. Though not limited to this,
	/// it for Omnipresent, it's meant to be used for automatically generated
	/// lists.
	/// </summary>
	/// <typeparam name="T">Datatype needed when configuring the object.</typeparam>
	public interface IConfigurable<T> {

		/// <summary>
		/// Configure this instance with the given data.
		/// </summary>
		/// <param name="configData"></param>
		void Configure(T configData);
	}

	public interface IConfigurable<T0, T1> {
		void Configure(T0 data1, T1 data2);
	}
}
