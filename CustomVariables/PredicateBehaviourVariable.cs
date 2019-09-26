//
//  PredicateBehaviourVariable.cs
//
//  Author:
//       Autofire <http://www.reach-beyond.pro/>
//
//  Copyright (c) 2018 ReachBeyond
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.


using UnityEngine;

namespace ReachBeyond.VariableObjects {

	[CreateAssetMenu(menuName="ReachBeyond/Variable/PredicateBehaviour", order = 450000)]
	public class PredicateBehaviourVariable : Base.ClassVariable<ReachBeyond.ScriptSupport.PredicateBehaviour> {}

	[System.Serializable]
	public class PredicateBehaviourReference : Base.Reference<ReachBeyond.ScriptSupport.PredicateBehaviour, PredicateBehaviourVariable> {}

	[System.Serializable]
	public class PredicateBehaviourConstReference : Base.ConstReference<ReachBeyond.ScriptSupport.PredicateBehaviour, PredicateBehaviourVariable> {}

}


/* DO NOT REMOVE -- START VARIABLE OBJECT INFO -- DO NOT REMOVE **
{
    "name": "PredicateBehaviour",
    "type": "ReachBeyond.ScriptSupport.PredicateBehaviour",
    "referability": "Class",
    "menuOrder": 450000,
    "builtin": false
}
** DO NOT REMOVE --  END VARIABLE OBJECT INFO  -- DO NOT REMOVE */
