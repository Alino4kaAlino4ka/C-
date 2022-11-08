public const int width = 15, height = 25, k = 15; // Размеры поля и размер клетки в пикселях
public int[,] shape = new int[2, 4]; // Массив для хранения падающей фигурки (для каждого блока 2 координаты [0, i] и [1, i]
public int[,] field = new int[width, height]; // Массив для хранения поля
public Bitmap bitfield = new Bitmap(k * (width + 1) + 1, k * (height + 3) + 1);
public Graphics gr; // Для рисования поля на PictureBox

//Заполним поле по краям:
for (int i = 0; i < width; i++)
    field[i, height - 1] = 1;
for (int i = 0; i < height; i++)
{
    field[0, i] = 1;
    field[width - 1, i] = 1;
}


//Заполним фигуру:

public void SetShape()
{
    Random x = new Random(DateTime.Now.Millisecond);
    switch (x.Next(7))
    { // Рандомно выбираем 1 из 7 возможных фигурок
        case 0: shape = new int[,] { { 2, 3, 4, 5 }, { 8, 8, 8, 8 } }; break;
        case 1: shape = new int[,] { { 2, 3, 2, 3 }, { 8, 8, 9, 9 } }; break;
        case 2: shape = new int[,] { { 2, 3, 4, 4 }, { 8, 8, 8, 9 } }; break;
        case 3: shape = new int[,] { { 2, 3, 4, 4 }, { 8, 8, 8, 7 } }; break;
        case 4: shape = new int[,] { { 3, 3, 4, 4 }, { 7, 8, 8, 9 } }; break;
        case 5: shape = new int[,] { { 3, 3, 4, 4 }, { 9, 8, 8, 7 } }; break;
        case 6: shape = new int[,] { { 3, 4, 4, 4 }, { 8, 7, 8, 9 } }; break;
    }
}



//Процедура, которая рисует «стакан» в PictureBox:

public void FillField()
{
    gr.Clear(Color.Black); //Очистим поле
    for (int i = 0; i < width; i++)
        for (int j = 0; j < height; j++)
            if (field[i, j] == 1)
            { // Если клетка поля существует
                gr.FillRectangle(Brushes.Green, i * k, j * k, k, k); // Рисуем в этом месте квадратик
                gr.DrawRectangle(Pens.Black, i * k, j * k, k, k);
            }
    for (int i = 0; i < 4; i++)
    { // Рисуем падающую фигуру
        gr.FillRectangle(Brushes.Red, shape[1, i] * k, shape[0, i] * k, k, k);
        gr.DrawRectangle(Pens.Black, shape[1, i] * k, shape[0, i] * k, k, k);
    }
    FieldPictureBox.Image = bitfield;
}


//Фигурки я сначала двигаю, а потом проверяю, возможен такой вариант или нет. Если в каком-то месте находится ошибка (фигура вышла за пределы поля или наложилась на уже лежащую в поле фигуру), фигурка возвращается на своё прежнее место. Для этого я написал функцию, которая возвращает true, если на поле нашлась ошибка или false, если ошибки нет:

       public bool FindMistake(){
            for (int i = 0; i < 4; i++)
                if (shape[1, i] >= width || shape[0, i] >= height || 
                    shape[1, i] <= 0 || shape[0, i] <= 0 || 
                    field[shape[1, i], shape[0, i]] == 1)
                        return true; 
            return false;
        }

//Теперь приступим к передвижению фигурки. Создадим в конструкторе событие KeyDown.

//Движение влево:

      switch (e.KeyCode){
            case Keys.A:
                for (int i = 0; i < 4; i++) 
                    shape[1, i]--; // Сначала сдвигаем координаты всех кусочков фигуры на 1 влево по оси OX 
                if (FindMistake()) // Если после этого нашлась ошибка
                    for (int i = 0; i < 4; i++) 
                            shape[1, i]++; // Возвращаем фигурку обратно на 1 вправо
                break;
            ...
           }

