using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Maze : IMaze
{
    private readonly List<List<Element>> mazeElements;

    public Maze()
    {
        mazeElements = new List<List<Element>>();
    }

    public void AddElementsLine(List<Element> elementsLine)
    {
        mazeElements.Add(elementsLine);
    }

    public List<List<Element>> GetMaze()
    {
        return mazeElements;
    }

    public int GetWidht()
    {
        if (mazeElements.Count > 0)
        {
            return mazeElements[0].Count;
        }
        return 0;
    }

    public int GetHeight()
    {
        return mazeElements.Count;
    }

}

