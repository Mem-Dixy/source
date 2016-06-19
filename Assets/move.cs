public class move : UnityEngine.MonoBehaviour {
	public System.Single range;
	public UnityEngine.Vector3 here;
	private void Update () {
		here=-transform.position;
		range = UnityEngine.Mathf.Abs(here.x)+UnityEngine.Mathf.Abs(here.y)+UnityEngine.Mathf.Abs(here.z);
		if (range>10) {
			range = UnityEngine.Mathf.Abs(range-1);
			here/=range;
			here*=UnityEngine.Time.deltaTime;
			transform.Translate(here);
		}
	}
}
