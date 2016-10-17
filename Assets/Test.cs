using UnityEngine;
using System.Collections;

public class Boss {        
	private int hp = 100;          // 体力
	private int mp = 53;          // 魔法力
	private int power = 25; // 攻撃力


	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	public void MAttack() { 
		if (this.mp >= 5) {
			this.mp -= 5;// 残りmpを減らす
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp);
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

}


public class Test : MonoBehaviour {

	void Start () {
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		// 攻撃用の関数を呼び出す
//		lastboss.Attack();
		// 防御用の関数を呼び出す
//		lastboss.Defence(3);

		//配列を宣言して出力課題
		//ArrayTest ();

		for (int i = 0; i < 15; i++) {
			lastboss.MAttack ();
		}
	}

	// Update is called once per frame
	void Update () {

	}

	private void ArrayTest () {
		int[] points = {22, 11, 555, 66, 8};

		for (int i = points.Length - 1; i >= 0; i--) {
			Debug.Log (points [i]);
		}
	}
}


