using BERTTokenizers.Base;

namespace BERTTokenizers;

public class SbertLargeTokenizer
    : UncasedTokenizer
{
    public SbertLargeTokenizer() : base("./Vocabularies/sbert.txt")
    {
    }
}