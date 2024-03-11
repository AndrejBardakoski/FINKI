Game game = new Glider(20);
while (game.CurrentGeneration <= game.MaxGenerations)
{
    game.Show();
    game.Evolve();
    Thread.Sleep(500);
}
Console.WriteLine("Evaluation ended!\nPress any key to exit...");
Console.ReadKey();


public class Cell
{
    public bool isAlive { get; set; }
    public bool shouldLive { get; set; }
    public Cell()
    {
        isAlive = false;
        shouldLive = false;
    }       
    public override string ToString()
    {
        return isAlive ? " X " : " _ ";
    }
}
public class Grid
{
    public int Rows { get; set; }
    public int Columns { get; set; }
    public Cell[][] Cells { get; set; }
    public Grid(int rows, int columns)
    {
        this.Rows = rows;
        this.Columns = columns;
        Cells = new Cell[rows][];
        for (int i = 0; i < Rows; i++)
        {
            Cells[i] = new Cell[Columns];
            for (int j = 0; j < Columns; j++)
            {
               Cells[i][j]= new Cell();
            }
        }
    }
    public void ToggleCell(int x, int y, bool isAlive)
    {
            Cells[x][y].isAlive = isAlive;
    }
    public int AliveNeighbours(int x,int y)
    {
        int numAliveNeighbours = 0;
        if (x != 0 && x!=Rows-1)
        {
            if(y!=0 && y != Columns - 1)
            {
                if (Cells[x - 1][y - 1].isAlive) { numAliveNeighbours++; }
                if (Cells[x][y - 1].isAlive) { numAliveNeighbours++; }
                if (Cells[x+1][y - 1].isAlive) { numAliveNeighbours++; }
                if (Cells[x-1][y].isAlive) { numAliveNeighbours++; }
                if (Cells[x+1][y].isAlive) { numAliveNeighbours++; }
                if (Cells[x-1][y+1].isAlive) { numAliveNeighbours++; }
                if (Cells[x][y+1].isAlive) { numAliveNeighbours++; }
                if (Cells[x+1][y+1].isAlive) { numAliveNeighbours++; }
            }
            else if(y == 0)
            {
                if (Cells[x - 1][y].isAlive) { numAliveNeighbours++; }
                if (Cells[x + 1][y].isAlive) { numAliveNeighbours++; }
                if (Cells[x - 1][y + 1].isAlive) { numAliveNeighbours++; }
                if (Cells[x][y + 1].isAlive) { numAliveNeighbours++; }
                if (Cells[x + 1][y + 1].isAlive) { numAliveNeighbours++; }
            }
            else if (y == Columns - 1)
            {
                if (Cells[x - 1][y - 1].isAlive) { numAliveNeighbours++; }
                if (Cells[x][y - 1].isAlive) { numAliveNeighbours++; }
                if (Cells[x + 1][y - 1].isAlive) { numAliveNeighbours++; }
                if (Cells[x - 1][y].isAlive) { numAliveNeighbours++; }
                if (Cells[x + 1][y].isAlive) { numAliveNeighbours++; }
            }
        }
        else if(x == 0)
        {
            if (y != 0 && y != Columns - 1)
            {
                if (Cells[x][y - 1].isAlive) { numAliveNeighbours++; }
                if (Cells[x + 1][y - 1].isAlive) { numAliveNeighbours++; }
                if (Cells[x + 1][y].isAlive) { numAliveNeighbours++; }
                if (Cells[x][y + 1].isAlive) { numAliveNeighbours++; }
                if (Cells[x + 1][y + 1].isAlive) { numAliveNeighbours++; }
            }
            else if (y == 0)
            {
                if (Cells[x + 1][y].isAlive) { numAliveNeighbours++; }
                if (Cells[x][y + 1].isAlive) { numAliveNeighbours++; }
                if (Cells[x + 1][y + 1].isAlive) { numAliveNeighbours++; }
            }
            else if (y == Columns - 1)
            {
                if (Cells[x][y - 1].isAlive) { numAliveNeighbours++; }
                if (Cells[x + 1][y - 1].isAlive) { numAliveNeighbours++; }
                if (Cells[x + 1][y].isAlive) { numAliveNeighbours++; }
            }
        }else if(x == Rows-1)
        {
            if (y != 0 && y != Columns - 1)
            {
                if (Cells[x - 1][y - 1].isAlive) { numAliveNeighbours++; }
                if (Cells[x][y - 1].isAlive) { numAliveNeighbours++; }
                if (Cells[x - 1][y].isAlive) { numAliveNeighbours++; }
                if (Cells[x - 1][y + 1].isAlive) { numAliveNeighbours++; }
                if (Cells[x][y + 1].isAlive) { numAliveNeighbours++; }
            }
            else if (y == 0)
            {
                if (Cells[x - 1][y].isAlive) { numAliveNeighbours++; }
                if (Cells[x - 1][y + 1].isAlive) { numAliveNeighbours++; }
                if (Cells[x][y + 1].isAlive) { numAliveNeighbours++; }
            }
            else if (y == Columns - 1)
            {
                if (Cells[x - 1][y - 1].isAlive) { numAliveNeighbours++; }
                if (Cells[x][y - 1].isAlive) { numAliveNeighbours++; }
                if (Cells[x - 1][y].isAlive) { numAliveNeighbours++; }
            }
        }
        return numAliveNeighbours;
    }
    public void Evolve()
    {
        int numAliveNeighbours;
        Cell currentCell;
        for(int i= 0; i < Rows; i++)
        {
            for(int j= 0; j < Columns; j++)
            {
                currentCell = Cells[i][j];
                numAliveNeighbours = AliveNeighbours(i, j);
                if (currentCell.isAlive)
                {
                    if(numAliveNeighbours<2 || numAliveNeighbours > 3)
                    {
                        currentCell.shouldLive = false;
                    }
                    else{ currentCell.shouldLive = true;}
                }
                else
                {
                    if (numAliveNeighbours == 3) { currentCell.shouldLive = true; }
                }
            }
        }
        foreach(Cell[] cells in Cells)
        {
            foreach (Cell cell in cells)
            {
                cell.isAlive = cell.shouldLive;
            }
        }
    }
}
public abstract class Game
{
    protected Grid grid;

