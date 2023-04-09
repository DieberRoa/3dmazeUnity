using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator : IMazeGenerator
{
    private IJsonManager mazeData;

    public MazeGenerator(IJsonManager mazeData)
    {
        this.mazeData = mazeData;
    }

    public Maze CreateMazeFromData()
    {
        Maze maze = new Maze();
        int x = 1;
        foreach (List<int> line in mazeData.GetMazeData())
        {
            List<Element> lineElements = new List<Element>();
            int y = 1;
            foreach (int intElement in line)
            {
                Element element = new Element();
                element.X = x;
                element.Y = y;
                if (intElement != 3)
                {
                    element.Type = EnumElementType.wall;
                }
                else
                {
                    element.Type = EnumElementType.space;
                }
                lineElements.Add(element);
                y++;
            }
            maze.AddElementsLine(lineElements);
            x++;
        }
        return maze;
    }

}
