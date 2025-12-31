using System;
using System.Collections.Generic;
using UnityEngine;

namespace PGS
{
	public static class GameManager
	{
		private static Dictionary<Type, SystemService> ServiceRegistry;

		[RuntimeInitializeOnLoadMethod]
		public static void InitRegistry()
		{
			ServiceRegistry = new Dictionary<Type, SystemService>();
			Debug.Log($"{nameof(GameManager)} Registry Initialized @ {DateTime.Now.ToShortTimeString()}");
		}

		public static void RegisterSystemService(SystemService service)
		{
			Debug.Log(service.GetType());
		}
	}
}