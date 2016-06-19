public class dimond : UnityEngine.MonoBehaviour {
	public UnityEngine.Transform ball;
	private void Update () {
//		UnityEngine.GameObject box=UnityEngine.GameObject.CreatePrimitive(UnityEngine.PrimitiveType.Sphere);
//		box.transform.position=new UnityEngine.Vector3(index_a*0.1f , index_b*0.1f , data[year , index_a , index_b]*256);
		UnityEngine.Transform.Instantiate(ball , UnityEngine.Random.onUnitSphere*0x10, UnityEngine.Quaternion.identity);
	}
}
