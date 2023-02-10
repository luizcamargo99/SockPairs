namespace SockPairs;

public static class SockPairs
{
    private const int PAIR_NUMBER = 2;

    public static int GetPairsCount(this string socks)
    {
        var countPair = 0;
        var socksArr = socks.Distinct().ToArray();
        for (int i = 0; i < socksArr.Length; i++)
            countPair += socks.Count(x => x == socksArr[i]) / PAIR_NUMBER;
        return countPair;
    }
}