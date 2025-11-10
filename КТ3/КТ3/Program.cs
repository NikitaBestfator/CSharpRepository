using System.Text;
using КТ3.Models;

namespace КТ3;

static class Program
{
    private static void TestQuestionary(Questionary questionary)
    {
        foreach (var question in questionary.Questions)
        {
            switch (question)
            {
                case SingleAnswerQuestion singleAnswersQuestion:
                    singleAnswersQuestion.AnswerIndex= 2;
                    break;
                case MultiAnswerQuestion multiAnswersQuestion:
                    multiAnswersQuestion.AnswersIndexes = [1, 4];
                    break;
                case TextAnswerQuestion textAnswersQuestion:
                    textAnswersQuestion.Answer = "Билл Гейтс";
                    break;
                case IntegerAnswerQuestion integerAnswerQuestionQuention:
                    integerAnswerQuestionQuention.Answer = 64;
                    break;
            }
        }
        
        Console.WriteLine(questionary.GetQuestionsAndAnswers());
    }
    
    
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var questionary = new Questionary(
            new List<Question>
            {
                new SingleAnswerQuestion("Земля круглая?", [ "Шарообразная", "Да", "Нет", "Не знаю", "Наверное", "Спросите у знатаков"]),
                new MultiAnswerQuestion("Выберите любымые цвета?", [ "Красный", "Жёлтый", "Фиолетовый", "Зелёный", "Синий", "Голубой"]),
                new TextAnswerQuestion("Как вас зовут?"),
                new IntegerAnswerQuestion("Сколько вам лет?")
            }
        );

        /*Для тестирования модули раскомментируйте следующие 3 строки*/
        //Console.OutputEncoding = Encoding.UTF8;
        //TestQuestionary(questionary);
        //return;
        
        //Работа с формами
        ApplicationConfiguration.Initialize();
        foreach (var question in questionary.Questions)
        {
            Application.Run(new QuestionForm(question));
        }
        
        Application.Run(new ReportForm(questionary));
    }
}