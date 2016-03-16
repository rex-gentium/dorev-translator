using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorevApp
{
    class Word
    {
        string prePunc = "";
        string word = "";
        string postPunc = "";

        public Word(string word)
        {
            this.word = word;
            SplitPunctuations();
        }

        public Word(string prePunctuation, string pureWord, string postPunctuation)
        {
            prePunc = prePunctuation;
            word = pureWord;
            postPunc = postPunctuation;
        }

        public Word(Word obj)
        {
            prePunc = obj.prePunc;
            word = obj.word;
            postPunc = obj.postPunc;
        }

        public override string ToString()
        {
            return prePunc + word + postPunc;
        }

        public Word RemoveYer()
        {
            // если слово состоит из одного ера
            if (word.Length == 1)
                return new Word(this);

            string newWord = word;
            // еры на концах слов: миръ
            while (char.ToLower(newWord.Last()) == 'ъ')
                newWord = newWord.Remove(newWord.Length - 1);
            // еры в серединах слов перед знаками препинания: какъ-то
            for (int i = 0; i < newWord.Length; i++)
            {
                if (char.ToLower(newWord[i]) == 'ъ' && Librarian.IsPunctiationSign(newWord[i + 1]))
                        newWord = newWord.Remove(i, 1);
            }

            return new Word(prePunc, newWord, postPunc);
        }

        public Word ReplaceYat()
        {
            return new Word(prePunc, word
                .Replace('Ѣ', 'Е')
                .Replace('ѣ', 'е'), 
                postPunc);
        }

        public Word ReplaceDecI()
        {
            return new Word(prePunc, word
                .Replace('І', 'И')
                .Replace('і', 'и'),
                postPunc);
        }

        public Word ReplaceIzhitsa()
        {
            return new Word(prePunc, word
                .Replace('Ѵ', 'И')
                .Replace('ѵ', 'и'),
                postPunc);
        }

        public Word ReplaceFita()
        {
            return new Word(prePunc, word
                .Replace('Ѳ', 'Ф')
                .Replace('ѳ', 'ф'),
                postPunc);
        }

        /*public Word ReplacePrefix()
        {
            
            word.StartsWith(prefix);
        }*/

        public Word ToModern()
        {
            if (word.Length == 0)
                return new Word(this);

            return RemoveYer()
                .ReplaceDecI()
                .ReplaceFita()
                .ReplaceIzhitsa()
                .ReplaceYat();
        }

        private void SplitPunctuations()
            // отделяет от слова сопроводительные (шедшие без пробела) знаки препинания
        {
            while (word.Length > 0 && Librarian.IsPunctiationSign(word.First()))
            {
                prePunc += word.First();
                word = word.Remove(0, 1);
            }
            while (word.Length > 0 && Librarian.IsPunctiationSign(word.Last()))
            {
                postPunc = word.Last() + postPunc;
                word = word.Remove(word.Length - 1);
            }
        }

    }
}
