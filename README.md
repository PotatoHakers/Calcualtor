# Calcualtor

![image](https://user-images.githubusercontent.com/97401395/199045219-b8900213-99f6-40d5-94f9-785d2411262d.png)
![image](https://user-images.githubusercontent.com/97401395/199045302-fd58f064-3886-44f3-8bc1-5451a0e0c2f4.png)

Приложение Calculator — это современное приложение на Windows Forms, написанное на языке C#. Приложение предоставляет стандартные операции калькулятора.

Основные расчеты

Этот калькулятор поддерживает все четыре основных типа вычислений: деление, умножение, сложение и вычитание.
Код написан на языке c# используя WIndows Forms и объектно-ориентированный подход программирования.

# Как приступить к работе

Требования:
На вашем компьютере должна быть установлена Windows 10 или иная версия.
Установите последнюю версию Visual Studio (достаточно бесплатной версии сообщества).
Установите рабочую нагрузку "Универсальная разработка платформы Windows".
Установите дополнительный компонент "Universal Windows Platform tools".
Установите последнюю версию пакета SDK для Windows 11.

![197620083-3abc64b7-446b-4bfd-b4bc-7eac8c87f650](https://user-images.githubusercontent.com/97401395/199044717-16a9c855-3685-4781-9aff-586410772d71.png)

В нашем калькуляторе есть класс под названием CalculatorMethod. В это методе написаны все функциональные методы, которые используются в кнопках самого калькулятора в форме под названием FormCalculator. 
![image](https://user-images.githubusercontent.com/97401395/199045668-2803b13b-374f-4874-ab28-4ba76033c159.png)

# Тестирование
Так же в нашем проекте есть XUnit тесты, которые предназначены для тестирования методов как основных арифметических действий, так и для тестирования вспомогательных методов.
Для написания таких тестов нам понадобиться набор следующих библиотек:
XUnit, Microsoft.NET.Test.SDK.

1) Класс для тестирования функции умножения в калькуляторе
![image](https://user-images.githubusercontent.com/97401395/199046087-71fb0cf2-0540-45c0-94bb-f151e7253e4f.png)
2) Класс для тестирования функции деления в калькуляторе
![image](https://user-images.githubusercontent.com/97401395/199046146-8bdfbbeb-0a1d-48a4-adbd-498d723b34cd.png)
![image](https://user-images.githubusercontent.com/97401395/199046216-73efd89e-9270-412a-ae43-0de7438cf654.png)
3) Класс для тестирования функции сложения в калькуляторе
![image](https://user-images.githubusercontent.com/97401395/199046262-cedcd9a4-fbb7-487e-9ed3-af63d59151a9.png)
4) Класс для тестирования функции отнимания в калькуляторе

Все 4 теста выполняются успешно
![image](https://user-images.githubusercontent.com/97401395/199046899-d70ad685-e57c-4ecc-aafa-e322b91614af.png)






