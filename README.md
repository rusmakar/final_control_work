# Программа на C# которая из имеющегося массива строк, формирует новый массив строк, длина которыйх меньше или равна трём символам.
## Описание
*Этот проект представляет собой программу на C#, которая принимает массив строк и формирует новый массив, содержащий только те строки, длина которых меньше или равна 3 символам. Программа предназначена для проверки базовых навыков программирования, работы с массивами и управления версиями.*
## Функционал
*Программа выполняет следующие задачи:*

* *Создает массив строк, заданный пользователем (либо введённый вручную, либо предопределённый в коде).*
* *Перебирает каждый элемент в массиве.*
* *Добавляет строки, длина которых меньше или равна 3 символам, в новый массив.*
* *Выводит получившийся массив с отфильтрованными строками.*
## Структура проекта
*Проект состоит из следующих этапов:*

* *Создание Git-репозитория.*
* *Построение блок-схемы алгоритма.*
* *Описание решения задачи.*
* *Написание программы на C#.*
* *Разделение работы на коммиты, отражающие этапы 2, 3 и 4.*
## Установка и запуск
### Требования
* *Среда разработки, поддерживающая C# (например, Visual Studio или Visual Studio Code).*
* *.NET SDK (если программа запускается через терминал).*
## Запуск программы
*1. Клонируйте репозиторий:*
```bash
git clone https://github.com/rusmakar/final_control_work.git
```
*2. Откройте проект в выбранной среде разработки или терминале.*

*3. Запустите программу, следуя инструкциям в интерфейсе (вводите строки или используйте предопределённые массивы в коде).*
## Примеры работы
*Вот несколько примеров входных данных и ожидаемого результата программы:*
* *Ввод: ["Hello", "2", "world", ":-)"]*    
*Результат: ["2", ":-)"]*
* *Ввод: ["1234", "1567", "-2", "computer science"]*    
*Результат: ["-2"]*
* *Ввод: ["Russia", "Denmark", "Kazan"]*
* *Результат: []*
## Структура кода
* *Основной метод — включает логику фильтрации строк, длина которых меньше или равна 3 символам.*

* *Дополнительные методы (если применимо) — для удобства можно выделить отдельный метод для фильтрации.*
## Блок-схема
* *Пример блок-схемы для алгоритма, используемого в программе:*
![Блок-схема](final_control_work/blok-shema.jpg)