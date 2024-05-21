﻿## Тестовое задание

### 1) Sql задание

Использовал для проверки скрипта [сайт](https://www.db-fiddle.com/) 

MySQL ver 8.0

sql скрипт для базы иницилизации базы данны [см. тут](./docs/schema-sql.txt)

sql скрипт решение задачи [см. тут](./docs/answer.txt)

[результат скрипта](docs/result1.png)

### 2) задание на понимание

[результат кода](docs/test2.cs)

- тк Point структура(Value type), то в функция получает копию структуры => изменения в структуре не влияют на нее.
- тк myForm класс(Reference type), то в функция получает копию класса, но ссылается на теже поля => изменения полей влияет на класс, но изменения самого класса нет, из-за этого присваивание классу значение null не повлияло на него.
- Здесь использовалась ключевое слово ref => передали структуру в функцию по ссылке => изменения в структуре внутри функция влияет на нее саму.
- Из-за ref присваивание классу значение null повлияло на него => ошибка в зоди вызова из null поля Text.

### 3) GeometricShapeCalculator

- GSC - Библиотека. Имеется из библиотеки доступ только к интерфейсу IShapeCalculator и классу ShapeCalculator

- Test - тесты из вне библиотеки. Проверяет только на исключения и методы ShapeCalculator. Неимеет доступ к другим клссам и интерфесам.
