using UnityEngine;


public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
	[SerializeField] protected bool doNotDestroy = true;



	protected virtual void Awake()
	{
		CheckDontDestroyOnLoad();
	}

	private void CheckDontDestroyOnLoad()
	{
		if (doNotDestroy)
		{
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
}
