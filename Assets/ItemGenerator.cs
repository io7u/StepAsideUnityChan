using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    //carPrefabを入れる
    public GameObject carPrefab;

    //coinPrefabを入れる
    public GameObject coinPrefab;

    //cornPrefabを入れる
    public GameObject conePrefab;

    //スタート地点
    private int startPos = 80;

    //ゴール地点
    private int goalPos = 360;

    //アイテムを出すx方向の範囲
    private float posRange = 3.4f;


    //カメラのオブジェクト
    private GameObject MainCamera;

    //カメラとコーンの距離
    private float difference1;

    //カメラとコインの距離
    private float difference2;

    //カメラと車の距離
    private float difference3;

    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    public int n;


    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");

        //MainCameraのオブジェクトを取得
        this.MainCamera = GameObject.Find("Main Camera");


        ////一定の距離ごとにアイテムを生成
        //for (int i = startPos; i < goalPos; i += 15)
        //{
        //    //どのアイテムを出すのかをランダムに設定
        //    int num = Random.Range(1, 11);
        //    if (num <= 2)
        //    {
        //        //コーンをx軸方向に一直線に生成
        //        for (float j = -1; j <= 1; j += 0.4f)
        //        {
        //            GameObject cone = Instantiate(conePrefab);
        //            cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
        //        }
        //    }
        //    else
        //    {
        //        //レーンごとにアイテムを生成
        //        for (int j = -1; j <= 1; j++)
        //        {
        //            //アイテムの種類を決める
        //            int item = Random.Range(1, 11);

        //            //アイテムを置くZ座標のオフセットをランダムに設定
        //            int offsetZ = Random.Range(-5, 6);

        //            //60%コイン配置:30%車配置:10%何もなし
        //            if (1 <= item && item <= 6)
        //            {
        //                //コインを生成
        //                GameObject coin = Instantiate(coinPrefab);
        //                coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);
        //            }
        //            else if (7 <= item && item <= 9)
        //            {
        //                //車を生成
        //                GameObject car = Instantiate(carPrefab);
        //                car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
        //            }
        //        }
        //    }
        //}

    }

    // Update is called once per frame
    void Update()
    {
        for(n = 0; n <= 360; n += 10)
        {
            if(unitychan.transform.position.z >= n && unitychan.transform.position.z <= n + 0.5)
            {
                //どのアイテムを出すのかをランダムに設定
                int num = Random.Range(1, 11);

                if (num <= 2)
                {
                    for (float j = -1; j <= 1; j += 0.4f)
                    {
                       GameObject cone = Instantiate(conePrefab);
                        cone.transform.position = new Vector3(4 * j, cone.transform.position.y, unitychan.transform.position.z + 40);
                    }
                }
                else
                {
                    //レーンごとにアイテムを生成
                    for (int j = -1; j <= 1; j++)
                    {
                        //アイテムの種類を決める
                        int item = Random.Range(1, 11);

                        //60%コイン配置:30%車配置:10%何もなし
                        if (1 <= item && item <= 6)
                        {
                            //コインを生成
                            GameObject coin = Instantiate(coinPrefab);
                            coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, unitychan.transform.position.z + 40);
                        }
                        else if (7 <= item && item <= 9)
                        {
                            //車を生成
                            GameObject car = Instantiate(carPrefab);
                            car.transform.position = new Vector3(posRange * j, car.transform.position.y, unitychan.transform.position.z + 40);
                        }
                    }
                }
            }
        }
        ////コーンとカメラの位置（z座標）の差を求める
        //this.difference1 = MainCamera.transform.position.z - conePrefab.transform.position.z;

        //if (difference1 > 0)
        //{
        //    Destroy(conePrefab);
        //}

        ////コインとカメラの位置（z座標）の差を求める
        //this.difference2 = MainCamera.transform.position.z - coinPrefab.transform.position.z;

        //if (difference2 > 0)
        //{
        //    Destroy(coinPrefab);
        //}

        ////車とカメラの位置（z座標）の差を求める
        //this.difference3 = MainCamera.transform.position.z - carPrefab.transform.position.z;

        //if (difference3 > 0)
        //{
        //    Destroy(carPrefab);

        //}

        
    }
}