//Аналогично движение вправо:

 case Keys.D:
     for (int i = 0; i < 4; i++) 
          shape[1, i]++;
     if (FindMistake())
          for (int i = 0; i < 4; i++)
               shape[1, i]--;
break;

//Переворот фигурки устроен немного сложнее:

case Keys.W:               
                var shapeT = new int[2, 4]; 
                Array.Copy(shape, shapeT, shape.Length); // Создадим копию фигурки, чтобы в случае, когда после переворота на поле найдется ошибка, не переворачивать её обратно, а просто восстановить копию
                int maxx = 0, maxy = 0; 
                for (int i = 0; i < 4; i++){
                    if (shape[0, i] > maxy)
                            maxy = shape[0, i]; 
                    if (shape[1, i] > maxx)
                            maxx = shape[1, i];
                } // Найдем максимальные координаты значения фигуры по X и по Y
                for (int i = 0; i < 4; i++) { 
                    int temp = shape[0, i];
                    shape[0, i] = maxy - (maxx - shape[1, i]) - 1;
                    shape[1, i] = maxx - (3 - (maxy - temp)) + 1;
                } // Перевернем фигуру. Эти формулы я обнаружил после тщательного изучения нарисованного квадратика с фигурой до и после переворота.
                if (FindMistake())
                        Array.Copy(shapeT, shape, shape.Length);                
                break;

//Теперь осталось только добавить падение фигурок и убирание строк. Все это будет происходить по событию TimerTick:

private void TickTimer_Tick(object sender, System.EventArgs e){
            if (field[8, 3] == 1)
                Environment.Exit(0); // Если клетка поля, на которой появляются фигурки заполнены, завершить программу.
            for (int i = 0; i < 4; i++) 
                shape[0, i]++; // Сместить фигурку вниз
            if (FindMistake()){
                for (int i = 0; i < 4; i++)
                    field[shape[1, i], --shape[0, i]]++;                 
                SetShape();
            } // Если нашлась ошибка, перенести фигурку на 1 клетку вверх, сохранить её в массив field и создать новую фигурку
            for (int i = height - 2; i > 2; i--){
                var cross = (from t in Enumerable.Range(0, field.GetLength(0)).Select(j => field[j, i]).ToArray() where t == 1 select t).Count(); // Количество заполненных полей в ряду
                if (cross == width)
                    for (int k = i; k > 1; k--)
                        for (int l = 1; l < width - 1; l++)
                            field[l, k] = field[l, k - 1];
            } // Проверка на заполненность рядом, если нашлись ряды, в которых все клетки заполнены, сместить все ряды, которые находятся выше убранной линии, на 1 вниз

            FillField(); // Перерисовать поле
        }

//Ну и наконец, при создании формы надо вызвать:

   SetShape();

//Итоговый код:

