using BERTTokenizers.Base;

namespace BERTTokenizers
{
    public class SbertTokenizer : UncasedTokenizer
    {
        public SbertTokenizer() : base("./Vocabularies/sbert.txt")
        {
        }
    }

     
}
