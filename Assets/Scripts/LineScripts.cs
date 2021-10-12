using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineScripts : Graphic
{
    public Vector2Int gridSize;
    public List<Vector2> points;

    float width, height, unitWidth, unitHeight;

    public float thicness = 10f;

    protected override void OnPopulateMesh(VertexHelper vh)
    {
        vh.Clear();

        float width = rectTransform.rect.width;
        float height = rectTransform.rect.height;

        unitWidth = width / (float)gridSize.x;
        unitHeight = height / (float)gridSize.y;

        if(points.Count < 2)
        {
            return;
        }
        for (int i = 0; i<points.Count;i++)
        {
            Vector2 point = points[i];

            DrawVerticesForPoint(point, vh);
        }

        for(int i = 0; i<points.Count-1; i++)
        {
            int index = i * 2;
            vh.AddTriangle(index + 0, index + 1, index + 3);
            vh.AddTriangle(index + 3, index + 2, index + 0);
        }
    }

    void DrawVerticesForPoint(Vector2 point, VertexHelper vh)
    {
        UIVertex v = UIVertex.simpleVert;
        v.color = color;

        v.position = new Vector3(-thicness / 2, 0);
        v.position += new Vector3(unitWidth * point.x, unitHeight * point.y);
        vh.AddVert(v);

        v.position = new Vector3(thicness / 2, 0);
        v.position += new Vector3(unitWidth * point.x, unitHeight*point.y);
        vh.AddVert(v);

    }
}
