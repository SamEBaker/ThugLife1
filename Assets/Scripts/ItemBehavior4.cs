using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior4 : MonoBehaviour
{
    public GameBehavior gameManager;
	//public GameObject bullet;
	//public float bulletSpeed = 100f;
	public MeshRenderer Slingshot;
	void Start()
	{
		gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
	}
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == "Player")
		{
			Destroy(this.transform.parent.gameObject);
			Debug.Log("You found a slingshot!");
			PlayerBehavior Player = collision.gameObject.GetComponent<PlayerBehavior>();
			Slingshot.enabled = true;
			gameManager.PrintLootReport();
			//if (Input.GetMouseButtonDown(0))
			//{
			//	GameObject newBullet = Instantiate(bullet, this.transform.position + new Vector3(1, 0, 0), this.transform.rotation) as GameObject;
			//	Rigidbody bulletRB = newBullet.GetComponent<Rigidbody>();
			//	bulletRB.velocity = this.transform.forward * bulletSpeed;
			//}
		}
	}
}