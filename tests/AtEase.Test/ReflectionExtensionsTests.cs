using System;
using AtEase.Extensions;
using FluentAssertions;
using Xunit;

namespace AtEase.Test
{
    [AttributeUsage(AttributeTargets.Property |
                    AttributeTargets.Struct)
    ]
    public class CustomAttrAttribute : Attribute
    {
        public string Name;

        public CustomAttrAttribute(string name)
        {
            Name = name;
        }
    }

    public class CustomClass
    {
        [CustomAttr("SomeName")]
        public int SomeProp { get; set; }
    }

    public class ReflectionExtensionsTests
    {
        [Fact]
        public void SingleAttributeValue_should_return_attribute_value()
        {
            CustomClass customClass = new CustomClass();

            string attributeValue = customClass.GetType().SingleAttributeValue<CustomAttrAttribute>("SomeProp", "Name");

            attributeValue.Should().Be("SomeName");
        }
    }
}