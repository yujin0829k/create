using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour {

  private GameObject _floor;
  private GameObject _wall1;
  private GameObject _wall2;
  private GameObject _wall3;
  private GameObject _wall4;

  // Use this for initialization
  void Start () {
    // 床を作ってGameObjectの子にする
    this._floor = new GameObject("floor");
    this._floor.transform.parent = this.transform;
    
    this._floor.AddComponent<MeshFilter>();
    this._floor.AddComponent<MeshRenderer>();
    MeshFilter floorMeshFilter = this._floor.GetComponent<MeshFilter>();
    Mesh floorMesh = new Mesh();
    floorMesh.vertices = new Vector3[] {
        new Vector3 (-1,  0, -1),
        new Vector3 (-1,  0,  1),       
        new Vector3 ( 1 , 0, -1),
        new Vector3 ( 1 , 0,  1),
    };
    floorMesh.triangles = new int[] {
        0, 1, 2,
        1, 3, 2,
    };
    floorMeshFilter.sharedMesh = floorMesh;

    // 壁①を作ってGameObjectの子にする
    this._wall1 = new GameObject("wall1");
    this._wall1.transform.parent = this.transform;
    this._wall1.AddComponent<MeshFilter>();
    this._wall1.AddComponent<MeshRenderer>();
    MeshFilter wall1MeshFilter = this._wall1.GetComponent<MeshFilter>();
    Mesh wall1Mesh = new Mesh();
    wall1Mesh.vertices = new Vector3[] {
        new Vector3 (-1,  0,  1),
        new Vector3 (-1,  2,  1),
        new Vector3 ( 1,  0,  1),
        new Vector3 ( 1,  2,  1),
    };
    wall1Mesh.triangles = new int[] {
        0, 1, 2,
        1, 3, 2,
    };
    wall1MeshFilter.sharedMesh = wall1Mesh;
  

    // 壁②を作ってGameObjectの子にする
    this._wall2 = new GameObject("wall2");
    this._wall2.transform.parent = this.transform;
    this._wall2.AddComponent<MeshFilter>();
    this._wall2.AddComponent<MeshRenderer>();
    MeshFilter wall2MeshFilter = this._wall2.GetComponent<MeshFilter>();
    Mesh wall2Mesh = new Mesh();
    wall2Mesh.vertices = new Vector3[] {
        new Vector3 (1,  0,  1),
        new Vector3 (1,  2,  1),
        new Vector3 (1,  0,  -1),
        new Vector3 (1,  2,  -1),
    };
    wall2Mesh.triangles = new int[] {
        0, 1, 2,
        1, 3, 2,
    };
    wall2MeshFilter.sharedMesh = wall2Mesh;

    // 壁③を作ってGameObjectの子にする
    this._wall3 = new GameObject("wall3");
    this._wall3.transform.parent = this.transform;
    this._wall3.AddComponent<MeshFilter>();
    this._wall3.AddComponent<MeshRenderer>();
    MeshFilter wall3MeshFilter = this._wall3.GetComponent<MeshFilter>();
    Mesh wall3Mesh = new Mesh();
    wall3Mesh.vertices = new Vector3[] {
        new Vector3 (1,  0,  -1),
        new Vector3 (1,  2,  -1),
        new Vector3 (-1,  0,  -1),
        new Vector3 (-1,  2,  -1),
    };
    wall3Mesh.triangles = new int[] {
        0, 1, 2,
        1, 3, 2,
    };
    wall3MeshFilter.sharedMesh = wall3Mesh;

        // 壁④を作ってGameObjectの子にする
    this._wall4 = new GameObject("wall4");
    this._wall4.transform.parent = this.transform;
    this._wall4.AddComponent<MeshFilter>();
    this._wall4.AddComponent<MeshRenderer>();
    MeshFilter wall4MeshFilter = this._wall4.GetComponent<MeshFilter>();
    Mesh wall4Mesh = new Mesh();
    wall4Mesh.vertices = new Vector3[] {
        new Vector3 (-1,  0,  -1),
        new Vector3 (-1,  2,  -1),
        new Vector3 (-1,  0,  1),
        new Vector3 (-1,  2,  1),
    };
    wall4Mesh.triangles = new int[] {
        0, 1, 2,
        1, 3, 2,
    };
    wall4MeshFilter.sharedMesh = wall4Mesh;
  }

	// Update is called once per frame
	void Update () {

	}
}