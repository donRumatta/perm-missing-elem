using PermMissingElem;

namespace Tests;

[TestFixture]
public class ArrayProcessorTests
{
    [Test]
    public void SeekMissing()
    {
        var result = ArrayProcessor.SeekMissing([2, 3, 1, 5]);
        
        Assert.AreEqual(4, result);
    }
    
    [Test]
    public void SeekMissing_Shortest()
    {
        var result = ArrayProcessor.SeekMissing([1]);
        
        Assert.AreEqual(2, result);
    }
    
    [Test]
    public void SeekMissing_Short()
    {
        var result = ArrayProcessor.SeekMissing([1, 3]);
        
        Assert.AreEqual(2, result);
    }
    
    [Test]
    public void SeekMissing_Large()
    {
        var input = Enumerable.Range(1, 100000).Skip(1).ToList();
        input.Add(100001);
        
        var result = ArrayProcessor.SeekMissing(input.ToArray());
        
        Assert.AreEqual(1, result);
    }
}