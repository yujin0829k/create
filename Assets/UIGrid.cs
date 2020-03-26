using UnityEngine;
using UnityEngine.UI;
public class UIGrid : Graphic
{
    [SerializeField]
    private Vector2 _position1;
    [SerializeField]
    private Vector2 _position2;
    [SerializeField]
    private float _weight;

    protected override void OnPopulateMesh(VertexHelper vh)
    {
        // （１）過去の頂点を削除
        vh.Clear();

        // （２）垂直ベクトルの計算
        var pos1_to_2 = _position2 - _position1;
        var verticalVector = CalcurateVerticalVector(pos1_to_2);

        // （３）左下、左上のベクトルを計算
        var pos1Top = _position1 + verticalVector * -_weight / 2;
        var pos1Bottom = _position1 + verticalVector * _weight / 2;
        var pos2Top = _position2 + verticalVector * -_weight / 2;
        var pos2Bottom = _position2 + verticalVector * _weight / 2;

        // （４）頂点を頂点リストに追加
        AddVert(vh, pos1Top);
        AddVert(vh, pos1Bottom);
        AddVert(vh, pos2Top);
        AddVert(vh, pos2Bottom);


        // （５）頂点リストを元にメッシュを貼る
        vh.AddTriangle(0, 1, 2);
        vh.AddTriangle(1, 2, 3);
    }
    private void AddVert(VertexHelper vh, Vector2 pos)
    {
        var vert = UIVertex.simpleVert;
        vert.position = pos;
        vert.color = color;
        vh.AddVert(vert);
    }

    private Vector2 CalcurateVerticalVector(Vector2 vec)
    {
        // 0除算の防止
        if (vec.y == 0)
        {
            return Vector2.up;
        }
        else
        {
            var verticalVector = new Vector2(1.0f, -vec.x / vec.y);
            return verticalVector.normalized;
        }
    }
}
