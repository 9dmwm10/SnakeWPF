using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLibs.DrawSnake
{
    public interface IDrawSnake
    {
        void OnSnakeInit();
        void OnSnakeMove();
        void OnSnakeEatBerry();
        void OnBerryCreate();
        void OnGameOver();
    }
}