// using System;
// using System.Linq;
// using System.Drawing;
// using System.Windows.Forms;
// namespace LittleTetris{
//     public partial class Form1 : Form{
//         public const int width = 15, height = 25, k = 15;
//         public int[,] shape = new int[2, 4];
//         public int[,] field = new int[width, height];
//         public Bitmap bitfield = new Bitmap(k * (width + 1) + 1, k * (height + 3) + 1);
//         public Graphics gr;
//         public Form1(){
//             InitializeComponent();
//             gr = Graphics.FromImage(bitfield);
//             for (int i = 0; i < width; i++)
//                 field[i, height - 1] = 1;
//             for (int i = 0; i < height; i++) {
//                 field[0, i] = 1;
//                 field[width - 1, i] = 1;
//             }
//             SetShape();
//         }
//         public void FillField(){
//             gr.Clear(Color.Black);
//             for (int i = 0; i < width; i++)
//                 for (int j = 0; j < height; j++)
//                     if (field[i, j] == 1){
//                         gr.FillRectangle(Brushes.Green, i * k, j * k, k, k);
//                         gr.DrawRectangle(Pens.Black, i * k, j * k, k, k);
//                     }
//             for (int i = 0; i < 4; i++){
//                 gr.FillRectangle(Brushes.Red, shape[1, i] * k, shape[0, i] * k, k, k);
//                 gr.DrawRectangle(Pens.Black, shape[1, i] * k, shape[0, i] * k, k, k);
//             }
//             FieldPictureBox.Image = bitfield;
//         }
//         private void TickTimer_Tick(object sender, System.EventArgs e){
//             if (field[8, 3] == 1)
//                 Environment.Exit(0);
//             for (int i = 0; i < 4; i++) 
//                 shape[0, i]++;
//             for (int i = height - 2; i > 2; i--){
//                 var cross = (from t in Enumerable.Range(0, field.GetLength(0)).Select(j => field[j, i]).ToArray() where t == 1 select t).Count();
//                 if (cross == width)
//                     for (int k = i; k > 1; k--)
//                         for (int l = 1; l < width - 1; l++)
//                             field[l, k] = field[l, k - 1];}
//             if (FindMistake()){
//                 for (int i = 0; i < 4; i++)
//                     field[shape[1, i], --shape[0, i]]++;                 
//                 SetShape();}
//             FillField();
//         }
//         private void Form1_KeyDown(object sender, KeyEventArgs e){
//            switch (e.KeyCode){
//             case Keys.A:
//                 for (int i = 0; i < 4; i++)
//                     shape[1, i]--;
//                 if (FindMistake())
//                     for (int i = 0; i < 4; i++)
//                             shape[1, i]++;
//                 break;
//             case Keys.D:
//                 for (int i = 0; i < 4; i++)
//                         shape[1, i]++;
//                 if (FindMistake())
//                         for (int i = 0; i < 4; i++)
//                             shape[1, i]--;
//                 break; 
//             case Keys.W:               
//                 var shapeT = new int[2, 4];
//                 Array.Copy(shape, shapeT, shape.Length);
//                 int maxx = 0, maxy = 0; 
//                 for (int i = 0; i < 4; i++){
//                     if (shape[0, i] > maxy)
//                             maxy = shape[0, i]; 
//                     if (shape[1, i] > maxx)
//                             maxx = shape[1, i];
//                 }
//                 for (int i = 0; i < 4; i++) { 
//                     int temp = shape[0, i];
//                     shape[0, i] = maxy - (maxx - shape[1, i]) - 1;
//                     shape[1, i] = maxx - (3 - (maxy - temp)) + 1;
//                 }
//                 if (FindMistake())
//                     Array.Copy(shapeT, shape, shape.Length);
//                 break;      
//            }
//         }
//         public void SetShape(){
//             Random x = new Random(DateTime.Now.Millisecond);
//             switch (x.Next(7)){
//                 case 0: shape = new int[,] { { 2, 3, 4, 5 }, { 8, 8, 8, 8 } }; break;
//                 case 1: shape = new int[,] { { 2, 3, 2, 3 }, { 8, 8, 9, 9 } }; break;
//                 case 2: shape = new int[,] { { 2, 3, 4, 4 }, { 8, 8, 8, 9 } }; break;
//                 case 3: shape = new int[,] { { 2, 3, 4, 4 }, { 8, 8, 8, 7 } }; break;
//                 case 4: shape = new int[,] { { 3, 3, 4, 4 }, { 7, 8, 8, 9 } }; break;
//                 case 5: shape = new int[,] { { 3, 3, 4, 4 }, { 9, 8, 8, 7 } }; break;
//                 case 6: shape = new int[,] { { 3, 4, 4, 4 }, { 8, 7, 8, 9 } }; break;
//             }
//         }
//         public bool FindMistake(){
//             for (int i = 0; i < 4; i++)
//                 if (shape[1, i] >= width || shape[0, i] >= height || 
//                     shape[1, i] <= 0 || shape[0, i] <= 0 || 
//                     field[shape[1, i], shape[0, i]] == 1)
//                         return true; 
//             return false;
//         }
//     }
// }