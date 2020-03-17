using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Floor : MonoBehaviour {
    // Materialを保持するようにする
    [SerializeField]
    public Material mat;

    void Start () {
    Mesh mesh = new Mesh ();
    mesh.vertices = new Vector3[] {
        // 左下、左上、右上、右下
        new Vector3 (-1.2f, -1.2f, 0),
        new Vector3 (-1.2f,  1.2f, 0),       
        new Vector3 (1.2f , -1.2f, 0),
        new Vector3 (1.2f ,  1.2f, 0),
    };

    //uv座標
    mesh.uv = new Vector2[] {
        // 同様に左下、左上、右上、右下
        new Vector2 (0, 0),
        new Vector2 (0, 1),
        new Vector2 (1, 0),              
        new Vector2 (1, 1),
    };

    //インデックス配列
    mesh.triangles = new int[] {
        0, 1, 2, 
        1, 3, 2,
    };
    GetComponent<MeshFilter> ().sharedMesh = mesh;
    GetComponent<MeshRenderer> ().material = mat;
    }
}