using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeObject : MonoBehaviour
{
    private readonly IMazeGenerator mazeGenerator;
    
    public MazeObject(IMazeGenerator mazeGenerator) : base()
    {
        this.mazeGenerator = mazeGenerator;
    }

    public MazeObject() : base()
    {
        this.mazeGenerator = new MazeGenerator(new JsonManager());
    }

    public void DrawMaze()
    {
        //GameObject.CreatePrimitive(PrimitiveType.Plane);
        foreach (List<Element> lineElement in this.mazeGenerator.CreateMazeFromData().GetMaze())
        {
            foreach (Element element in lineElement)
            {
                if (element.Type == EnumElementType.wall)
                {
                    GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    wall.transform.position = new Vector3(element.X, element.Y, 0);
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        DrawMaze();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
