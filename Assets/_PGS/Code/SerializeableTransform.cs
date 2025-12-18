using UnityEngine;

namespace PGS
{
	/// <summary>
	/// Serializes the Position/Rotation/Scale of a given Transform for use in Save/Load systems
	/// </summary>
	[System.Serializable]
	public struct SerializeableTransform
	{
		public Vector3 position;
		public Quaternion rotation;
		public Vector3 scale;

		public SerializeableTransform(Transform transform)
		{
			position = transform.position;
			rotation = transform.rotation;
			scale = transform.localScale;
		}
	}
}

