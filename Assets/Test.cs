using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss {
	private int hp = 100;
	private int power = 25;
	//int型のmpを宣言し53で初期化
	private int mp = 53;

	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}
	public void Defence (int damage){
		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage;
	}
	//mpを消費して魔法攻撃をするMagic関数
//	public void Magic (){
//		this.mp -=5;
//		if (this.mp >= 0) {
//			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
//		} else {
//			Debug.Log("MPが足りないため魔法が使えない。");
//		}
	//以下訂正↓　『残りMPが足りているか判定』してから『MPを減らす』処理にする。足りない場合でも残りMP表示に変更した。

	public void Magic (){
		if (this.mp >= 5) {
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
		} else {
			Debug.Log("MPが足りないため魔法が使えない。残りMPは" + this.mp + "。");
		} 

	}
		
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Boss lastboss = new Boss ();
		lastboss.Attack();
		lastboss.Defence(3);
		//Magic関数を呼び出して魔法を使う
//		lastboss.Magic();
//		lastboss.Magic();
//		lastboss.Magic();
//		lastboss.Magic();
//		lastboss.Magic();
//		lastboss.Magic();
//		lastboss.Magic();
//		lastboss.Magic();
//		lastboss.Magic();
//		lastboss.Magic();
//		lastboss.Magic();
	//以下訂正↓　ループを使う様に訂正


		for (int i = 0; i < 15; i++) 
		{
			lastboss.Magic ();
		}


		Boss midboss = new Boss ();
		midboss.Attack ();
		midboss.Defence (6);





		//配列の宣言を追記------------------------------

		//要素の個数が５のint型配列arrayを宣言し、初期化
		int [] array = {2,7,15,3,1};

		//配列の各要素を順番に表示
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array[i]);
		}

		//配列の各要素を逆順に表示
		for(int i = 4; i >= 0; i--){
			Debug.Log (array [i]);
		}

	}
		
	
	// Update is called once per frame
	void Update () {
		
	}
}
