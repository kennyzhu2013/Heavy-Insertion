using UnityEngine;
		
		//get wider as upwardsBias goes up - counterintuitive, but right in this case?
			(velocity.x / Mathf.Log(_sparksEmitter.upwardsBias)),
			(velocity.y * Mathf.Log(_sparksEmitter.upwardsBias)),
			(velocity.z / Mathf.Log(_sparksEmitter.upwardsBias)));
		
		_sparksEmitter.startRadius = 0f;