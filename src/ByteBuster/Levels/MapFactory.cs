using ByteBuster.Abstractions.Levels;

namespace ByteBuster.Levels;

public class MapFactory
{
    private readonly Dictionary<string, CellData> cellDictionary = GenerateCellDictionary();
    
    private readonly List<ICell> pendingCells = new();
    
    private uint pendingWidth, pendingHeight;
    
    public MapFactory SetDimensions(uint width, uint height)
    {
        pendingCells.Clear();
        pendingWidth = width;
        pendingHeight = height;
        return this;
    }

    public MapFactory PushKeys(params string[] keys)
    {
        foreach (var key in keys)
        {
            if (!cellDictionary.ContainsKey(key))
            {
                continue;
            }
            
            var cell = new Cell(key, cellDictionary[key]);
            pendingCells.Add(cell);
        }
        return this;
    }

    public ICell[,] Build()
    {
        // TODO: implement integrity checks
        var cells = new ICell[pendingWidth, pendingHeight];
        int i = 0;
        for(int w = 0; w < pendingWidth; w++)
        {
            for (int h = 0; h < pendingHeight; h++)
            {
                cells[w, h] = pendingCells[i];
                i++;
            }
        }
        return cells;
    }

    private static Dictionary<string, CellData> GenerateCellDictionary()
    {
        var dict = new Dictionary<string, CellData>();
        AddCellData("_", true, "bg/____");
        AddCellData(".", true, "b/...", "fg/...");
        AddCellData("~", false, "b/~~~");
        AddCellData("X", false, "b/XXX");
        return dict;
        
        // --- local func

        void AddCellData(string k, bool isFree, string bg, string? fg = null)
        {
            dict.Add(k, new CellData(k, isFree, fg ?? "", bg));
        }
    }
}