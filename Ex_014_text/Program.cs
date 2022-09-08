// Дан текст. Надо пробелы заменить черточкамт, прописные с и к заглавными

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            +"ежели бы вас послали вместо нашего милого Винценгероде,"
            +"вы бы взяли приступом согласие прусского короля."
            +"Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
    {
        string result = String.Empty;

        int length = text.Length;
        for (int i = 0; i < length; i++)
            {
                if (text[i] == oldValue) result = result + $"{newValue}";
                else result = result + $"{text[i]}";
            }
        return result;
    }

string newText = Replace(text, ' ', '-');
string newText1 = Replace(newText, 'к', 'К');
string newText2 = Replace(newText1, 'с', 'С');
Console.WriteLine(newText);
Console.WriteLine(newText1);
Console.WriteLine(newText2);