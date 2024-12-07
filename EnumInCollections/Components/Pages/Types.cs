namespace EnumInCollections.Components.Pages;

public enum Test
{
    A,
    B
}

public class BadComplexProperty
{
    public string? StringValue { get; set; }
    public Test? EnumValue { get; set; }
}

public class BadBiding
{
    public Test? EnumValueParent { get; set; }
    public BadComplexProperty[] Items { get; set; } = [new(), new() { EnumValue = Test.A, StringValue = "Nothing" }];
}


public class GoodComplexProperty
{
    public string? StringValue { get; set; }
    public string? EnumValue { get; set; }
}

public class GoodBiding
{
    public Test? EnumValueParent { get; set; }
    public GoodComplexProperty[] Items { get; set; } = [new(), new() { EnumValue = Test.A.ToString(), StringValue = "Nothing" }];
}