    public int CurrentGeneration { get; set; }

    public int MaxGenerations { get; set; }
    public Game(int maxGenerations)
    {
        MaxGenerations = maxGenerations;
        CurrentGeneration = 0;
    }
    public void Evolve()
    {
        grid.Evolve();
        CurrentGeneration++;
    }
    virtual public void Show()
    {
        Console.Clear();

        Console.WriteLine("Current generation: {0}",CurrentGeneration);
        foreach(Cell[] cells in grid.Cells)
        {
            foreach(Cell cell in cells)
            {
                Console.Write(cell.ToString());
            }
            Console.WriteLine();
        }
    }
}
/// <summary>
/// Implementacija na igrata so pochetna sostojba so statichki raspored na zhivi kletki koi ne se menuvaat pri evolucija.
/// </summary>
class StillLifeGame : Game
{
    public enum GameType
    {
        Block,
        Beehive,
        Loaf,
        Boat
    }

    public GameType Type { get; set; }

    public StillLifeGame(GameType gameType, int maxGenerations) : base(maxGenerations)
    {
        Type = gameType;
        if (Type == GameType.Block)
        {
            grid = new Grid(4, 4);
            grid.ToggleCell(1, 1, true);
            grid.ToggleCell(1, 2, true);
            grid.ToggleCell(2, 1, true);
            grid.ToggleCell(2, 2, true);
        }

        if (Type == GameType.Beehive)
        {
            grid = new Grid(5, 6);
            grid.ToggleCell(1, 2, true);
            grid.ToggleCell(1, 3, true);
            grid.ToggleCell(2, 1, true);
            grid.ToggleCell(2, 4, true);
            grid.ToggleCell(3, 2, true);
            grid.ToggleCell(3, 3, true);
        }
        if(Type == GameType.Loaf)
        {
            grid = new Grid(6, 6);
            grid.ToggleCell(0, 0, true);
            grid.ToggleCell(0, 2, true);
            grid.ToggleCell(0, 5, true);
            grid.ToggleCell(1, 1, true);
            grid.ToggleCell(1, 2, true);
            grid.ToggleCell(1, 3, true);
            grid.ToggleCell(1, 5, true);
            grid.ToggleCell(2, 0, true);
            grid.ToggleCell(2, 4, true);
            grid.ToggleCell(3, 1, true);
            grid.ToggleCell(3, 5, true);
            grid.ToggleCell(4, 0, true);
            grid.ToggleCell(4, 2, true);
            grid.ToggleCell(4, 4, true);
            grid.ToggleCell(5, 1, true);
            grid.ToggleCell(5, 3, true);
            grid.ToggleCell(5, 5, true);
        }
        if(Type == GameType.Boat)
        {
            grid = new Grid(10, 4);
            grid.ToggleCell(0, 0, true);
            grid.ToggleCell(0, 2, true);
            grid.ToggleCell(1, 1, true);
            grid.ToggleCell(1, 2, true);
            grid.ToggleCell(1, 3, true);
            grid.ToggleCell(2, 0, true);
            grid.ToggleCell(3, 1, true);
            grid.ToggleCell(4, 0, true);
            grid.ToggleCell(4, 2, true);
            grid.ToggleCell(4, 3, true);
            grid.ToggleCell(5, 1, true);
            grid.ToggleCell(5, 3, true);
            grid.ToggleCell(6, 3, true);
            grid.ToggleCell(7, 0, true);
            grid.ToggleCell(7, 2, true);
            grid.ToggleCell(9, 2, true);
            grid.ToggleCell(9, 1, true);
        }
    }

