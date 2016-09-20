using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
	public bool CustomLogEnabled = true;
	string someString = "";

	// Use this for initialization
	void Start () {
		someString = gameObject.name;
	}
	
	// Update is called once per frame
	void Update () {
		DefaultLog();
		CustomLog();
	}

	void DefaultLog() {
		Profiler.BeginSample("DefaultLog");
		Debug.LogFormat("My name: {0}", someString);
		Profiler.EndSample();
	}

	void CustomLog() {
		Profiler.BeginSample("CustomLog");
		CustomFormatLog("My name: {0}", someString);
		Profiler.EndSample();
	}

	void CustomFormatLog<T>(string msg, T arg) {
		if( CustomLogEnabled ) {
			Debug.LogFormat(msg, arg);
		}
	}
}
