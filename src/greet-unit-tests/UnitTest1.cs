using FluentAssertions;
using greet_test;
using Xunit;

namespace greet_unit_tests;

public class UnitTest1
{
    [Theory(DisplayName = "Deve retornar \"Olá\"")]
    [InlineData("Olá")]
    public void TestGreet(string expected)
    {
        var result = Class1.Greet();
        result.Should().Be(expected);
    }
}