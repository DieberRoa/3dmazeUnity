using System.Collections.Generic;

public interface IMaze
{
    void AddElementsLine(List<Element> elementsLine);
    int GetHeight();
    List<List<Element>> GetMaze();
    int GetWidht();
}