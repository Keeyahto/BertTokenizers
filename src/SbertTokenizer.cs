using BERTTokenizers.Base;

namespace BERTTokenizers
{
    public class SbertTokenizer : UncasedTokenizer
    {
        public SbertTokenizer() : base("./Vocabularies/sbert_large_mt_nlu_ru.txt")
        {
        }
    }
}