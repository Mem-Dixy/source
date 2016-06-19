namespace AssemblyCSharp {
	public class Text : UnityEngine.MonoBehaviour {
		private screen view;
		private void Awake () {
			useGUILayout = false;
			view = new screen ();
		}
		private void Update () {
			if (UnityEngine.Input.anyKeyDown) {
				System.UInt64 import = keyboard.type();
				if (import != keyboard.alias.error) {
					view.update(import);
				}
			}
		}
	}
}