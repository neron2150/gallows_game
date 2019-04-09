using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Курсовая
{
    class Gallows
    {
        string[] db = {
                          "спорт+Хоккей+бассейн+лыжи+бег+фитнесс+борьба+дзюдо+футбол+баскетбол+волейбол", 
                          "семья+Бабка+бабушка+Брат+Братан+братаник+братеня+братеник+брательник+Внук+Внучка+Вуй+Дед+Дочь+Дядя+Мать+Отец+Племянник+Племянница+Племяш+Пращур+Сестра", 
                          "овощ+морковь+баклажан+лук+чеснок+брокколи+капуста+огурец+помидор+кабачок+шпинат+грибы+бобы+горох+перец",
                          "Фрукт+апельсин+банан+груша+виноград+клубника+яблоко+лимон+персик+дыня+арбуз+ананас+киви+вишня", 
                          "Мясо+говядина+ягнятина+баранина+оленина+телятина+свинина+ветчина+бекон+ветчина", 
                          "морепродукты+креветка+мидии+устрицы+омар+кальмар+краб",
                          "рыба+треска+форель+семга+хек+камбала+скумбрия+сардина+селедка", 
                          "напиток+чай+кофе+сок+молоко+пиво+вино+лимонад+сидр"
                      }; 
        public static Gallows obj = new Gallows(); //объект класса
        string userWord; //загаданное слово, которое видит ирок (****)
        string mainWord; // само слово
        string theme; //тема
        byte chance; //шаг иры
        byte difficulty = 1;
        public byte Chanse
        {
            get { return chance; }
            set { chance = value; }
        }
        public byte Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }
        public string Theme
        {
            get { return theme; }
            set { theme = value; }
        }
        public string UserWord
        {
            get { return userWord; }
            set { userWord = value; }

        }
        public string MainWord
        {
            get { return mainWord; }
            set
            {
                mainWord = value;
                //userWord = Replace(value); //мы не можем спалить это слово
            }
        }
        public static string Replace(string s) //заменяем каждую букву на *
        {
            string ss = "";
            for (int i = 0; i < s.Length; i++)
            {
                ss += "*";
            }
            return ss;
        }

        public string LetterSelection(char letter) // главная часть программы по нахождению введённой буквы
        {
            string bufword = "";
            for (int i = 0; i < mainWord.Length; i++) // ищем букву в слове ("вилка")
            {
                if (mainWord[i] != letter)
                {
                    bufword += userWord[i].ToString();
                }
                else
                {
                    bufword += letter;
                }

            }


            if (userWord == bufword)
            {
                chance+=difficulty;
                return userWord;
            }
            else
            {
                userWord = bufword;
                return userWord;
            }


        }
        public void ComputerWordSelection()
        {
            Random r = new Random();

            string[] buf = db[r.Next(0, db.Length - 1)].Split('+');
            mainWord = buf[r.Next(1,buf.Length-1)].ToUpper();
            theme= buf[0];
        }
    }
}
