using SFML.Window;

namespace Snake;

public class InputController
{
    private Snake _snake;

    /// <summary>
    /// Конструктор объекта InputController, который сохраняет ссылку на объект Snake.
    /// </summary>
    public InputController(Snake snake)
    {
        // Конструктор сохраняет змейку в поле класса.
        _snake = snake;
    }
    
    public void ProcessInput()
    {
        // Проверяем нажатую кнопку и в зависимости от нее - задаем змейке соответствующее направление.

        // Перемещаем змейку вверх
        if (Keyboard.IsKeyPressed(Keyboard.Key.W) || Keyboard.IsKeyPressed(Keyboard.Key.Up))
        {
            // Проверка, что текущее направление змейки не вниз.
            if ((int)_snake.Direction.Y != 1)
            {
                _snake.SetMoveDirectionToUp();
            }
        }
        if (Keyboard.IsKeyPressed(Keyboard.Key.S) || Keyboard.IsKeyPressed(Keyboard.Key.Down))
        {
            if ((int)_snake.Direction.Y != -1)
            {
                _snake.SetMoveDirectionToDown();
            }
        }
        if (Keyboard.IsKeyPressed(Keyboard.Key.A) || Keyboard.IsKeyPressed(Keyboard.Key.Left))
        {
            if ((int)_snake.Direction.X != 1)
            {
                _snake.SetMoveDirectionToLeft();
            }
        }
        if (Keyboard.IsKeyPressed(Keyboard.Key.D) || Keyboard.IsKeyPressed(Keyboard.Key.Right))
        {
            if ((int)_snake.Direction.X != -1)
            {
                _snake.SetMoveDirectionToRight();
            }
        }
        // Двигаем змейку.
        MoveSnake();
    }

    public void MoveSnake()
    {
        // Двигаем змейку.
        _snake.MoveForward();
    }
}