using MelonLoader;
using UnityEngine;
using Il2CppInterop;
using Il2CppInterop.Runtime.Injection; 
using System.Collections;


namespace ModSettings
{
	public class ModSettingsMain : MelonMod
	{
		public override void OnInitializeMelon()
		{
			#if DEBUG
						ModSettingsExample.BasicExample.OnLoad();
						ModSettingsExample.OnChangeExample.OnLoad();
						ModSettingsExample.VisibilityExample.OnLoad();
			#endif
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
       


        }

        public override void OnUpdate()
		{

		}

    }
}