    override public void Show()
    {
        Console.Title = String.Format("Still Game of Life: {0}", Type);
        base.Show();
    }
}
/// <summary>
/// Implementacija na igrata so pochetna sostojba so raspored na zhivi kletki koi osciliraat pri evolucija.
/// </summary>
class OscilatorGame : Game
{
    public enum GameType
    {
        Blinker,
        Toad,
        Beacon,
        Pulsar
    }

    public GameType Type { get; set; }

    public OscilatorGame(GameType gameType, int maxGenerations) : base(maxGenerations)
    {
        Type = gameType;
        if (gameType == GameType.Blinker)
        {
            grid = new Grid(5, 5);
            grid.ToggleCell(2, 1, true);
            grid.ToggleCell(2, 2, true);
            grid.ToggleCell(2, 3, true);
        }

        if (gameType == GameType.Toad)
        {
            grid = new Grid(6, 6);
            grid.ToggleCell(2, 1, true);
            grid.ToggleCell(3, 1, true);
            grid.ToggleCell(4, 2, true);
            grid.ToggleCell(1, 3, true);
            grid.ToggleCell(2, 4, true);
            grid.ToggleCell(3, 4, true);
        }
        if (gameType == GameType.Beacon)
        {
            grid = new Grid(6, 6);
            grid.ToggleCell(1, 1, true);
            grid.ToggleCell(1, 2, true);
            grid.ToggleCell(2, 1, true);
            grid.ToggleCell(2, 2, true);
            grid.ToggleCell(3, 3, true);
            grid.ToggleCell(3, 4, true);
            grid.ToggleCell(4, 3, true);
            grid.ToggleCell(4, 4, true);
        }
        if (gameType == GameType.Pulsar)
        {
            grid = new Grid(17, 17);
            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    if (i == 2 || i == 7 || i == 9 || i == 14)
                    {
                        if (j == 4 || j == 5 || j == 6 || j == 10 || j == 11 || j == 12)
                        {
                            grid.ToggleCell(i, j, true);
                        }
                    }
                    if ((i >= 4 && i <= 6) || (i >= 10 && i <= 12))
                    {
                        if (j == 2 || j == 7 || j == 9 || j == 14)
                        {
                            grid.ToggleCell(i, j, true);
                        }

                    }
                }
            }
        }
    }

    override public void Show()
    {
        Console.Title = String.Format("Oscilator Game of Life: {0}", Type);
        base.Show();
    }
}
public class Glider : Game
{
    public Glider(int maxGenerators) : base(maxGenerators)
    {
        grid = new Grid(10, 10);
        grid.ToggleCell(4, 4, true);
        grid.ToggleCell(4, 3, true);
        grid.ToggleCell(4, 2, true);
        grid.ToggleCell(3, 4, true);
        grid.ToggleCell(2, 3, true);
    }
    override public void Show()
    {
        Console.Title = String.Format("Glider Game of Life: ");
        base.Show();
    }
}